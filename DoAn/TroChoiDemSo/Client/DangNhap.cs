using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public void ThamGia()
        {
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            Name = user;
            if (user == null || user.Equals(""))
            {
                MessageBox.Show("Ip Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             else if (pass == null || user.Equals(""))
            {
                MessageBox.Show("Tên Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
