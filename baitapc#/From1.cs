using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace baitapc_
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-J5A60PL\\MAYAO;Initial Catalog=sale;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                dataAdapter = new SqlDataAdapter("SELECT * FROM customer", connection);
                dataTable = new DataTable();
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Thêm
        {
            string idText = textBox1.Text; // Lấy giá trị ID từ textBox1
            string name = textBox2.Text;

            if (!string.IsNullOrEmpty(idText) && !string.IsNullOrEmpty(name))
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO customer (id, name) VALUES (@id, @name)", connection);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idText)); // Thêm ID vào câu lệnh
                    cmd.Parameters.AddWithValue("@name", name);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thành công.");
                        LoadData(); // Cập nhật dữ liệu trên form
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập id và tên.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Sửa
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                string name = textBox2.Text;

                if (!string.IsNullOrEmpty(name)) // Kiểm tra tên không rỗng
                {
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE customer SET name = @name WHERE id = @id", connection);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Kiểm tra số hàng bị ảnh hưởng
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thành công.");
                            LoadData(); // Cập nhật dữ liệu trên form
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bản ghi để sửa."); // Thông báo nếu không sửa được
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên."); // Thông báo nếu tên rỗng
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa."); // Thông báo nếu chưa chọn dòng
            }
        }

        private void button3_Click(object sender, EventArgs e) // Xóa
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE id = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Kiểm tra số hàng bị ảnh hưởng
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công.");
                        LoadData(); // Cập nhật dữ liệu trên form
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa."); // Thông báo nếu không xóa được
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa."); // Thông báo nếu chưa chọn dòng
            }
        }

        private void button4_Click(object sender, EventArgs e) // Thoát
        {
            this.Close(); // Đóng form hiện tại
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đặt tên lại cho các TextBox khi chọn một dòng
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString(); // Hiển thị ID
                textBox2.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString(); // Hiển thị tên
            }
        }

        
    }
}
