namespace WinheProjectInvoice
{
    partial class Product
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
            this.btn_deleteproducts = new System.Windows.Forms.Button();
            this.btn_editproducts = new System.Windows.Forms.Button();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.dgv_showproduct = new System.Windows.Forms.DataGridView();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deleteproducts
            // 
            this.btn_deleteproducts.Location = new System.Drawing.Point(600, 304);
            this.btn_deleteproducts.Name = "btn_deleteproducts";
            this.btn_deleteproducts.Size = new System.Drawing.Size(96, 23);
            this.btn_deleteproducts.TabIndex = 13;
            this.btn_deleteproducts.Text = "Delete Products";
            this.btn_deleteproducts.UseVisualStyleBackColor = true;
            this.btn_deleteproducts.Click += new System.EventHandler(this.btn_deleteproducts_Click);
            // 
            // btn_editproducts
            // 
            this.btn_editproducts.Location = new System.Drawing.Point(496, 304);
            this.btn_editproducts.Name = "btn_editproducts";
            this.btn_editproducts.Size = new System.Drawing.Size(98, 23);
            this.btn_editproducts.TabIndex = 12;
            this.btn_editproducts.Text = "Edit Products";
            this.btn_editproducts.UseVisualStyleBackColor = true;
            this.btn_editproducts.Click += new System.EventHandler(this.btn_editproducts_Click);
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(394, 304);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(96, 23);
            this.btn_addproduct.TabIndex = 11;
            this.btn_addproduct.Text = "Add Products";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // dgv_showproduct
            // 
            this.dgv_showproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showproduct.Location = new System.Drawing.Point(26, 67);
            this.dgv_showproduct.Name = "dgv_showproduct";
            this.dgv_showproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_showproduct.Size = new System.Drawing.Size(670, 214);
            this.dgv_showproduct.TabIndex = 10;
            this.dgv_showproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showproduct_CellClick);
            this.dgv_showproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showproduct_CellContentClick);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(621, 22);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 9;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(384, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(26, 22);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(340, 20);
            this.txt_search.TabIndex = 7;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(722, 348);
            this.Controls.Add(this.btn_deleteproducts);
            this.Controls.Add(this.btn_editproducts);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.dgv_showproduct);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteproducts;
        private System.Windows.Forms.Button btn_editproducts;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.DataGridView dgv_showproduct;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}