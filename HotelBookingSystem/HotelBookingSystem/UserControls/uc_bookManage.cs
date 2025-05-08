using HotelBookingSystem.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem.UserControls
{
    public partial class uc_bookManage : UserControl
    {
        public static uc_bookManage _instance;
        public static uc_bookManage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_bookManage();
                return _instance;
            }
        }

        public uc_bookManage()
        {
            InitializeComponent();
        }

        public void reload()
        {
            myDatabase.UpdatePastReservationsStatus();
            myDatabase.DisplayPendingReservations(dgv_pendings);
            myDatabase.DisplayApprovedReservations(dgv_upcoming);
            myDatabase.DisplayHistoryReservations(dgv_history);
        }

        private void uc_bookManage_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void dgv_pendings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_pendings.Rows[e.RowIndex];
                string rID = selectedRow.Cells["ID"].Value.ToString();

                Modals.frm_viewReservation vapp = new frm_viewReservation(rID, "admin");

                if (vapp.ShowDialog() == DialogResult.OK)
                {
                    reload();
                }
            }
        }

        private void dgv_upcoming_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_upcoming.Rows[e.RowIndex];
                string rID = selectedRow.Cells["ID"].Value.ToString();
                string status = selectedRow.Cells["PAYMENT STATUS"].Value.ToString();

                if(status != "Paid")
                {
                    Modals.frm_payment payment = new frm_payment(rID);

                    if (payment.ShowDialog() == DialogResult.OK)
                    {
                        reload();
                    }
                } 
            }
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            string filterText = tbx_search.Text.Trim().ToLower();

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgv_history.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dgv_history.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cell1 = row.Cells[1];
                    var cell2 = row.Cells[2];
                    var cell6 = row.Cells[6];

                    bool match1 = cell1.Value != null && cell1.Value.ToString().ToLower().Contains(filterText);
                    bool match2 = cell2.Value != null && cell2.Value.ToString().ToLower().Contains(filterText);
                    bool match6 = cell6.Value != null && cell6.Value.ToString().ToLower().Contains(filterText);

                    row.Visible = match1 || match2 || match6;
                }
            }

            currencyManager.ResumeBinding();
        }
    }
}
