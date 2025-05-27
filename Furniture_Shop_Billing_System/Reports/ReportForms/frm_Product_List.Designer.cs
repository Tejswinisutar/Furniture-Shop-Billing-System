
namespace Furniture_Shop_Billing_System.Reports.ReportForms
{
    partial class frm_Product_List
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
            this.crv_Product_List = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Product_List
            // 
            this.crv_Product_List.ActiveViewIndex = -1;
            this.crv_Product_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Product_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Product_List.DisplayStatusBar = false;
            this.crv_Product_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Product_List.Location = new System.Drawing.Point(0, 0);
            this.crv_Product_List.Name = "crv_Product_List";
            this.crv_Product_List.ShowCloseButton = false;
            this.crv_Product_List.ShowCopyButton = false;
            this.crv_Product_List.ShowExportButton = false;
            this.crv_Product_List.ShowGotoPageButton = false;
            this.crv_Product_List.ShowGroupTreeButton = false;
            this.crv_Product_List.ShowParameterPanelButton = false;
            this.crv_Product_List.ShowRefreshButton = false;
            this.crv_Product_List.ShowTextSearchButton = false;
            this.crv_Product_List.ShowZoomButton = false;
            this.crv_Product_List.Size = new System.Drawing.Size(1171, 914);
            this.crv_Product_List.TabIndex = 0;
            this.crv_Product_List.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 914);
            this.Controls.Add(this.crv_Product_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product List Report";
            this.Load += new System.EventHandler(this.frm_Product_List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Product_List;
    }
}