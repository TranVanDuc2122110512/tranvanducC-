namespace ducC_
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kh?i t?o m?c ??nh
            result.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            // Xóa màn hình n?u ?ang trong tr?ng thái phép toán
            if (operation_pressed)
            {
                result.Clear();
                operation_pressed = false; // ??t l?i tr?ng thái
            }

            // Thêm s? vào k?t qu?
            result.Text += b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text; // L?u phép toán
            value = Double.Parse(result.Text); // L?u giá tr? hi?n t?i
            operation_pressed = true; // ?ánh d?u ?ã nh?n phép toán
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Th?c hi?n phép toán khi nh?n nút "="
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    // Ki?m tra tránh chia cho 0
                    if (Double.Parse(result.Text) != 0)
                    {
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                    }
                    else
                    {
                        result.Text = "Cannot divide by zero"; // Thông báo l?i
                    }
                    break;
                default:
                    break;
            }

            operation_pressed = false; // ??t l?i tr?ng thái
        }

        // Các hàm khác không thay ??i
    }
}
