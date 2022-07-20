using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Desktop_Organiser.classes;

namespace Desktop_Organiser
{
    public partial class addEvent : UserControl
    {
        private SqlConnection sqlConnection = DatabaseConnectionClass.GetConnection();
        static DataTable dataTable = new DataTable();

        public void loadRankComboBox()
        {
            sqlConnection.Open();
            string query = "select * from [orgRank]";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public addEvent()
        {
            InitializeComponent();
            listView1.Visible = false;
            loadRankComboBox();
        }

        private DataTable showEvent(string value)
        {
            string query = "select * from [orgEvents] where reminderDate = @date";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@date", value);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        private SqlDataReader showEventWithReader(string value)
        {
            string query = "select * from [orgEvents] where reminderDate = @date";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@date", value);
            
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            return dataReader;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                string val = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
                sqlConnection.Open();
                dataTable = showEvent(val);
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(new string[] { row["id"].ToString(),
                        row["rank"].ToString(),
                        row["title"].ToString(),
                        row["description"].ToString(),
                        row["isActive"].ToString() });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();
            listView1.Visible = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("[dbo].[eventAddOrEdit]", sqlConnection);
                // User.Id = 1; // DELETE THIS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                command.Parameters.AddWithValue("@userId", User.Id);
                command.Parameters.AddWithValue("@reminderDate", dateTimePicker1.Value.Date);
                command.Parameters.AddWithValue("@rank", comboBox1.GetItemText(this.comboBox1.SelectedValue));
                command.Parameters.AddWithValue("@title", titleTextBox.Text);
                command.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                command.Parameters.AddWithValue("@creationDate", DateTime.Now.Date);
                command.Parameters.AddWithValue("@isActive", checkBox1.Checked);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if (listView1.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        int id = Convert.ToInt32(item.SubItems[0]);
                        setValues(id);
                        comboBox1.SelectedItem = Event.RemindedDate;
                        titleTextBox.Text = Event.Title;
                        descriptionTextBox.Text = Event.Description;
                        // checkBox1.Checked = Boolean.Parse(Event.IsEventActive.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setValues(int value)
        {
            string query = "SELECT * FROM orgEvents WHERE id = @id";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@id", value);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Event.EventId = Convert.ToInt32(reader["id"]); // (int)dataReader["id"];
                Event.UserId = Convert.ToInt32(reader["userId"]); // (int)dataReader["userId"];
                Event.RemindedDate = Convert.ToDateTime(reader["reminderDate"]); // (DateTime)dataReader["reminderDate"];
                Event.Rank = Convert.ToInt32(reader["rank"]); // (int)dataReader["rank"];
                Event.Title = Convert.ToString(reader["title"]); // dataReader["title"].ToString();
                Event.Description = Convert.ToString(reader["description"]); // dataReader["description"].ToString();
                Event.CreationDate = Convert.ToDateTime(reader["creationDate"]); // (DateTime)dataReader["creationDate"];
                Event.IsEventActive = Convert.ToChar(reader["isActive"]);
            }
            sqlConnection.Close();
        }
    }
}
