using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Baocao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            // Lấy dữ liệu từ các điều khiển (TextBox, DateTimePicker, CheckBox, etc.)
            string maNhanVien = textBoxMaNV.Text;
            string hoTen = textBoxHoTen.Text;
            string biDanh = textBoxBiDanh.Text;
            bool gioiTinh = chkGioiTinh.Checked; // True nếu là nữ, False nếu là nam
            bool coGiaDinh = chkCoGiaDinh.Checked;
            string diDong = textBoxDiDong.Text;
            string dienThoaiNha = textBoxDTNha.Text;
            string email = textBoxEmail.Text;
            DateTime ngaySinh = DateSinh.Value;
            string noiSinh = textBoxNoiSinh.Text;
            string cmnd = textBoxCMND.Text; // Sử dụng CMND hoặc CCCD
            DateTime ngayCap = DateCap.Value;
            string noiCap = txtNoicap.Text;
            string queQuan = textBoxQueQuan.Text;
            string diaChi = textBoxDiaChi.Text;
            string tamTru = textBoxTamTru.Text;

            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(maNhanVien) || string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(diDong) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(cmnd) || string.IsNullOrWhiteSpace(noiSinh))
            {
                errorMessage = "Vui lòng nhập đầy đủ thông tin bắt buộc!";
            }
            // Kiểm tra số điện thoại di động không chứa chữ
            else if (!Regex.IsMatch(diDong, @"^\d+$"))
            {
                errorMessage = "Số điện thoại di động không hợp lệ, chỉ được chứa số.";
            }
            // Kiểm tra số điện thoại nhà không chứa chữ
            else if (!Regex.IsMatch(dienThoaiNha, @"^\d*$"))
            {
                errorMessage = "Số điện thoại nhà không hợp lệ, chỉ được chứa số.";
            }
            // Kiểm tra CCCD không chứa chữ
            else if (!Regex.IsMatch(cmnd, @"^\d+$"))
            {
                errorMessage = "CCCD không hợp lệ, chỉ được chứa số.";
            }
            // Kiểm tra họ tên, bí danh, tỉnh thành, quê quán, địa chỉ, tạm trú không chứa số
            else if (Regex.IsMatch(hoTen, @"\d") || Regex.IsMatch(biDanh, @"\d") ||
                     Regex.IsMatch(noiCap, @"\d") || Regex.IsMatch(queQuan, @"\d") ||
                     Regex.IsMatch(diaChi, @"\d") || Regex.IsMatch(tamTru, @"\d"))
            {
                errorMessage = "Họ tên, bí danh, nơi cấp, quê quán, địa chỉ, tạm trú không được chứa số.";
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tạo một đối tượng của NhanVienRepository
                NhanVienRepository repository = new NhanVienRepository();

                // Gọi phương thức AddNhanVien để thêm dữ liệu vào SQL
                repository.AddNhanVien(
                    maNhanVien, hoTen, biDanh, gioiTinh, coGiaDinh, diDong, dienThoaiNha, email,
                    ngaySinh, noiSinh, cmnd, ngayCap, noiCap, queQuan, diaChi, tamTru);

                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


             

        private void button4_Click_1(object sender, EventArgs e)
        {
            {
                // Tạo đối tượng Form3
                Form3 form3 = new Form3();

                // Hiển thị Form3
                form3.Show();

                // Đóng Form1 (Form hiện tại)
                this.Close();
            }
        }
    }

    public class NhanVienRepository
    {
        private string connectionString = "Data Source=DESKTOP-J5A60PL\\MAYAO;Initial Catalog=quanlinhanvien;Integrated Security=True"; // Thay thế chuỗi kết nối với chuỗi của bạn

        public void AddNhanVien(
            string maNhanVien, string hoTen, string biDanh, bool gioiTinh, bool coGiaDinh,
            string diDong, string dienThoaiNha, string email, DateTime ngaySinh,
            string noiSinh, string cmnd, DateTime ngayCap, string noiCap,
            string queQuan, string diaChi, string tamTru)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"INSERT INTO ThongTinCaNhan (MaNhanVien, HoTen, BiDanh, GioiTinh, CoGiaDinh, SoDienThoaiDiDong, 
                                      DienThoaiNha, Email, NgaySinh, NoiSinh, CMND, NgayCapCMND, NoiCapCMND, 
                                      QueQuan, DiaChi, TamTru) 
                                     VALUES (@MaNhanVien, @HoTen, @BiDanh, @GioiTinh, @CoGiaDinh, @SoDienThoaiDiDong, 
                                      @DienThoaiNha, @Email, @NgaySinh, @NoiSinh, @CMND, @NgayCapCMND, 
                                      @NoiCapCMND, @QueQuan, @DiaChi, @TamTru)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@BiDanh", biDanh ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@CoGiaDinh", coGiaDinh);
                        cmd.Parameters.AddWithValue("@SoDienThoaiDiDong", diDong);
                        cmd.Parameters.AddWithValue("@DienThoaiNha", dienThoaiNha ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@NoiSinh", noiSinh);
                        cmd.Parameters.AddWithValue("@CMND", cmnd);
                        cmd.Parameters.AddWithValue("@NgayCapCMND", ngayCap);
                        cmd.Parameters.AddWithValue("@NoiCapCMND", noiCap);
                        cmd.Parameters.AddWithValue("@QueQuan", queQuan);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@TamTru", tamTru);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
