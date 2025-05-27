
namespace Furniture_Shop_Billing_System.Windows_Form.User_Management
{
    partial class frm_Add_User
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
            this.gb_Add_User = new System.Windows.Forms.GroupBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.cmb_UserRole = new System.Windows.Forms.ComboBox();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gb_Add_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_User
            // 
            this.gb_Add_User.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Add_User.Controls.Add(this.tb_UserName);
            this.gb_Add_User.Controls.Add(this.cmb_UserRole);
            this.gb_Add_User.Controls.Add(this.tb_Confirm_Password);
            this.gb_Add_User.Controls.Add(this.lbl_Confirm_Password);
            this.gb_Add_User.Controls.Add(this.tb_Password);
            this.gb_Add_User.Controls.Add(this.lbl_Password);
            this.gb_Add_User.Controls.Add(this.lbl_User_Name);
            this.gb_Add_User.Controls.Add(this.lbl_User_Role);
            this.gb_Add_User.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_User.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Add_User.Location = new System.Drawing.Point(38, 51);
            this.gb_Add_User.Name = "gb_Add_User";
            this.gb_Add_User.Size = new System.Drawing.Size(1188, 538);
            this.gb_Add_User.TabIndex = 20;
            this.gb_Add_User.TabStop = false;
            this.gb_Add_User.Text = "Add User";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(692, 200);
            this.tb_UserName.MaxLength = 30;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(296, 32);
            this.tb_UserName.TabIndex = 2;
            // 
            // cmb_UserRole
            // 
            this.cmb_UserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserRole.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserRole.FormattingEnabled = true;
            this.cmb_UserRole.Items.AddRange(new object[] {
            "Admin",
            "Casher",
            "Manager"});
            this.cmb_UserRole.Location = new System.Drawing.Point(692, 86);
            this.cmb_UserRole.MaxLength = 20;
            this.cmb_UserRole.Name = "cmb_UserRole";
            this.cmb_UserRole.Size = new System.Drawing.Size(296, 33);
            this.cmb_UserRole.TabIndex = 1;
            this.cmb_UserRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_UserRole_KeyPress);
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Confirm_Password.Location = new System.Drawing.Point(692, 437);
            this.tb_Confirm_Password.MaxLength = 30;
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.Size = new System.Drawing.Size(296, 32);
            this.tb_Confirm_Password.TabIndex = 4;
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(236, 437);
            this.lbl_Confirm_Password.Name = "lbl_Confirm_Password";
            this.lbl_Confirm_Password.Size = new System.Drawing.Size(235, 31);
            this.lbl_Confirm_Password.TabIndex = 10;
            this.lbl_Confirm_Password.Text = "Confirm Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(692, 323);
            this.tb_Password.MaxLength = 30;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(296, 32);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(240, 310);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(127, 31);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_User_Name.Location = new System.Drawing.Point(236, 198);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(146, 31);
            this.lbl_User_Name.TabIndex = 1;
            this.lbl_User_Name.Text = "User Name";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.ForeColor = System.Drawing.Color.Black;
            this.lbl_User_Role.Location = new System.Drawing.Point(236, 82);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(131, 31);
            this.lbl_User_Role.TabIndex = 0;
            this.lbl_User_Role.Text = "User Role";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Red;
            this.btn_Add.Location = new System.Drawing.Point(507, 646);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(212, 61);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add User";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frm_Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb_Add_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_User";
            this.gb_Add_User.ResumeLayout(false);
            this.gb_Add_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_User;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_UserRole;
        private System.Windows.Forms.TextBox tb_UserName;
    }
}