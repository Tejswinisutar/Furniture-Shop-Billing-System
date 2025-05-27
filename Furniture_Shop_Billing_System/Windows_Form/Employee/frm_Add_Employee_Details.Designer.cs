
namespace Furniture_Shop_Billing_System.Windows_Form.Employee
{
    partial class frm_Add_Employee_Details
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
            this.tb_Designation = new System.Windows.Forms.TextBox();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.tb_Employee_Id = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.tb_Bank_Name = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Account_No = new System.Windows.Forms.Label();
            this.lbl_Bank_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.gb_Bank_Details = new System.Windows.Forms.GroupBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Employee_Id = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Employee_Details = new System.Windows.Forms.GroupBox();
            this.gb_Bank_Details.SuspendLayout();
            this.gb_Employee_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(328, 670);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(189, 60);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(893, 275);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(281, 32);
            this.tb_Aadhar_No.TabIndex = 6;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Aadhar_No_KeyPress);
            // 
            // lbl_Aadhar_No
            // 
            this.lbl_Aadhar_No.AutoSize = true;
            this.lbl_Aadhar_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Aadhar_No.Location = new System.Drawing.Point(659, 273);
            this.lbl_Aadhar_No.Name = "lbl_Aadhar_No";
            this.lbl_Aadhar_No.Size = new System.Drawing.Size(148, 31);
            this.lbl_Aadhar_No.TabIndex = 17;
            this.lbl_Aadhar_No.Text = "Aadhar No";
            // 
            // tb_Designation
            // 
            this.tb_Designation.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Designation.Location = new System.Drawing.Point(287, 272);
            this.tb_Designation.MaxLength = 40;
            this.tb_Designation.Name = "tb_Designation";
            this.tb_Designation.Size = new System.Drawing.Size(299, 32);
            this.tb_Designation.TabIndex = 3;
            this.tb_Designation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Designation_KeyPress);
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.ForeColor = System.Drawing.Color.Black;
            this.lbl_Designation.Location = new System.Drawing.Point(31, 270);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(159, 31);
            this.lbl_Designation.TabIndex = 9;
            this.lbl_Designation.Text = "Designation";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(895, 54);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(279, 40);
            this.dtp_Date.TabIndex = 4;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(895, 160);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(279, 32);
            this.tb_Mobile_No.TabIndex = 5;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_No_KeyPress);
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(287, 157);
            this.tb_Employee_Name.MaxLength = 80;
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(299, 32);
            this.tb_Employee_Name.TabIndex = 2;
            this.tb_Employee_Name.TextChanged += new System.EventHandler(this.tb_Employee_Name_TextChanged);
            this.tb_Employee_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Employee_Name_KeyPress);
            // 
            // tb_Employee_Id
            // 
            this.tb_Employee_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Id.Location = new System.Drawing.Point(287, 47);
            this.tb_Employee_Id.Name = "tb_Employee_Id";
            this.tb_Employee_Id.Size = new System.Drawing.Size(299, 32);
            this.tb_Employee_Id.TabIndex = 1;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(661, 158);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(146, 31);
            this.lbl_Mobile_No.TabIndex = 3;
            this.lbl_Mobile_No.Text = "Mobile  No";
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(287, 135);
            this.tb_Account_No.MaxLength = 16;
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(299, 32);
            this.tb_Account_No.TabIndex = 8;
            this.tb_Account_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Account_No_KeyPress);
            // 
            // tb_Bank_Name
            // 
            this.tb_Bank_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bank_Name.Location = new System.Drawing.Point(287, 50);
            this.tb_Bank_Name.MaxLength = 40;
            this.tb_Bank_Name.Name = "tb_Bank_Name";
            this.tb_Bank_Name.Size = new System.Drawing.Size(299, 32);
            this.tb_Bank_Name.TabIndex = 7;
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
            this.lbl_Date.Location = new System.Drawing.Point(677, 54);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(71, 31);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
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
            this.gb_Bank_Details.Location = new System.Drawing.Point(12, 414);
            this.gb_Bank_Details.Name = "gb_Bank_Details";
            this.gb_Bank_Details.Size = new System.Drawing.Size(1241, 215);
            this.gb_Bank_Details.TabIndex = 30;
            this.gb_Bank_Details.TabStop = false;
            this.gb_Bank_Details.Text = "BankDetails";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(893, 50);
            this.tb_Note.MaxLength = 120;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(281, 127);
            this.tb_Note.TabIndex = 9;
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(24, 155);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(209, 31);
            this.lbl_Employee_Name.TabIndex = 1;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Employee_Id
            // 
            this.lbl_Employee_Id.AutoSize = true;
            this.lbl_Employee_Id.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Employee_Id.Location = new System.Drawing.Point(24, 54);
            this.lbl_Employee_Id.Name = "lbl_Employee_Id";
            this.lbl_Employee_Id.Size = new System.Drawing.Size(166, 31);
            this.lbl_Employee_Id.TabIndex = 0;
            this.lbl_Employee_Id.Text = "Employee Id";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(733, 670);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(181, 60);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Employee_Details
            // 
            this.gb_Employee_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Employee_Details.Controls.Add(this.tb_Aadhar_No);
            this.gb_Employee_Details.Controls.Add(this.lbl_Aadhar_No);
            this.gb_Employee_Details.Controls.Add(this.tb_Designation);
            this.gb_Employee_Details.Controls.Add(this.lbl_Designation);
            this.gb_Employee_Details.Controls.Add(this.dtp_Date);
            this.gb_Employee_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Employee_Details.Controls.Add(this.tb_Employee_Name);
            this.gb_Employee_Details.Controls.Add(this.tb_Employee_Id);
            this.gb_Employee_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Employee_Details.Controls.Add(this.lbl_Date);
            this.gb_Employee_Details.Controls.Add(this.lbl_Employee_Name);
            this.gb_Employee_Details.Controls.Add(this.lbl_Employee_Id);
            this.gb_Employee_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Employee_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Employee_Details.Location = new System.Drawing.Point(12, 28);
            this.gb_Employee_Details.Name = "gb_Employee_Details";
            this.gb_Employee_Details.Size = new System.Drawing.Size(1241, 354);
            this.gb_Employee_Details.TabIndex = 40;
            this.gb_Employee_Details.TabStop = false;
            this.gb_Employee_Details.Text = "Employee Details";
            // 
            // frm_Add_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Bank_Details);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Employee_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Employee_Details";
            this.Load += new System.EventHandler(this.frm_Add_Employee_Details_Load);
            this.gb_Bank_Details.ResumeLayout(false);
            this.gb_Bank_Details.PerformLayout();
            this.gb_Employee_Details.ResumeLayout(false);
            this.gb_Employee_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.Label lbl_Aadhar_No;
        private System.Windows.Forms.TextBox tb_Designation;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.TextBox tb_Employee_Id;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.TextBox tb_Bank_Name;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Account_No;
        private System.Windows.Forms.Label lbl_Bank_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.GroupBox gb_Bank_Details;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_Id;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gb_Employee_Details;
    }
}