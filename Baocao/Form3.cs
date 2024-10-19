using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Baocao
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=DESKTOP-J5A60PL\\MAYAO;Initial Catalog=quanlinhanvien;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
            LoadData(); // Gọi phương thức load dữ liệu khi khởi tạo form
        }

        private void LoadData()
        {
            // Khởi tạo kết nối SQL
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // Câu truy vấn để lấy dữ liệu từ bảng ThongTinCaNhan
                    string query = "SELECT * FROM ThongTinCaNhan";

                    // Khởi tạo SqlDataAdapter để lấy dữ liệu
                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    // Tạo DataTable để chứa dữ liệu từ SQL
                    DataTable dt = new DataTable();

                    // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                    da.Fill(dt);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có vấn đề
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sự kiện khi người dùng click vào ô trong DataGridView (nếu cần xử lý thêm)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng của Form1
            Form1 form1 = new Form1();

            // Hiển thị Form1
            form1.Show();

            // Ẩn Form3
            this.Hide(); // Hoặc dùng this.Close() nếu muốn đóng Form3 hoàn toàn
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột MaNhanVien từ dòng đã chọn dưới dạng chuỗi
                string maNhanVien = dataGridView1.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();

                // Xác nhận lại với người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Khởi tạo kết nối SQL
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            // Mở kết nối
                            con.Open();

                            // Câu truy vấn xóa dữ liệu
                            string query = "DELETE FROM ThongTinCaNhan WHERE MaNhanVien = @MaNhanVien";

                            // Khởi tạo SqlCommand để thực thi truy vấn
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                // Thêm tham số @MaNhanVien dưới dạng chuỗi
                                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                                // Thực thi truy vấn
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Kiểm tra nếu việc xóa thành công
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa thành công!");

                                    // Tải lại dữ liệu sau khi xóa
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy nhân viên cần xóa.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Form3
            Form2 form2 = new Form2();

            // Hiển thị Form3
            form2.Show();

            // Đóng Form1 (Form hiện tại)
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị của các cột từ dòng đã chọn
                string maNhanVien = dataGridView1.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                string hoTen = dataGridView1.SelectedRows[0].Cells["HoTen"].Value?.ToString();
                string soDienThoai = dataGridView1.SelectedRows[0].Cells["SoDienThoaiDiDong"].Value?.ToString();
                string email = dataGridView1.SelectedRows[0].Cells["Email"].Value?.ToString();
                // Các trường khác nếu cần...

                // Xác nhận lại với người dùng trước khi sửa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin của nhân viên này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Khởi tạo kết nối SQL
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            // Mở kết nối
                            con.Open();

                            // Câu truy vấn cập nhật dữ liệu
                            string query = "UPDATE ThongTinCaNhan SET HoTen = @HoTen, SoDienThoaiDiDong = @SoDienThoai, Email = @Email WHERE MaNhanVien = @MaNhanVien";

                            // Khởi tạo SqlCommand để thực thi truy vấn
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                // Thêm các tham số vào câu lệnh SQL
                                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                                cmd.Parameters.AddWithValue("@Email", email);

                                // Thực thi truy vấn
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Kiểm tra nếu việc cập nhật thành công
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cập nhật thành công!");

                                    // Tải lại dữ liệu sau khi cập nhật
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy nhân viên cần sửa.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.");
            }
        }

    }
}
