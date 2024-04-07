namespace LAB02
{
    partial class Bai5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            pictureBox1 = new PictureBox();
            Btnchose = new Button();
            label1 = new Label();
            listView = new ListView();
            btndelete = new Button();
            btnexit = new Button();
            Link = new FolderBrowserDialog();
            labelpath = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Btnchose
            // 
            Btnchose.Location = new Point(143, 51);
            Btnchose.Name = "Btnchose";
            Btnchose.Size = new Size(158, 37);
            Btnchose.TabIndex = 1;
            Btnchose.Text = "CHỌN THƯ MỤC";
            Btnchose.UseVisualStyleBackColor = true;
            Btnchose.Click += Btnchose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 68);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "ĐỊA CHỈ: ";
            // 
            // listView
            // 
            listView.Location = new Point(143, 94);
            listView.Name = "listView";
            listView.Size = new Size(571, 274);
            listView.TabIndex = 4;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(493, 372);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(100, 33);
            btndelete.TabIndex = 5;
            btndelete.Text = "XÓA";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(614, 374);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(100, 33);
            btnexit.TabIndex = 6;
            btnexit.Text = "THOÁT";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // labelpath
            // 
            labelpath.AutoSize = true;
            labelpath.Location = new Point(388, 67);
            labelpath.Name = "labelpath";
            labelpath.Size = new Size(0, 20);
            labelpath.TabIndex = 4;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelpath);
            Controls.Add(btnexit);
            Controls.Add(btndelete);
            Controls.Add(listView);
            Controls.Add(label1);
            Controls.Add(Btnchose);
            Controls.Add(pictureBox1);
            Name = "Bai5";
            Text = "Bai5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Btnchose;
        private Label label1;
        private ListView listView;
        private Button btndelete;
        private Button btnexit;
        private FolderBrowserDialog Link;
        private Label labelpath;
    }
}