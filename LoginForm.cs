using Desktop_Organiser.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Organiser
{
    public partial class LoginForm : Form
    {
        SqlConnection sqlConnection = classes.DatabaseConnectionClass.GetConnection();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (loginTextBox1.Text != "" && passwordTextBox2.Text != "")
            {
                string loginText = loginTextBox1.Text;
                string passwordText = passwordTextBox2.Text;
                if (loginExist(loginText))
                {
                    sqlConnection.Open();
                    string query = "userCheck";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", passwordText);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string pswString = reader["password"].ToString();
                        byte[] psw = System.Text.Encoding.Default.GetBytes(pswString);
                        // byte[] hashedPassword = CryptoClass.GetSHA1(loginText, passwordText);
                        if (CryptoClass.MatchSHA1(psw, CryptoClass.GetSHA1(loginText, passwordText)))
                        {
                            MessageBox.Show("Welcome!");
                            MainForm main = new MainForm();
                            this.Hide();
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login Error.");
                        }
                        sqlConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist. Check login.");
                }
            }
            else
            {
                MessageBox.Show("Login and password must be entered.");
            }
        }

        private bool loginExist(string login)
        {
            string query = "SELECT COUNT(*) FROM orgUser WHERE username = @username";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", login);
            sqlConnection.Open();
            int checkUser = (int) command.ExecuteScalar();
            sqlConnection.Close();
            if (checkUser > 0)
            {
                saveMyUser(login);
                return true;
            }
            return false;
        }

        private void saveMyUser(string login)
        {
            string query = "SELECT * FROM orgUser WHERE username = @username";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", login);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User.fillUser((int) reader["id"], reader["username"].ToString(), reader["password"].ToString(), reader["email"].ToString());
                //user.Id = (int) reader["id"];
                //user.Username = reader["username"].ToString();
                //user.Password = reader["password"].ToString();
                //user.Email = reader["email"].ToString();
            }
            sqlConnection.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            this.Hide();
            register.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ForgetPassForm forgetPass = new ForgetPassForm();
            this.Hide();
            forgetPass.Show();
        }
    }
}
