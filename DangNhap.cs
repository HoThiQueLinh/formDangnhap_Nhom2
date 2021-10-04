using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhBlack
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendn = "ndungithue";
            string matkhau = "Abc@123";
            if (tendn.Equals(txtdangnhap.Text) && matkhau.Equals(txtmatkhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
                MessageBox.Show("Đăng nhập thất bại");
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
