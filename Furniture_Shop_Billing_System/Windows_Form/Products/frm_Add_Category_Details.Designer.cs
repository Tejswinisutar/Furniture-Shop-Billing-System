
namespace Furniture_Shop_Billing_System.Windows_Form.Products
{
    partial class frm_Add_Category_Details
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
            this.gb_Add_Category = new System.Windows.Forms.GroupBox();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.tb_Category_Id = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_Category_Id = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Add_Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_Category
            // 
            this.gb_Add_Category.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Add_Category.Controls.Add(this.tb_Category_Name);
            this.gb_Add_Category.Controls.Add(this.tb_Category_Id);
            this.gb_Add_Category.Controls.Add(this.lbl_Category_Name);
            this.gb_Add_Category.Controls.Add(this.lbl_Category_Id);
            this.gb_Add_Category.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_Category.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Add_Category.Location = new System.Drawing.Point(186, 110);
            this.gb_Add_Category.Name = "gb_Add_Category";
            this.gb_Add_Category.Size = new System.Drawing.Size(893, 394);
            this.gb_Add_Category.TabIndex = 20;
            this.gb_Add_Category.TabStop = false;
            this.gb_Add_Category.Text = "Add Category";
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(490, 256);
            this.tb_Category_Name.MaxLength = 80;
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(302, 32);
            this.tb_Category_Name.TabIndex = 2;
            // 
            // tb_Category_Id
            // 
            this.tb_Category_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Id.Location = new System.Drawing.Point(490, 106);
            this.tb_Category_Id.Name = "tb_Category_Id";
            this.tb_Category_Id.Size = new System.Drawing.Size(302, 32);
            this.tb_Category_Id.TabIndex = 1;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Category_Name.Location = new System.Drawing.Point(111, 257);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(193, 31);
            this.lbl_Category_Name.TabIndex = 1;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // lbl_Category_Id
            // 
            this.lbl_Category_Id.AutoSize = true;
            this.lbl_Category_Id.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Category_Id.Location = new System.Drawing.Point(111, 107);
            this.lbl_Category_Id.Name = "lbl_Category_Id";
            this.lbl_Category_Id.Size = new System.Drawing.Size(150, 31);
            this.lbl_Category_Id.TabIndex = 0;
            this.lbl_Category_Id.Text = "Category Id";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(521, 578);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(199, 71);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Category_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Add_Category);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Category_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Category_Details";
            this.Load += new System.EventHandler(this.frm_Add_Category_Details_Load);
            this.gb_Add_Category.ResumeLayout(false);
            this.gb_Add_Category.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_Category;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.TextBox tb_Category_Id;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Id;
        private System.Windows.Forms.Button btn_Save;
    }
}