using System.Windows.Forms;

namespace LAB02
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Bai1 FromN = new Bai1();
            FromN.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Bai2 FromN = new Bai2();
            FromN.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            bai3 FromN = new bai3();
            FromN.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Bai4 FromN = new Bai4();
            FromN.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Bai5 FromN = new Bai5();
            FromN.ShowDialog();
        }
    }
}
