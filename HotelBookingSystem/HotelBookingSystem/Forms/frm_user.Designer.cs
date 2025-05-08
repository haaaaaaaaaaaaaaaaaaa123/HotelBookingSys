namespace HotelBookingSystem.Forms
{
    partial class frm_user
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
            this.pnl_container = new Guna.UI2.WinForms.Guna2Panel();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_book = new Guna.UI2.WinForms.Guna2Button();
            this.btn_room = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.AutoScroll = true;
            this.pnl_container.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_container.Location = new System.Drawing.Point(200, 0);
            this.pnl_container.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(900, 700);
            this.pnl_container.TabIndex = 9;
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.BorderRadius = 12;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Controls.Add(this.btn_logout);
            this.guna2Panel1.Controls.Add(this.btn_book);
            this.guna2Panel1.Controls.Add(this.btn_room);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 700);
            this.guna2Panel1.TabIndex = 7;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_logout.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.Transparent;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logout.Location = new System.Drawing.Point(0, 628);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(199, 52);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logout.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.Transparent;
            this.btn_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_book.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_book.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_book.FillColor = System.Drawing.Color.Transparent;
            this.btn_book.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_book.Location = new System.Drawing.Point(0, 166);
            this.btn_book.Margin = new System.Windows.Forms.Padding(0);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(199, 52);
            this.btn_book.TabIndex = 2;
            this.btn_book.Text = "Book a Room";
            this.btn_book.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_book.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.Color.Transparent;
            this.btn_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_room.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_room.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_room.FillColor = System.Drawing.Color.AliceBlue;
            this.btn_room.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_room.Location = new System.Drawing.Point(0, 112);
            this.btn_room.Margin = new System.Windows.Forms.Padding(0);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(200, 52);
            this.btn_room.TabIndex = 1;
            this.btn_room.Text = "Rooms";
            this.btn_room.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_room.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 15F);
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Booking";
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_user";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_container;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_room;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_book;
    }
}