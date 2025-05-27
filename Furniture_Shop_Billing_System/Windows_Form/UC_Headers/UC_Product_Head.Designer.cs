
namespace Furniture_Shop_Billing_System.Windows_Form.UC_Headers
{
    partial class UC_Product_Head
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
            this.lbl_Product = new System.Windows.Forms.Label();
            this.btn_SubCategory = new System.Windows.Forms.Button();
            this.btn_Update_Product = new System.Windows.Forms.Button();
            this.btn_View_List = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Product.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.ForeColor = System.Drawing.Color.Black;
            this.lbl_Product.Location = new System.Drawing.Point(540, 14);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(164, 45);
            this.lbl_Product.TabIndex = 8;
            this.lbl_Product.Text = "Product";
            // 
            // btn_SubCategory
            // 
            this.btn_SubCategory.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubCategory.Location = new System.Drawing.Point(249, 89);
            this.btn_SubCategory.Name = "btn_SubCategory";
            this.btn_SubCategory.Size = new System.Drawing.Size(237, 47);
            this.btn_SubCategory.TabIndex = 1;
            this.btn_SubCategory.Text = "SubCategory";
            this.btn_SubCategory.UseVisualStyleBackColor = true;
            this.btn_SubCategory.Click += new System.EventHandler(this.btn_SubCategory_Click);
            // 
            // btn_Update_Product
            // 
            this.btn_Update_Product.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Product.Location = new System.Drawing.Point(815, 89);
            this.btn_Update_Product.Name = "btn_Update_Product";
            this.btn_Update_Product.Size = new System.Drawing.Size(236, 47);
            this.btn_Update_Product.TabIndex = 2;
            this.btn_Update_Product.Text = "Update Product";
            this.btn_Update_Product.UseVisualStyleBackColor = true;
            this.btn_Update_Product.Click += new System.EventHandler(this.btn_Update_Product_Click);
            // 
            // btn_View_List
            // 
            this.btn_View_List.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_List.Location = new System.Drawing.Point(1082, 89);
            this.btn_View_List.Name = "btn_View_List";
            this.btn_View_List.Size = new System.Drawing.Size(171, 47);
            this.btn_View_List.TabIndex = 9;
            this.btn_View_List.Text = "View List";
            this.btn_View_List.UseVisualStyleBackColor = true;
            this.btn_View_List.Click += new System.EventHandler(this.btn_View_List_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.Location = new System.Drawing.Point(25, 89);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(182, 47);
            this.btn_Category.TabIndex = 10;
            this.btn_Category.Text = "Category";
            this.btn_Category.UseVisualStyleBackColor = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.Location = new System.Drawing.Point(533, 89);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(237, 47);
            this.btn_Add_Product.TabIndex = 11;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.UseVisualStyleBackColor = true;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // UC_Product_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.btn_Category);
            this.Controls.Add(this.btn_View_List);
            this.Controls.Add(this.btn_SubCategory);
            this.Controls.Add(this.btn_Update_Product);
            this.Controls.Add(this.lbl_Product);
            this.Name = "UC_Product_Head";
            this.Size = new System.Drawing.Size(1265, 153);
            this.Load += new System.EventHandler(this.UC_Product_Head_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Button btn_SubCategory;
        private System.Windows.Forms.Button btn_Update_Product;
        private System.Windows.Forms.Button btn_View_List;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_Add_Product;
    }
}
