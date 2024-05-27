using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Empolees empolees = new Empolees();
            empolees.Show();
            this.Hide();
        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            Stuff stuff = new Stuff();
            stuff.Show();
            this.Hide();
        }
    }
}
