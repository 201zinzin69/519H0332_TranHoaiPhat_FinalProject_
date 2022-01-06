
namespace _519h0332_TranHoaiPhat_FinalProject
{
    partial class InputSheet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.finalC_DBDataSet = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet();
            this.nHAPKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHAPKHOTableAdapter = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSetTableAdapters.NHAPKHOTableAdapter();
            this.nHAPKHOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofThisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPKHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nHAPKHOIDDataGridViewTextBoxColumn,
            this.nameofItemDataGridViewTextBoxColumn,
            this.numberofItemDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dayofThisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nHAPKHOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalC_DBDataSet
            // 
            this.finalC_DBDataSet.DataSetName = "FinalC_DBDataSet";
            this.finalC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHAPKHOBindingSource
            // 
            this.nHAPKHOBindingSource.DataMember = "NHAPKHO";
            this.nHAPKHOBindingSource.DataSource = this.finalC_DBDataSet;
            // 
            // nHAPKHOTableAdapter
            // 
            this.nHAPKHOTableAdapter.ClearBeforeFill = true;
            // 
            // nHAPKHOIDDataGridViewTextBoxColumn
            // 
            this.nHAPKHOIDDataGridViewTextBoxColumn.DataPropertyName = "NHAPKHO_ID";
            this.nHAPKHOIDDataGridViewTextBoxColumn.HeaderText = "NHAPKHO_ID";
            this.nHAPKHOIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nHAPKHOIDDataGridViewTextBoxColumn.Name = "nHAPKHOIDDataGridViewTextBoxColumn";
            this.nHAPKHOIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameofItemDataGridViewTextBoxColumn
            // 
            this.nameofItemDataGridViewTextBoxColumn.DataPropertyName = "NameofItem";
            this.nameofItemDataGridViewTextBoxColumn.HeaderText = "NameofItem";
            this.nameofItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameofItemDataGridViewTextBoxColumn.Name = "nameofItemDataGridViewTextBoxColumn";
            this.nameofItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofItemDataGridViewTextBoxColumn
            // 
            this.numberofItemDataGridViewTextBoxColumn.DataPropertyName = "NumberofItem";
            this.numberofItemDataGridViewTextBoxColumn.HeaderText = "NumberofItem";
            this.numberofItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofItemDataGridViewTextBoxColumn.Name = "numberofItemDataGridViewTextBoxColumn";
            this.numberofItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayofThisDataGridViewTextBoxColumn
            // 
            this.dayofThisDataGridViewTextBoxColumn.DataPropertyName = "DayofThis";
            this.dayofThisDataGridViewTextBoxColumn.HeaderText = "DayofThis";
            this.dayofThisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayofThisDataGridViewTextBoxColumn.Name = "dayofThisDataGridViewTextBoxColumn";
            this.dayofThisDataGridViewTextBoxColumn.Width = 125;
            // 
            // InputSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InputSheet";
            this.Text = "InputSheet";
            this.Load += new System.EventHandler(this.InputSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPKHOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private FinalC_DBDataSet finalC_DBDataSet;
        private System.Windows.Forms.BindingSource nHAPKHOBindingSource;
        private FinalC_DBDataSetTableAdapters.NHAPKHOTableAdapter nHAPKHOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHAPKHOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofThisDataGridViewTextBoxColumn;
    }
}