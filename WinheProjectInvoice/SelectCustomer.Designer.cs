namespace WinheProjectInvoice
{
    partial class SelectCustomer
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
            this.dgv_selectcustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cusid = new System.Windows.Forms.TextBox();
            this.txt_cusname = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_searchtext = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_selectcustomer
            // 
            this.dgv_selectcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selectcustomer.Location = new System.Drawing.Point(25, 49);
            this.dgv_selectcustomer.Name = "dgv_selectcustomer";
            this.dgv_selectcustomer.Size = new System.Drawing.Size(640, 268);
            this.dgv_selectcustomer.TabIndex = 0;
            this.dgv_selectcustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_selectcustomer_CellClick);
            this.dgv_selectcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_selectcustomer_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name ";
            // 
            // txt_cusid
            // 
            this.txt_cusid.Location = new System.Drawing.Point(126, 346);
            this.txt_cusid.Name = "txt_cusid";
            this.txt_cusid.Size = new System.Drawing.Size(220, 20);
            this.txt_cusid.TabIndex = 3;
            // 
            // txt_cusname
            // 
            this.txt_cusname.Location = new System.Drawing.Point(126, 385);
            this.txt_cusname.Name = "txt_cusname";
            this.txt_cusname.Size = new System.Drawing.Size(220, 20);
            this.txt_cusname.TabIndex = 4;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(509, 360);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(156, 23);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "Select Customer";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search Customer";
            // 
            // txt_searchtext
            // 
            this.txt_searchtext.Location = new System.Drawing.Point(116, 17);
            this.txt_searchtext.Name = "txt_searchtext";
            this.txt_searchtext.Size = new System.Drawing.Size(288, 20);
            this.txt_searchtext.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(441, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // SelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 463);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txt_cusname);
            this.Controls.Add(this.txt_cusid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_selectcustomer);
            this.Name = "SelectCustomer";
            this.Text = "SelectCustomer";
            this.Load += new System.EventHandler(this.SelectCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_selectcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cusid;
        private System.Windows.Forms.TextBox txt_cusname;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_searchtext;
        private System.Windows.Forms.Button btn_search;
    }
}