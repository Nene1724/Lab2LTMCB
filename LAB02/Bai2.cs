using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace LAB02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                textBox1.Text = ofd.SafeFileName.ToString();

                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                textBox2.Text = fs.Name.ToString();

                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;

                //đếm số dòng
                textBox3.Text = content.Split('\n').Count().ToString();

                //đếm số từ
                textBox4.Text = content.Split(' ').Count().ToString();

                //đếm số ký tự
                textBox5.Text = content.Length.ToString();

                fs.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu xảy ra lỗi
                MessageBox.Show("Đã xảy ra lỗi khi đọc tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }

}
