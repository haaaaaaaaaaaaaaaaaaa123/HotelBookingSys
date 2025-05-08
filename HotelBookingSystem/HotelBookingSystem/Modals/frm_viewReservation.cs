using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem.Modals
{
    public partial class frm_viewReservation : Form
    {
        private string _ID;
        private string _role;

        public frm_viewReservation(string id, string role)
        {
            InitializeComponent();
            _ID = id;
            _role = role;
        }

        public void LoadProductData(string customer, string roomNo, string contact, string CI, string CO, string fee, string totalFee, string status)
        {
            lbl_name.Text = customer;
            lbl_roomNo.Text = roomNo;
            lbl_contact.Text = contact;
            lbl_CIdate.Text = CI;
            lbl_COdate.Text = CO;
            lbl_fee.Text = "₱" + fee;
            lbl_totalFee.Text = "₱" + totalFee;

            DateTime checkInDate = DateTime.Parse(CI);
            DateTime checkOutDate = DateTime.Parse(CO);
            int nights = (checkOutDate - checkInDate).Days;

            lbl_nights.Text = nights.ToString() + " night(s)";

            if (status == "Pending" && _role != "user")
            {
                pnl_btns.BringToFront();
                btn_cancelReservation.SendToBack();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frm_viewReservation_Load(object sender, EventArgs e)
        {
            myDatabase.getBookingData(_ID, LoadProductData);
        }

        private void btn_approved_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure to approve this reservation?", "Confirm", MessageBoxButtons.OKCancel);

            if(confirm == DialogResult.OK)
            {
                bool isApproved = myDatabase.ApproveReservation(int.Parse(_ID));
                if (isApproved)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            bool isCancelled = myDatabase.RejectReservation(int.Parse(_ID));
            if (isCancelled)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_cancelReservation_Click(object sender, EventArgs e)
        {
            bool isCancelled = myDatabase.CancelReservation(int.Parse(_ID));
            if (isCancelled)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
