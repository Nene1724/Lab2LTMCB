using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB02
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {

            InitializeComponent();
            listView.Columns.Add("Tên File", 300, HorizontalAlignment.Left);
            listView.Columns.Add("Kích Thước", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Ngày tạo", 200, HorizontalAlignment.Left);
            listView.Columns.Add("Đuôi mở rộng", 120, HorizontalAlignment.Left);

        }

        private void Btnchose_Click(object sender, EventArgs e)
        {
            if (Link.ShowDialog() == DialogResult.OK)
            {
                labelpath.Text = Link.SelectedPath;
                DirectoryInfo directoryInfo = new DirectoryInfo(Link.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles();
                listView.View = View.Details;
                listView.GridLines = true;
                foreach (FileInfo file in files)
                {
                    string[] row = { file.Name, file.Length.ToString(), Path.GetExtension(file.Name), file.LastWriteTime.ToString() };
                    ListViewItem listViewItem = new ListViewItem(row);
                    listView.Items.Add(listViewItem);
                }
            }
            else { MessageBox.Show("Chọn folder"); }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            labelpath.Text = null;
            listView.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
