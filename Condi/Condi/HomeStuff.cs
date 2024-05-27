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
    public partial class HomeStuff : Form
    {
        private Button currentButton;
        private Form activeForm;
        public HomeStuff()
        {
            InitializeComponent();
        }

        private void HomeStuff_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Requests(), button_client);
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Requests(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Comments(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users(), sender);
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButtons();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(96, 169, 247);
                }
            }
        }

        //DIASABLE NAV BUTTON COLORS
        private void DisableButtons()
        {
            foreach (Control btn in panel1.Controls)
            {
                if (btn.Name != "button_exit")
                {
                    if (btn.GetType() == typeof(Button))
                    {
                        btn.BackColor = Color.FromArgb(242, 242, 242);
                    }
                }
            }
        }
        private void OpenChildForm(Form form, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.bodyPanel.Controls.Add(form);
            this.bodyPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form1 AH = new Form1();
            this.Close();
            AH.Show();
        }
    }
}
