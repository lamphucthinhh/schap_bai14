namespace schap_bai5._5
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLaptrinh = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.chkgachchan = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên:";
            // 
            // lblLaptrinh
            // 
            this.lblLaptrinh.Location = new System.Drawing.Point(105, 263);
            this.lblLaptrinh.Multiline = true;
            this.lblLaptrinh.Name = "lblLaptrinh";
            this.lblLaptrinh.ReadOnly = true;
            this.lblLaptrinh.Size = new System.Drawing.Size(131, 34);
            this.lblLaptrinh.TabIndex = 1;
            this.lblLaptrinh.Text = "Tèo 2023";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chkitalic);
            this.groupBox2.Controls.Add(this.chkgachchan);
            this.groupBox2.Controls.Add(this.chkBold);
            this.groupBox2.Location = new System.Drawing.Point(218, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkitalic.ForeColor = System.Drawing.Color.Blue;
            this.chkitalic.Location = new System.Drawing.Point(18, 62);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(103, 17);
            this.chkitalic.TabIndex = 0;
            this.chkitalic.Text = "nghiêng Italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.chkitalic_CheckedChanged);
            // 
            // chkgachchan
            // 
            this.chkgachchan.AutoSize = true;
            this.chkgachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgachchan.ForeColor = System.Drawing.Color.Blue;
            this.chkgachchan.Location = new System.Drawing.Point(18, 97);
            this.chkgachchan.Name = "chkgachchan";
            this.chkgachchan.Size = new System.Drawing.Size(89, 17);
            this.chkgachchan.TabIndex = 0;
            this.chkgachchan.Text = "Gạch Chân";
            this.chkgachchan.UseVisualStyleBackColor = true;
            this.chkgachchan.CheckedChanged += new System.EventHandler(this.chkgachchan_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.ForeColor = System.Drawing.Color.Blue;
            this.chkBold.Location = new System.Drawing.Point(18, 28);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(80, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgreen.ForeColor = System.Drawing.Color.Lime;
            this.radgreen.Location = new System.Drawing.Point(21, 50);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(59, 17);
            this.radgreen.TabIndex = 0;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radgreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(21, 27);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(48, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "color";
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblack.Location = new System.Drawing.Point(21, 96);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(57, 17);
            this.radblack.TabIndex = 0;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radblack_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(21, 73);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(50, 17);
            this.radblue.TabIndex = 0;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radblue_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập Trình Bởi:";
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(106, 42);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(312, 20);
            this.txtnhapten.TabIndex = 1;
            this.txtnhapten.Text = "Tèo 2023";
            this.txtnhapten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(262, 281);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(90, 34);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lập trình bởi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.lblLaptrinh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblLaptrinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.CheckBox chkgachchan;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label3;
    }
}

