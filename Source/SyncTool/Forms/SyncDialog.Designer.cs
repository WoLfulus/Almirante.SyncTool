namespace Almirante.SyncTool.Forms
{
    partial class SyncDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.status = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.syncWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(128, 13);
            this.status.TabIndex = 0;
            this.status.Text = "Syncing content project...";
            this.status.UseWaitCursor = true;
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(12, 29);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(317, 19);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 1;
            this.progress.UseWaitCursor = true;
            // 
            // syncWorker
            // 
            this.syncWorker.WorkerReportsProgress = true;
            this.syncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Sync);
            this.syncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnWorkerProgress);
            this.syncWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnWorkerCompleted);
            // 
            // SyncDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 80);
            this.ControlBox = false;
            this.Controls.Add(this.progress);
            this.Controls.Add(this.status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SyncDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Syncing...";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.SyncDialog_Load);
            this.Shown += new System.EventHandler(this.SyncDialog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ProgressBar progress;
        private System.ComponentModel.BackgroundWorker syncWorker;
    }
}