using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //xử lý sự kiện khi người dùng đã chọn giói tính Nam
        //click đôi vào control checkbox
        //đây là sự kiện mà nếu thay đổi việc check(check or bỏ check đều xảy ra sự kiện)
        //nếu muốn kiểm tra nếu nút được check mới thông báo thì sửa như sau
        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
                MessageBox.Show("Bạn chọn gới tính Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
                MessageBox.Show("Bạn chọn gới tính Nữ", "Thông báo");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else
                txtHopMau.BackColor = Color.Green;
        }
    }
}
