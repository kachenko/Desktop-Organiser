using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Organiser
{
    public partial class Form1 : Form
    {
        showEvent addevent = new showEvent();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuPnl.Show();
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            menuPnl.Hide();
            addevent.Location = new Point(0, 31);
            this.Controls.Add(addevent);
        }

        private void editEventBtn_Click(object sender, EventArgs e)
        {
            menuPnl.Hide();
        }
    }
}
