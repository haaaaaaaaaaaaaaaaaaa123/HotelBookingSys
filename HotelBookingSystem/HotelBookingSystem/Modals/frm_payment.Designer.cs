namespace HotelBookingSystem.Modals
{
    partial class frm_payment
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
            this.pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_confirm = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_totalFee = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.spn_payment = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spn_payment)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ROOM PAYMENT";
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
            this.btn_close.Location = new System.Drawing.Point(260, 10);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(28, 28);
            this.btn_close.TabIndex = 16;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.SystemColors.Control;
            this.pnl.Controls.Add(this.btn_confirm);
            this.pnl.Controls.Add(this.lbl_totalFee);
            this.pnl.Controls.Add(this.lbl);
            this.pnl.Controls.Add(this.spn_payment);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Location = new System.Drawing.Point(0, 50);
            this.pnl.Margin = new System.Windows.Forms.Padding(0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(300, 200);
            this.pnl.TabIndex = 18;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.BorderColor = System.Drawing.Color.Green;
            this.btn_confirm.BorderRadius = 4;
            this.btn_confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirm.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(20, 144);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(260, 40);
            this.btn_confirm.TabIndex = 24;
            this.btn_confirm.Text = "CONFIRM";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // lbl_totalFee
            // 
            this.lbl_totalFee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_totalFee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_totalFee.Location = new System.Drawing.Point(192, 20);
            this.lbl_totalFee.Name = "lbl_totalFee";
            this.lbl_totalFee.Size = new System.Drawing.Size(88, 24);
            this.lbl_totalFee.TabIndex = 23;
            this.lbl_totalFee.Text = "₱100.00";
            this.lbl_totalFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl.ForeColor = System.Drawing.Color.Gray;
            this.lbl.Location = new System.Drawing.Point(20, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(83, 21);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "To be paid:";
            // 
            // spn_payment
            // 
            this.spn_payment.BackColor = System.Drawing.Color.Transparent;
            this.spn_payment.BorderRadius = 4;
            this.spn_payment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.spn_payment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spn_payment.Location = new System.Drawing.Point(20, 70);
            this.spn_payment.Margin = new System.Windows.Forms.Padding(0);
            this.spn_payment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spn_payment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spn_payment.Name = "spn_payment";
            this.spn_payment.Size = new System.Drawing.Size(260, 44);
            this.spn_payment.TabIndex = 21;
            this.spn_payment.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Amount";
            // 
            // frm_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_payment";
            this.Load += new System.EventHandler(this.frm_payment_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spn_payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2Panel pnl;
        private Guna.UI2.WinForms.Guna2NumericUpDown spn_payment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_totalFee;
        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2Button btn_confirm;
    }
}