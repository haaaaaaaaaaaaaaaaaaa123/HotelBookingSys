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
    public partial class uc_roomManage : UserControl
    {
        public static uc_roomManage _instance;
        public static uc_roomManage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_roomManage();
                return _instance;
            }
        }
        public uc_roomManage()
        {
            InitializeComponent();
        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            Modals.frm_addRoom addRoom = new Modals.frm_addRoom();

            var result = addRoom.ShowDialog();

            if(result == DialogResult.OK)
            {
                myDatabase.DisplayRooms(dgv_rooms);
            }
        }

        private void dgv_rooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_rooms.Rows[e.RowIndex];

                byte[] image1 = (byte[])selectedRow.Cells["Image 1"].Value;
                byte[] image2 = (byte[])selectedRow.Cells["Image 2"].Value;
                byte[] image3 = (byte[])selectedRow.Cells["Image 3"].Value;
                int roomNumber = Convert.ToInt32(selectedRow.Cells["Room No."].Value);
                string description = selectedRow.Cells["Description"].Value.ToString();
                string type = selectedRow.Cells["Category"].Value.ToString();
                int price = Convert.ToInt32(selectedRow.Cells["Price"].Value);       

                frm_addRoom modal = new frm_addRoom();
                modal.LoadProductData(image1, image2, image3, roomNumber, description, type, price);

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    myDatabase.DisplayRooms(dgv_rooms);
                }
            }
        }

        private void uc_roomManage_Load(object sender, EventArgs e)
        {
            myDatabase.DisplayRooms(dgv_rooms);
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            string filterText = tbx_search.Text.Trim().ToLower();

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgv_rooms.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dgv_rooms.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cell3 = row.Cells[3];
                    var cell4 = row.Cells[4];
                    var cell6 = row.Cells[6];

                    bool match3 = cell3.Value != null && cell3.Value.ToString().ToLower().Contains(filterText);
                    bool match4 = cell4.Value != null && cell4.Value.ToString().ToLower().Contains(filterText);
                    bool match6 = cell6.Value != null && cell6.Value.ToString().ToLower().Contains(filterText);

                    row.Visible = match3 || match4 || match6;
                }
            }

            currencyManager.ResumeBinding();
        }
    }
}
