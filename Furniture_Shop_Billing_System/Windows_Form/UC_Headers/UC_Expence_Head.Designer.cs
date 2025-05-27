
namespace Furniture_Shop_Billing_System.Windows_Form.UC_Headers
{
    partial class UC_Expence_Head
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
            this.btn_Add_Expence = new System.Windows.Forms.Button();
            this.btn_View_List = new System.Windows.Forms.Button();
            this.lbl_Expence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Add_Expence
            // 
            this.btn_Add_Expence.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Expence.Location = new System.Drawing.Point(105, 84);
            this.btn_Add_Expence.Name = "btn_Add_Expence";
            this.btn_Add_Expence.Size = new System.Drawing.Size(237, 47);
            this.btn_Add_Expence.TabIndex = 1;
            this.btn_Add_Expence.Text = "Add Expence";
            this.btn_Add_Expence.UseVisualStyleBackColor = true;
            this.btn_Add_Expence.Click += new System.EventHandler(this.btn_Add_Expence_Click);
            // 
            // btn_View_List
            // 
            this.btn_View_List.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_List.Location = new System.Drawing.Point(911, 84);
            this.btn_View_List.Name = "btn_View_List";
            this.btn_View_List.Size = new System.Drawing.Size(221, 47);
            this.btn_View_List.TabIndex = 2;
            this.btn_View_List.Text = "View List";
            this.btn_View_List.UseVisualStyleBackColor = true;
            this.btn_View_List.Click += new System.EventHandler(this.btn_View_List_Click);
            // 
            // lbl_Expence
            // 
            this.lbl_Expence.AutoSize = true;
            this.lbl_Expence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Expence.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence.ForeColor = System.Drawing.Color.Black;
            this.lbl_Expence.Location = new System.Drawing.Point(537, 20);
            this.lbl_Expence.Name = "lbl_Expence";
            this.lbl_Expence.Size = new System.Drawing.Size(172, 45);
            this.lbl_Expence.TabIndex = 10;
            this.lbl_Expence.Text = "Expence";
            // 
            // UC_Expence_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btn_Add_Expence);
            this.Controls.Add(this.btn_View_List);
            this.Controls.Add(this.lbl_Expence);
            this.Name = "UC_Expence_Head";
            this.Size = new System.Drawing.Size(1265, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Expence;
        private System.Windows.Forms.Button btn_View_List;
        private System.Windows.Forms.Label lbl_Expence;
    }
}
