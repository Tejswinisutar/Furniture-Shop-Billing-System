
namespace Furniture_Shop_Billing_System.Windows_Form.Suppiler
{
    partial class frm_Update_Supplier_Details
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
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.lbl_Aadhar_No = new System.Windows.Forms.Label();
            this.lbl_Supplier_Company = new System.Windows.Forms.Label();
            this.tb_Supplier_Company = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Supplier_Name = new System.Windows.Forms.TextBox();
            this.tb_Supplier_Id = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.tb_Bank_Name = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Account_No = new System.Windows.Forms.Label();
            this.lbl_Bank_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Supplier_Id = new System.Windows.Forms.Label();
            this.gb_Suppiler_Details = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Bank_Details = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Suppiler_Details.SuspendLayout();
            this.gb_Bank_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(328, 667);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(189, 60);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(239, 269);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(279, 32);
            this.tb_Aadhar_No.TabIndex = 4;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Aadhar_No_KeyPress);
            // 
            // lbl_Aadhar_No
            // 
            this.lbl_Aadhar_No.AutoSize = true;
            this.lbl_Aadhar_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Aadhar_No.Location = new System.Drawing.Point(29, 270);
            this.lbl_Aadhar_No.Name = "lbl_Aadhar_No";
            this.lbl_Aadhar_No.Size = new System.Drawing.Size(148, 31);
            this.lbl_Aadhar_No.TabIndex = 17;
            this.lbl_Aadhar_No.Text = "Aadhar No";
            // 
            // lbl_Supplier_Company
            // 
            this.lbl_Supplier_Company.AutoSize = true;
            this.lbl_Supplier_Company.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Company.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Company.Location = new System.Drawing.Point(698, 270);
            this.lbl_Supplier_Company.Name = "lbl_Supplier_Company";
            this.lbl_Supplier_Company.Size = new System.Drawing.Size(236, 31);
            this.lbl_Supplier_Company.TabIndex = 9;
            this.lbl_Supplier_Company.Text = "Supplier Company";
            // 
            // tb_Supplier_Company
            // 
            this.tb_Supplier_Company.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Company.Location = new System.Drawing.Point(963, 272);
            this.tb_Supplier_Company.MaxLength = 80;
            this.tb_Supplier_Company.Name = "tb_Supplier_Company";
            this.tb_Supplier_Company.Size = new System.Drawing.Size(244, 32);
            this.tb_Supplier_Company.TabIndex = 7;
            this.tb_Supplier_Company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Suppiler_Company_KeyPress);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(963, 53);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(244, 40);
            this.dtp_Date.TabIndex = 5;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(963, 160);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(244, 32);
            this.tb_Mobile_No.TabIndex = 6;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_No_KeyPress);
            // 
            // tb_Supplier_Name
            // 
            this.tb_Supplier_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Name.Location = new System.Drawing.Point(239, 157);
            this.tb_Supplier_Name.MaxLength = 80;
            this.tb_Supplier_Name.Name = "tb_Supplier_Name";
            this.tb_Supplier_Name.Size = new System.Drawing.Size(279, 32);
            this.tb_Supplier_Name.TabIndex = 3;
            this.tb_Supplier_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Suppiler_Name_KeyPress);
            // 
            // tb_Supplier_Id
            // 
            this.tb_Supplier_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier_Id.Location = new System.Drawing.Point(239, 48);
            this.tb_Supplier_Id.Name = "tb_Supplier_Id";
            this.tb_Supplier_Id.Size = new System.Drawing.Size(279, 32);
            this.tb_Supplier_Id.TabIndex = 1;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(715, 161);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(146, 31);
            this.lbl_Mobile_No.TabIndex = 3;
            this.lbl_Mobile_No.Text = "Mobile  No";
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(287, 135);
            this.tb_Account_No.MaxLength = 11;
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(315, 32);
            this.tb_Account_No.TabIndex = 9;
            // 
            // tb_Bank_Name
            // 
            this.tb_Bank_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bank_Name.Location = new System.Drawing.Point(287, 50);
            this.tb_Bank_Name.MaxLength = 80;
            this.tb_Bank_Name.Name = "tb_Bank_Name";
            this.tb_Bank_Name.Size = new System.Drawing.Size(315, 32);
            this.tb_Bank_Name.TabIndex = 8;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Black;
            this.lbl_Note.Location = new System.Drawing.Point(715, 57);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(69, 31);
            this.lbl_Note.TabIndex = 2;
            this.lbl_Note.Text = "Note";
            // 
            // lbl_Account_No
            // 
            this.lbl_Account_No.AutoSize = true;
            this.lbl_Account_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Account_No.Location = new System.Drawing.Point(23, 133);
            this.lbl_Account_No.Name = "lbl_Account_No";
            this.lbl_Account_No.Size = new System.Drawing.Size(154, 31);
            this.lbl_Account_No.TabIndex = 1;
            this.lbl_Account_No.Text = "Account No";
            // 
            // lbl_Bank_Name
            // 
            this.lbl_Bank_Name.AutoSize = true;
            this.lbl_Bank_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bank_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Bank_Name.Location = new System.Drawing.Point(24, 57);
            this.lbl_Bank_Name.Name = "lbl_Bank_Name";
            this.lbl_Bank_Name.Size = new System.Drawing.Size(158, 31);
            this.lbl_Bank_Name.TabIndex = 0;
            this.lbl_Bank_Name.Text = "Bank Name";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Date.Location = new System.Drawing.Point(731, 57);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(71, 31);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(867, 50);
            this.tb_Note.MaxLength = 120;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(340, 127);
            this.tb_Note.TabIndex = 10;
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(24, 155);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(196, 31);
            this.lbl_Supplier_Name.TabIndex = 1;
            this.lbl_Supplier_Name.Text = "Supplier Name";
            // 
            // lbl_Supplier_Id
            // 
            this.lbl_Supplier_Id.AutoSize = true;
            this.lbl_Supplier_Id.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Id.Location = new System.Drawing.Point(24, 54);
            this.lbl_Supplier_Id.Name = "lbl_Supplier_Id";
            this.lbl_Supplier_Id.Size = new System.Drawing.Size(153, 31);
            this.lbl_Supplier_Id.TabIndex = 0;
            this.lbl_Supplier_Id.Text = "Supplier Id";
            // 
            // gb_Suppiler_Details
            // 
            this.gb_Suppiler_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Suppiler_Details.Controls.Add(this.btn_Search);
            this.gb_Suppiler_Details.Controls.Add(this.tb_Aadhar_No);
            this.gb_Suppiler_Details.Controls.Add(this.lbl_Aadhar_No);
            this.gb_Suppiler_Details.Controls.Add(this.lbl_Supplier_Company);
            this.gb_Suppiler_Details.Controls.Add(this.tb_Supplier_Company);
            this.gb_Suppiler_Details.Controls.Add(this.dtp_Date);
            this.gb_Suppiler_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Suppiler_Details.Controls.Add(this.tb_Supplier_Name);
            this.gb_Suppiler_Details.Controls.Add(this.tb_Supplier_Id);
            this.gb_Suppiler_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Suppiler_Details.Controls.Add(this.lbl_Date);
            this.gb_Suppiler_Details.Controls.Add(this.lbl_Supplier_Name);
            this.gb_Suppiler_Details.Controls.Add(this.lbl_Supplier_Id);
            this.gb_Suppiler_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Suppiler_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Suppiler_Details.Location = new System.Drawing.Point(12, 31);
            this.gb_Suppiler_Details.Name = "gb_Suppiler_Details";
            this.gb_Suppiler_Details.Size = new System.Drawing.Size(1229, 348);
            this.gb_Suppiler_Details.TabIndex = 40;
            this.gb_Suppiler_Details.TabStop = false;
            this.gb_Suppiler_Details.Text = "Suppiler Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(563, 37);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(146, 48);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // gb_Bank_Details
            // 
            this.gb_Bank_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Bank_Details.Controls.Add(this.tb_Note);
            this.gb_Bank_Details.Controls.Add(this.tb_Account_No);
            this.gb_Bank_Details.Controls.Add(this.tb_Bank_Name);
            this.gb_Bank_Details.Controls.Add(this.lbl_Note);
            this.gb_Bank_Details.Controls.Add(this.lbl_Account_No);
            this.gb_Bank_Details.Controls.Add(this.lbl_Bank_Name);
            this.gb_Bank_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bank_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Bank_Details.Location = new System.Drawing.Point(12, 411);
            this.gb_Bank_Details.Name = "gb_Bank_Details";
            this.gb_Bank_Details.Size = new System.Drawing.Size(1229, 215);
            this.gb_Bank_Details.TabIndex = 30;
            this.gb_Bank_Details.TabStop = false;
            this.gb_Bank_Details.Text = "BankDetails";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Red;
            this.btn_Update.Location = new System.Drawing.Point(782, 677);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(181, 60);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_Update_Supplier_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Suppiler_Details);
            this.Controls.Add(this.gb_Bank_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_Supplier_Details";
            this.Text = "frm_Update_Suppiler_Details";
            this.gb_Suppiler_Details.ResumeLayout(false);
            this.gb_Suppiler_Details.PerformLayout();
            this.gb_Bank_Details.ResumeLayout(false);
            this.gb_Bank_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.Label lbl_Aadhar_No;
        private System.Windows.Forms.Label lbl_Supplier_Company;
        private System.Windows.Forms.TextBox tb_Supplier_Company;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Supplier_Id;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.TextBox tb_Bank_Name;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Account_No;
        private System.Windows.Forms.Label lbl_Bank_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Label lbl_Supplier_Id;
        private System.Windows.Forms.GroupBox gb_Suppiler_Details;
        private System.Windows.Forms.GroupBox gb_Bank_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
    }
}