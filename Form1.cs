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
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        showEvent showevent = new showEvent();
        addEvent addevent = new addEvent();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Organiser"].ConnectionString);


        }

        private void showEventBtn_Click(object sender, EventArgs e)
        {
            menuPnl.Hide();
            showevent.Location = new Point(0, 31);
            this.Controls.Add(showevent);
            showevent.Visible = true;

        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            menuPnl.Hide();
            addevent.Location = new Point(0, 31);
            this.Controls.Add(addevent);
            addevent.Visible = true;

        }

        private void editEventBtn_Click(object sender, EventArgs e)
        {
            menuPnl.Hide();

        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            if (menuPnl.Visible)
            {
                this.Close();
            }
            else if (!menuPnl.Visible && addevent.Visible || !menuPnl.Visible && showevent.Visible)
            {
                addevent.Visible = false;
                showevent.Visible = false;
                menuPnl.Show();
            }

        }
    }
}
