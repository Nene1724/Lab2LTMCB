namespace LAB02
{
    partial class Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtName = new TextBox();
            TxtMssv = new TextBox();
            TxtPhone = new TextBox();
            TxtMath = new TextBox();
            TxtLitre = new TextBox();
            BtnNhap = new Button();
            Btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 60);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 2;
            label1.Text = "NHẬP THÔNG TIN SINH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 98);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "HỌ VÀ TÊN: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 137);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "MSSV:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 179);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 5;
            label4.Text = "ĐIỆN THOẠI: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 226);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 6;
            label5.Text = "ĐIỂM TOÁN: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 274);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 7;
            label6.Text = "ĐIỂM VĂN: ";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(256, 84);
            TxtName.Multiline = true;
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(402, 34);
            TxtName.TabIndex = 8;
            TxtName.TextChanged += textBox1_TextChanged;
            // 
            // TxtMssv
            // 
            TxtMssv.Location = new Point(256, 123);
            TxtMssv.Multiline = true;
            TxtMssv.Name = "TxtMssv";
            TxtMssv.Size = new Size(402, 34);
            TxtMssv.TabIndex = 9;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(256, 165);
            TxtPhone.Multiline = true;
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(402, 34);
            TxtPhone.TabIndex = 10;
            // 
            // TxtMath
            // 
            TxtMath.Location = new Point(256, 212);
            TxtMath.Multiline = true;
            TxtMath.Name = "TxtMath";
            TxtMath.Size = new Size(402, 34);
            TxtMath.TabIndex = 11;
            // 
            // TxtLitre
            // 
            TxtLitre.Location = new Point(256, 260);
            TxtLitre.Multiline = true;
            TxtLitre.Name = "TxtLitre";
            TxtLitre.Size = new Size(402, 34);
            TxtLitre.TabIndex = 12;
            // 
            // BtnNhap
            // 
            BtnNhap.Location = new Point(435, 317);
            BtnNhap.Name = "BtnNhap";
            BtnNhap.Size = new Size(94, 29);
            BtnNhap.TabIndex = 13;
            BtnNhap.Text = "NHẬP";
            BtnNhap.UseVisualStyleBackColor = true;
            BtnNhap.Click += button1_Click;
            // 
            // Btnexit
            // 
            Btnexit.Location = new Point(564, 317);
            Btnexit.Name = "Btnexit";
            Btnexit.Size = new Size(94, 29);
            Btnexit.TabIndex = 14;
            Btnexit.Text = "THOÁT";
            Btnexit.UseVisualStyleBackColor = true;
            Btnexit.Click += Btnexit_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btnexit);
            Controls.Add(BtnNhap);
            Controls.Add(TxtLitre);
            Controls.Add(TxtMath);
            Controls.Add(TxtPhone);
            Controls.Add(TxtMssv);
            Controls.Add(TxtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Bai4";
            Text = "Bai4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtName;
        private TextBox TxtMssv;
        private TextBox TxtPhone;
        private TextBox TxtMath;
        private TextBox TxtLitre;
        private Button BtnNhap;
        private Button Btnexit;
    }
}