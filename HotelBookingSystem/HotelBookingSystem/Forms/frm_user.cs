using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelBookingSystem.Forms
{
    public partial class frm_user : Form
    {
        private string _email;
        public frm_user(string email)
        {
            InitializeComponent();
            _email = email;

            UserControls.uc_rooms.Instance.reload();
            UserControls.uc_rooms.Instance.SetAuthor(_email);
            changeUC(pnl_container, UserControls.uc_rooms.Instance);
            SetBtnDesign(btn_room);
        }
        public void changeUC(Panel pnl, UserControl uc)
        {
            pnl_container.Controls.Remove(uc);

            Cursor = Cursors.WaitCursor;
            if (!pnl.Controls.Contains(uc))
            {
                pnl.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
            uc.BringToFront();

            Cursor = Cursors.Default;
        }

        private void ResetButtonBorderColor()
        {
            Guna2Button[] buttons = { btn_room, btn_book, btn_logout };

            foreach (var button in buttons)
            {
                button.CustomBorderThickness = new Padding(8, 0, 0, 0);
                button.CustomBorderColor = Color.Transparent;
                button.FillColor = Color.Transparent;
                button.ForeColor = Color.FromArgb(64,64,64);
            }
        }

        private void SetBtnDesign(Guna2Button clickedButton)
        {
            ResetButtonBorderColor();
            clickedButton.CustomBorderThickness = new Padding(8, 0, 0, 0);
            clickedButton.CustomBorderColor = Color.RoyalBlue;
            clickedButton.FillColor = Color.AliceBlue;
            clickedButton.ForeColor = Color.RoyalBlue;
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            UserControls.uc_rooms.Instance.reload();
            changeUC(pnl_container, UserControls.uc_rooms.Instance);
            SetBtnDesign(btn_room);
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            UserControls.uc_bookRoom.Instance.reload();
            UserControls.uc_bookRoom.Instance.SetEmail(_email);
            changeUC(pnl_container, UserControls.uc_bookRoom.Instance);
            SetBtnDesign(btn_book);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                SetBtnDesign(btn_logout);
                frm_login log = new frm_login();
                log.Show();
                this.Hide();
            }
        }
    }
}
