namespace UDPTimeServer
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblPort = new System.Windows.Forms.Label();
			this.numPort = new System.Windows.Forms.NumericUpDown();
			this.btnChay = new System.Windows.Forms.Button();
			this.btnDung = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(83, 49);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(204, 25);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "UPD TIME SERVER";
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(82, 141);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(70, 25);
			this.lblPort.TabIndex = 1;
			this.lblPort.Text = "PORT";
			// 
			// numPort
			// 
			this.numPort.Location = new System.Drawing.Point(345, 141);
			this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numPort.Name = "numPort";
			this.numPort.Size = new System.Drawing.Size(215, 31);
			this.numPort.TabIndex = 2;
			this.numPort.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
			// 
			// btnChay
			// 
			this.btnChay.Location = new System.Drawing.Point(88, 255);
			this.btnChay.Name = "btnChay";
			this.btnChay.Size = new System.Drawing.Size(133, 67);
			this.btnChay.TabIndex = 3;
			this.btnChay.Text = "Chạy";
			this.btnChay.UseVisualStyleBackColor = true;
			this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
			// 
			// btnDung
			// 
			this.btnDung.Enabled = false;
			this.btnDung.Location = new System.Drawing.Point(273, 255);
			this.btnDung.Name = "btnDung";
			this.btnDung.Size = new System.Drawing.Size(150, 57);
			this.btnDung.TabIndex = 4;
			this.btnDung.Text = "Dừng";
			this.btnDung.UseVisualStyleBackColor = true;
			this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(498, 242);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(168, 70);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnDung);
			this.Controls.Add(this.btnChay);
			this.Controls.Add(this.numPort);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.lblTitle);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnThoat;
    }
}

