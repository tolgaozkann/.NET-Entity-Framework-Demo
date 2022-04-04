
namespace EntityFrameworkDemo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.tbStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.tbNameUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbNameUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.gpxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbStockAmount = new System.Windows.Forms.TextBox();
            this.txbUnitPrice = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbxUpdate.SuspendLayout();
            this.gpxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btDelete.Location = new System.Drawing.Point(26, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(171, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btUpdate);
            this.gbxUpdate.Controls.Add(this.tbStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.tbNameUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(413, 285);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(352, 210);
            this.gbxUpdate.TabIndex = 6;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Product";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(131, 181);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(138, 23);
            this.btUpdate.TabIndex = 6;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // tbStockAmountUpdate
            // 
            this.tbStockAmountUpdate.Location = new System.Drawing.Point(131, 138);
            this.tbStockAmountUpdate.Name = "tbStockAmountUpdate";
            this.tbStockAmountUpdate.Size = new System.Drawing.Size(138, 24);
            this.tbStockAmountUpdate.TabIndex = 5;
            // 
            // tbNameUnitPriceUpdate
            // 
            this.tbNameUnitPriceUpdate.Location = new System.Drawing.Point(131, 88);
            this.tbNameUnitPriceUpdate.Name = "tbNameUnitPriceUpdate";
            this.tbNameUnitPriceUpdate.Size = new System.Drawing.Size(138, 24);
            this.tbNameUnitPriceUpdate.TabIndex = 4;
            // 
            // tbNameUpdate
            // 
            this.tbNameUpdate.Location = new System.Drawing.Point(131, 35);
            this.tbNameUpdate.Name = "tbNameUpdate";
            this.tbNameUpdate.Size = new System.Drawing.Size(138, 24);
            this.tbNameUpdate.TabIndex = 3;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(10, 141);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(114, 18);
            this.lblStockAmountUpdate.TabIndex = 2;
            this.lblStockAmountUpdate.Text = "StockAmount:";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(10, 88);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(82, 18);
            this.lblUnitPriceUpdate.TabIndex = 1;
            this.lblUnitPriceUpdate.Text = "UnitPrice:";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(7, 35);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(62, 18);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "Name: ";
            // 
            // gpxAdd
            // 
            this.gpxAdd.Controls.Add(this.btnAdd);
            this.gpxAdd.Controls.Add(this.txbStockAmount);
            this.gpxAdd.Controls.Add(this.txbUnitPrice);
            this.gpxAdd.Controls.Add(this.txbName);
            this.gpxAdd.Controls.Add(this.lblStockAmount);
            this.gpxAdd.Controls.Add(this.lblUnitPrice);
            this.gpxAdd.Controls.Add(this.lblName);
            this.gpxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpxAdd.Location = new System.Drawing.Point(26, 279);
            this.gpxAdd.Name = "gpxAdd";
            this.gpxAdd.Size = new System.Drawing.Size(352, 210);
            this.gpxAdd.TabIndex = 5;
            this.gpxAdd.TabStop = false;
            this.gpxAdd.Text = "Add a Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbStockAmount
            // 
            this.txbStockAmount.Location = new System.Drawing.Point(131, 138);
            this.txbStockAmount.Name = "txbStockAmount";
            this.txbStockAmount.Size = new System.Drawing.Size(138, 24);
            this.txbStockAmount.TabIndex = 5;
            // 
            // txbUnitPrice
            // 
            this.txbUnitPrice.Location = new System.Drawing.Point(131, 88);
            this.txbUnitPrice.Name = "txbUnitPrice";
            this.txbUnitPrice.Size = new System.Drawing.Size(138, 24);
            this.txbUnitPrice.TabIndex = 4;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(131, 35);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(138, 24);
            this.txbName.TabIndex = 3;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(10, 141);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(114, 18);
            this.lblStockAmount.TabIndex = 2;
            this.lblStockAmount.Text = "StockAmount:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(10, 88);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(82, 18);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "UnitPrice:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(26, 55);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(739, 163);
            this.dgwProducts.TabIndex = 4;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(526, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(573, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(135, 20);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 531);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gpxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gpxAdd.ResumeLayout(false);
            this.gpxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.TextBox tbStockAmountUpdate;
        private System.Windows.Forms.TextBox tbNameUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbNameUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.GroupBox gpxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbStockAmount;
        private System.Windows.Forms.TextBox txbUnitPrice;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

