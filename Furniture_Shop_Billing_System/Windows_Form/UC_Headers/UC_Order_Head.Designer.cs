
namespace Furniture_Shop_Billing_System.Windows_Form.UC_Headers
{
    partial class UC_Order_Head
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
            this.btn_Receive_Order = new System.Windows.Forms.Button();
            this.btn_Order_Payment = new System.Windows.Forms.Button();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Receive_Order
            // 
            this.btn_Receive_Order.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Receive_Order.Location = new System.Drawing.Point(117, 83);
            this.btn_Receive_Order.Name = "btn_Receive_Order";
            this.btn_Receive_Order.Size = new System.Drawing.Size(237, 47);
            this.btn_Receive_Order.TabIndex = 11;
            this.btn_Receive_Order.Text = "Receive Order";
            this.btn_Receive_Order.UseVisualStyleBackColor = true;
            this.btn_Receive_Order.Click += new System.EventHandler(this.btn_Receive_Order_Click);
            // 
            // btn_Order_Payment
            // 
            this.btn_Order_Payment.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order_Payment.Location = new System.Drawing.Point(919, 83);
            this.btn_Order_Payment.Name = "btn_Order_Payment";
            this.btn_Order_Payment.Size = new System.Drawing.Size(237, 47);
            this.btn_Order_Payment.TabIndex = 9;
            this.btn_Order_Payment.Text = "Order Payment";
            this.btn_Order_Payment.UseVisualStyleBackColor = true;
            this.btn_Order_Payment.Click += new System.EventHandler(this.btn_Order_Payment_Click);
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Order.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order.ForeColor = System.Drawing.Color.Black;
            this.lbl_Order.Location = new System.Drawing.Point(561, 22);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(124, 45);
            this.lbl_Order.TabIndex = 10;
            this.lbl_Order.Text = "Order";
            // 
            // UC_Order_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btn_Receive_Order);
            this.Controls.Add(this.btn_Order_Payment);
            this.Controls.Add(this.lbl_Order);
            this.Name = "UC_Order_Head";
            this.Size = new System.Drawing.Size(1265, 153);
            this.Load += new System.EventHandler(this.UC_Order_Head_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Receive_Order;
        private System.Windows.Forms.Button btn_Order_Payment;
        private System.Windows.Forms.Label lbl_Order;
    }
}
