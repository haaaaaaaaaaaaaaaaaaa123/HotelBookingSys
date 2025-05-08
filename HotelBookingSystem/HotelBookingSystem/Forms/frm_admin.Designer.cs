namespace HotelBookingSystem.Forms
{
    partial class frm_admin
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_bookManage = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_roomManage = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dashboad = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_container = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2Panel1.Controls.Add(this.btn_bookManage);
            this.guna2Panel1.Controls.Add(this.btn_logout);
            this.guna2Panel1.Controls.Add(this.btn_roomManage);
            this.guna2Panel1.Controls.Add(this.btn_dashboad);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(220, 700);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_bookManage
            // 
            this.btn_bookManage.BackColor = System.Drawing.Color.Transparent;
            this.btn_bookManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bookManage.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_bookManage.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_bookManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_bookManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_bookManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_bookManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_bookManage.FillColor = System.Drawing.Color.Transparent;
            this.btn_bookManage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bookManage.Location = new System.Drawing.Point(0, 209);
            this.btn_bookManage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bookManage.Name = "btn_bookManage";
            this.btn_bookManage.Size = new System.Drawing.Size(220, 52);
            this.btn_bookManage.TabIndex = 7;
            this.btn_bookManage.Text = "Booking Management";
            this.btn_bookManage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_bookManage.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_bookManage.Click += new System.EventHandler(this.btn_bookManage_Click);
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
            this.btn_logout.Size = new System.Drawing.Size(220, 52);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logout.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_roomManage
            // 
            this.btn_roomManage.BackColor = System.Drawing.Color.Transparent;
            this.btn_roomManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_roomManage.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_roomManage.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_roomManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_roomManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_roomManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_roomManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_roomManage.FillColor = System.Drawing.Color.Transparent;
            this.btn_roomManage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roomManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_roomManage.Location = new System.Drawing.Point(0, 153);
            this.btn_roomManage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_roomManage.Name = "btn_roomManage";
            this.btn_roomManage.Size = new System.Drawing.Size(220, 52);
            this.btn_roomManage.TabIndex = 5;
            this.btn_roomManage.Text = "Room Management";
            this.btn_roomManage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_roomManage.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_roomManage.Click += new System.EventHandler(this.btn_roomManage_Click);
            // 
            // btn_dashboad
            // 
            this.btn_dashboad.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboad.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.btn_dashboad.CustomBorderThickness = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_dashboad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dashboad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dashboad.FillColor = System.Drawing.Color.MistyRose;
            this.btn_dashboad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboad.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_dashboad.Location = new System.Drawing.Point(0, 97);
            this.btn_dashboad.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboad.Name = "btn_dashboad";
            this.btn_dashboad.Size = new System.Drawing.Size(220, 52);
            this.btn_dashboad.TabIndex = 4;
            this.btn_dashboad.Text = "Dashboard";
            this.btn_dashboad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dashboad.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_dashboad.Click += new System.EventHandler(this.btn_dashboad_Click);
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
            // pnl_container
            // 
            this.pnl_container.AutoScroll = true;
            this.pnl_container.Location = new System.Drawing.Point(220, 0);
            this.pnl_container.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(880, 700);
            this.pnl_container.TabIndex = 10;
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_admin";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_roomManage;
        private Guna.UI2.WinForms.Guna2Button btn_dashboad;
        private Guna.UI2.WinForms.Guna2Button btn_bookManage;
        private Guna.UI2.WinForms.Guna2Panel pnl_container;
    }
}