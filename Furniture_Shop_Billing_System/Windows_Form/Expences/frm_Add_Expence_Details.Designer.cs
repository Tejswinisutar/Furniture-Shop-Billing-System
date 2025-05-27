
namespace Furniture_Shop_Billing_System.Windows_Form.Expences
{
    partial class frm_Add_Expence_Details
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Payment_Mode = new System.Windows.Forms.ComboBox();
            this.lbl_Payment_Mode = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.pb_Bill_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Bill_Image = new System.Windows.Forms.Label();
            this.tb_Total_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Expence_Details = new System.Windows.Forms.TextBox();
            this.tb_Expence_Id = new System.Windows.Forms.TextBox();
            this.lbl_Expence_Details = new System.Windows.Forms.Label();
            this.lbl_Expence_Id = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Expence_Details = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).BeginInit();
            this.gb_Expence_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(357, 673);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(189, 60);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Payment_Mode
            // 
            this.cmb_Payment_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Payment_Mode.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Payment_Mode.FormattingEnabled = true;
            this.cmb_Payment_Mode.Items.AddRange(new object[] {
            "Cash ",
            "UPI",
            "Other"});
            this.cmb_Payment_Mode.Location = new System.Drawing.Point(882, 517);
            this.cmb_Payment_Mode.MaxLength = 40;
            this.cmb_Payment_Mode.Name = "cmb_Payment_Mode";
            this.cmb_Payment_Mode.Size = new System.Drawing.Size(297, 33);
            this.cmb_Payment_Mode.TabIndex = 8;
            // 
            // lbl_Payment_Mode
            // 
            this.lbl_Payment_Mode.AutoSize = true;
            this.lbl_Payment_Mode.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Mode.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Mode.Location = new System.Drawing.Point(662, 519);
            this.lbl_Payment_Mode.Name = "lbl_Payment_Mode";
            this.lbl_Payment_Mode.Size = new System.Drawing.Size(193, 31);
            this.lbl_Payment_Mode.TabIndex = 14;
            this.lbl_Payment_Mode.Text = "Payment Mode";
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Browse.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.Blue;
            this.btn_Browse.Location = new System.Drawing.Point(966, 395);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(144, 47);
            this.btn_Browse.TabIndex = 7;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // pb_Bill_Image
            // 
            this.pb_Bill_Image.BackColor = System.Drawing.Color.White;
            this.pb_Bill_Image.Location = new System.Drawing.Point(882, 171);
            this.pb_Bill_Image.Name = "pb_Bill_Image";
            this.pb_Bill_Image.Size = new System.Drawing.Size(297, 208);
            this.pb_Bill_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Bill_Image.TabIndex = 13;
            this.pb_Bill_Image.TabStop = false;
            // 
            // lbl_Bill_Image
            // 
            this.lbl_Bill_Image.AutoSize = true;
            this.lbl_Bill_Image.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Image.ForeColor = System.Drawing.Color.Black;
            this.lbl_Bill_Image.Location = new System.Drawing.Point(662, 249);
            this.lbl_Bill_Image.Name = "lbl_Bill_Image";
            this.lbl_Bill_Image.Size = new System.Drawing.Size(144, 31);
            this.lbl_Bill_Image.TabIndex = 12;
            this.lbl_Bill_Image.Text = "Bill Image";
            // 
            // tb_Total_Amount
            // 
            this.tb_Total_Amount.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Amount.Location = new System.Drawing.Point(313, 518);
            this.tb_Total_Amount.Name = "tb_Total_Amount";
            this.tb_Total_Amount.Size = new System.Drawing.Size(297, 32);
            this.tb_Total_Amount.TabIndex = 6;
            this.tb_Total_Amount.Text = "0";
            this.tb_Total_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Total_Amount_KeyPress);
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Total_Amount.Location = new System.Drawing.Point(24, 516);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(182, 31);
            this.lbl_Total_Amount.TabIndex = 10;
            this.lbl_Total_Amount.Text = "Total Amount";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(882, 50);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(297, 40);
            this.dtp_Date.TabIndex = 5;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Date.Location = new System.Drawing.Point(674, 50);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(71, 31);
            this.lbl_Date.TabIndex = 8;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Expence_Details
            // 
            this.tb_Expence_Details.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expence_Details.Location = new System.Drawing.Point(313, 214);
            this.tb_Expence_Details.MaxLength = 80;
            this.tb_Expence_Details.Multiline = true;
            this.tb_Expence_Details.Name = "tb_Expence_Details";
            this.tb_Expence_Details.Size = new System.Drawing.Size(308, 165);
            this.tb_Expence_Details.TabIndex = 2;
            // 
            // tb_Expence_Id
            // 
            this.tb_Expence_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expence_Id.Location = new System.Drawing.Point(313, 52);
            this.tb_Expence_Id.Name = "tb_Expence_Id";
            this.tb_Expence_Id.Size = new System.Drawing.Size(308, 32);
            this.tb_Expence_Id.TabIndex = 1;
            // 
            // lbl_Expence_Details
            // 
            this.lbl_Expence_Details.AutoSize = true;
            this.lbl_Expence_Details.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Details.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expence_Details.Location = new System.Drawing.Point(24, 201);
            this.lbl_Expence_Details.Name = "lbl_Expence_Details";
            this.lbl_Expence_Details.Size = new System.Drawing.Size(209, 31);
            this.lbl_Expence_Details.TabIndex = 1;
            this.lbl_Expence_Details.Text = "Expence Details";
            // 
            // lbl_Expence_Id
            // 
            this.lbl_Expence_Id.AutoSize = true;
            this.lbl_Expence_Id.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expence_Id.Location = new System.Drawing.Point(24, 50);
            this.lbl_Expence_Id.Name = "lbl_Expence_Id";
            this.lbl_Expence_Id.Size = new System.Drawing.Size(150, 31);
            this.lbl_Expence_Id.TabIndex = 0;
            this.lbl_Expence_Id.Text = "Expence Id";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(799, 673);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(181, 60);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Expence_Details
            // 
            this.gb_Expence_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Expence_Details.Controls.Add(this.cmb_Payment_Mode);
            this.gb_Expence_Details.Controls.Add(this.lbl_Payment_Mode);
            this.gb_Expence_Details.Controls.Add(this.btn_Browse);
            this.gb_Expence_Details.Controls.Add(this.pb_Bill_Image);
            this.gb_Expence_Details.Controls.Add(this.lbl_Bill_Image);
            this.gb_Expence_Details.Controls.Add(this.tb_Total_Amount);
            this.gb_Expence_Details.Controls.Add(this.lbl_Total_Amount);
            this.gb_Expence_Details.Controls.Add(this.dtp_Date);
            this.gb_Expence_Details.Controls.Add(this.lbl_Date);
            this.gb_Expence_Details.Controls.Add(this.tb_Expence_Details);
            this.gb_Expence_Details.Controls.Add(this.tb_Expence_Id);
            this.gb_Expence_Details.Controls.Add(this.lbl_Expence_Details);
            this.gb_Expence_Details.Controls.Add(this.lbl_Expence_Id);
            this.gb_Expence_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Expence_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Expence_Details.Location = new System.Drawing.Point(19, 25);
            this.gb_Expence_Details.Name = "gb_Expence_Details";
            this.gb_Expence_Details.Size = new System.Drawing.Size(1227, 598);
            this.gb_Expence_Details.TabIndex = 30;
            this.gb_Expence_Details.TabStop = false;
            this.gb_Expence_Details.Text = "Expence Details";
            // 
            // frm_Add_Expence_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Expence_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Expence_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Expence_Details";
            this.Load += new System.EventHandler(this.frm_Add_Expence_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).EndInit();
            this.gb_Expence_Details.ResumeLayout(false);
            this.gb_Expence_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Payment_Mode;
        private System.Windows.Forms.Label lbl_Payment_Mode;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.PictureBox pb_Bill_Image;
        private System.Windows.Forms.Label lbl_Bill_Image;
        private System.Windows.Forms.TextBox tb_Total_Amount;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Expence_Details;
        private System.Windows.Forms.TextBox tb_Expence_Id;
        private System.Windows.Forms.Label lbl_Expence_Details;
        private System.Windows.Forms.Label lbl_Expence_Id;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Expence_Details;
    }
}