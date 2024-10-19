using System;
using System.Windows.Forms;

namespace Baocao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Định nghĩa tên đăng nhập và mật khẩu
            string validUsername = "tranvanduc";
            string validPassword = "123456";

            // Lấy giá trị từ các TextBox
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;

            // Kiểm tra thông tin đăng nhập
            if (enteredUsername == validUsername && enteredPassword == validPassword)
            {
                // Nếu thông tin đúng, mở Form3
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide(); // Ẩn Form2
            }
            else
            {
                // Nếu thông tin sai, hiển thị thông báo lỗi
                label4.Text = "Tên người dùng hoặc mật khẩu sai.";
                label4.ForeColor = System.Drawing.Color.Red; // Đặt màu chữ đỏ
            }
        }
    }
}
