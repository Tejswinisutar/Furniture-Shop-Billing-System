
namespace Furniture_Shop_Billing_System.Windows_Form.Order
{
    partial class frm_Order_Payment
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dtp_Payment_Date = new System.Windows.Forms.DateTimePicker();
            this.gb_Order_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Payment_Mode = new System.Windows.Forms.ComboBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Paying_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paying_Amount = new System.Windows.Forms.Label();
            this.lbl_Payment_Mode = new System.Windows.Forms.Label();
            this.tb_Paid_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paid_Amount = new System.Windows.Forms.Label();
            this.lbl_Payment_Date = new System.Windows.Forms.Label();
            this.tb_Remaining_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Remaining_Amount = new System.Windows.Forms.Label();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.tb_Payment_Id = new System.Windows.Forms.TextBox();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.lbl_Payment_Id = new System.Windows.Forms.Label();
            this.tb_Order_Id = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Order_Id = new System.Windows.Forms.Label();
            this.gb__Order_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Order_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Order_Date = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Supplier_Name = new System.Windows.Forms.TextBox();
            this.gb_Order_Details.SuspendLayout();
            this.gb__Order_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(709, 686);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(181, 60);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(236, 686);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(189, 60);
            this.btn_Refresh.TabIndex = 15;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dtp_Payment_Date
            // 
            this.dtp_Payment_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Payment_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Payment_Date.Location = new System.Drawing.Point(904, 48);
            this.dtp_Payment_Date.Name = "dtp_Payment_Date";
            this.dtp_Payment_Date.Size = new System.Drawing.Size(285, 40);
            this.dtp_Payment_Date.TabIndex = 10;
            // 
            // gb_Order_Details
            // 
            this.gb_Order_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Order_Details.Controls.Add(this.cmb_Payment_Mode);
            this.gb_Order_Details.Controls.Add(this.tb_Note);
            this.gb_Order_Details.Controls.Add(this.lbl_Note);
            this.gb_Order_Details.Controls.Add(this.tb_Paying_Amount);
            this.gb_Order_Details.Controls.Add(this.lbl_Paying_Amount);
            this.gb_Order_Details.Controls.Add(this.dtp_Payment_Date);
            this.gb_Order_Details.Controls.Add(this.lbl_Payment_Mode);
            this.gb_Order_Details.Controls.Add(this.tb_Paid_Amount);
            this.gb_Order_Details.Controls.Add(this.lbl_Paid_Amount);
            this.gb_Order_Details.Controls.Add(this.lbl_Payment_Date);
            this.gb_Order_Details.Controls.Add(this.tb_Remaining_Amount);
            this.gb_Order_Details.Controls.Add(this.lbl_Remaining_Amount);
            this.gb_Order_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Order_Details.Controls.Add(this.tb_Payment_Id);
            this.gb_Order_Details.Controls.Add(this.lbl_Final_Bill);
            this.gb_Order_Details.Controls.Add(this.lbl_Payment_Id);
            this.gb_Order_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Order_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Order_Details.Location = new System.Drawing.Point(12, 218);
            this.gb_Order_Details.Name = "gb_Order_Details";
            this.gb_Order_Details.Size = new System.Drawing.Size(1241, 444);
            this.gb_Order_Details.TabIndex = 30;
            this.gb_Order_Details.TabStop = false;
            // 
            // cmb_Payment_Mode
            // 
            this.cmb_Payment_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Payment_Mode.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Payment_Mode.FormattingEnabled = true;
            this.cmb_Payment_Mode.Items.AddRange(new object[] {
            "UPI",
            "Cash",
            "Other"});
            this.cmb_Payment_Mode.Location = new System.Drawing.Point(322, 370);
            this.cmb_Payment_Mode.Name = "cmb_Payment_Mode";
            this.cmb_Payment_Mode.Size = new System.Drawing.Size(294, 33);
            this.cmb_Payment_Mode.TabIndex = 9;
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(904, 320);
            this.tb_Note.MaxLength = 120;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(294, 107);
            this.tb_Note.TabIndex = 13;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Black;
            this.lbl_Note.Location = new System.Drawing.Point(662, 355);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(69, 31);
            this.lbl_Note.TabIndex = 22;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Paying_Amount
            // 
            this.tb_Paying_Amount.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paying_Amount.Location = new System.Drawing.Point(904, 256);
            this.tb_Paying_Amount.Name = "tb_Paying_Amount";
            this.tb_Paying_Amount.Size = new System.Drawing.Size(294, 32);
            this.tb_Paying_Amount.TabIndex = 12;
            this.tb_Paying_Amount.Text = "0";
            this.tb_Paying_Amount.TextChanged += new System.EventHandler(this.tb_Paying_Amount_TextChanged);
            // 
            // lbl_Paying_Amount
            // 
            this.lbl_Paying_Amount.AutoSize = true;
            this.lbl_Paying_Amount.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paying_Amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Paying_Amount.Location = new System.Drawing.Point(647, 257);
            this.lbl_Paying_Amount.Name = "lbl_Paying_Amount";
            this.lbl_Paying_Amount.Size = new System.Drawing.Size(204, 31);
            this.lbl_Paying_Amount.TabIndex = 20;
            this.lbl_Paying_Amount.Text = "Paying Amount";
            // 
            // lbl_Payment_Mode
            // 
            this.lbl_Payment_Mode.AutoSize = true;
            this.lbl_Payment_Mode.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Mode.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Mode.Location = new System.Drawing.Point(18, 372);
            this.lbl_Payment_Mode.Name = "lbl_Payment_Mode";
            this.lbl_Payment_Mode.Size = new System.Drawing.Size(193, 31);
            this.lbl_Payment_Mode.TabIndex = 16;
            this.lbl_Payment_Mode.Text = "Payment Mode";
            // 
            // tb_Paid_Amount
            // 
            this.tb_Paid_Amount.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid_Amount.Location = new System.Drawing.Point(904, 151);
            this.tb_Paid_Amount.Name = "tb_Paid_Amount";
            this.tb_Paid_Amount.Size = new System.Drawing.Size(285, 32);
            this.tb_Paid_Amount.TabIndex = 11;
            this.tb_Paid_Amount.Text = "0";
            // 
            // lbl_Paid_Amount
            // 
            this.lbl_Paid_Amount.AutoSize = true;
            this.lbl_Paid_Amount.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_Amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Paid_Amount.Location = new System.Drawing.Point(647, 146);
            this.lbl_Paid_Amount.Name = "lbl_Paid_Amount";
            this.lbl_Paid_Amount.Size = new System.Drawing.Size(177, 31);
            this.lbl_Paid_Amount.TabIndex = 13;
            this.lbl_Paid_Amount.Text = "Paid Amount";
            // 
            // lbl_Payment_Date
            // 
            this.lbl_Payment_Date.AutoSize = true;
            this.lbl_Payment_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Date.Location = new System.Drawing.Point(647, 49);
            this.lbl_Payment_Date.Name = "lbl_Payment_Date";
            this.lbl_Payment_Date.Size = new System.Drawing.Size(184, 31);
            this.lbl_Payment_Date.TabIndex = 12;
            this.lbl_Payment_Date.Text = "Payment Date";
            // 
            // tb_Remaining_Amount
            // 
            this.tb_Remaining_Amount.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Remaining_Amount.Location = new System.Drawing.Point(322, 259);
            this.tb_Remaining_Amount.Name = "tb_Remaining_Amount";
            this.tb_Remaining_Amount.Size = new System.Drawing.Size(294, 32);
            this.tb_Remaining_Amount.TabIndex = 8;
            this.tb_Remaining_Amount.Text = "0";
            // 
            // lbl_Remaining_Amount
            // 
            this.lbl_Remaining_Amount.AutoSize = true;
            this.lbl_Remaining_Amount.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaining_Amount.ForeColor = System.Drawing.Color.Black;
            this.lbl_Remaining_Amount.Location = new System.Drawing.Point(6, 257);
            this.lbl_Remaining_Amount.Name = "lbl_Remaining_Amount";
            this.lbl_Remaining_Amount.Size = new System.Drawing.Size(254, 31);
            this.lbl_Remaining_Amount.TabIndex = 7;
            this.lbl_Remaining_Amount.Text = "Remaining Amount";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(322, 148);
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(294, 32);
            this.tb_Final_Bill.TabIndex = 7;
            this.tb_Final_Bill.Text = "0";
            // 
            // tb_Payment_Id
            // 
            this.tb_Payment_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Payment_Id.Location = new System.Drawing.Point(322, 51);
            this.tb_Payment_Id.Name = "tb_Payment_Id";
            this.tb_Payment_Id.Size = new System.Drawing.Size(294, 32);
            this.tb_Payment_Id.TabIndex = 6;
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(22, 149);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(138, 31);
            this.lbl_Final_Bill.TabIndex = 1;
            this.lbl_Final_Bill.Text = "Final Bill";
            // 
            // lbl_Payment_Id
            // 
            this.lbl_Payment_Id.AutoSize = true;
            this.lbl_Payment_Id.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Payment_Id.Location = new System.Drawing.Point(22, 48);
            this.lbl_Payment_Id.Name = "lbl_Payment_Id";
            this.lbl_Payment_Id.Size = new System.Drawing.Size(154, 31);
            this.lbl_Payment_Id.TabIndex = 0;
            this.lbl_Payment_Id.Text = "Payment Id";
            this.lbl_Payment_Id.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Order_Id
            // 
            this.tb_Order_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Order_Id.Location = new System.Drawing.Point(265, 37);
            this.tb_Order_Id.Name = "tb_Order_Id";
            this.tb_Order_Id.Size = new System.Drawing.Size(258, 32);
            this.tb_Order_Id.TabIndex = 1;
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(18, 120);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(196, 31);
            this.lbl_Supplier_Name.TabIndex = 1;
            this.lbl_Supplier_Name.Text = "Supplier Name";
            // 
            // lbl_Order_Id
            // 
            this.lbl_Order_Id.AutoSize = true;
            this.lbl_Order_Id.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Order_Id.Location = new System.Drawing.Point(22, 37);
            this.lbl_Order_Id.Name = "lbl_Order_Id";
            this.lbl_Order_Id.Size = new System.Drawing.Size(118, 31);
            this.lbl_Order_Id.TabIndex = 0;
            this.lbl_Order_Id.Text = "Order Id";
            // 
            // gb__Order_Details
            // 
            this.gb__Order_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb__Order_Details.Controls.Add(this.dtp_Order_Date);
            this.gb__Order_Details.Controls.Add(this.lbl_Order_Date);
            this.gb__Order_Details.Controls.Add(this.btn_Search);
            this.gb__Order_Details.Controls.Add(this.tb_Mobile_No);
            this.gb__Order_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb__Order_Details.Controls.Add(this.tb_Supplier_Name);
            this.gb__Order_Details.Controls.Add(this.tb_Order_Id);
            this.gb__Order_Details.Controls.Add(this.lbl_Supplier_Name);
            this.gb__Order_Details.Controls.Add(this.lbl_Order_Id);
            this.gb__Order_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb__Order_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb__Order_Details.Location = new System.Drawing.Point(12, 23);
            this.gb__Order_Details.Name = "gb__Order_Details";
            this.gb__Order_Details.Size = new System.Drawing.Size(1241, 176);
            this.gb__Order_Details.TabIndex = 50;
            this.gb__Order_Details.TabStop = false;
            this.gb__Order_Details.Text = "Order Details";
            // 
            // dtp_Order_Date
            // 
            this.dtp_Order_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Order_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Order_Date.Location = new System.Drawing.Point(940, 38);
            this.dtp_Order_Date.Name = "dtp_Order_Date";
            this.dtp_Order_Date.Size = new System.Drawing.Size(258, 40);
            this.dtp_Order_Date.TabIndex = 4;
            // 
            // lbl_Order_Date
            // 
            this.lbl_Order_Date.AutoSize = true;
            this.lbl_Order_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Order_Date.Location = new System.Drawing.Point(739, 36);
            this.lbl_Order_Date.Name = "lbl_Order_Date";
            this.lbl_Order_Date.Size = new System.Drawing.Size(148, 31);
            this.lbl_Order_Date.TabIndex = 10;
            this.lbl_Order_Date.Text = "Order Date";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(568, 34);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(145, 44);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(940, 122);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(258, 32);
            this.tb_Mobile_No.TabIndex = 5;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(739, 123);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(139, 31);
            this.lbl_Mobile_No.TabIndex = 7;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // tb_Supplier_Name
            // 
            this.tb_Supplier_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Name.Location = new System.Drawing.Point(265, 122);
            this.tb_Supplier_Name.Name = "tb_Supplier_Name";
            this.tb_Supplier_Name.Size = new System.Drawing.Size(258, 32);
            this.tb_Supplier_Name.TabIndex = 3;
            // 
            // frm_Order_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Order_Details);
            this.Controls.Add(this.gb__Order_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Order_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Order_Payment";
            this.Load += new System.EventHandler(this.frm_Order_Payment_Load);
            this.gb_Order_Details.ResumeLayout(false);
            this.gb_Order_Details.PerformLayout();
            this.gb__Order_Details.ResumeLayout(false);
            this.gb__Order_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DateTimePicker dtp_Payment_Date;
        private System.Windows.Forms.GroupBox gb_Order_Details;
        private System.Windows.Forms.Label lbl_Payment_Mode;
        private System.Windows.Forms.TextBox tb_Paid_Amount;
        private System.Windows.Forms.Label lbl_Paid_Amount;
        private System.Windows.Forms.Label lbl_Payment_Date;
        private System.Windows.Forms.TextBox tb_Remaining_Amount;
        private System.Windows.Forms.Label lbl_Remaining_Amount;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.TextBox tb_Payment_Id;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.Label lbl_Payment_Id;
        private System.Windows.Forms.TextBox tb_Order_Id;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Label lbl_Order_Id;
        private System.Windows.Forms.GroupBox gb__Order_Details;
        private System.Windows.Forms.DateTimePicker dtp_Order_Date;
        private System.Windows.Forms.Label lbl_Order_Date;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Paying_Amount;
        private System.Windows.Forms.Label lbl_Paying_Amount;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ComboBox cmb_Payment_Mode;
    }
}