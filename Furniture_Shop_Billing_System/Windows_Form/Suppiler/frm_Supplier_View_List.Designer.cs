
namespace Furniture_Shop_Billing_System.Windows_Form.Suppiler
{
    partial class frm_Supplier_View_List
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
            this.dgv_Supplier_List = new System.Windows.Forms.DataGridView();
            this.lbl_Supplier_View_List = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Supplier_List
            // 
            this.dgv_Supplier_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Supplier_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier_List.Location = new System.Drawing.Point(26, 86);
            this.dgv_Supplier_List.Name = "dgv_Supplier_List";
            this.dgv_Supplier_List.RowHeadersWidth = 51;
            this.dgv_Supplier_List.RowTemplate.Height = 24;
            this.dgv_Supplier_List.Size = new System.Drawing.Size(1212, 624);
            this.dgv_Supplier_List.TabIndex = 11;
            // 
            // lbl_Supplier_View_List
            // 
            this.lbl_Supplier_View_List.AutoSize = true;
            this.lbl_Supplier_View_List.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_View_List.ForeColor = System.Drawing.Color.Red;
            this.lbl_Supplier_View_List.Location = new System.Drawing.Point(455, 23);
            this.lbl_Supplier_View_List.Name = "lbl_Supplier_View_List";
            this.lbl_Supplier_View_List.Size = new System.Drawing.Size(314, 40);
            this.lbl_Supplier_View_List.TabIndex = 15;
            this.lbl_Supplier_View_List.Text = "Supplier View List";
            // 
            // frm_Supplier_View_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.Controls.Add(this.lbl_Supplier_View_List);
            this.Controls.Add(this.dgv_Supplier_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Supplier_View_List";
            this.Text = "Supplier_View_List";
            this.Load += new System.EventHandler(this.frm_Supplier_View_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Supplier_List;
        private System.Windows.Forms.Label lbl_Supplier_View_List;
    }
}