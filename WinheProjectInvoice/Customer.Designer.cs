namespace WinheProjectInvoice
{
    partial class Customer
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
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_addcustomer = new System.Windows.Forms.Button();
            this.dgv_showcustomers = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showcustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.Location = new System.Drawing.Point(583, 30);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 10;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_addcustomer
            // 
            this.btn_addcustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addcustomer.Location = new System.Drawing.Point(562, 342);
            this.btn_addcustomer.Name = "btn_addcustomer";
            this.btn_addcustomer.Size = new System.Drawing.Size(96, 23);
            this.btn_addcustomer.TabIndex = 9;
            this.btn_addcustomer.Text = "Add Customers";
            this.btn_addcustomer.UseVisualStyleBackColor = false;
            this.btn_addcustomer.Click += new System.EventHandler(this.btn_addcustomer_Click);
            // 
            // dgv_showcustomers
            // 
            this.dgv_showcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showcustomers.Location = new System.Drawing.Point(74, 79);
            this.dgv_showcustomers.Name = "dgv_showcustomers";
            this.dgv_showcustomers.Size = new System.Drawing.Size(584, 222);
            this.dgv_showcustomers.TabIndex = 8;
            this.dgv_showcustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showcustomers_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(409, 32);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(74, 32);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(313, 20);
            this.txt_search.TabIndex = 6;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(733, 394);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_addcustomer);
            this.Controls.Add(this.dgv_showcustomers);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showcustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_addcustomer;
        private System.Windows.Forms.DataGridView dgv_showcustomers;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}