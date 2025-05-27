
namespace Furniture_Shop_Billing_System.Reports.ReportForms
{
    partial class frm_Customer_Bill
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
            this.crv_Customer_Bill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Customer_Bill
            // 
            this.crv_Customer_Bill.ActiveViewIndex = -1;
            this.crv_Customer_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_Bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_Bill.DisplayStatusBar = false;
            this.crv_Customer_Bill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Customer_Bill.Location = new System.Drawing.Point(0, 1);
            this.crv_Customer_Bill.Name = "crv_Customer_Bill";
            this.crv_Customer_Bill.Size = new System.Drawing.Size(1171, 913);
            this.crv_Customer_Bill.TabIndex = 0;
            this.crv_Customer_Bill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Customer_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 914);
            this.Controls.Add(this.crv_Customer_Bill);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Purchase List";
            this.Load += new System.EventHandler(this.frm_Customer_Purchase_List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_Bill;
    }
}