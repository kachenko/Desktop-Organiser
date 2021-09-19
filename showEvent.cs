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
    public partial class showEvent : UserControl
    {
        public showEvent()
        {
            InitializeComponent();
            listBox1.Visible = false;
            listView1.Visible = false;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listView1.Visible = true;
        }
    }
}
