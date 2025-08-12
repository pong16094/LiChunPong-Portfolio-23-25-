
namespace Login
{
    partial class search
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
            this.components = new System.ComponentModel.Container();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new Login.productDataSet();
            this.infoTableAdapter = new Login.productDataSetTableAdapters.infoTableAdapter();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.usefortestDataSet = new Login.usefortestDataSet();
            this.infoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter1 = new Login.usefortestDataSetTableAdapters.infoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usefortestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(47, 96);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(259, 25);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Enter proID or proName";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("PMingLiU", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btSearch.Location = new System.Drawing.Point(324, 85);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(161, 45);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDDataGridViewTextBoxColumn,
            this.proNameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(694, 283);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // proIDDataGridViewTextBoxColumn
            // 
            this.proIDDataGridViewTextBoxColumn.DataPropertyName = "proID";
            this.proIDDataGridViewTextBoxColumn.HeaderText = "proID";
            this.proIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proIDDataGridViewTextBoxColumn.Name = "proIDDataGridViewTextBoxColumn";
            this.proIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // proNameDataGridViewTextBoxColumn
            // 
            this.proNameDataGridViewTextBoxColumn.DataPropertyName = "proName";
            this.proNameDataGridViewTextBoxColumn.HeaderText = "proName";
            this.proNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proNameDataGridViewTextBoxColumn.Name = "proNameDataGridViewTextBoxColumn";
            this.proNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "info";
            this.infoBindingSource.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "productDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "--All--",
            "A",
            "B",
            "C",
            "D"});
            this.cbType.Location = new System.Drawing.Point(46, 166);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(49, 23);
            this.cbType.TabIndex = 4;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            this.cbType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbType_KeyUp);
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Items.AddRange(new object[] {
            "-------------",
            "Steel",
            "Aluminum",
            "Cast Iron",
            "Stainless Steel",
            "Titanium",
            "Brass",
            "Bronze"});
            this.cbMaterial.Location = new System.Drawing.Point(151, 166);
            this.cbMaterial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(96, 23);
            this.cbMaterial.TabIndex = 11;
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            this.cbMaterial.TextChanged += new System.EventHandler(this.cbCom_TextChanged);
            this.cbMaterial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbCom_KeyUp);
            // 
            // usefortestDataSet
            // 
            this.usefortestDataSet.DataSetName = "usefortestDataSet";
            this.usefortestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource1
            // 
            this.infoBindingSource1.DataMember = "info";
            this.infoBindingSource1.DataSource = this.usefortestDataSet;
            // 
            // infoTableAdapter1
            // 
            this.infoTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Material";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(968, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Name = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usefortestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private productDataSet productDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private productDataSetTableAdapters.infoTableAdapter infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbMaterial;
        private usefortestDataSet usefortestDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource1;
        private usefortestDataSetTableAdapters.infoTableAdapter infoTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}