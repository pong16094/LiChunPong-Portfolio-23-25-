
namespace Dispatch_Processing
{
    partial class DispatchPage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dptxt = new System.Windows.Forms.Label();
            this.generatebtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.mainpagebtn = new System.Windows.Forms.Button();
            this.dpLogo = new System.Windows.Forms.PictureBox();
            this.dnbtn = new System.Windows.Forms.Button();
            this.grnbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.purchase_orderDataGridView = new System.Windows.Forms.DataGridView();
            this.purchase_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lmc1DataSet = new Dispatch_Processing.lmc1DataSet();
            this.purchase_orderTableAdapter = new Dispatch_Processing.lmc1DataSetTableAdapters.purchase_orderTableAdapter();
            this.tableAdapterManager = new Dispatch_Processing.lmc1DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dpLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmc1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dptxt
            // 
            this.dptxt.AutoSize = true;
            this.dptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptxt.Location = new System.Drawing.Point(279, 36);
            this.dptxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dptxt.Name = "dptxt";
            this.dptxt.Size = new System.Drawing.Size(479, 37);
            this.dptxt.TabIndex = 7;
            this.dptxt.Text = "Welcome to LMC Dispatch Page";
            // 
            // generatebtn
            // 
            this.generatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebtn.Location = new System.Drawing.Point(1740, 978);
            this.generatebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(112, 35);
            this.generatebtn.TabIndex = 0;
            this.generatebtn.Text = "Generate";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(1740, 18);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(112, 35);
            this.logoutbtn.TabIndex = 8;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // mainpagebtn
            // 
            this.mainpagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpagebtn.Location = new System.Drawing.Point(18, 978);
            this.mainpagebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainpagebtn.Name = "mainpagebtn";
            this.mainpagebtn.Size = new System.Drawing.Size(112, 35);
            this.mainpagebtn.TabIndex = 9;
            this.mainpagebtn.Text = "back";
            this.mainpagebtn.UseVisualStyleBackColor = true;
            this.mainpagebtn.Click += new System.EventHandler(this.mainpagebtn_Click);
            // 
            // dpLogo
            // 
            this.dpLogo.Image = global::Dispatch_Processing.Properties.Resources.legend_motor_company_high_resolution_logo_black;
            this.dpLogo.Location = new System.Drawing.Point(18, 18);
            this.dpLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpLogo.Name = "dpLogo";
            this.dpLogo.Size = new System.Drawing.Size(210, 150);
            this.dpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dpLogo.TabIndex = 5;
            this.dpLogo.TabStop = false;
            this.dpLogo.Click += new System.EventHandler(this.logo_Click);
            // 
            // dnbtn
            // 
            this.dnbtn.Location = new System.Drawing.Point(18, 228);
            this.dnbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dnbtn.Name = "dnbtn";
            this.dnbtn.Size = new System.Drawing.Size(210, 35);
            this.dnbtn.TabIndex = 10;
            this.dnbtn.Text = "DispatchNote";
            this.dnbtn.UseVisualStyleBackColor = true;
            this.dnbtn.Click += new System.EventHandler(this.dnbtn_Click);
            // 
            // grnbtn
            // 
            this.grnbtn.Location = new System.Drawing.Point(18, 303);
            this.grnbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grnbtn.Name = "grnbtn";
            this.grnbtn.Size = new System.Drawing.Size(210, 35);
            this.grnbtn.TabIndex = 11;
            this.grnbtn.Text = "GoodRecievedNote";
            this.grnbtn.UseVisualStyleBackColor = true;
            this.grnbtn.Click += new System.EventHandler(this.grnbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.purchase_orderDataGridView);
            this.panel1.Location = new System.Drawing.Point(286, 190);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 780);
            this.panel1.TabIndex = 12;
            // 
            // purchase_orderDataGridView
            // 
            this.purchase_orderDataGridView.AllowUserToAddRows = false;
            this.purchase_orderDataGridView.AllowUserToDeleteRows = false;
            this.purchase_orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_orderDataGridView.Location = new System.Drawing.Point(4, 4);
            this.purchase_orderDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchase_orderDataGridView.Name = "purchase_orderDataGridView";
            this.purchase_orderDataGridView.ReadOnly = true;
            this.purchase_orderDataGridView.RowHeadersWidth = 62;
            this.purchase_orderDataGridView.RowTemplate.Height = 24;
            this.purchase_orderDataGridView.Size = new System.Drawing.Size(1557, 771);
            this.purchase_orderDataGridView.TabIndex = 0;
            this.purchase_orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchase_orderDataGridView_CellContentClick);
            // 
            // purchase_orderBindingSource
            // 
            this.purchase_orderBindingSource.DataMember = "purchase_order";
            this.purchase_orderBindingSource.DataSource = this.lmc1DataSet;
            // 
            // lmc1DataSet
            // 
            this.lmc1DataSet.DataSetName = "lmc1DataSet";
            this.lmc1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase_orderTableAdapter
            // 
            this.purchase_orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.copy1_4TableAdapter = null;
            this.tableAdapterManager.copy2_3TableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.despatch_instruction_cover_dic_TableAdapter = null;
            this.tableAdapterManager.despatch_instruction_detail_did_TableAdapter = null;
            this.tableAdapterManager.disetTableAdapter = null;
            this.tableAdapterManager.invoicesetTableAdapter = null;
            this.tableAdapterManager.invoicing_sectionTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.purchase_orderTableAdapter = this.purchase_orderTableAdapter;
            this.tableAdapterManager.sales_officeTableAdapter = null;
            this.tableAdapterManager.shipmanTableAdapter = null;
            this.tableAdapterManager.spare_parts_storeTableAdapter = null;
            this.tableAdapterManager.spares_despatch_departmentTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.stockrecordTableAdapter = null;
            this.tableAdapterManager.supplyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dispatch_Processing.lmc1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // DispatchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1870, 1030);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grnbtn);
            this.Controls.Add(this.dnbtn);
            this.Controls.Add(this.mainpagebtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.dptxt);
            this.Controls.Add(this.dpLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DispatchPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DispatchPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dpLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchase_orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmc1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox dpLogo;
        private System.Windows.Forms.Label dptxt;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button mainpagebtn;
        private System.Windows.Forms.Button dnbtn;
        private System.Windows.Forms.Button grnbtn;
        private System.Windows.Forms.Panel panel1;
        private lmc1DataSet lmc1DataSet;
        private System.Windows.Forms.BindingSource purchase_orderBindingSource;
        private lmc1DataSetTableAdapters.purchase_orderTableAdapter purchase_orderTableAdapter;
        private lmc1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView purchase_orderDataGridView;
    }
}

