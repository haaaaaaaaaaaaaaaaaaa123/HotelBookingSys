using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            var passValid = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^A-Za-z\d]).{8,}$");
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            string fname = tbx_firstname.Text.Trim();
            string lname = tbx_lastname.Text.Trim();
            string email = tbx_email.Text.Trim();
            string pass = tbx_password.Text.Trim();
            string cpass = tbx_cpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(cpass))
            {
                MessageBox.Show("Please complete all fields!");
            }
            else if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Please enter a valid email address.");
            }
            else if (!pass.Equals(cpass))
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (!passValid.IsMatch(pass))
            {
                MessageBox.Show("Your password is weak. Please use a combination of at least 8 characters including uppercase and lowercase letters, numbers, and symbols for better security.", "Warning");
            }
            else
            {
                bool success = myDatabase.SignUp(fname, lname, email, pass);

                if (success)
                {
                    tbx_firstname.Text = "";
                    tbx_lastname.Text = "";
                    tbx_email.Text = "";
                    tbx_password.Text = "";
                    tbx_cpassword.Text = "";

                    frm_login log = new frm_login();
                    log.Show();
                    this.Hide();
                }
            }
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            frm_login log = new frm_login();
            log.Show();
            this.Close();
        }
    }
}
