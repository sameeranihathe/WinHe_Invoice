namespace WinheProjectInvoice
{
    partial class Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_invoices = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "All Rights are reserved by Winhe IT.Copy Rights ";
            // 
            // btn_invoices
            // 
            this.btn_invoices.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_invoices.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoices.Location = new System.Drawing.Point(443, 135);
            this.btn_invoices.Name = "btn_invoices";
            this.btn_invoices.Size = new System.Drawing.Size(182, 83);
            this.btn_invoices.TabIndex = 8;
            this.btn_invoices.Text = "Invoices";
            this.btn_invoices.UseVisualStyleBackColor = false;
            this.btn_invoices.Click += new System.EventHandler(this.btn_invoices_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_customers.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Location = new System.Drawing.Point(255, 135);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(182, 83);
            this.btn_customers.TabIndex = 7;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_products
            // 
            this.btn_products.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_products.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.Location = new System.Drawing.Point(67, 135);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(182, 83);
            this.btn_products.TabIndex = 6;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = false;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Winhe IT";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(689, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_invoices);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_invoices;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Label label1;
    }
}