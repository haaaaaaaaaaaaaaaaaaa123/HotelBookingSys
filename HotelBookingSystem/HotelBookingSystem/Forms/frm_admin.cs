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

namespace HotelBookingSystem.Forms
{
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();

            UserControls.uc_dashboard.Instance.reload();
            changeUC(pnl_container, UserControls.uc_dashboard.Instance);
            SetBtnDesign(btn_dashboad);
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
            Guna2Button[] buttons = { btn_dashboad, btn_roomManage, btn_bookManage, btn_logout };

            foreach (var button in buttons)
            {
                button.CustomBorderThickness = new Padding(8, 0, 0, 0);
                button.CustomBorderColor = Color.Transparent;
                button.FillColor = Color.Transparent;
                button.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void SetBtnDesign(Guna2Button clickedButton)
        {
            ResetButtonBorderColor();
            clickedButton.CustomBorderThickness = new Padding(8, 0, 0, 0);
            clickedButton.CustomBorderColor = Color.IndianRed;
            clickedButton.FillColor = Color.MistyRose;
        }

        private void btn_dashboad_Click(object sender, EventArgs e)
        {
            UserControls.uc_dashboard.Instance.reload(); 
            changeUC(pnl_container, UserControls.uc_dashboard.Instance);
            SetBtnDesign(btn_dashboad);
        }

        private void btn_roomManage_Click(object sender, EventArgs e)
        {
            changeUC(pnl_container, UserControls.uc_roomManage.Instance);
            SetBtnDesign(btn_roomManage);
        }

        private void btn_bookManage_Click(object sender, EventArgs e)
        {
            UserControls.uc_bookManage.Instance.reload();
            changeUC(pnl_container, UserControls.uc_bookManage.Instance);
            SetBtnDesign(btn_bookManage);
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
