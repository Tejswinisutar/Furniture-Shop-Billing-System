
namespace Furniture_Shop_Billing_System.Windows_Form.Products
{
    partial class frm_Add_Product_Details
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
            this.lbl_Product_Company = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_SubCategory = new System.Windows.Forms.Label();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.gb_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(319, 660);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(189, 60);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Details
            // 
            this.tb_Details.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Details.Location = new System.Drawing.Point(847, 367);
            this.tb_Details.MaxLength = 80;
            this.tb_Details.Name = "tb_Details";
            this.tb_Details.Size = new System.Drawing.Size(283, 32);
            this.tb_Details.TabIndex = 9;
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier.Location = new System.Drawing.Point(599, 484);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(119, 31);
            this.lbl_Supplier.TabIndex = 21;
            this.lbl_Supplier.Text = "Supplier";
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.ForeColor = System.Drawing.Color.Black;
            this.lbl_Details.Location = new System.Drawing.Point(610, 368);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(100, 31);
            this.lbl_Details.TabIndex = 20;
            this.lbl_Details.Text = "Details";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(847, 256);
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(283, 32);
            this.tb_Purchase_Price.TabIndex = 8;
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(599, 259);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(205, 31);
            this.lbl_Purchase_Price.TabIndex = 18;
            this.lbl_Purchase_Price.Text = " Purchase Price";
            // 
            // tb_Sale_Price
            // 
            this.tb_Sale_Price.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sale_Price.Location = new System.Drawing.Point(847, 148);
            this.tb_Sale_Price.Name = "tb_Sale_Price";
            this.tb_Sale_Price.Size = new System.Drawing.Size(283, 32);
            this.tb_Sale_Price.TabIndex = 7;
            // 
            // lbl_Sale_Price
            // 
            this.lbl_Sale_Price.AutoSize = true;
            this.lbl_Sale_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sale_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Sale_Price.Location = new System.Drawing.Point(610, 152);
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
            this.lbl_Date.Location = new System.Drawing.Point(610, 47);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(71, 31);
            this.lbl_Date.TabIndex = 14;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Product_Company
            // 
            this.tb_Product_Company.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Company.Location = new System.Drawing.Point(281, 486);
            this.tb_Product_Company.MaxLength = 40;
            this.tb_Product_Company.Name = "tb_Product_Company";
            this.tb_Product_Company.Size = new System.Drawing.Size(266, 32);
            this.tb_Product_Company.TabIndex = 5;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(278, 370);
            this.tb_Product_Name.MaxLength = 80;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(263, 32);
            this.tb_Product_Name.TabIndex = 4;
            // 
            // lbl_Product_Company
            // 
            this.lbl_Product_Company.AutoSize = true;
            this.lbl_Product_Company.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Company.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Company.Location = new System.Drawing.Point(18, 484);
            this.lbl_Product_Company.Name = "lbl_Product_Company";
            this.lbl_Product_Company.Size = new System.Drawing.Size(227, 31);
            this.lbl_Product_Company.TabIndex = 11;
            this.lbl_Product_Company.Text = "Product Company";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Name.Location = new System.Drawing.Point(29, 368);
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
            this.lbl_SubCategory.Location = new System.Drawing.Point(29, 254);
            this.lbl_SubCategory.Name = "lbl_SubCategory";
            this.lbl_SubCategory.Size = new System.Drawing.Size(162, 31);
            this.lbl_SubCategory.TabIndex = 7;
            this.lbl_SubCategory.Text = "SubCategory";
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(278, 54);
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(263, 32);
            this.tb_Product_Id.TabIndex = 1;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.Black;
            this.lbl_Category.Location = new System.Drawing.Point(29, 146);
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
            this.lbl_Product_Id.Location = new System.Drawing.Point(29, 57);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(144, 31);
            this.lbl_Product_Id.TabIndex = 0;
            this.lbl_Product_Id.Text = "Product Id";
            // 
            // gb_Details
            // 
            this.gb_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Details.Controls.Add(this.dtp_Date);
            this.gb_Details.Controls.Add(this.cmb_Category);
            this.gb_Details.Controls.Add(this.cmb_SubCategory);
            this.gb_Details.Controls.Add(this.cmb_Supplier);
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
            this.dtp_Date.Location = new System.Drawing.Point(847, 45);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(283, 40);
            this.dtp_Date.TabIndex = 6;
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(278, 152);
            this.cmb_Category.MaxLength = 80;
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(266, 33);
            this.cmb_Category.TabIndex = 2;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SubCategory.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(278, 259);
            this.cmb_SubCategory.MaxLength = 80;
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(266, 33);
            this.cmb_SubCategory.TabIndex = 3;
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(847, 486);
            this.cmb_Supplier.MaxLength = 80;
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(283, 33);
            this.cmb_Supplier.TabIndex = 10;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(731, 660);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(155, 60);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Product_Details";
            this.Load += new System.EventHandler(this.frm_Add_Product_Details_Load);
            this.gb_Details.ResumeLayout(false);
            this.gb_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
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
        private System.Windows.Forms.Label lbl_Product_Company;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_SubCategory;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.GroupBox gb_Details;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.DateTimePicker dtp_Date;
    }
}