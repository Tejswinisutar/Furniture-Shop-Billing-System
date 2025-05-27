
namespace Furniture_Shop_Billing_System.Windows_Form.UC_Headers
{
    partial class UC_Employee_Head
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
            this.lbl_Employee = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_View_List = new System.Windows.Forms.Button();
            this.btn_Add_Employee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Employee.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee.ForeColor = System.Drawing.Color.Black;
            this.lbl_Employee.Location = new System.Drawing.Point(520, 11);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(198, 45);
            this.lbl_Employee.TabIndex = 7;
            this.lbl_Employee.Text = "Employee";
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(504, 79);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(265, 47);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update Employee";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Employee_Click_1);
            // 
            // btn_View_List
            // 
            this.btn_View_List.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_List.Location = new System.Drawing.Point(958, 79);
            this.btn_View_List.Name = "btn_View_List";
            this.btn_View_List.Size = new System.Drawing.Size(237, 47);
            this.btn_View_List.TabIndex = 9;
            this.btn_View_List.Text = "View List";
            this.btn_View_List.UseVisualStyleBackColor = true;
            this.btn_View_List.Click += new System.EventHandler(this.btn_View_List_Click);
            // 
            // btn_Add_Employee
            // 
            this.btn_Add_Employee.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Employee.Location = new System.Drawing.Point(77, 79);
            this.btn_Add_Employee.Name = "btn_Add_Employee";
            this.btn_Add_Employee.Size = new System.Drawing.Size(237, 47);
            this.btn_Add_Employee.TabIndex = 10;
            this.btn_Add_Employee.Text = "Add Employee";
            this.btn_Add_Employee.UseVisualStyleBackColor = true;
            this.btn_Add_Employee.Click += new System.EventHandler(this.btn_Add_Employee_Click_1);
            // 
            // UC_Employee_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btn_Add_Employee);
            this.Controls.Add(this.btn_View_List);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lbl_Employee);
            this.Name = "UC_Employee_Head";
            this.Size = new System.Drawing.Size(1265, 153);
            this.Load += new System.EventHandler(this.UC_Employee_Head_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_View_List;
        private System.Windows.Forms.Button btn_Add_Employee;
    }
}
