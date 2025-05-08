namespace HotelBookingSystem.Modals
{
    partial class frm_viewReservation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_COdate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_fee = new System.Windows.Forms.Label();
            this.lbl_totalFee = new System.Windows.Forms.Label();
            this.lbl_oTotal = new System.Windows.Forms.Label();
            this.lbl_nights = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_CIdate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelReservation = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_btns = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_approved = new Guna.UI2.WinForms.Guna2Button();
            this.btn_2cancel = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnl_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.BorderRadius = 12;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ROOM RESERVATION";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_close.Image = global::HotelBookingSystem.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(288, 12);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 16;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbl_roomNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_COdate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.lbl_CIdate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl_contact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cancelReservation);
            this.panel1.Controls.Add(this.pnl_btns);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 400);
            this.panel1.TabIndex = 18;
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNo.Location = new System.Drawing.Point(228, 36);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(86, 24);
            this.lbl_roomNo.TabIndex = 30;
            this.lbl_roomNo.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(229, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Room Number";
            // 
            // lbl_COdate
            // 
            this.lbl_COdate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_COdate.Location = new System.Drawing.Point(19, 203);
            this.lbl_COdate.Name = "lbl_COdate";
            this.lbl_COdate.Size = new System.Drawing.Size(180, 24);
            this.lbl_COdate.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(20, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Check-Out Date";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 4;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lbl_fee);
            this.guna2Panel1.Controls.Add(this.lbl_totalFee);
            this.guna2Panel1.Controls.Add(this.lbl_oTotal);
            this.guna2Panel1.Controls.Add(this.lbl_nights);
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 256);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(290, 72);
            this.guna2Panel1.TabIndex = 22;
            // 
            // lbl_fee
            // 
            this.lbl_fee.AutoSize = true;
            this.lbl_fee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fee.ForeColor = System.Drawing.Color.Gray;
            this.lbl_fee.Location = new System.Drawing.Point(220, 7);
            this.lbl_fee.Name = "lbl_fee";
            this.lbl_fee.Size = new System.Drawing.Size(60, 15);
            this.lbl_fee.TabIndex = 17;
            this.lbl_fee.Text = "Room Fee";
            this.lbl_fee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_totalFee
            // 
            this.lbl_totalFee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_totalFee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_totalFee.Location = new System.Drawing.Point(192, 38);
            this.lbl_totalFee.Name = "lbl_totalFee";
            this.lbl_totalFee.Size = new System.Drawing.Size(88, 24);
            this.lbl_totalFee.TabIndex = 16;
            this.lbl_totalFee.Text = "₱100.00";
            this.lbl_totalFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_oTotal
            // 
            this.lbl_oTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_oTotal.Location = new System.Drawing.Point(215, 7);
            this.lbl_oTotal.Name = "lbl_oTotal";
            this.lbl_oTotal.Size = new System.Drawing.Size(65, 15);
            this.lbl_oTotal.TabIndex = 15;
            this.lbl_oTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_nights
            // 
            this.lbl_nights.AutoSize = true;
            this.lbl_nights.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_nights.ForeColor = System.Drawing.Color.Gray;
            this.lbl_nights.Location = new System.Drawing.Point(8, 42);
            this.lbl_nights.Name = "lbl_nights";
            this.lbl_nights.Size = new System.Drawing.Size(69, 21);
            this.lbl_nights.TabIndex = 14;
            this.lbl_nights.Text = "3 Nights";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(8, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Room Fee";
            // 
            // lbl_CIdate
            // 
            this.lbl_CIdate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CIdate.Location = new System.Drawing.Point(18, 148);
            this.lbl_CIdate.Name = "lbl_CIdate";
            this.lbl_CIdate.Size = new System.Drawing.Size(180, 24);
            this.lbl_CIdate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(18, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Check-In Date";
            // 
            // lbl_contact
            // 
            this.lbl_contact.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(20, 92);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(180, 24);
            this.lbl_contact.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(20, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contact No";
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(20, 36);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(180, 24);
            this.lbl_name.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer Name";
            // 
            // btn_cancelReservation
            // 
            this.btn_cancelReservation.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelReservation.BorderRadius = 4;
            this.btn_cancelReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelReservation.FillColor = System.Drawing.Color.IndianRed;
            this.btn_cancelReservation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelReservation.ForeColor = System.Drawing.Color.White;
            this.btn_cancelReservation.Location = new System.Drawing.Point(20, 340);
            this.btn_cancelReservation.Name = "btn_cancelReservation";
            this.btn_cancelReservation.Size = new System.Drawing.Size(290, 36);
            this.btn_cancelReservation.TabIndex = 21;
            this.btn_cancelReservation.Text = "Cancel Reservation";
            this.btn_cancelReservation.Click += new System.EventHandler(this.btn_cancelReservation_Click);
            // 
            // pnl_btns
            // 
            this.pnl_btns.Controls.Add(this.btn_approved);
            this.pnl_btns.Controls.Add(this.btn_2cancel);
            this.pnl_btns.Location = new System.Drawing.Point(20, 340);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Size = new System.Drawing.Size(290, 36);
            this.pnl_btns.TabIndex = 28;
            // 
            // btn_approved
            // 
            this.btn_approved.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_approved.BorderRadius = 4;
            this.btn_approved.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_approved.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_approved.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_approved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_approved.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_approved.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_approved.ForeColor = System.Drawing.Color.White;
            this.btn_approved.Location = new System.Drawing.Point(145, 0);
            this.btn_approved.Name = "btn_approved";
            this.btn_approved.Size = new System.Drawing.Size(145, 36);
            this.btn_approved.TabIndex = 28;
            this.btn_approved.Text = "Approve Reservation";
            this.btn_approved.Click += new System.EventHandler(this.btn_approved_Click);
            // 
            // btn_2cancel
            // 
            this.btn_2cancel.BorderColor = System.Drawing.Color.Red;
            this.btn_2cancel.BorderRadius = 4;
            this.btn_2cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_2cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_2cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_2cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_2cancel.FillColor = System.Drawing.Color.IndianRed;
            this.btn_2cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2cancel.ForeColor = System.Drawing.Color.White;
            this.btn_2cancel.Location = new System.Drawing.Point(0, 0);
            this.btn_2cancel.Name = "btn_2cancel";
            this.btn_2cancel.Size = new System.Drawing.Size(135, 36);
            this.btn_2cancel.TabIndex = 27;
            this.btn_2cancel.Text = "Reject Reservation";
            this.btn_2cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_viewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_viewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_viewReservation";
            this.Load += new System.EventHandler(this.frm_viewReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnl_btns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_COdate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbl_totalFee;
        private System.Windows.Forms.Label lbl_oTotal;
        private System.Windows.Forms.Label lbl_nights;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_CIdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_cancelReservation;
        private Guna.UI2.WinForms.Guna2Panel pnl_btns;
        private Guna.UI2.WinForms.Guna2Button btn_approved;
        private Guna.UI2.WinForms.Guna2Button btn_2cancel;
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_fee;
    }
}