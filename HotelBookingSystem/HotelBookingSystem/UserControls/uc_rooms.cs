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
    public partial class uc_rooms : UserControl
    {
        public static uc_rooms _instance;
        public static uc_rooms Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_rooms();
                return _instance;
            }
        }

        private string _email;
        public void SetAuthor(string email)
        {
            this._email = email;
        }

        public void reload()
        {
            myDatabase.DisplayUserReservations(dgv_reservation, _email);
            myDatabase.Rooms(flp_container);
        }

        public uc_rooms()
        {
            InitializeComponent();
        }

        private void uc_rooms_Load(object sender, EventArgs e)
        {
            myDatabase.DisplayUserReservations(dgv_reservation, _email);
            myDatabase.Rooms(flp_container);
        }

        private void dgv_reservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_reservation.Rows[e.RowIndex];
                string rID = selectedRow.Cells["ID"].Value.ToString();
                string status = selectedRow.Cells["STATUS"].Value.ToString();

                if (status == "Pending")
                {
                    Modals.frm_viewReservation view = new frm_viewReservation(rID, "user");

                    if (view.ShowDialog() == DialogResult.OK)
                    {
                        myDatabase.DisplayUserReservations(dgv_reservation, _email);
                    }
                }
            }
        }
    }
}
