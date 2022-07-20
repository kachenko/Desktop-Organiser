using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Desktop_Organiser
{
    public partial class showEvent : UserControl
    {
        private SqlConnection sqlConnection = null;
        

        public showEvent()
        {
            InitializeComponent();
            listView1.Visible = false;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Organiser"].ConnectionString);
            sqlConnection.Open();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlDataReader dataReader = null;
            try
            {
                string val = this.dateTimePicker1.Value.ToString("dd.MM.yyyy");
                SqlCommand sqlCommand = new SqlCommand("SELECT [rank], [title], [text], [isActive] FROM [dbo].[orgEvents] WHERE convert(varchar, remindAt, 104) = @date", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@date", val);
                dataReader = sqlCommand.ExecuteReader();
                ListViewItem item = null;
                while(dataReader.Read())
                {
                    item = new ListViewItem(new string[] { Convert.ToString(dataReader["rank"]),
                                                           Convert.ToString(dataReader["title"]),
                                                           Convert.ToString(dataReader["text"]),
                                                           Convert.ToString(dataReader["isActive"]) });

                    listView1.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }

            listView1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-mm-dd";
        }
    }
}
