namespace HotelBookingSystem.UserControls
{
    partial class uc_roomManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbx_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_addRoom = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_rooms = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).BeginInit();
            this.SuspendLayout();
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
            this.tbx_search.PlaceholderText = "Search room";
            this.tbx_search.SelectedText = "";
            this.tbx_search.Size = new System.Drawing.Size(220, 40);
            this.tbx_search.TabIndex = 10;
            this.tbx_search.TextChanged += new System.EventHandler(this.tbx_search_TextChanged);
            // 
            // btn_addRoom
            // 
            this.btn_addRoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_addRoom.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_addRoom.BorderRadius = 4;
            this.btn_addRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addRoom.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRoom.ForeColor = System.Drawing.Color.White;
            this.btn_addRoom.Location = new System.Drawing.Point(729, 20);
            this.btn_addRoom.Margin = new System.Windows.Forms.Padding(0);
            this.btn_addRoom.Name = "btn_addRoom";
            this.btn_addRoom.Size = new System.Drawing.Size(131, 40);
            this.btn_addRoom.TabIndex = 9;
            this.btn_addRoom.Text = "New Room";
            this.btn_addRoom.Click += new System.EventHandler(this.btn_addRoom_Click);
            // 
            // dgv_rooms
            // 
            this.dgv_rooms.AllowUserToAddRows = false;
            this.dgv_rooms.AllowUserToDeleteRows = false;
            this.dgv_rooms.AllowUserToResizeColumns = false;
            this.dgv_rooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rooms.ColumnHeadersHeight = 32;
            this.dgv_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_rooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.Location = new System.Drawing.Point(20, 80);
            this.dgv_rooms.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_rooms.Name = "dgv_rooms";
            this.dgv_rooms.ReadOnly = true;
            this.dgv_rooms.RowHeadersVisible = false;
            this.dgv_rooms.Size = new System.Drawing.Size(840, 600);
            this.dgv_rooms.TabIndex = 8;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_rooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_rooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_rooms.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_rooms.ThemeStyle.ReadOnly = true;
            this.dgv_rooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_rooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_rooms.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_rooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_rooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rooms_CellDoubleClick);
            // 
            // uc_roomManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.btn_addRoom);
            this.Controls.Add(this.dgv_rooms);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "uc_roomManage";
            this.Size = new System.Drawing.Size(880, 700);
            this.Load += new System.EventHandler(this.uc_roomManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbx_search;
        private Guna.UI2.WinForms.Guna2Button btn_addRoom;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_rooms;
    }
}
