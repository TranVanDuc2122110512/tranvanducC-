namespace Baocao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtNoisinh = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBoxMaNV = new TextBox();
            textBoxHoTen = new TextBox();
            textBoxDiDong = new TextBox();
            textBoxDTNha = new TextBox();
            textBoxCMND = new TextBox();
            textBoxQueQuan = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxTamTru = new TextBox();
            textBoxNoiSinh = new TextBox();
            textBoxEmail = new TextBox();
            textBoxBiDanh = new TextBox();
            chkGioiTinh = new CheckBox();
            chkCoGiaDinh = new CheckBox();
            DateSinh = new DateTimePicker();
            DateCap = new DateTimePicker();
            label14 = new Label();
            txtNoicap = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(346, 300);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(449, 300);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(561, 300);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(642, 300);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 46);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Di động";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 102);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 133);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "CMND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 162);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Quê Quán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 195);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 227);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 10;
            label7.Text = "Tạm trú";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(236, 46);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 11;
            label8.Text = "Họ tên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(236, 73);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 12;
            label9.Text = "Điện thoại nhà";
            // 
            // txtNoisinh
            // 
            txtNoisinh.AutoSize = true;
            txtNoisinh.Location = new Point(236, 102);
            txtNoisinh.Name = "txtNoisinh";
            txtNoisinh.Size = new Size(51, 15);
            txtNoisinh.TabIndex = 13;
            txtNoisinh.Text = "Nơi sinh";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(236, 133);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 14;
            label11.Text = "Ngày cấp";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(452, 56);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 15;
            label12.Text = "Bí danh";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(452, 102);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 16;
            label13.Text = "Địa chỉ Email";
            // 
            // textBoxMaNV
            // 
            textBoxMaNV.Location = new Point(120, 38);
            textBoxMaNV.Name = "textBoxMaNV";
            textBoxMaNV.Size = new Size(100, 23);
            textBoxMaNV.TabIndex = 17;
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(331, 43);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(100, 23);
            textBoxHoTen.TabIndex = 18;
            // 
            // textBoxDiDong
            // 
            textBoxDiDong.Location = new Point(120, 67);
            textBoxDiDong.Name = "textBoxDiDong";
            textBoxDiDong.Size = new Size(100, 23);
            textBoxDiDong.TabIndex = 19;
            // 
            // textBoxDTNha
            // 
            textBoxDTNha.Location = new Point(331, 70);
            textBoxDTNha.Name = "textBoxDTNha";
            textBoxDTNha.Size = new Size(100, 23);
            textBoxDTNha.TabIndex = 20;
            // 
            // textBoxCMND
            // 
            textBoxCMND.Location = new Point(120, 125);
            textBoxCMND.Name = "textBoxCMND";
            textBoxCMND.Size = new Size(100, 23);
            textBoxCMND.TabIndex = 21;
            // 
            // textBoxQueQuan
            // 
            textBoxQueQuan.Location = new Point(120, 154);
            textBoxQueQuan.Name = "textBoxQueQuan";
            textBoxQueQuan.Size = new Size(100, 23);
            textBoxQueQuan.TabIndex = 22;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(120, 187);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(100, 23);
            textBoxDiaChi.TabIndex = 23;
            // 
            // textBoxTamTru
            // 
            textBoxTamTru.Location = new Point(120, 219);
            textBoxTamTru.Name = "textBoxTamTru";
            textBoxTamTru.Size = new Size(100, 23);
            textBoxTamTru.TabIndex = 24;
            // 
            // textBoxNoiSinh
            // 
            textBoxNoiSinh.Location = new Point(331, 102);
            textBoxNoiSinh.Name = "textBoxNoiSinh";
            textBoxNoiSinh.Size = new Size(100, 23);
            textBoxNoiSinh.TabIndex = 25;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(533, 94);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 26;
            // 
            // textBoxBiDanh
            // 
            textBoxBiDanh.Location = new Point(533, 48);
            textBoxBiDanh.Name = "textBoxBiDanh";
            textBoxBiDanh.Size = new Size(100, 23);
            textBoxBiDanh.TabIndex = 27;
            // 
            // chkGioiTinh
            // 
            chkGioiTinh.AutoSize = true;
            chkGioiTinh.Location = new Point(642, 52);
            chkGioiTinh.Name = "chkGioiTinh";
            chkGioiTinh.Size = new Size(52, 19);
            chkGioiTinh.TabIndex = 30;
            chkGioiTinh.Text = "Nam";
            chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // chkCoGiaDinh
            // 
            chkCoGiaDinh.AutoSize = true;
            chkCoGiaDinh.Location = new Point(698, 50);
            chkCoGiaDinh.Name = "chkCoGiaDinh";
            chkCoGiaDinh.Size = new Size(87, 19);
            chkCoGiaDinh.TabIndex = 31;
            chkCoGiaDinh.Text = "Có gia đình";
            chkCoGiaDinh.UseVisualStyleBackColor = true;
            // 
            // DateSinh
            // 
            DateSinh.Location = new Point(120, 96);
            DateSinh.Name = "DateSinh";
            DateSinh.Size = new Size(100, 23);
            DateSinh.TabIndex = 32;
            // 
            // DateCap
            // 
            DateCap.Location = new Point(331, 131);
            DateCap.Name = "DateCap";
            DateCap.Size = new Size(100, 23);
            DateCap.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(449, 142);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 34;
            label14.Text = "Nơi Cấp";
            // 
            // txtNoicap
            // 
            txtNoicap.Location = new Point(533, 133);
            txtNoicap.Name = "txtNoicap";
            txtNoicap.Size = new Size(100, 23);
            txtNoicap.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(287, 9);
            label10.Name = "label10";
            label10.Size = new Size(168, 28);
            label10.TabIndex = 30;
            label10.Text = "Thông tin cá nhân";
            // 
            // Form1
            // 
            ClientSize = new Size(797, 379);
            Controls.Add(label10);
            Controls.Add(label14);
            Controls.Add(txtNoicap);
            Controls.Add(DateCap);
            Controls.Add(DateSinh);
            Controls.Add(chkCoGiaDinh);
            Controls.Add(chkGioiTinh);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtNoisinh);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(textBoxMaNV);
            Controls.Add(textBoxHoTen);
            Controls.Add(textBoxDiDong);
            Controls.Add(textBoxDTNha);
            Controls.Add(textBoxCMND);
            Controls.Add(textBoxQueQuan);
            Controls.Add(textBoxDiaChi);
            Controls.Add(textBoxTamTru);
            Controls.Add(textBoxNoiSinh);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxBiDanh);
            Name = "Form1";
            Text = "Thông Tin Nhân Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label txtNoisinh;
        private Label label11;
        private Label label12;
        private Label label13;

        // TextBox declarations
        private TextBox textBoxMaNV;
        private TextBox textBoxHoTen;
        private TextBox textBoxDiDong;
        private TextBox textBoxDTNha;
        private TextBox textBoxCMND;
        private TextBox textBoxQueQuan;
        private TextBox textBoxDiaChi;
        private TextBox textBoxTamTru;
        private TextBox textBoxNoiSinh;
        private TextBox textBoxEmail;
        private TextBox textBoxBiDanh;
        private CheckBox chkGioiTinh;
        private CheckBox chkCoGiaDinh;
        private DateTimePicker DateSinh;
        private DateTimePicker DateCap;
        private Label label14;
        private TextBox txtNoicap;
        private Label label10;
    }
}
