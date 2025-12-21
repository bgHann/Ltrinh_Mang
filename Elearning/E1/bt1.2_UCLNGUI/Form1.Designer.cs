namespace bt1._2
{
    partial class frmUCLN
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
			this.components = new System.ComponentModel.Container();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.btntinh = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.NumericUpDown();
			this.txtB = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbkq = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtB)).BeginInit();
			this.SuspendLayout();
			// 
			// btntinh
			// 
			this.btntinh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btntinh.Location = new System.Drawing.Point(237, 363);
			this.btntinh.Name = "btntinh";
			this.btntinh.Size = new System.Drawing.Size(108, 48);
			this.btntinh.TabIndex = 0;
			this.btntinh.Text = "Tính";
			this.btntinh.UseVisualStyleBackColor = true;
			this.btntinh.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(442, 363);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 47);
			this.button2.TabIndex = 1;
			this.button2.Text = "Đóng";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(179, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "a";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(179, 194);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "b";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(303, 113);
			this.txtA.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(334, 31);
			this.txtA.TabIndex = 4;
			this.txtA.ValueChanged += new System.EventHandler(this.txtA_ValueChanged);
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(303, 188);
			this.txtB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(334, 31);
			this.txtB.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(179, 275);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "USCLN";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(353, 275);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 25);
			this.label4.TabIndex = 7;
			// 
			// lbkq
			// 
			this.lbkq.AutoSize = true;
			this.lbkq.Location = new System.Drawing.Point(359, 275);
			this.lbkq.Name = "lbkq";
			this.lbkq.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbkq.Size = new System.Drawing.Size(0, 25);
			this.lbkq.TabIndex = 8;
			// 
			// frmUCLN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(791, 487);
			this.Controls.Add(this.lbkq);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btntinh);
			this.ForeColor = System.Drawing.Color.MediumTurquoise;
			this.Name = "frmUCLN";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "USCLN";
			this.Load += new System.EventHandler(this.frmUCLN_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtA;
        private System.Windows.Forms.NumericUpDown txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbkq;
    }
}

