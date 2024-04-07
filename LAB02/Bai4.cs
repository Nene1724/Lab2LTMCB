using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB02
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string id = TxtMssv.Text;
            string phone = TxtPhone.Text;
            string math = TxtMath.Text;
            string literature = TxtLitre.Text;
            double tb;

            string Input = "input_bai4.txt";
            string Output = "output_bai4.txt";

            try
            {
                if (phone.Length != 10 || !phone.All(char.IsDigit))
                {
                    throw new Exception("Số điện thoại không hợp lệ");
                }

                if (!double.TryParse(math, out double mathScore) || mathScore < 0 || mathScore > 10)
                {
                    throw new Exception("Điểm toán không hợp lệ.");
                }

                if (!double.TryParse(literature, out double literatureScore) || literatureScore < 0 || literatureScore > 10)
                {
                    throw new Exception("Điểm văn không hợp lệ.");
                }

                using (StreamWriter sw = File.AppendText(Input))
                {
                    
                    sw.WriteLine($"{id}\n{name}\n{phone}\n{math}\n{literature}\n ");
                }

                tb = Math.Round((double.Parse(math, CultureInfo.InvariantCulture.NumberFormat) + double.Parse(literature, CultureInfo.InvariantCulture.NumberFormat))/2,2);

                using (StreamWriter sw = File.AppendText(Output))
                {
                   
                    sw.WriteLine($"{id}\n{name}\n{phone}\n{math}\n{literature}\n{tb}\n");
                }

                MessageBox.Show("Dữ liệu đã được nhập và lưu vào file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtName.Clear();
                TxtMssv.Clear();
                TxtPhone.Clear();
                TxtMath.Clear();
                TxtLitre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
     
        }
    }
}
