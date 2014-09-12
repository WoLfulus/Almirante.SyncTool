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
using System.Windows.Forms;

namespace Almirante.SyncTool.Forms
{
    public partial class NewProject : Form
    {
        public NewProject()
        {
            this.InitializeComponent();
            this.SourceFolders = new List<string>();
        }

        public string ProjectName
        {
            get;
            set;
        }

        public string ProjectFile
        {
            get;
            set;
        }

        public List<string> SourceFolders
        {
            get;
            set;
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
        }

        private void FindProject(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog()
            {
                Title = "Select a target project",
                AddExtension = true,
                DefaultExt = ".contentproj",
                CheckPathExists = true,
                CheckFileExists = true,
                Multiselect = false,
                Filter = "XNA ContentProject (*.contentproj)|*.contentproj",
                SupportMultiDottedExtensions = true
            };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.textProject.Text = sfd.FileName;
        }

        private void NewProject_Shown(object sender, EventArgs e)
        {
            this.textName.Focus();
            this.textName.SelectAll();
        }

        private void AddFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "Browse source folder:",
                ShowNewFolderButton = true
            };

            if (fbd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.listFolders.Items.Add(fbd.SelectedPath);
        }

        private void RemoveFolder(object sender, EventArgs e)
        {
            if (this.listFolders.SelectedIndex >= 0)
            {
                this.listFolders.Items.RemoveAt(this.listFolders.SelectedIndex);
            }
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (this.listFolders.Items.Count == 0)
            {
                MessageBox.Show("You must select at least 1 source folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.textProject.Text == "")
            {
                MessageBox.Show("You must specify the target project file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.textName.Text == "")
            {
                MessageBox.Show("You must specify the project name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.ProjectFile = this.textProject.Text;
            this.ProjectName = this.textName.Text;

            for (int i = 0; i < this.listFolders.Items.Count; i++)
            {
                this.SourceFolders.Add((string)this.listFolders.Items[i]);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}