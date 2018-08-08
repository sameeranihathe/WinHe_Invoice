namespace WinheProjectInvoice
{
    partial class Invoice
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
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_searchcustomer = new System.Windows.Forms.Button();
            this.lbl_showcustomerName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_invoice2show = new System.Windows.Forms.DataGridView();
            this.btn_addinvoice = new System.Windows.Forms.Button();
            this.txt_quntity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_showproductname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_showproductid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_viewinvoice = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_invoicesearch = new System.Windows.Forms.TextBox();
            this.dgv_invoiceshow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice2show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceshow)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(592, 551);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(114, 23);
            this.btn_print.TabIndex = 64;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_searchcustomer
            // 
            this.btn_searchcustomer.Location = new System.Drawing.Point(156, 551);
            this.btn_searchcustomer.Name = "btn_searchcustomer";
            this.btn_searchcustomer.Size = new System.Drawing.Size(114, 23);
            this.btn_searchcustomer.TabIndex = 63;
            this.btn_searchcustomer.Text = "Search Customer";
            this.btn_searchcustomer.UseVisualStyleBackColor = true;
            this.btn_searchcustomer.Click += new System.EventHandler(this.btn_searchcustomer_Click);
            // 
            // lbl_showcustomerName
            // 
            this.lbl_showcustomerName.AutoSize = true;
            this.lbl_showcustomerName.Location = new System.Drawing.Point(91, 556);
            this.lbl_showcustomerName.Name = "lbl_showcustomerName";
            this.lbl_showcustomerName.Size = new System.Drawing.Size(0, 13);
            this.lbl_showcustomerName.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Customer :";
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Location = new System.Drawing.Point(592, 503);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(100, 20);
            this.txt_totalprice.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Total Price :";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(404, 503);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(100, 20);
            this.txt_discount.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Descount:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(223, 503);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Total:";
            // 
            // dgv_invoice2show
            // 
            this.dgv_invoice2show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice2show.Location = new System.Drawing.Point(29, 338);
            this.dgv_invoice2show.Name = "dgv_invoice2show";
            this.dgv_invoice2show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_invoice2show.Size = new System.Drawing.Size(675, 150);
            this.dgv_invoice2show.TabIndex = 54;
            this.dgv_invoice2show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoice2show_CellClick);
            this.dgv_invoice2show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoice2show_CellContentClick);
            // 
            // btn_addinvoice
            // 
            this.btn_addinvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addinvoice.Location = new System.Drawing.Point(610, 298);
            this.btn_addinvoice.Name = "btn_addinvoice";
            this.btn_addinvoice.Size = new System.Drawing.Size(96, 23);
            this.btn_addinvoice.TabIndex = 53;
            this.btn_addinvoice.Text = "Add Invoice";
            this.btn_addinvoice.UseVisualStyleBackColor = false;
            this.btn_addinvoice.Click += new System.EventHandler(this.btn_addinvoice_Click);
            // 
            // txt_quntity
            // 
            this.txt_quntity.Location = new System.Drawing.Point(491, 300);
            this.txt_quntity.Name = "txt_quntity";
            this.txt_quntity.Size = new System.Drawing.Size(100, 20);
            this.txt_quntity.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Qty :";
            // 
            // lbl_showproductname
            // 
            this.lbl_showproductname.AutoSize = true;
            this.lbl_showproductname.Location = new System.Drawing.Point(266, 303);
            this.lbl_showproductname.Name = "lbl_showproductname";
            this.lbl_showproductname.Size = new System.Drawing.Size(0, 13);
            this.lbl_showproductname.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Product Name :";
            // 
            // lbl_showproductid
            // 
            this.lbl_showproductid.AutoSize = true;
            this.lbl_showproductid.Location = new System.Drawing.Point(91, 303);
            this.lbl_showproductid.Name = "lbl_showproductid";
            this.lbl_showproductid.Size = new System.Drawing.Size(0, 13);
            this.lbl_showproductid.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Product Id :";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.Location = new System.Drawing.Point(592, 51);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(105, 23);
            this.btn_home.TabIndex = 46;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_viewinvoice
            // 
            this.btn_viewinvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewinvoice.Location = new System.Drawing.Point(472, 51);
            this.btn_viewinvoice.Name = "btn_viewinvoice";
            this.btn_viewinvoice.Size = new System.Drawing.Size(105, 23);
            this.btn_viewinvoice.TabIndex = 45;
            this.btn_viewinvoice.Text = "View All Invoice";
            this.btn_viewinvoice.UseVisualStyleBackColor = false;
            this.btn_viewinvoice.Click += new System.EventHandler(this.btn_viewinvoice_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(472, 97);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 23);
            this.btn_search.TabIndex = 44;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_invoicesearch
            // 
            this.txt_invoicesearch.Location = new System.Drawing.Point(29, 100);
            this.txt_invoicesearch.Name = "txt_invoicesearch";
            this.txt_invoicesearch.Size = new System.Drawing.Size(396, 20);
            this.txt_invoicesearch.TabIndex = 43;
            // 
            // dgv_invoiceshow
            // 
            this.dgv_invoiceshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoiceshow.Location = new System.Drawing.Point(29, 135);
            this.dgv_invoiceshow.Name = "dgv_invoiceshow";
            this.dgv_invoiceshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_invoiceshow.Size = new System.Drawing.Size(675, 150);
            this.dgv_invoiceshow.TabIndex = 42;
            this.dgv_invoiceshow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoiceshow_CellClick);
            this.dgv_invoiceshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoiceshow_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 57);
            this.label1.TabIndex = 41;
            this.label1.Text = "Generate Invoice ";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(795, 733);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_searchcustomer);
            this.Controls.Add(this.lbl_showcustomerName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_invoice2show);
            this.Controls.Add(this.btn_addinvoice);
            this.Controls.Add(this.txt_quntity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_showproductname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_showproductid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_viewinvoice);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_invoicesearch);
            this.Controls.Add(this.dgv_invoiceshow);
            this.Controls.Add(this.label1);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice2show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_searchcustomer;
        private System.Windows.Forms.Label lbl_showcustomerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_invoice2show;
        private System.Windows.Forms.Button btn_addinvoice;
        private System.Windows.Forms.TextBox txt_quntity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_showproductname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_showproductid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_viewinvoice;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_invoicesearch;
        private System.Windows.Forms.DataGridView dgv_invoiceshow;
        private System.Windows.Forms.Label label1;
    }
}