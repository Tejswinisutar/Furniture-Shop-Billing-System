
namespace Furniture_Shop_Billing_System.Windows_Form.Employee
{
    partial class frm_Employee_View_List
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
            this.dgv_Employee_List = new System.Windows.Forms.DataGridView();
            this.lbl_Employee_View_List = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Employee_List
            // 
            this.dgv_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_List.Location = new System.Drawing.Point(26, 94);
            this.dgv_Employee_List.Name = "dgv_Employee_List";
            this.dgv_Employee_List.RowHeadersWidth = 51;
            this.dgv_Employee_List.RowTemplate.Height = 24;
            this.dgv_Employee_List.Size = new System.Drawing.Size(1212, 639);
            this.dgv_Employee_List.TabIndex = 14;
            this.dgv_Employee_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employee_List_CellContentClick);
            // 
            // lbl_Employee_View_List
            // 
            this.lbl_Employee_View_List.AutoSize = true;
            this.lbl_Employee_View_List.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_View_List.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee_View_List.Location = new System.Drawing.Point(432, 26);
            this.lbl_Employee_View_List.Name = "lbl_Employee_View_List";
            this.lbl_Employee_View_List.Size = new System.Drawing.Size(335, 40);
            this.lbl_Employee_View_List.TabIndex = 16;
            this.lbl_Employee_View_List.Text = "Employee View List";
            // 
            // frm_Employee_View_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 758);
            this.Controls.Add(this.lbl_Employee_View_List);
            this.Controls.Add(this.dgv_Employee_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Employee_View_List";
            this.Text = "frm_Employee_View_List";
            this.Load += new System.EventHandler(this.frm_Employee_View_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Employee_List;
        private System.Windows.Forms.Label lbl_Employee_View_List;
    }
}