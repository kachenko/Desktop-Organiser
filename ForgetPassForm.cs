using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Organiser
{
    public partial class ForgetPassForm : Form
    {
        SqlConnection sqlConnection = classes.DatabaseConnectionClass.GetConnection();
        public ForgetPassForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string loginText = textBox1.Text;
            string passwordText = textBox2.Text;
            string passwordRepText = textBox3.Text;
            if (loginExist(loginText))
            {
                if (passwordText == "" || passwordRepText == "")
                {
                    MessageBox.Show("Enter or repeat your password.");
                }
                if (passwordText == passwordRepText)
                {
                    passwordText = System.Text.Encoding.Default.GetString(CryptoClass.GetSHA1(loginText, passwordText));
                    string query = "updateUserPassword";
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", loginText);
                    command.Parameters.AddWithValue("@password", passwordText);
                    int isSuccessfully = command.ExecuteNonQuery();
                    sqlConnection.Close();
                    if (isSuccessfully == 1)
                    {
                        LoginForm login = new LoginForm();
                        this.Hide();
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match.");
                }
            }
            else
            {
                MessageBox.Show("User does not exist. Check login.");
            }
        }

        private bool loginExist(string login)
        {
            string query = "SELECT COUNT(*) FROM orgUser WHERE username = @username";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", login);
            sqlConnection.Open();
            if ((int) command.ExecuteScalar() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
