namespace ADO01
{
    partial class frmProducts
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
            this.btonClose = new System.Windows.Forms.Button();
            this.tabcProducts = new System.Windows.Forms.TabControl();
            this.tabpData = new System.Windows.Forms.TabPage();
            this.tabpDetail = new System.Windows.Forms.TabPage();
            this.grpbQuery = new System.Windows.Forms.GroupBox();
            this.dgrd = new System.Windows.Forms.DataGridView();
            this.tboxQProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxQCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxQSupplier = new System.Windows.Forms.ComboBox();
            this.btonQuery = new System.Windows.Forms.Button();
            this.tabcProducts.SuspendLayout();
            this.tabpData.SuspendLayout();
            this.grpbQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Location = new System.Drawing.Point(673, 625);
            this.btonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(93, 45);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // tabcProducts
            // 
            this.tabcProducts.Controls.Add(this.tabpData);
            this.tabcProducts.Controls.Add(this.tabpDetail);
            this.tabcProducts.Location = new System.Drawing.Point(12, 12);
            this.tabcProducts.Name = "tabcProducts";
            this.tabcProducts.SelectedIndex = 0;
            this.tabcProducts.Size = new System.Drawing.Size(754, 606);
            this.tabcProducts.TabIndex = 1;
            // 
            // tabpData
            // 
            this.tabpData.Controls.Add(this.dgrd);
            this.tabpData.Controls.Add(this.grpbQuery);
            this.tabpData.Location = new System.Drawing.Point(4, 28);
            this.tabpData.Name = "tabpData";
            this.tabpData.Padding = new System.Windows.Forms.Padding(3);
            this.tabpData.Size = new System.Drawing.Size(746, 574);
            this.tabpData.TabIndex = 0;
            this.tabpData.Text = "General";
            this.tabpData.UseVisualStyleBackColor = true;
            // 
            // tabpDetail
            // 
            this.tabpDetail.Location = new System.Drawing.Point(4, 28);
            this.tabpDetail.Name = "tabpDetail";
            this.tabpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDetail.Size = new System.Drawing.Size(746, 407);
            this.tabpDetail.TabIndex = 1;
            this.tabpDetail.Text = "Detail";
            this.tabpDetail.UseVisualStyleBackColor = true;
            // 
            // grpbQuery
            // 
            this.grpbQuery.Controls.Add(this.btonQuery);
            this.grpbQuery.Controls.Add(this.cboxQSupplier);
            this.grpbQuery.Controls.Add(this.label3);
            this.grpbQuery.Controls.Add(this.cboxQCategory);
            this.grpbQuery.Controls.Add(this.label2);
            this.grpbQuery.Controls.Add(this.label1);
            this.grpbQuery.Controls.Add(this.tboxQProductName);
            this.grpbQuery.Location = new System.Drawing.Point(9, 18);
            this.grpbQuery.Name = "grpbQuery";
            this.grpbQuery.Size = new System.Drawing.Size(734, 236);
            this.grpbQuery.TabIndex = 0;
            this.grpbQuery.TabStop = false;
            this.grpbQuery.Text = "Sorgu Seçenekleri";
            // 
            // dgrd
            // 
            this.dgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd.Location = new System.Drawing.Point(6, 269);
            this.dgrd.Name = "dgrd";
            this.dgrd.Size = new System.Drawing.Size(734, 265);
            this.dgrd.TabIndex = 1;
            // 
            // tboxQProductName
            // 
            this.tboxQProductName.Location = new System.Drawing.Point(175, 32);
            this.tboxQProductName.Name = "tboxQProductName";
            this.tboxQProductName.Size = new System.Drawing.Size(239, 26);
            this.tboxQProductName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // cboxQCategory
            // 
            this.cboxQCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQCategory.FormattingEnabled = true;
            this.cboxQCategory.Location = new System.Drawing.Point(175, 82);
            this.cboxQCategory.Name = "cboxQCategory";
            this.cboxQCategory.Size = new System.Drawing.Size(121, 27);
            this.cboxQCategory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tedarikçi";
            // 
            // cboxQSupplier
            // 
            this.cboxQSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxQSupplier.FormattingEnabled = true;
            this.cboxQSupplier.Location = new System.Drawing.Point(175, 138);
            this.cboxQSupplier.Name = "cboxQSupplier";
            this.cboxQSupplier.Size = new System.Drawing.Size(227, 27);
            this.cboxQSupplier.TabIndex = 5;
            // 
            // btonQuery
            // 
            this.btonQuery.Location = new System.Drawing.Point(6, 197);
            this.btonQuery.Name = "btonQuery";
            this.btonQuery.Size = new System.Drawing.Size(92, 33);
            this.btonQuery.TabIndex = 2;
            this.btonQuery.Text = "Sorgula";
            this.btonQuery.UseVisualStyleBackColor = true;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 683);
            this.Controls.Add(this.tabcProducts);
            this.Controls.Add(this.btonClose);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.tabcProducts.ResumeLayout(false);
            this.tabpData.ResumeLayout(false);
            this.grpbQuery.ResumeLayout(false);
            this.grpbQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.TabControl tabcProducts;
        private System.Windows.Forms.TabPage tabpData;
        private System.Windows.Forms.DataGridView dgrd;
        private System.Windows.Forms.GroupBox grpbQuery;
        private System.Windows.Forms.Button btonQuery;
        private System.Windows.Forms.ComboBox cboxQSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxQCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxQProductName;
        private System.Windows.Forms.TabPage tabpDetail;
    }
}