using Guna.UI2.WinForms;
using HotelBookingSystem.Properties;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem.Modals
{
    public partial class frm_addRoom : Form
    {
        public bool isUpdateMode = false;
        int oldNumber = 0;
        public Image image1, image2, image3;
        public byte[] roomImage1, roomImage2, roomImage3;

        public frm_addRoom()
        {
            InitializeComponent();
        }

        public void RemoveImage(Guna2PictureBox pbx)
        {
            if (pbx == pbx_image1)
            {
                roomImage1 = null;
                image1 = null;
                pbx.Image = null;
                btn_upload1.Visible = true;
            }
            else if (pbx == pbx_image2)
            {
                roomImage2 = null;
                image2 = null;
                pbx.Image = null;
                btn_upload2.Visible = true;
            }
            else if (pbx == pbx_image3)
            {
                roomImage3 = null;
                image3 = null;
                pbx.Image = null;
                btn_upload3.Visible = true;
            }
        }

        private void UploadImage(ref byte[] imageBytes, ref Image image, Guna2PictureBox pictureBox, Guna2Button uploadButton)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg;*.gif)|*.png;*.jpeg;*.jpg;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        imageBytes = new byte[fs.Length];
                        fs.Read(imageBytes, 0, (int)fs.Length);
                    }

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                        pictureBox.Image = image;
                        uploadButton.Visible = false;

                        Guna2Button btn_del = new Guna2Button()
                        {
                            Size = new Size(20, 20),
                            BackColor = Color.Transparent,
                            FillColor = Color.White,
                            BorderRadius = 2,
                            Location = new Point(173, 5),
                            Image = Resources.delete,
                        };

                        btn_del.Click += (s, e) =>
                        {
                            RemoveImage(pictureBox);
                            btn_del.Visible = false;
                        };

                        pictureBox.Controls.Add(btn_del);
                    }
                }
            }
        }

        public void LoadProductData(byte[] imageB1, byte[] imageB2, byte[] imageB3, int roomNo, string description, string type, int price)
        {
            isUpdateMode = true;

            oldNumber = roomNo;
            spn_roomNumber.Value = roomNo;
            tbx_description.Text = description;
            cbx_type.SelectedItem = type;
            spn_price.Value = price;

            image1?.Dispose();
            image2?.Dispose();
            image3?.Dispose();

            if (imageB1 != null)
            {
                using (MemoryStream ms1 = new MemoryStream(imageB1))
                {
                    image1 = Image.FromStream(ms1);
                    pbx_image1.Image = image1;
                    roomImage1 = imageB1;

                    Guna2Button btn_del = new Guna2Button()
                    {
                        Size = new Size(20, 20),
                        BackColor = Color.Transparent,
                        FillColor = Color.White,
                        BorderRadius = 2,
                        Location = new Point(173, 5),
                        Image = Resources.delete,
                    };

                    btn_del.Click += (s, e) =>
                    {
                        RemoveImage(pbx_image1);
                        btn_del.Visible = false;
                    };

                    pbx_image1.Controls.Add(btn_del);
                }
            }

            if (imageB2 != null)
            {
                using (MemoryStream ms2 = new MemoryStream(imageB2))
                {
                    image2 = Image.FromStream(ms2);
                    pbx_image2.Image = image2;
                    roomImage2 = imageB2;

                    Guna2Button btn_del = new Guna2Button()
                    {
                        Size = new Size(20, 20),
                        BackColor = Color.Transparent,
                        FillColor = Color.White,
                        BorderRadius = 2,
                        Location = new Point(173, 5),
                        Image = Resources.delete,
                    };

                    btn_del.Click += (s, e) =>
                    {
                        RemoveImage(pbx_image2);
                        btn_del.Visible = false;
                    };

                    pbx_image2.Controls.Add(btn_del);
                }
            }

            if (imageB3 != null)
            {
                using (MemoryStream ms3 = new MemoryStream(imageB3))
                {
                    image3 = Image.FromStream(ms3);
                    pbx_image3.Image = image3;
                    roomImage3 = imageB3;

                    Guna2Button btn_del = new Guna2Button()
                    {
                        Size = new Size(20, 20),
                        BackColor = Color.Transparent,
                        FillColor = Color.White,
                        BorderRadius = 2,
                        Location = new Point(173, 5),
                        Image = Resources.delete,
                    };

                    btn_del.Click += (s, e) =>
                    {
                        RemoveImage(pbx_image3);
                        btn_del.Visible = false;
                    };

                    pbx_image3.Controls.Add(btn_del);
                }
            }

            btn_upload1.Visible = false;
            btn_upload2.Visible = false;
            btn_upload3.Visible = false;

            pnl_update.BringToFront();
            pnl_add.SendToBack();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(spn_roomNumber.Value < 0 || spn_price.Value < 0 || cbx_type.SelectedIndex == -1 || string.IsNullOrEmpty(tbx_description.Text))
            {
                MessageBox.Show("Some field are either missing or invalid");
            }
            else
            {
                var result = MessageBox.Show("Are you sure to update this room?", "Confirmation", MessageBoxButtons.YesNo);

                int room, price;
                if (!int.TryParse(spn_roomNumber.Text.Trim(), out room) || !int.TryParse(spn_price.Text.Trim(), out price))
                {
                    MessageBox.Show("Please enter a valid value", "Warning");
                    return;
                }

                if (result == DialogResult.Yes)
                {
                    myDatabase.UpdateRoom(oldNumber, roomImage1, roomImage2, roomImage3, room, tbx_description.Text.Trim(), price, cbx_type.SelectedItem.ToString());
                    spn_roomNumber.Value = 1;
                    tbx_description.Text = "";
                    spn_price.Value = 1;
                    cbx_type.SelectedIndex = -1;
                    RemoveImage(pbx_image1);
                    RemoveImage(pbx_image2);
                    RemoveImage(pbx_image3);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this room?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                myDatabase.DeleteRoom((int)spn_roomNumber.Value);
                spn_roomNumber.Value = 1;
                spn_price.Value = 1;
                cbx_type.SelectedIndex = -1;
                RemoveImage(pbx_image1);
                RemoveImage(pbx_image2);
                RemoveImage(pbx_image3);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            if (image1 == null || image2 == null || image3 == null)
            {
                MessageBox.Show("Please upload all image", "Warning");
                return;
            }

            if (cbx_type.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all fields", "Warning");
                return;
            }

            int roomNo, price;
            if (!int.TryParse(spn_price.Text.Trim(), out price) || !int.TryParse(spn_roomNumber.Text.Trim(), out roomNo))
            {
                MessageBox.Show("Please enter a valid value", "Warning");
                return;
            }

            bool result = myDatabase.AddRoom(roomImage1, roomImage2, roomImage3, roomNo, tbx_description.Text.Trim(), price, cbx_type.SelectedItem.ToString());

            if (result)
            {
                spn_roomNumber.Value = 1;
                tbx_description.Text = "";
                spn_price.Value = 1;
                cbx_type.SelectedIndex = -1;
                RemoveImage(pbx_image1);
                RemoveImage(pbx_image2);
                RemoveImage(pbx_image3);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_upload1_Click(object sender, EventArgs e)
        {
            UploadImage(ref roomImage1, ref image1, pbx_image1, btn_upload1);
        }

        private void btn_upload2_Click(object sender, EventArgs e)
        {
            UploadImage(ref roomImage2, ref image2, pbx_image2, btn_upload2);
        }

        private void btn_upload3_Click(object sender, EventArgs e)
        {
            UploadImage(ref roomImage3, ref image3, pbx_image3, btn_upload3);
        }
    }
}
