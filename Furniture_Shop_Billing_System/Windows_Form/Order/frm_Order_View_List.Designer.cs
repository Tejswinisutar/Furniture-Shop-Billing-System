
namespace Furniture_Shop_Billing_System.Windows_Form.Order
{
    partial class frm_Order_View_List
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
            this.lbl_Order_View_List = new System.Windows.Forms.Label();
            this.dgv_Order_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Order_View_List
            // 
            this.lbl_Order_View_List.AutoSize = true;
            this.lbl_Order_View_List.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order_View_List.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Order_View_List.Location = new System.Drawing.Point(486, 30);
            this.lbl_Order_View_List.Name = "lbl_Order_View_List";
            this.lbl_Order_View_List.Size = new System.Drawing.Size(270, 40);
            this.lbl_Order_View_List.TabIndex = 17;
            this.lbl_Order_View_List.Text = "Order View List";
            // 
            // dgv_Order_List
            // 
            this.dgv_Order_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order_List.Location = new System.Drawing.Point(26, 93);
            this.dgv_Order_List.Name = "dgv_Order_List";
            this.dgv_Order_List.RowHeadersWidth = 51;
            this.dgv_Order_List.RowTemplate.Height = 24;
            this.dgv_Order_List.Size = new System.Drawing.Size(1212, 630);
            this.dgv_Order_List.TabIndex = 16;
            // 
            // frm_Order_View_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.Controls.Add(this.lbl_Order_View_List);
            this.Controls.Add(this.dgv_Order_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Order_View_List";
            this.Text = "frm_Order_View_List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Order_View_List;
        private System.Windows.Forms.DataGridView dgv_Order_List;
    }
}