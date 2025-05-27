
namespace Furniture_Shop_Billing_System.Windows_Form.Products
{
    partial class frm_Update_Product_Details
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
            this.tb_Details = new System.Windows.Forms.TextBox();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.tb_Sale_Price = new System.Windows.Forms.TextBox();
            this.lbl_Sale_Price = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Product_Company = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_SubCategory = new System.Windows.Forms.Label();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.gb_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Product_Company = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.tb_SubCategory = new System.Windows.Forms.TextBox();
            this.tb_Supplier = new System.Windows.Forms.TextBox();
            this.gb_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Details
            // 
            this.tb_Details.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Details.Location = new System.Drawing.Point(922, 367);
            this.tb_Details.MaxLength = 80;
            this.tb_Details.Name = "tb_Details";
            this.tb_Details.Size = new System.Drawing.Size(243, 32);
            this.tb_Details.TabIndex = 10;
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier.Location = new System.Drawing.Point(709, 483);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(126, 31);
            this.lbl_Supplier.TabIndex = 21;
            this.lbl_Supplier.Text = "Supplier ";
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.ForeColor = System.Drawing.Color.Black;
            this.lbl_Details.Location = new System.Drawing.Point(709, 367);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(100, 31);
            this.lbl_Details.TabIndex = 20;
            this.lbl_Details.Text = "Details";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(922, 256);
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(243, 32);
            this.tb_Purchase_Price.TabIndex = 9;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Purchase_Price_KeyPress);
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(698, 258);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(205, 31);
            this.lbl_Purchase_Price.TabIndex = 18;
            this.lbl_Purchase_Price.Text = " Purchase Price";
            // 
            // tb_Sale_Price
            // 
            this.tb_Sale_Price.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sale_Price.Location = new System.Drawing.Point(922, 148);
            this.tb_Sale_Price.Name = "tb_Sale_Price";
            this.tb_Sale_Price.Size = new System.Drawing.Size(243, 32);
            this.tb_Sale_Price.TabIndex = 8;
            this.tb_Sale_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Sale_Price_KeyPress);
            // 
            // lbl_Sale_Price
            // 
            this.lbl_Sale_Price.AutoSize = true;
            this.lbl_Sale_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sale_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Sale_Price.Location = new System.Drawing.Point(709, 151);
            this.lbl_Sale_Price.Name = "lbl_Sale_Price";
            this.lbl_Sale_Price.Size = new System.Drawing.Size(137, 31);
            this.lbl_Sale_Price.TabIndex = 15;
            this.lbl_Sale_Price.Text = "Sale Price";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Date.Location = new System.Drawing.Point(709, 46);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(71, 31);
            this.lbl_Date.TabIndex = 14;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Product_Company
            // 
            this.tb_Product_Company.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Company.Location = new System.Drawing.Point(268, 486);
            this.tb_Product_Company.MaxLength = 40;
            this.tb_Product_Company.Name = "tb_Product_Company";
            this.tb_Product_Company.Size = new System.Drawing.Size(236, 32);
            this.tb_Product_Company.TabIndex = 6;
            this.tb_Product_Company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_Company_KeyPress);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(268, 367);
            this.tb_Product_Name.MaxLength = 80;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(236, 32);
            this.tb_Product_Name.TabIndex = 5;
            this.tb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Product_Name_KeyPress);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Name.Location = new System.Drawing.Point(21, 368);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(187, 31);
            this.lbl_Product_Name.TabIndex = 10;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_SubCategory
            // 
            this.lbl_SubCategory.AutoSize = true;
            this.lbl_SubCategory.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubCategory.ForeColor = System.Drawing.Color.Black;
            this.lbl_SubCategory.Location = new System.Drawing.Point(21, 254);
            this.lbl_SubCategory.Name = "lbl_SubCategory";
            this.lbl_SubCategory.Size = new System.Drawing.Size(162, 31);
            this.lbl_SubCategory.TabIndex = 7;
            this.lbl_SubCategory.Text = "SubCategory";
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(268, 46);
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(236, 32);
            this.tb_Product_Id.TabIndex = 1;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.Black;
            this.lbl_Category.Location = new System.Drawing.Point(21, 146);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(116, 31);
            this.lbl_Category.TabIndex = 1;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Id.Location = new System.Drawing.Point(21, 47);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(144, 31);
            this.lbl_Product_Id.TabIndex = 0;
            this.lbl_Product_Id.Text = "Product Id";
            // 
            // gb_Details
            // 
            this.gb_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Details.Controls.Add(this.tb_Supplier);
            this.gb_Details.Controls.Add(this.tb_SubCategory);
            this.gb_Details.Controls.Add(this.tb_Category);
            this.gb_Details.Controls.Add(this.dtp_Date);
            this.gb_Details.Controls.Add(this.btn_Search);
            this.gb_Details.Controls.Add(this.tb_Details);
            this.gb_Details.Controls.Add(this.lbl_Supplier);
            this.gb_Details.Controls.Add(this.lbl_Details);
            this.gb_Details.Controls.Add(this.tb_Purchase_Price);
            this.gb_Details.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Details.Controls.Add(this.tb_Sale_Price);
            this.gb_Details.Controls.Add(this.lbl_Sale_Price);
            this.gb_Details.Controls.Add(this.lbl_Date);
            this.gb_Details.Controls.Add(this.tb_Product_Company);
            this.gb_Details.Controls.Add(this.tb_Product_Name);
            this.gb_Details.Controls.Add(this.lbl_Product_Company);
            this.gb_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Details.Controls.Add(this.lbl_SubCategory);
            this.gb_Details.Controls.Add(this.tb_Product_Id);
            this.gb_Details.Controls.Add(this.lbl_Category);
            this.gb_Details.Controls.Add(this.lbl_Product_Id);
            this.gb_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Details.Location = new System.Drawing.Point(38, 38);
            this.gb_Details.Name = "gb_Details";
            this.gb_Details.Size = new System.Drawing.Size(1188, 577);
            this.gb_Details.TabIndex = 30;
            this.gb_Details.TabStop = false;
            this.gb_Details.Text = "Product Details";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(922, 45);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(243, 40);
            this.dtp_Date.TabIndex = 7;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(529, 38);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 47);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Product_Company
            // 
            this.lbl_Product_Company.AutoSize = true;
            this.lbl_Product_Company.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Company.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Company.Location = new System.Drawing.Point(12, 480);
            this.lbl_Product_Company.Name = "lbl_Product_Company";
            this.lbl_Product_Company.Size = new System.Drawing.Size(227, 31);
            this.lbl_Product_Company.TabIndex = 11;
            this.lbl_Product_Company.Text = "Product Company";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(267, 673);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(189, 60);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Red;
            this.btn_Update.Location = new System.Drawing.Point(778, 673);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(181, 60);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_Category
            // 
            this.tb_Category.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.Location = new System.Drawing.Point(268, 153);
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.Size = new System.Drawing.Size(243, 32);
            this.tb_Category.TabIndex = 22;
            // 
            // tb_SubCategory
            // 
            this.tb_SubCategory.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SubCategory.Location = new System.Drawing.Point(268, 260);
            this.tb_SubCategory.Name = "tb_SubCategory";
            this.tb_SubCategory.Size = new System.Drawing.Size(243, 32);
            this.tb_SubCategory.TabIndex = 23;
            // 
            // tb_Supplier
            // 
            this.tb_Supplier.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Supplier.Location = new System.Drawing.Point(922, 480);
            this.tb_Supplier.MaxLength = 80;
            this.tb_Supplier.Name = "tb_Supplier";
            this.tb_Supplier.Size = new System.Drawing.Size(236, 32);
            this.tb_Supplier.TabIndex = 24;
            // 
            // frm_Update_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.gb_Details);
            this.Controls.Add(this.btn_Refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_Product_Details";
            this.Text = "frm_Update_Product_Details";
            this.gb_Details.ResumeLayout(false);
            this.gb_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Details;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Sale_Price;
        private System.Windows.Forms.Label lbl_Sale_Price;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Product_Company;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_SubCategory;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.GroupBox gb_Details;
        private System.Windows.Forms.Label lbl_Product_Company;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Category;
        private System.Windows.Forms.TextBox tb_SubCategory;
        private System.Windows.Forms.TextBox tb_Supplier;
    }
}