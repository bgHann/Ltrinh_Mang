namespace UDPTimeClient
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
			this.txtIP = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numPort = new System.Windows.Forms.NumericUpDown();
			this.cboRequest = new System.Windows.Forms.ComboBox();
			this.btnGui = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
			this.SuspendLayout();
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(426, 120);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(100, 31);
			this.txtIP.TabIndex = 0;
			this.txtIP.Text = "127.0.0.1";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(149, 40);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(192, 25);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "UDP TIME CLIENT";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(221, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "IP Server:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(164, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Port:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(154, 305);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "Yêu Cầu";
			// 
			// numPort
			// 
			this.numPort.Location = new System.Drawing.Point(394, 196);
			this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numPort.Name = "numPort";
			this.numPort.Size = new System.Drawing.Size(120, 31);
			this.numPort.TabIndex = 5;
			this.numPort.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
			// 
			// cboRequest
			// 
			this.cboRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRequest.FormattingEnabled = true;
			this.cboRequest.Items.AddRange(new object[] {
            "TIME",
            "DATE",
            "DATETIME"});
			this.cboRequest.Location = new System.Drawing.Point(336, 296);
			this.cboRequest.Name = "cboRequest";
			this.cboRequest.Size = new System.Drawing.Size(121, 33);
			this.cboRequest.TabIndex = 6;
			// 
			// btnGui
			// 
			this.btnGui.Location = new System.Drawing.Point(199, 352);
			this.btnGui.Name = "btnGui";
			this.btnGui.Size = new System.Drawing.Size(106, 39);
			this.btnGui.TabIndex = 7;
			this.btnGui.Text = "Gửi";
			this.btnGui.UseVisualStyleBackColor = true;
			this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(381, 352);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(145, 39);
			this.btnThoat.TabIndex = 8;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnGui);
			this.Controls.Add(this.cboRequest);
			this.Controls.Add(this.numPort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.txtIP);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.ComboBox cboRequest;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnThoat;
    }
}

