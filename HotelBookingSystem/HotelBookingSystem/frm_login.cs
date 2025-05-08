using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = tbx_email.Text.Trim();
            string pass = tbx_password.Text.Trim();

            bool success = myDatabase.Login(email, pass);

            if (success)
            {
                this.Hide();
            }
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            frm_register reg = new frm_register();
            reg.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to close?",
               "Confirm Exit",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
