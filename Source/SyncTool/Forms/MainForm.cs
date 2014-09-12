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
using System.IO;
using System.Windows.Forms;
using Almirante.SyncTool.Data;

namespace Almirante.SyncTool.Forms
{
    public partial class MainForm : Form
    {
        private ContentPipeline selectedImporter = null;

        private ContentPipeline selectedProcessor = null;

        private Extension selectedExtension = null;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void OnBrowseImporters(object sender, MouseEventArgs e)
        {
            this.contextBrowser.Items.Clear();
            foreach (var importer in Configuration.Instance.Importers)
            {
                var button = new ToolStripMenuItem()
                {
                    Text = importer.Description,
                    Tag = importer.Value,
                };
                button.Click += (csender, ce) =>
                {
                    ToolStripMenuItem b = csender as ToolStripMenuItem;
                    this.textImporter.Text = (string)b.Tag;
                };
                this.contextBrowser.Items.Add(button);
            }
            this.contextBrowser.Show((Control)sender, e.X, e.Y);
        }

        private void OnBrowseProcessors(object sender, MouseEventArgs e)
        {
            this.contextBrowser.Items.Clear();
            foreach (var processor in Configuration.Instance.Processors)
            {
                var button = new ToolStripMenuItem()
                {
                    Text = processor.Description,
                    Tag = processor.Value,
                };
                button.Click += (csender, ce) =>
                {
                    ToolStripMenuItem b = csender as ToolStripMenuItem;
                    this.textProcessor.Text = (string)b.Tag;
                };
                this.contextBrowser.Items.Add(button);
            }
            this.contextBrowser.Show((Control)sender, e.X, e.Y);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.RefreshImporters();
            this.RefreshProcessors();
            this.RefreshExtensions();
            this.RefreshProjects();
        }

        private void OnShowInterface(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void OnCloseInterface(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OnClosingInterface(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void OnShownInterface(object sender, EventArgs e)
        {
            this.Visible = false;
            this.traySync.ShowBalloonTip(5000, "XNA SyncTool", "XNA SyncTool is running...", ToolTipIcon.Info);
        }

        /// <summary>
        /// Called when [importer mouse down].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs" /> instance containing the event data.</param>
        private void OnImporterMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextImporters.Show((Control)sender, e.X, e.Y);
            }
        }

        /// <summary>
        /// Called when [processor mouse down].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs" /> instance containing the event data.</param>
        private void OnProcessorMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextProcessors.Show((Control)sender, e.X, e.Y);
            }
        }

