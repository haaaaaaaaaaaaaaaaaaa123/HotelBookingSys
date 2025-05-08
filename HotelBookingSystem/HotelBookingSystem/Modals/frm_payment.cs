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
    public partial class frm_payment : Form
    {
        private string _ID;
        public frm_payment(string id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void frm_payment_Load(object sender, EventArgs e)
        {
            myDatabase.getTotalPrice(_ID, lbl_totalFee);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int total = int.Parse(lbl_totalFee.Text.Replace("₱", "").Replace(".00", "").Trim());

            if ((int)spn_payment.Value < total)
            {
                MessageBox.Show("Payment must be greater that cost");
            }
            else
            {
                myDatabase.updatePaymentStatus(_ID);
                DialogResult = DialogResult.OK;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
