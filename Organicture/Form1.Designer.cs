
namespace Organicture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderPathBtn = new System.Windows.Forms.Button();
            this.directoryLB = new System.Windows.Forms.ListBox();
            this.currentDirectoryLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadPictureBtn = new System.Windows.Forms.Button();
            this.organiseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderPathBtn
            // 
            this.folderPathBtn.Location = new System.Drawing.Point(12, 156);
            this.folderPathBtn.Name = "folderPathBtn";
            this.folderPathBtn.Size = new System.Drawing.Size(115, 23);
            this.folderPathBtn.TabIndex = 0;
            this.folderPathBtn.Text = "Choose folder";
            this.folderPathBtn.UseVisualStyleBackColor = true;
            this.folderPathBtn.Click += new System.EventHandler(this.folderPathBtn_Click);
            // 
            // directoryLB
            // 
            this.directoryLB.BackColor = System.Drawing.SystemColors.Control;
            this.directoryLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directoryLB.FormattingEnabled = true;
            this.directoryLB.ItemHeight = 15;
            this.directoryLB.Location = new System.Drawing.Point(12, 32);
            this.directoryLB.Name = "directoryLB";
            this.directoryLB.Size = new System.Drawing.Size(265, 90);
            this.directoryLB.TabIndex = 1;
            // 
            // currentDirectoryLbl
            // 
            this.currentDirectoryLbl.AutoSize = true;
            this.currentDirectoryLbl.Location = new System.Drawing.Point(12, 129);
            this.currentDirectoryLbl.Name = "currentDirectoryLbl";
            this.currentDirectoryLbl.Size = new System.Drawing.Size(38, 15);
            this.currentDirectoryLbl.TabIndex = 2;
            this.currentDirectoryLbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "All directories";
            // 
            // loadPictureBtn
            // 
            this.loadPictureBtn.Location = new System.Drawing.Point(133, 156);
            this.loadPictureBtn.Name = "loadPictureBtn";
            this.loadPictureBtn.Size = new System.Drawing.Size(75, 23);
            this.loadPictureBtn.TabIndex = 4;
            this.loadPictureBtn.Text = "Load";
            this.loadPictureBtn.UseVisualStyleBackColor = true;
            this.loadPictureBtn.Click += new System.EventHandler(this.loadPictureBtn_Click);
            // 
            // organiseBtn
            // 
            this.organiseBtn.Location = new System.Drawing.Point(274, 156);
            this.organiseBtn.Name = "organiseBtn";
            this.organiseBtn.Size = new System.Drawing.Size(75, 23);
            this.organiseBtn.TabIndex = 5;
            this.organiseBtn.Text = "Next";
            this.organiseBtn.UseVisualStyleBackColor = true;
            this.organiseBtn.Click += new System.EventHandler(this.organiseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 191);
            this.Controls.Add(this.organiseBtn);
            this.Controls.Add(this.loadPictureBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentDirectoryLbl);
            this.Controls.Add(this.directoryLB);
            this.Controls.Add(this.folderPathBtn);
            this.Name = "Form1";
            this.Text = "Organicture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button folderPathBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox directoryLB;
        private System.Windows.Forms.Label currentDirectoryLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadPictureBtn;
        private System.Windows.Forms.Button organiseBtn;
    }
}

