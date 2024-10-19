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

            // X�a m�n h�nh n?u ?ang trong tr?ng th�i ph�p to�n
            if (operation_pressed)
            {
                result.Clear();
                operation_pressed = false; // ??t l?i tr?ng th�i
            }

            // Th�m s? v�o k?t qu?
            result.Text += b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text; // L?u ph�p to�n
            value = Double.Parse(result.Text); // L?u gi� tr? hi?n t?i
            operation_pressed = true; // ?�nh d?u ?� nh?n ph�p to�n
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Th?c hi?n ph�p to�n khi nh?n n�t "="
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
                    // Ki?m tra tr�nh chia cho 0
                    if (Double.Parse(result.Text) != 0)
                    {
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                    }
                    else
                    {
                        result.Text = "Cannot divide by zero"; // Th�ng b�o l?i
                    }
                    break;
                default:
                    break;
            }

            operation_pressed = false; // ??t l?i tr?ng th�i
        }

        // C�c h�m kh�c kh�ng thay ??i
    }
}
