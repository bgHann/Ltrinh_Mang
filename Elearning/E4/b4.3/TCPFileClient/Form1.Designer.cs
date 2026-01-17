namespace TCPFileClient
{
    partial class Form1
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
			this.btnChooseFile = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblFile = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnChooseFile
			// 
			this.btnChooseFile.Location = new System.Drawing.Point(102, 122);
			this.btnChooseFile.Name = "btnChooseFile";
			this.btnChooseFile.Size = new System.Drawing.Size(174, 55);
			this.btnChooseFile.TabIndex = 0;
			this.btnChooseFile.Text = "Chọn file";
			this.btnChooseFile.UseVisualStyleBackColor = true;
			this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(356, 121);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(196, 56);
			this.btnSend.TabIndex = 1;
			this.btnSend.Text = "Gửi";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(331, 217);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(195, 16);
			this.progressBar1.TabIndex = 2;
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Location = new System.Drawing.Point(115, 215);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(150, 25);
			this.lblFile.TabIndex = 3;
			this.lblFile.Text = "Chưa chọn file";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnChooseFile);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFile;
    }
}

