
namespace Furniture_Shop_Billing_System.Reports.ReportForms
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
            this.crv_Receive_Order = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Receive_Order
            // 
            this.crv_Receive_Order.ActiveViewIndex = -1;
            this.crv_Receive_Order.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Receive_Order.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Receive_Order.DisplayStatusBar = false;
            this.crv_Receive_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Receive_Order.Location = new System.Drawing.Point(0, 0);
            this.crv_Receive_Order.Name = "crv_Receive_Order";
            this.crv_Receive_Order.Size = new System.Drawing.Size(1171, 914);
            this.crv_Receive_Order.TabIndex = 0;
            this.crv_Receive_Order.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Receive_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 914);
            this.Controls.Add(this.crv_Receive_Order);
            this.Name = "frm_Receive_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Receive_Order";
            this.Load += new System.EventHandler(this.frm_Receive_Order_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Receive_Order;
    }
}