namespace HotelBookingSystem.UserControls
{
    partial class uc_bookRoom
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_roomContain = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_bookRoom = new Guna.UI2.WinForms.Guna2Button();
            this.flp_images = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.flp_container = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_bookForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_COdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewInfo = new Guna.UI2.WinForms.Guna2Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tbx_lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_CIdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.tbx_contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_bookRoomNo = new System.Windows.Forms.Label();
            this.btn_confirmBook = new Guna.UI2.WinForms.Guna2Button();
            this.tbx_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbx_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnl_roomContain.SuspendLayout();
            this.pnl_bookForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_roomContain
            // 
            this.pnl_roomContain.BackColor = System.Drawing.Color.White;
            this.pnl_roomContain.Controls.Add(this.lbl_description);
            this.pnl_roomContain.Controls.Add(this.label9);
            this.pnl_roomContain.Controls.Add(this.lbl_number);
            this.pnl_roomContain.Controls.Add(this.lbl_price);
            this.pnl_roomContain.Controls.Add(this.btn_bookRoom);
            this.pnl_roomContain.Controls.Add(this.flp_images);
            this.pnl_roomContain.Controls.Add(this.label8);
            this.pnl_roomContain.Location = new System.Drawing.Point(600, 0);
            this.pnl_roomContain.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_roomContain.Name = "pnl_roomContain";
            this.pnl_roomContain.Size = new System.Drawing.Size(300, 700);
            this.pnl_roomContain.TabIndex = 0;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_description.Location = new System.Drawing.Point(20, 290);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(260, 220);
            this.lbl_description.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(20, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Description";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_number.Location = new System.Drawing.Point(20, 200);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(0, 25);
            this.lbl_number.TabIndex = 4;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_price.Location = new System.Drawing.Point(20, 230);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(0, 25);
            this.lbl_price.TabIndex = 10;
            // 
            // btn_bookRoom
            // 
            this.btn_bookRoom.BorderRadius = 4;
            this.btn_bookRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_bookRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_bookRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_bookRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_bookRoom.Enabled = false;
            this.btn_bookRoom.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_bookRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookRoom.ForeColor = System.Drawing.Color.White;
            this.btn_bookRoom.Location = new System.Drawing.Point(20, 636);
            this.btn_bookRoom.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bookRoom.Name = "btn_bookRoom";
            this.btn_bookRoom.Size = new System.Drawing.Size(260, 44);
            this.btn_bookRoom.TabIndex = 5;
            this.btn_bookRoom.Text = "Book this Room";
            this.btn_bookRoom.Click += new System.EventHandler(this.btn_bookRoom_Click);
            // 
            // flp_images
            // 
            this.flp_images.AutoScroll = true;
            this.flp_images.BackColor = System.Drawing.Color.Transparent;
            this.flp_images.Location = new System.Drawing.Point(20, 50);
            this.flp_images.Name = "flp_images";
            this.flp_images.Size = new System.Drawing.Size(280, 140);
            this.flp_images.TabIndex = 4;
            this.flp_images.WrapContents = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Images";
            // 
            // flp_container
            // 
            this.flp_container.AutoScroll = true;
            this.flp_container.BackColor = System.Drawing.Color.Transparent;
            this.flp_container.Location = new System.Drawing.Point(20, 84);
            this.flp_container.Margin = new System.Windows.Forms.Padding(0);
            this.flp_container.Name = "flp_container";
            this.flp_container.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.flp_container.Size = new System.Drawing.Size(580, 600);
            this.flp_container.TabIndex = 12;
            // 
            // pnl_bookForm
            // 
            this.pnl_bookForm.BackColor = System.Drawing.Color.White;
            this.pnl_bookForm.Controls.Add(this.lbl_total);
            this.pnl_bookForm.Controls.Add(this.label3);
            this.pnl_bookForm.Controls.Add(this.label2);
            this.pnl_bookForm.Controls.Add(this.dtp_COdate);
            this.pnl_bookForm.Controls.Add(this.label1);
            this.pnl_bookForm.Controls.Add(this.btn_viewInfo);
            this.pnl_bookForm.Controls.Add(this.label17);
            this.pnl_bookForm.Controls.Add(this.tbx_lname);
            this.pnl_bookForm.Controls.Add(this.label14);
            this.pnl_bookForm.Controls.Add(this.dtp_CIdate);
            this.pnl_bookForm.Controls.Add(this.label15);
            this.pnl_bookForm.Controls.Add(this.tbx_contact);
            this.pnl_bookForm.Controls.Add(this.label16);
            this.pnl_bookForm.Controls.Add(this.tbx_fname);
            this.pnl_bookForm.Controls.Add(this.lbl_bookRoomNo);
            this.pnl_bookForm.Controls.Add(this.btn_confirmBook);
            this.pnl_bookForm.Location = new System.Drawing.Point(600, 0);
            this.pnl_bookForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_bookForm.Name = "pnl_bookForm";
            this.pnl_bookForm.Size = new System.Drawing.Size(300, 700);
            this.pnl_bookForm.TabIndex = 13;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(20, 543);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(42, 20);
            this.lbl_total.TabIndex = 34;
            this.lbl_total.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Check-Out Date";
            // 
            // dtp_COdate
            // 
            this.dtp_COdate.BorderRadius = 4;
            this.dtp_COdate.Checked = true;
            this.dtp_COdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_COdate.FillColor = System.Drawing.Color.White;
            this.dtp_COdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_COdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_COdate.Location = new System.Drawing.Point(20, 453);
            this.dtp_COdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_COdate.MinDate = new System.DateTime(2025, 4, 26, 0, 0, 0, 0);
            this.dtp_COdate.Name = "dtp_COdate";
            this.dtp_COdate.Size = new System.Drawing.Size(260, 48);
            this.dtp_COdate.TabIndex = 31;
            this.dtp_COdate.Value = new System.DateTime(2025, 4, 26, 19, 18, 42, 579);
            this.dtp_COdate.ValueChanged += new System.EventHandler(this.dtp_COdate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "View Information";
            // 
            // btn_viewInfo
            // 
            this.btn_viewInfo.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_viewInfo.BorderColor = System.Drawing.Color.Silver;
            this.btn_viewInfo.BorderRadius = 4;
            this.btn_viewInfo.BorderThickness = 1;
            this.btn_viewInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewInfo.FillColor = System.Drawing.Color.Transparent;
            this.btn_viewInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_viewInfo.ForeColor = System.Drawing.Color.White;
            this.btn_viewInfo.Location = new System.Drawing.Point(20, 20);
            this.btn_viewInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_viewInfo.Name = "btn_viewInfo";
            this.btn_viewInfo.Size = new System.Drawing.Size(32, 32);
            this.btn_viewInfo.TabIndex = 29;
            this.btn_viewInfo.Click += new System.EventHandler(this.btn_viewInfo_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "Last Name";
            // 
            // tbx_lname
            // 
            this.tbx_lname.BorderRadius = 4;
            this.tbx_lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_lname.DefaultText = "";
            this.tbx_lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbx_lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbx_lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_lname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_lname.Location = new System.Drawing.Point(20, 211);
            this.tbx_lname.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_lname.Name = "tbx_lname";
            this.tbx_lname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbx_lname.PlaceholderText = "Enter your last";
            this.tbx_lname.SelectedText = "";
            this.tbx_lname.Size = new System.Drawing.Size(260, 48);
            this.tbx_lname.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Check-In Date";
            // 
            // dtp_CIdate
            // 
            this.dtp_CIdate.BorderRadius = 4;
            this.dtp_CIdate.Checked = true;
            this.dtp_CIdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_CIdate.FillColor = System.Drawing.Color.White;
            this.dtp_CIdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_CIdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_CIdate.Location = new System.Drawing.Point(20, 371);
            this.dtp_CIdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_CIdate.MinDate = new System.DateTime(2025, 4, 26, 0, 0, 0, 0);
            this.dtp_CIdate.Name = "dtp_CIdate";
            this.dtp_CIdate.Size = new System.Drawing.Size(260, 48);
            this.dtp_CIdate.TabIndex = 23;
            this.dtp_CIdate.Value = new System.DateTime(2025, 4, 26, 19, 18, 42, 579);
            this.dtp_CIdate.ValueChanged += new System.EventHandler(this.dtp_CIdate_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "Contact Number";
            // 
            // tbx_contact
            // 
            this.tbx_contact.BorderRadius = 4;
            this.tbx_contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_contact.DefaultText = "";
            this.tbx_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbx_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbx_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_contact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_contact.Location = new System.Drawing.Point(20, 291);
            this.tbx_contact.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_contact.Name = "tbx_contact";
            this.tbx_contact.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbx_contact.PlaceholderText = "09XXXXXXXXX";
            this.tbx_contact.SelectedText = "";
            this.tbx_contact.Size = new System.Drawing.Size(260, 48);
            this.tbx_contact.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 15);
            this.label16.TabIndex = 20;
            this.label16.Text = "First Name";
            // 
            // tbx_fname
            // 
            this.tbx_fname.BorderRadius = 4;
            this.tbx_fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_fname.DefaultText = "";
            this.tbx_fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbx_fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbx_fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_fname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_fname.Location = new System.Drawing.Point(20, 134);
            this.tbx_fname.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_fname.Name = "tbx_fname";
            this.tbx_fname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbx_fname.PlaceholderText = "Enter your first";
            this.tbx_fname.SelectedText = "";
            this.tbx_fname.Size = new System.Drawing.Size(260, 48);
            this.tbx_fname.TabIndex = 19;
            // 
            // lbl_bookRoomNo
            // 
            this.lbl_bookRoomNo.AutoSize = true;
            this.lbl_bookRoomNo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_bookRoomNo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_bookRoomNo.Location = new System.Drawing.Point(20, 66);
            this.lbl_bookRoomNo.Name = "lbl_bookRoomNo";
            this.lbl_bookRoomNo.Size = new System.Drawing.Size(147, 25);
            this.lbl_bookRoomNo.TabIndex = 7;
            this.lbl_bookRoomNo.Text = "Book Form (R.)";
            // 
            // btn_confirmBook
            // 
            this.btn_confirmBook.BorderRadius = 4;
            this.btn_confirmBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirmBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirmBook.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_confirmBook.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmBook.ForeColor = System.Drawing.Color.White;
            this.btn_confirmBook.Location = new System.Drawing.Point(20, 636);
            this.btn_confirmBook.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirmBook.Name = "btn_confirmBook";
            this.btn_confirmBook.Size = new System.Drawing.Size(260, 44);
            this.btn_confirmBook.TabIndex = 6;
            this.btn_confirmBook.Text = "Confirm Book";
            this.btn_confirmBook.Click += new System.EventHandler(this.btn_confirmBook_Click);
            // 
            // tbx_search
            // 
            this.tbx_search.BorderRadius = 4;
            this.tbx_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_search.DefaultText = "";
            this.tbx_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbx_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbx_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbx_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_search.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbx_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbx_search.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.tbx_search.Location = new System.Drawing.Point(20, 20);
            this.tbx_search.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.PlaceholderText = "Search available room";
            this.tbx_search.SelectedText = "";
            this.tbx_search.Size = new System.Drawing.Size(260, 44);
            this.tbx_search.TabIndex = 14;
            this.tbx_search.TextChanged += new System.EventHandler(this.tbx_search_TextChanged);
            // 
            // cbx_category
            // 
            this.cbx_category.BackColor = System.Drawing.Color.Transparent;
            this.cbx_category.BorderRadius = 4;
            this.cbx_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_category.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbx_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbx_category.ItemHeight = 38;
            this.cbx_category.Items.AddRange(new object[] {
            "All",
            "Single Room",
            "Double Room",
            "Family Room",
            "Suite Room"});
            this.cbx_category.Location = new System.Drawing.Point(300, 20);
            this.cbx_category.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(140, 44);
            this.cbx_category.StartIndex = 0;
            this.cbx_category.TabIndex = 15;
            this.cbx_category.SelectedIndexChanged += new System.EventHandler(this.cbx_category_SelectedIndexChanged);
            // 
            // uc_bookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.flp_container);
            this.Controls.Add(this.pnl_bookForm);
            this.Controls.Add(this.pnl_roomContain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_bookRoom";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Size = new System.Drawing.Size(900, 700);
            this.Load += new System.EventHandler(this.uc_bookRoom_Load);
            this.pnl_roomContain.ResumeLayout(false);
            this.pnl_roomContain.PerformLayout();
            this.pnl_bookForm.ResumeLayout(false);
            this.pnl_bookForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_roomContain;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.FlowLayoutPanel flp_container;
        private System.Windows.Forms.FlowLayoutPanel flp_images;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_bookRoom;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_price;
        private Guna.UI2.WinForms.Guna2Panel pnl_bookForm;
        private Guna.UI2.WinForms.Guna2Button btn_confirmBook;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox tbx_lname;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_CIdate;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox tbx_contact;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox tbx_fname;
        private System.Windows.Forms.Label lbl_bookRoomNo;
        private Guna.UI2.WinForms.Guna2TextBox tbx_search;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_category;
        private Guna.UI2.WinForms.Guna2Button btn_viewInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_COdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_total;
    }
}
