using Guna.UI2.WinForms;
using Org.BouncyCastle.Utilities;
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
using System.Xml.Linq;

namespace HotelBookingSystem.UserControls
{
    public partial class uc_bookRoom : UserControl
    {
        public static uc_bookRoom _instance;
        public static uc_bookRoom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_bookRoom();
                return _instance;
            }
        }

        private string _userEmail;
        public void SetEmail(string email)
        {
            _userEmail = email;
        }

        private decimal _roomPricePerNight;
        private decimal totalPrice;
        private void UpdateTotalPrice()
        {
            if (dtp_CIdate.Value < dtp_COdate.Value)
            {
                int totalNights = (dtp_COdate.Value - dtp_CIdate.Value).Days;
                totalPrice = totalNights * _roomPricePerNight;

                lbl_total.Text = $"Total: ₱{totalPrice:0.00} for {totalNights} night(s)";
            }
            else
            {
                lbl_total.Text = "Please select valid dates";
            }
        }

        public void reload()
        {
            myDatabase.DisplayRoomsOnUser(flp_container);
        }

        public uc_bookRoom()
        {
            InitializeComponent();
            dtp_CIdate.MinDate = DateTime.Now.AddDays(1);
        }

        void createImgPlaceHolder(Image img)
        {
            Guna2PictureBox pbx = new Guna2PictureBox() {
                Margin = new Padding(0, 0, 20, 0),
                Size = new Size(200, 120),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = img,
            };

            flp_images.Controls.Add(pbx);
        }

        public void roomDetails(Image img1, Image img2, Image img3, string number, string price, string description)
        {
            flp_images.Controls.Clear();

            createImgPlaceHolder(img1);
            createImgPlaceHolder(img2); 
            createImgPlaceHolder(img3);

            lbl_number.Text = "Room " + number;
            lbl_price.Text = price;
            lbl_description.Text = description;

            lbl_bookRoomNo.Text = "Book Form (R."+number+")";
            btn_bookRoom.Enabled = true;


            // Extract numeric value from ₱price string
            if (decimal.TryParse(Regex.Match(price, @"\d+(\.\d+)?").Value, out decimal parsedPrice))
            {
                _roomPricePerNight = parsedPrice;
            }

            // Update total price display
            UpdateTotalPrice();
        }

        private void btn_bookRoom_Click(object sender, EventArgs e)
        {
                pnl_roomContain.SendToBack();
                pnl_bookForm.BringToFront();
        }

        private void btn_viewInfo_Click(object sender, EventArgs e)
        {
                pnl_roomContain.BringToFront();
                pnl_bookForm.SendToBack();
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            string searchProd = tbx_search.Text.Trim();

            foreach (Control control in flp_container.Controls)
            {
                if (control is Panel panel)
                {
                    bool isMatchFound = panel.Controls
                        .OfType<Label>()
                        .Any(label => label.Text.IndexOf(searchProd, StringComparison.OrdinalIgnoreCase) >= 0);

                    panel.Visible = isMatchFound;
                }
            }
        }

        private void cbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cbx_category.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(filter) || filter.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                foreach (Control control in flp_container.Controls)
                {
                    Panel panel = control as Panel;
                    if (panel != null)
                    {
                        panel.Visible = true;
                    }
                }
                return;
            }

            foreach (Control control in flp_container.Controls)
            {
                Panel panel = control as Panel;
                if (panel != null)
                {
                    bool isMatchFound = false;
                    foreach (Control innerControl in panel.Controls)
                    {
                        Label label = innerControl as Label;
                        if (label != null && label.Text.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            isMatchFound = true;
                            break;
                        }
                    }
                    panel.Visible = isMatchFound;
                }
            }
        }

        private void uc_bookRoom_Load(object sender, EventArgs e)
        {
            myDatabase.DisplayRoomsOnUser(flp_container);
        }

        private void dtp_CIdate_ValueChanged(object sender, EventArgs e)
        {
            dtp_COdate.MinDate = dtp_CIdate.Value;
            UpdateTotalPrice();
        }

        private void dtp_COdate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(tbx_fname.Text) ||
                string.IsNullOrWhiteSpace(tbx_lname.Text) ||
                string.IsNullOrWhiteSpace(tbx_contact.Text) ||
                lbl_bookRoomNo.Text == "Book Form (R.)")
            {
                MessageBox.Show("Please complete all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string contactPattern = @"^09\d{9}$";
            if (!Regex.IsMatch(tbx_contact.Text, contactPattern))
            {
                MessageBox.Show("Please enter a valid 11-digit contact number starting with 09.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_confirmBook_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var confirmation = MessageBox.Show("Are you sure to book this room?", "Book Confirmation", MessageBoxButtons.OKCancel);

                if(confirmation == DialogResult.OK)
                {
                    string fname = tbx_fname.Text.Trim();
                    string lname = tbx_lname.Text.Trim();
                    string contact = tbx_contact.Text.Trim();
                    DateTime dateI = dtp_CIdate.Value.Date;
                    DateTime dateO = dtp_COdate.Value.Date;
                    string roomNumber = lbl_number.Text.Replace("Room ", "").Trim();

                    myDatabase.bookRoom(roomNumber, fname, lname, contact, _userEmail, dateI, dateO, _roomPricePerNight, totalPrice);

                    MessageBox.Show("Booked saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbx_fname.Text = "";
                    tbx_lname.Text = "";
                    tbx_contact.Text = "";
                    dtp_CIdate.Value = dtp_CIdate.MinDate;

                    lbl_bookRoomNo.Text = "Book Form (R.)";
                    lbl_total.Text = "Total";
                }
            }
        }
    }
}
