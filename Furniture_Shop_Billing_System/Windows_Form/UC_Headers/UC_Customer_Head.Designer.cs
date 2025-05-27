
namespace Furniture_Shop_Billing_System.Windows_Form.UC_Headers
{
    partial class UC_Customer_Head
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
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.btn_Add_Customer = new System.Windows.Forms.Button();
            this.btn_View_List = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Customer.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.ForeColor = System.Drawing.Color.Black;
            this.lbl_Customer.Location = new System.Drawing.Point(530, 19);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(200, 45);
            this.lbl_Customer.TabIndex = 7;
            this.lbl_Customer.Text = "Customer ";
            // 
            // btn_Add_Customer
            // 
            this.btn_Add_Customer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Customer.Location = new System.Drawing.Point(100, 81);
            this.btn_Add_Customer.Name = "btn_Add_Customer";
            this.btn_Add_Customer.Size = new System.Drawing.Size(237, 47);
            this.btn_Add_Customer.TabIndex = 1;
            this.btn_Add_Customer.Text = "Add Customer";
            this.btn_Add_Customer.UseVisualStyleBackColor = true;
            this.btn_Add_Customer.Click += new System.EventHandler(this.btn_Add_Customer_Click);
            // 
            // btn_View_List
            // 
            this.btn_View_List.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_List.Location = new System.Drawing.Point(865, 81);
            this.btn_View_List.Name = "btn_View_List";
            this.btn_View_List.Size = new System.Drawing.Size(237, 47);
            this.btn_View_List.TabIndex = 8;
            this.btn_View_List.Text = "View List";
            this.btn_View_List.UseVisualStyleBackColor = true;
            this.btn_View_List.Click += new System.EventHandler(this.btn_View_List_Click);
            // 
            // UC_Customer_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btn_View_List);
            this.Controls.Add(this.btn_Add_Customer);
            this.Controls.Add(this.lbl_Customer);
            this.Name = "UC_Customer_Head";
            this.Size = new System.Drawing.Size(1265, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.Button btn_Add_Customer;
        private System.Windows.Forms.Button btn_View_List;
    }
}
