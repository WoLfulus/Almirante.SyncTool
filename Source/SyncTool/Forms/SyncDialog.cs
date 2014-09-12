/// 
/// The MIT License (MIT)
/// 
/// Copyright (c) 2014 João Francisco Biondo Trinca <wolfulus@gmail.com>
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
/// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Build.Evaluation;
using Almirante.SyncTool.Data;

namespace Almirante.SyncTool.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SyncDialog : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private UserProject project;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncDialog"/> class.
        /// </summary>
        /// <param name="project">The project.</param>
        public SyncDialog(UserProject project)
        {
            this.project = project;
            this.Message = "?";
            this.InitializeComponent();
            this.Align();
        }

        /// <summary>
        /// Handles the Load event of the SyncDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SyncDialog_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Aligns this instance.
        /// </summary>
        private void Align()
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height - 25;
            this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width - 25;
        }

        /// <summary>
        /// WNDs the proc.
        /// </summary>
        /// <param name="message">The message.</param>
        protected override void WndProc(ref Message message)
        {
            const int WMSyscommand = 0x0112;
            const int SCMove = 0xF010;

            switch (message.Msg)
            {
                case WMSyscommand:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SCMove)
                    {
                        return;
                    }
                    break;
            }

            base.WndProc(ref message);
        }

        /// <summary>
        /// Updates the progress.
        /// </summary>
        /// <param name="progress">The progress.</param>
        /// <param name="status">The status.</param>
        private void UpdateProgress(int progress, string status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.UpdateProgress(progress, status);
                }));
                return;
            }

            this.status.Text = status;
            this.progress.Value = progress;
        }

        /// <summary>
        /// Syncs the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
        private void Sync(object sender, DoWorkEventArgs e)
        {
            e.Result = DialogResult.Cancel;

            // Project setup

            this.UpdateProgress(0, string.Format("Loading '{0}' ...", this.project.Name));

            Thread.Sleep(1000);

            Project proj = new Project(this.project.ProjectFile);

            try
            {
                // Sanity checks
                this.UpdateProgress(0, "Performing sanity checks...");

#if DEBUG
                Thread.Sleep(500);
#endif

                if (!File.Exists(this.project.ProjectFile))
                {
                    this.Message = "Target project not found.";
                    return;
                }

                foreach (var sourceFolder in this.project.SourceFolders)
                {
                    if (!Directory.Exists(sourceFolder))
                    {
                        this.Message = "Source content folder not found.";
                        return;
                    }
                }

                // File cleanup

                this.UpdateProgress(0, "Removing files...");

#if DEBUG
                Thread.Sleep(500);
#endif

                FileInfo documentInfo = new FileInfo(this.project.ProjectFile);
                DirectoryInfo directoryInfo = new DirectoryInfo(documentInfo.DirectoryName);

                if (Directory.Exists(Path.Combine(directoryInfo.FullName, "bin")))
                {
                    DirectoryInfo info = new DirectoryInfo(Path.Combine(directoryInfo.FullName, "bin"));
                    info.Delete(true);
                }

                if (Directory.Exists(Path.Combine(directoryInfo.FullName, "obj")))
                {
                    DirectoryInfo info = new DirectoryInfo(Path.Combine(directoryInfo.FullName, "obj"));
                    info.Delete(true);
                }

                this.CleanupDirectory(documentInfo, directoryInfo);

                // Project cleanup

                this.UpdateProgress(0, "Removing references...");

#if DEBUG
                Thread.Sleep(500);
#endif

                List<ProjectItem> toRemove = new List<ProjectItem>();
                foreach (var item in proj.Items)
                {
                    if (item.ItemType == "Compile" || item.ItemType == "None")
                    {
                        toRemove.Add(item);
                    }
                }

                proj.RemoveItems(toRemove);

                // proj.Save(this.project.ProjectFile);

                // Copy files

                this.UpdateProgress(0, "Copying files & references...");

#if DEBUG
                Thread.Sleep(500);
#endif

                foreach (var sourceFolder in this.project.SourceFolders)
                {
                    DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourceFolder);
                    string[] sourceFiles = Directory.GetFiles(sourceDirectoryInfo.FullName, "*.*", SearchOption.AllDirectories);
                    foreach (var sourceFile in sourceFiles)
                    {
                        FileInfo sourceFileInfo = new FileInfo(sourceFile);
                        if (sourceFileInfo.FullName != documentInfo.FullName)
                        {
                            var ext = Configuration.Instance.Extensions.Find((entry) =>
                            {
                                if (entry.ToString().ToLower() == sourceFileInfo.Extension.ToLower())
                                {
                                    return true;
                                }
                                return false;
                            });

                            if (ext != null)
                            {
                                string relativePath = sourceFileInfo.FullName.Substring(sourceDirectoryInfo.FullName.Length + 1);
                                string targetPath = Path.Combine(directoryInfo.FullName, relativePath);

                                FileInfo targetFile = new FileInfo(targetPath);
                                DirectoryInfo targetDirectory = new DirectoryInfo(targetFile.DirectoryName);
                                targetDirectory.CreateDirectory();

                                sourceFileInfo.CopyTo(targetPath, true);

                                List<KeyValuePair<string, string>> metadata = new List<KeyValuePair<string, string>>();
                                metadata.Add(new KeyValuePair<string, string>("Name", Path.GetFileNameWithoutExtension(targetFile.FullName)));

                                if (ext.Designer)
                                {
                                    metadata.Add(new KeyValuePair<string, string>("SubType", "Designer"));
                                }

                                var properties = SynctoolProperty.Load(string.Format("{0}.synctool", sourceFileInfo.FullName));
                                if (properties == null)
                                {
                                    properties = new SynctoolProperty()
                                    {
                                        Copy = false,
                                        Importer = null,
                                        Processor = null
                                    };
                                }
                                
                                if (!properties.Copy)
                                {
                                    DirectoryInfo tempDir = sourceFileInfo.Directory;
                                    while (tempDir != null)
                                    {
                                        var folderProperties = SynctoolProperty.Load(Path.Combine(tempDir.FullName, ".synctool"));
                                        if (folderProperties != null)
                                        {
                                            properties.Copy = folderProperties.Copy;
                                            break;
                                        }
                                        if (tempDir.FullName == sourceDirectoryInfo.FullName)
                                        {
                                            break;
                                        }
                                        tempDir = tempDir.Parent;
                                    }
                                }

                                if (ext.Copy || properties.Copy)
                                {
                                    if (!properties.Process)
                                    {
                                        metadata.Add(new KeyValuePair<string, string>("CopyToOutputDirectory", "PreserveNewest"));
                                    }
                                    proj.AddItem("None", relativePath, metadata);
                                }
                                else
                                {
                                    metadata.Add(new KeyValuePair<string, string>("Importer", properties.Importer ?? ext.ContentImporter));
                                    metadata.Add(new KeyValuePair<string, string>("Processor", properties.Processor ?? ext.ContentProcessor));
                                    proj.AddItem("Compile", relativePath, metadata);
                                }
                            }
                        }
                    }
                }

                proj.Save();

                // Project cleanup

                this.UpdateProgress(0, "Finished...");

#if DEBUG
                Thread.Sleep(500);
#endif
                this.Message = "Project successfully synchronized.";
                e.Result = DialogResult.OK;
            }
            catch (System.Exception)
            {
            }
            finally
            {
                Microsoft.Build.Evaluation.ProjectCollection.GlobalProjectCollection.UnloadProject(proj);
            }
        }

        /// <summary>
        /// Cleanups the directory.
        /// </summary>
        /// <param name="documentInfo">The document info.</param>
        /// <param name="directoryInfo">The directory info.</param>
        private void CleanupDirectory(FileInfo documentInfo, DirectoryInfo directoryInfo)
        {
            this.CleanupDirectoryFiles(documentInfo, directoryInfo);
            IEnumerable<DirectoryInfo> directories = directoryInfo.EnumerateDirectories();
            foreach (DirectoryInfo info in directories)
            {
                if (info.Name != ".svn")
                {
                    this.CleanupDirectory(documentInfo, info);
                }
            }
        }

        /// <summary>
        /// Cleanups the directory files.
        /// </summary>
        /// <param name="documentInfo">The document info.</param>
        /// <param name="dirInfo">The dir info.</param>
        private void CleanupDirectoryFiles(FileInfo documentInfo, DirectoryInfo dirInfo)
        {
            IEnumerable<FileInfo> files = dirInfo.EnumerateFiles();
            foreach (FileInfo info in files)
            {
                if (info.FullName != documentInfo.FullName)
                {
                    info.Delete();
                }
            }
        }

        /// <summary>
        /// Called when [worker completed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void OnWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                this.Message = string.Format("Error: {0}", e.Error.Message);
            }
            this.DialogResult = (DialogResult)e.Result;
        }

        /// <summary>
        /// Called when [worker progress].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.ComponentModel.ProgressChangedEventArgs"/> instance containing the event data.</param>
        private void OnWorkerProgress(object sender, ProgressChangedEventArgs e)
        {
            this.progress.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Handles the Shown event of the SyncDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SyncDialog_Shown(object sender, EventArgs e)
        {
            this.syncWorker.RunWorkerAsync();
            this.Activate();
        }
    }
}