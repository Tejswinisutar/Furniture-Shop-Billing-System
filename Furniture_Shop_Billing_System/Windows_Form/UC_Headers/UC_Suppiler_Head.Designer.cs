
namespace Furniture_Shop_Billing_System.Windows_Form.UC_Headers
{
    partial class UC_Suppiler_Head
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
            this.btn_Update_Supplier = new System.Windows.Forms.Button();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.btn_Add_Supplier = new System.Windows.Forms.Button();
            this.btn_View_List = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Update_Supplier
            // 
            this.btn_Update_Supplier.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Supplier.Location = new System.Drawing.Point(502, 91);
            this.btn_Update_Supplier.Name = "btn_Update_Supplier";
            this.btn_Update_Supplier.Size = new System.Drawing.Size(248, 47);
            this.btn_Update_Supplier.TabIndex = 2;
            this.btn_Update_Supplier.Text = "Update Supplier";
            this.btn_Update_Supplier.UseVisualStyleBackColor = true;
            this.btn_Update_Supplier.Click += new System.EventHandler(this.btn_Update_Suppiler_Click);
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Supplier.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.ForeColor = System.Drawing.Color.Black;
            this.lbl_Supplier.Location = new System.Drawing.Point(505, 15);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(177, 45);
            this.lbl_Supplier.TabIndex = 6;
            this.lbl_Supplier.Text = "Supplier";
            // 
            // btn_Add_Supplier
            // 
            this.btn_Add_Supplier.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Supplier.Location = new System.Drawing.Point(95, 91);
            this.btn_Add_Supplier.Name = "btn_Add_Supplier";
            this.btn_Add_Supplier.Size = new System.Drawing.Size(237, 47);
            this.btn_Add_Supplier.TabIndex = 1;
            this.btn_Add_Supplier.Text = "Add Supplier";
            this.btn_Add_Supplier.UseVisualStyleBackColor = true;
            this.btn_Add_Supplier.Click += new System.EventHandler(this.btn_Add_Suppiler_Click);
            // 
            // btn_View_List
            // 
            this.btn_View_List.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_List.Location = new System.Drawing.Point(968, 91);
            this.btn_View_List.Name = "btn_View_List";
            this.btn_View_List.Size = new System.Drawing.Size(248, 47);
            this.btn_View_List.TabIndex = 7;
            this.btn_View_List.Text = "View List";
            this.btn_View_List.UseVisualStyleBackColor = true;
            this.btn_View_List.Click += new System.EventHandler(this.btn_View_List_Click);
            // 
            // UC_Suppiler_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btn_View_List);
            this.Controls.Add(this.btn_Add_Supplier);
            this.Controls.Add(this.lbl_Supplier);
            this.Controls.Add(this.btn_Update_Supplier);
            this.Name = "UC_Suppiler_Head";
            this.Size = new System.Drawing.Size(1265, 153);
            this.Load += new System.EventHandler(this.UC_Suppiler_Head_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Update_Supplier;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Button btn_Add_Supplier;
        private System.Windows.Forms.Button btn_View_List;
    }
}
