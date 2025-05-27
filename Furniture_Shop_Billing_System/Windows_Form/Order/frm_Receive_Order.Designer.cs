
namespace Furniture_Shop_Billing_System.Windows_Form.Order
{
    partial class frm_Receive_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Order_Details = new System.Windows.Forms.GroupBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.cmb_Supplier_Name = new System.Windows.Forms.ComboBox();
            this.dtp_Order_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Order_Id = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Order_Date = new System.Windows.Forms.Label();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Order_Id = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Purchase_Receive = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_SubCategory = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_SubCategory = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Order_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Receive)).BeginInit();
            this.gb_Purchase_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Order_Details
            // 
            this.gb_Order_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Order_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Order_Details.Controls.Add(this.cmb_Supplier_Name);
            this.gb_Order_Details.Controls.Add(this.dtp_Order_Date);
            this.gb_Order_Details.Controls.Add(this.tb_Order_Id);
            this.gb_Order_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Order_Details.Controls.Add(this.lbl_Order_Date);
            this.gb_Order_Details.Controls.Add(this.lbl_Supplier_Name);
            this.gb_Order_Details.Controls.Add(this.lbl_Order_Id);
            this.gb_Order_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Order_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Order_Details.Location = new System.Drawing.Point(12, 12);
            this.gb_Order_Details.Name = "gb_Order_Details";
            this.gb_Order_Details.Size = new System.Drawing.Size(1241, 147);
            this.gb_Order_Details.TabIndex = 30;
            this.gb_Order_Details.TabStop = false;
            this.gb_Order_Details.Text = "Order Details";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(903, 96);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(298, 32);
            this.tb_Mobile_No.TabIndex = 4;
            // 
            // cmb_Supplier_Name
            // 
            this.cmb_Supplier_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Supplier_Name.FormattingEnabled = true;
            this.cmb_Supplier_Name.Location = new System.Drawing.Point(308, 97);
            this.cmb_Supplier_Name.Name = "cmb_Supplier_Name";
            this.cmb_Supplier_Name.Size = new System.Drawing.Size(298, 33);
            this.cmb_Supplier_Name.TabIndex = 2;
            this.cmb_Supplier_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Suppiler_Name_SelectedIndexChanged);
            this.cmb_Supplier_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Supplier_Name_KeyPress);
            // 
            // dtp_Order_Date
            // 
            this.dtp_Order_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Order_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Order_Date.Location = new System.Drawing.Point(903, 28);
            this.dtp_Order_Date.Name = "dtp_Order_Date";
            this.dtp_Order_Date.Size = new System.Drawing.Size(298, 40);
            this.dtp_Order_Date.TabIndex = 3;
            // 
            // tb_Order_Id
            // 
            this.tb_Order_Id.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Order_Id.Location = new System.Drawing.Point(308, 28);
            this.tb_Order_Id.Name = "tb_Order_Id";
            this.tb_Order_Id.Size = new System.Drawing.Size(298, 32);
            this.tb_Order_Id.TabIndex = 1;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(684, 99);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(146, 31);
            this.lbl_Mobile_No.TabIndex = 3;
            this.lbl_Mobile_No.Text = "Mobile  No";
            // 
            // lbl_Order_Date
            // 
            this.lbl_Order_Date.AutoSize = true;
            this.lbl_Order_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Order_Date.Location = new System.Drawing.Point(684, 34);
            this.lbl_Order_Date.Name = "lbl_Order_Date";
            this.lbl_Order_Date.Size = new System.Drawing.Size(148, 31);
            this.lbl_Order_Date.TabIndex = 2;
            this.lbl_Order_Date.Text = "Order Date";
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(23, 97);
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
            this.lbl_Order_Id.Location = new System.Drawing.Point(23, 35);
            this.lbl_Order_Id.Name = "lbl_Order_Id";
            this.lbl_Order_Id.Size = new System.Drawing.Size(118, 31);
            this.lbl_Order_Id.TabIndex = 0;
            this.lbl_Order_Id.Text = "Order Id";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Red;
            this.btn_Add.Location = new System.Drawing.Point(1128, 43);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 82);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Purchase_Receive
            // 
            this.dgv_Purchase_Receive.AllowUserToAddRows = false;
            this.dgv_Purchase_Receive.AllowUserToDeleteRows = false;
            this.dgv_Purchase_Receive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Purchase_Receive.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Purchase_Receive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Purchase_Receive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Receive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Category,
            this.SubCategory,
            this.Product_Name,
            this.Quantity,
            this.Sale_Price,
            this.Total});
            this.dgv_Purchase_Receive.Location = new System.Drawing.Point(29, 148);
            this.dgv_Purchase_Receive.Name = "dgv_Purchase_Receive";
            this.dgv_Purchase_Receive.ReadOnly = true;
            this.dgv_Purchase_Receive.RowHeadersWidth = 51;
            this.dgv_Purchase_Receive.RowTemplate.Height = 24;
            this.dgv_Purchase_Receive.Size = new System.Drawing.Size(1191, 277);
            this.dgv_Purchase_Receive.TabIndex = 20;
            // 
            // Sr_No
            // 
            this.Sr_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sr_No.HeaderText = "Sr.No.";
            this.Sr_No.MinimumWidth = 6;
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            this.Sr_No.Width = 91;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // SubCategory
            // 
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.MinimumWidth = 6;
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Sale_Price
            // 
            this.Sale_Price.HeaderText = "Purchase Price";
            this.Sale_Price.MinimumWidth = 6;
            this.Sale_Price.Name = "Sale_Price";
            this.Sale_Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(992, 436);
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(191, 32);
            this.tb_Final_Bill.TabIndex = 14;
            this.tb_Final_Bill.Text = "0";
            // 
            // tb_GST
            // 
            this.tb_GST.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(599, 439);
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(121, 32);
            this.tb_GST.TabIndex = 13;
            this.tb_GST.Text = "0";
            this.tb_GST.TextChanged += new System.EventHandler(this.tb_GST_TextChanged);
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(211, 439);
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(172, 32);
            this.tb_Total_Bill.TabIndex = 12;
            this.tb_Total_Bill.Text = "0";
            // 
            // tb_Total
            // 
            this.tb_Total.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(922, 101);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(174, 32);
            this.tb_Total.TabIndex = 10;
            this.tb_Total.Text = "0";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(555, 93);
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(165, 32);
            this.tb_Purchase_Price.TabIndex = 9;
            this.tb_Purchase_Price.Text = "0";
            this.tb_Purchase_Price.TextChanged += new System.EventHandler(this.tb_Purchase_Price_TextChanged);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(922, 35);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(174, 33);
            this.cmb_Product_Name.TabIndex = 7;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // cmb_SubCategory
            // 
            this.cmb_SubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SubCategory.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SubCategory.FormattingEnabled = true;
            this.cmb_SubCategory.Location = new System.Drawing.Point(555, 31);
            this.cmb_SubCategory.Name = "cmb_SubCategory";
            this.cmb_SubCategory.Size = new System.Drawing.Size(165, 33);
            this.cmb_SubCategory.TabIndex = 6;
            this.cmb_SubCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SubCategory_SelectedIndexChanged);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cmb_Category.Location = new System.Drawing.Point(149, 27);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(179, 33);
            this.cmb_Category.TabIndex = 5;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(797, 440);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(138, 31);
            this.lbl_Final_Bill.TabIndex = 9;
            this.lbl_Final_Bill.Text = "Final Bill";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(149, 96);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(179, 32);
            this.tb_Quantity.TabIndex = 8;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.ForeColor = System.Drawing.Color.Black;
            this.lbl_GST.Location = new System.Drawing.Point(464, 440);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(68, 31);
            this.lbl_GST.TabIndex = 7;
            this.lbl_GST.Text = "GST";
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(40, 438);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(133, 31);
            this.lbl_Total_Bill.TabIndex = 6;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.Black;
            this.lbl_Total.Location = new System.Drawing.Point(740, 99);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(77, 31);
            this.lbl_Total.TabIndex = 5;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product_Name.Location = new System.Drawing.Point(726, 35);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(187, 31);
            this.lbl_Product_Name.TabIndex = 4;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_SubCategory
            // 
            this.lbl_SubCategory.AutoSize = true;
            this.lbl_SubCategory.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubCategory.ForeColor = System.Drawing.Color.Black;
            this.lbl_SubCategory.Location = new System.Drawing.Point(348, 31);
            this.lbl_SubCategory.Name = "lbl_SubCategory";
            this.lbl_SubCategory.Size = new System.Drawing.Size(162, 31);
            this.lbl_SubCategory.TabIndex = 2;
            this.lbl_SubCategory.Text = "SubCategory";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Black;
            this.lbl_Quantity.Location = new System.Drawing.Point(12, 94);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(120, 31);
            this.lbl_Quantity.TabIndex = 1;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.Black;
            this.lbl_Category.Location = new System.Drawing.Point(12, 25);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(116, 31);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(333, 686);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(189, 60);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // gb_Purchase_Details
            // 
            this.gb_Purchase_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Purchase_Details.Controls.Add(this.btn_Add);
            this.gb_Purchase_Details.Controls.Add(this.dgv_Purchase_Receive);
            this.gb_Purchase_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Purchase_Details.Controls.Add(this.tb_GST);
            this.gb_Purchase_Details.Controls.Add(this.tb_Total_Bill);
            this.gb_Purchase_Details.Controls.Add(this.tb_Total);
            this.gb_Purchase_Details.Controls.Add(this.tb_Purchase_Price);
            this.gb_Purchase_Details.Controls.Add(this.tb_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.cmb_SubCategory);
            this.gb_Purchase_Details.Controls.Add(this.cmb_Category);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Final_Bill);
            this.gb_Purchase_Details.Controls.Add(this.lbl_GST);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Total_Bill);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Total);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Purchase_Details.Controls.Add(this.lbl_SubCategory);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Category);
            this.gb_Purchase_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Purchase_Details.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Purchase_Details.Location = new System.Drawing.Point(12, 174);
            this.gb_Purchase_Details.Name = "gb_Purchase_Details";
            this.gb_Purchase_Details.Size = new System.Drawing.Size(1241, 487);
            this.gb_Purchase_Details.TabIndex = 40;
            this.gb_Purchase_Details.TabStop = false;
            this.gb_Purchase_Details.Text = "Purchase Details";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(334, 94);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(198, 31);
            this.lbl_Purchase_Price.TabIndex = 3;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(729, 686);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(181, 60);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Receive_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Order_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Purchase_Details);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Receive_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Receive_Order";
            this.Load += new System.EventHandler(this.frm_Receive_Order_Load);
            this.gb_Order_Details.ResumeLayout(false);
            this.gb_Order_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Receive)).EndInit();
            this.gb_Purchase_Details.ResumeLayout(false);
            this.gb_Purchase_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Order_Details;
        private System.Windows.Forms.DateTimePicker dtp_Order_Date;
        private System.Windows.Forms.TextBox tb_Order_Id;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Order_Date;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Label lbl_Order_Id;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Purchase_Receive;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_SubCategory;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_SubCategory;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox gb_Purchase_Details;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Supplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox tb_Mobile_No;
    }
}