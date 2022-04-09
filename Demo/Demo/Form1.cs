using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "admin";
            txtPassWord.Text = "admin";
            if (this.txtUserName.Text == "admin" && this.txtPassWord.Text == "admin")
            {
                MessageBox.Show("Bạn đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Bạn đăng nhập không thành công");
            }
        }
    }
}
