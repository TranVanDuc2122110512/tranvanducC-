using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Article05
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
                // Truy vấn để lấy cả tên khu vực (area_name)
                string query = @"SELECT c.id, c.name, a.name AS area_name 
                                 FROM customerr c
                                 JOIN areas a ON c.id_area = a.id";
                dataAdapter = new SqlDataAdapter(query, connection);
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
            string idText = textBox1.Text;
            string name = textBox2.Text;
            string idAreaText = textBox3.Text; // id_area lấy từ textBox3 (chuỗi)

            if (!string.IsNullOrEmpty(idText) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(idAreaText))
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    // Câu lệnh INSERT vào customerr
                    SqlCommand cmd = new SqlCommand("INSERT INTO customerr (id, name, id_area) VALUES (@id, @name, @id_area)", connection);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idText)); // id là số nên cần chuyển đổi
                    cmd.Parameters.AddWithValue("@name", name); // name là chuỗi nên không cần chuyển đổi
                    cmd.Parameters.AddWithValue("@id_area", idAreaText); // id_area là chuỗi nên không cần chuyển đổi
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thành công.");
                        LoadData(); // Tải lại dữ liệu sau khi thêm
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
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Sửa
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(textBox1.Text); // Sử dụng giá trị từ textBox1
                string name = textBox2.Text;
                string idAreaText = textBox3.Text; // Lấy id_area từ textBox3 (chuỗi)

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(idAreaText))
                {
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        connection.Open();

                        // Câu lệnh UPDATE trong customerr
                        SqlCommand cmd = new SqlCommand("UPDATE customerr SET name = @name, id_area = @id_area WHERE id = @id", connection);
                        cmd.Parameters.AddWithValue("@name", name); // name là chuỗi nên không cần chuyển đổi
                        cmd.Parameters.AddWithValue("@id_area", idAreaText); // id_area là chuỗi nên không cần chuyển đổi
                        cmd.Parameters.AddWithValue("@id", id); // id là số

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thành công.");
                            LoadData(); // Tải lại dữ liệu sau khi sửa
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bản ghi để sửa.");
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
                    MessageBox.Show("Vui lòng nhập tên và khu vực.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa.");
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
                    // Câu lệnh DELETE trong customerr
                    SqlCommand cmd = new SqlCommand("DELETE FROM customerr WHERE id = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công.");
                        LoadData(); // Tải lại dữ liệu sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa.");
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
                MessageBox.Show("Vui lòng chọn dòng để xóa.");
            }
        }

        private void button4_Click(object sender, EventArgs e) // Thoát
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["area_name"].Value.ToString(); // Hiển thị tên khu vực
            }
        }
    }
}
