namespace WinheProjectInvoice
{
    partial class ViewInvoices
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
            this.dgv_showinvoices = new System.Windows.Forms.DataGridView();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_invoiceNo = new System.Windows.Forms.ComboBox();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.txt_searchtext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showinvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_showinvoices
            // 
            this.dgv_showinvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showinvoices.Location = new System.Drawing.Point(49, 91);
            this.dgv_showinvoices.Name = "dgv_showinvoices";
            this.dgv_showinvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_showinvoices.Size = new System.Drawing.Size(670, 214);
            this.dgv_showinvoices.TabIndex = 17;
            this.dgv_showinvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showproduct_CellContentClick);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(644, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 16;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(406, 48);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(49, 49);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(340, 20);
            this.txt_search.TabIndex = 14;
            // 
            // cmb_invoiceNo
            // 
            this.cmb_invoiceNo.FormattingEnabled = true;
            this.cmb_invoiceNo.Location = new System.Drawing.Point(550, 50);
            this.cmb_invoiceNo.Name = "cmb_invoiceNo";
            this.cmb_invoiceNo.Size = new System.Drawing.Size(88, 21);
            this.cmb_invoiceNo.TabIndex = 21;
            this.cmb_invoiceNo.SelectedIndexChanged += new System.EventHandler(this.cmb_invoiceNo_SelectedIndexChanged);
            // 
            // btn_invoice
            // 
            this.btn_invoice.Location = new System.Drawing.Point(563, 12);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(75, 23);
            this.btn_invoice.TabIndex = 22;
            this.btn_invoice.Text = "Invoice";
            this.btn_invoice.UseVisualStyleBackColor = true;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // txt_searchtext
            // 
            this.txt_searchtext.Location = new System.Drawing.Point(644, 50);
            this.txt_searchtext.Name = "txt_searchtext";
            this.txt_searchtext.Size = new System.Drawing.Size(75, 23);
            this.txt_searchtext.TabIndex = 23;
            this.txt_searchtext.Text = "Search";
            this.txt_searchtext.UseVisualStyleBackColor = true;
            this.txt_searchtext.Click += new System.EventHandler(this.txt_searchtext_Click);
            // 
            // ViewInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 397);
            this.Controls.Add(this.txt_searchtext);
            this.Controls.Add(this.btn_invoice);
            this.Controls.Add(this.cmb_invoiceNo);
            this.Controls.Add(this.dgv_showinvoices);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Name = "ViewInvoices";
            this.Text = "ViewInvoices";
            this.Load += new System.EventHandler(this.ViewInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showinvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_showinvoices;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_invoiceNo;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.Button txt_searchtext;
    }
}