        /// <summary>
        /// Called when [extensions mouse down].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs" /> instance containing the event data.</param>
        private void OnExtensionsMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextExtensions.Show((Control)sender, e.X, e.Y);
            }
        }

        /// <summary>
        /// Called when [importer select].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnImporterSelect(object sender, EventArgs e)
        {
            this.selectedImporter = null;
            if (this.listImporters.SelectedItem == null)
            {
                this.groupImporter.Enabled = false;
                this.textImporterDescription.Text = "";
                this.textImporterValue.Text = "";
                return;
            }
            else
            {
                this.groupImporter.Enabled = true;
                var value = this.listImporters.SelectedItem as ContentPipeline;
                this.textImporterDescription.Text = value.Description;
                this.textImporterValue.Text = value.Value;
                this.selectedImporter = value;
            }
        }

        /// <summary>
        /// Called when [create importer].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnCreateImporter(object sender, EventArgs e)
        {
            var form = new NewDialog() { Text = "New importer", Value = "Importer" };
            form.label1.Text = "Importer description:";
            form.textBox1.Text = "Importer";

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(form.Value))
                {
                    MessageBox.Show("Importer description cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Configuration.Instance.Importers.Add(new ContentPipeline()
                    {
                        Description = form.Value,
                        Value = ""
                    });
                    Configuration.Instance.Save();

                    this.RefreshImporters();
                }
            }
        }

        /// <summary>
        /// Called when [remove importer].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnRemoveImporter(object sender, EventArgs e)
        {
            if (this.selectedImporter != null)
            {
                Configuration.Instance.Importers.Remove(this.selectedImporter);
                Configuration.Instance.Save();
                this.RefreshImporters();
            }
        }

        /// <summary>
        /// Called when [importer description changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnImporterDescriptionChanged(object sender, EventArgs e)
        {
            if (this.selectedImporter != null)
            {
                this.selectedImporter.Description = this.textImporterDescription.Text;
                Configuration.Instance.Save();
            }
        }

        /// <summary>
        /// Called when [importer value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnImporterValueChanged(object sender, EventArgs e)
        {
            if (this.selectedImporter != null)
            {
                this.selectedImporter.Value = this.textImporterValue.Text;
                Configuration.Instance.Save();
            }
        }

        /// <summary>
        /// Refreshes the importers.
        /// </summary>
        private void RefreshImporters()
        {
            this.listImporters.Items.Clear();
            this.listImporters.Items.AddRange(Configuration.Instance.Importers.ToArray());
        }

        /// <summary>
        /// Called when [processor select].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnProcessorSelect(object sender, EventArgs e)
        {
            this.selectedProcessor = null;
            if (this.listProcessors.SelectedItem == null)
            {
                this.groupProcessor.Enabled = false;
                this.textProcessorDescription.Text = "";
                this.textProcessorValue.Text = "";
                return;
            }
            else
            {
                this.groupProcessor.Enabled = true;
                var value = this.listProcessors.SelectedItem as ContentPipeline;
                this.textProcessorDescription.Text = value.Description;
                this.textProcessorValue.Text = value.Value;
                this.selectedProcessor = value;
            }
        }

        /// <summary>
        /// Called when [create processor].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnCreateProcessor(object sender, EventArgs e)
        {
            var form = new NewDialog() { Text = "New processor", Value = "Processor" };
            form.label1.Text = "Processor description:";
            form.textBox1.Text = "Processor";

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(form.Value))
                {
                    MessageBox.Show("Processor description cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Configuration.Instance.Processors.Add(new ContentPipeline()
                    {
                        Description = form.Value,
                        Value = ""
                    });
                    Configuration.Instance.Save();

                    this.RefreshProcessors();
                }
            }
        }

        /// <summary>
        /// Called when [remove processor].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnRemoveProcessor(object sender, EventArgs e)
        {
            if (this.selectedProcessor != null)
            {
                Configuration.Instance.Processors.Remove(this.selectedProcessor);
                Configuration.Instance.Save();
                this.RefreshProcessors();
            }
        }

        /// <summary>
        /// Called when [processor description changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnProcessorDescriptionChanged(object sender, EventArgs e)
        {
            if (this.selectedProcessor != null)
            {
                this.selectedProcessor.Description = this.textProcessorDescription.Text;
                Configuration.Instance.Save();
            }
        }

        /// <summary>
        /// Called when [processor value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnProcessorValueChanged(object sender, EventArgs e)
        {
            if (this.selectedProcessor != null)
            {
                this.selectedProcessor.Value = this.textProcessorValue.Text;
                Configuration.Instance.Save();
            }
        }

        /// <summary>
        /// Refreshes the processors.
        /// </summary>
        private void RefreshProcessors()
        {
            this.listProcessors.Items.Clear();
            this.listProcessors.Items.AddRange(Configuration.Instance.Processors.ToArray());
        }

        /// <summary>
        /// Called when [extension select].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnExtensionSelect(object sender, EventArgs e)
        {
            this.selectedExtension = null;
            if (this.listExtensions.SelectedItem == null)
            {
                this.groupExtension.Enabled = false;
                this.textImporter.Text = "";
                this.textProcessor.Text = "";
                this.checkCopy.Checked = false;
                this.checkDesigner.Checked = false;
                return;
            }
            else
            {
                this.groupExtension.Enabled = true;
                var value = this.listExtensions.SelectedItem as Extension;
                this.textImporter.Text = value.ContentImporter;
                this.textProcessor.Text = value.ContentProcessor;
                this.checkCopy.Checked = value.Copy;
                this.checkDesigner.Checked = value.Designer;
                this.selectedExtension = value;
            }
        }

        /// <summary>
        /// Called when [create extension].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnCreateExtension(object sender, EventArgs e)
        {
            var form = new NewDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(form.Value))
                {
                    MessageBox.Show("Extension cannot be null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Configuration.Instance.Extensions.Add(new Extension()
                    {
                        Copy = true,
                        Designer = false,
                        ContentImporter = "",
                        ContentProcessor = "",
                        Value = form.Value
                    });
                    Configuration.Instance.Save();

                    this.RefreshExtensions();
                }
            }
        }

        /// <summary>
        /// Called when [remove extension].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnRemoveExtension(object sender, EventArgs e)
        {
            if (this.selectedExtension != null)
            {
                Configuration.Instance.Extensions.Remove(this.selectedExtension);
                Configuration.Instance.Save();
                this.RefreshExtensions();
            }
        }

        /// <summary>
        /// Called when [extension importer change].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnExtensionImporterChange(object sender, EventArgs e)
        {
            if (this.selectedExtension != null)
            {
                this.selectedExtension.ContentImporter = this.textImporter.Text;
                Configuration.Instance.Save();
            }
        }

        /// <summary>
        /// Called when [extension processor changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnExtensionProcessorChanged(object sender, EventArgs e)
        {
            if (this.selectedExtension != null)
            {
                this.selectedExtension.ContentProcessor = this.textProcessor.Text;
                Configuration.Instance.Save();
            }
        }

        /// <summary>
        /// Called when [extension designer changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnExtensionDesignerChanged(object sender, EventArgs e)
        {
            if (this.selectedExtension != null)
            {
                this.selectedExtension.Designer = this.checkDesigner.Checked;
                Configuration.Instance.Save();
            }
        }

        /// <summary>
        /// Called when [extension copy changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnExtensionCopyChanged(object sender, EventArgs e)
        {
            if (this.selectedExtension != null)
            {
                this.selectedExtension.Copy = this.checkCopy.Checked;
                Configuration.Instance.Save();
            }
        }

        /// <summary>
        /// Refreshes the extensions.
        /// </summary>
        private void RefreshExtensions()
        {
            this.listExtensions.Items.Clear();
            this.listExtensions.Items.AddRange(Configuration.Instance.Extensions.ToArray());
        }

        /// <summary>
        /// Called when [create export].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnCreateExport(object sender, EventArgs e)
        {
            try
            {
                this.menuSynchronize.Enabled = false;

                NewProject np = new NewProject();
                if (np.ShowDialog() == DialogResult.OK)
                {
                    UserProject project = new UserProject()
                    {
                        Name = np.ProjectName,
                        ProjectFile = np.ProjectFile,
                        SourceFolders = np.SourceFolders
                    };

                    Configuration.Instance.User.Projects.Add(project);
                    Configuration.Instance.Save();

                    this.RefreshProjects();

                    this.Synchronize(project);
                }
            }
            catch (System.Exception)
            {
            }
            finally
            {
                this.menuSynchronize.Enabled = true;
            }
        }

        /// <summary>
        /// Refreshes the projects.
        /// </summary>
        private void RefreshProjects()
        {
            while (this.menuSynchronize.DropDownItems.Count > 3)
            {
                this.menuSynchronize.DropDownItems.RemoveAt(this.menuSynchronize.DropDownItems.Count - 1);
            }

            foreach (var project in Configuration.Instance.User.Projects)
            {
                var item = new ToolStripMenuItem()
                {
                    Text = Path.GetFileName(project.Name)
                };

                var sync = new ToolStripMenuItem()
                {
                    Text = "Synchronize",
                    Tag = project,
                    Image = Almirante.SyncTool.Properties.Resources.refresh
                };

                sync.Click += (sender, e) =>
                {
                    var proj = (sender as ToolStripMenuItem).Tag as UserProject;
                    if (proj != null)
                    {
                        this.Synchronize(proj);
                    }
                };

                item.DropDownItems.Add(sync);

                var edit = new ToolStripMenuItem()
                {
                    Text = "Edit",
                    Tag = project,
                    Image = Almirante.SyncTool.Properties.Resources.edit
                };

                edit.Click += (sender, e) =>
                {
                    var proj = (sender as ToolStripMenuItem).Tag as UserProject;
                    if (proj != null)
                    {
                        // TODO: Edit project
                    }
                };

                item.DropDownItems.Add(edit);

                var delete = new ToolStripMenuItem()
                {
                    Text = "Delete",
                    Tag = project,
                    Image = Almirante.SyncTool.Properties.Resources.delete
                };

                delete.Click += (sender, e) =>
                {
                    var proj = (sender as ToolStripMenuItem).Tag as UserProject;
                    if (proj != null)
                    {
                        if (MessageBox.Show("Are you sure you want to remove this project?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Configuration.Instance.User.Projects.Remove(proj);
                            this.RefreshProjects();
                        }
                    }
                };

                item.DropDownItems.Add(delete);

                this.menuSynchronize.DropDownItems.Add(item);
            }
        }

        /// <summary>
        /// Synchronizes the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        private void Synchronize(UserProject project)
        {
            this.menuSynchronize.Enabled = false;

            var sync = new SyncDialog(project);
            if (sync.ShowDialog() == DialogResult.OK)
            {
                this.traySync.ShowBalloonTip(5000, "Success!", sync.Message, ToolTipIcon.Info);
            }
            else
            {
                this.traySync.ShowBalloonTip(5000, "Failed!", sync.Message, ToolTipIcon.Error);
            }

            this.menuSynchronize.Enabled = true;
        }

        /// <summary>
        /// Synchronizes all projects.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void SynchronizeAllProjects(object sender, EventArgs e)
        {
            this.menuSynchronize.Enabled = false;

            if (MessageBox.Show("You'll need to reopen the visual studio solution after doing this. Continue?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int failed = 0;
                foreach (var project in Configuration.Instance.User.Projects)
                {
                    SyncDialog dialog = new SyncDialog(project);
                    if (dialog.ShowDialog() != DialogResult.OK)
                    {
                        failed++;
                    }
                }

                if (failed > 0)
                {
                    this.traySync.ShowBalloonTip(5000, "Failed!", string.Format("{0} projects failed to synchronize!", failed), ToolTipIcon.Warning);
                }
                else
                {
                    this.traySync.ShowBalloonTip(5000, "Success!", "All projects synchronized!", ToolTipIcon.Info);
                }
            }

            this.menuSynchronize.Enabled = true;
        }

        private void OnSettingsClick(object sender, EventArgs e)
        {
            this.Visible = true;
        }
    }
}