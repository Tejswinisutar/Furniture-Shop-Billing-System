
namespace Furniture_Shop_Billing_System.Reports.ReportForms
{
    partial class frm_Customer_Montnhly_List
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
            this.crv_Customer_View_List = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtp_Todt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Fdt = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crv_Customer_View_List
            // 
            this.crv_Customer_View_List.ActiveViewIndex = -1;
            this.crv_Customer_View_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_View_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_View_List.DisplayStatusBar = false;
            this.crv_Customer_View_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Customer_View_List.Location = new System.Drawing.Point(0, 137);
            this.crv_Customer_View_List.Name = "crv_Customer_View_List";
            this.crv_Customer_View_List.Size = new System.Drawing.Size(1171, 777);
            this.crv_Customer_View_List.TabIndex = 0;
            this.crv_Customer_View_List.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp_Todt
            // 
            this.dtp_Todt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Todt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Todt.Location = new System.Drawing.Point(553, 53);
            this.dtp_Todt.Name = "dtp_Todt";
            this.dtp_Todt.Size = new System.Drawing.Size(200, 32);
            this.dtp_Todt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            // 
            // dtp_Fdt
            // 
            this.dtp_Fdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fdt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fdt.Location = new System.Drawing.Point(139, 48);
            this.dtp_Fdt.Name = "dtp_Fdt";
            this.dtp_Fdt.Size = new System.Drawing.Size(200, 32);
            this.dtp_Fdt.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(935, 47);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(134, 41);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_To.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(430, 50);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(45, 31);
            this.lbl_To.TabIndex = 20;
            this.lbl_To.Text = "To";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_From.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(34, 47);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(81, 31);
            this.lbl_From.TabIndex = 19;
            this.lbl_From.Text = "From";
            // 
            // frm_Customer_Montnhly_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 914);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.dtp_Todt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Fdt);
            this.Controls.Add(this.crv_Customer_View_List);
            this.Name = "frm_Customer_Montnhly_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Customer_Montnhly_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_View_List;
        private System.Windows.Forms.DateTimePicker dtp_Todt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Fdt;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
    }
}