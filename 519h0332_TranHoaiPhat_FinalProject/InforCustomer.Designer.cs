
namespace _519h0332_TranHoaiPhat_FinalProject
{
    partial class InforCustomer
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
            this.finalC_DBDataSet4 = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet4();
            this.dATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATHANGTableAdapter = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet4TableAdapters.DATHANGTableAdapter();
            this.dATHANGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofCusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofTiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howToPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATHANGIDDataGridViewTextBoxColumn,
            this.nameofCusDataGridViewTextBoxColumn,
            this.nameofItemDataGridViewTextBoxColumn,
            this.numberofTiemDataGridViewTextBoxColumn,
            this.howToPayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dATHANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalC_DBDataSet4
            // 
            this.finalC_DBDataSet4.DataSetName = "FinalC_DBDataSet4";
            this.finalC_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATHANGBindingSource
            // 
            this.dATHANGBindingSource.DataMember = "DATHANG";
            this.dATHANGBindingSource.DataSource = this.finalC_DBDataSet4;
            // 
            // dATHANGTableAdapter
            // 
            this.dATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // dATHANGIDDataGridViewTextBoxColumn
            // 
            this.dATHANGIDDataGridViewTextBoxColumn.DataPropertyName = "DATHANG_ID";
            this.dATHANGIDDataGridViewTextBoxColumn.HeaderText = "DATHANG_ID";
            this.dATHANGIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATHANGIDDataGridViewTextBoxColumn.Name = "dATHANGIDDataGridViewTextBoxColumn";
            this.dATHANGIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameofCusDataGridViewTextBoxColumn
            // 
            this.nameofCusDataGridViewTextBoxColumn.DataPropertyName = "NameofCus";
            this.nameofCusDataGridViewTextBoxColumn.HeaderText = "NameofCus";
            this.nameofCusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameofCusDataGridViewTextBoxColumn.Name = "nameofCusDataGridViewTextBoxColumn";
            this.nameofCusDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameofItemDataGridViewTextBoxColumn
            // 
            this.nameofItemDataGridViewTextBoxColumn.DataPropertyName = "NameofItem";
            this.nameofItemDataGridViewTextBoxColumn.HeaderText = "NameofItem";
            this.nameofItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameofItemDataGridViewTextBoxColumn.Name = "nameofItemDataGridViewTextBoxColumn";
            this.nameofItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofTiemDataGridViewTextBoxColumn
            // 
            this.numberofTiemDataGridViewTextBoxColumn.DataPropertyName = "NumberofTiem";
            this.numberofTiemDataGridViewTextBoxColumn.HeaderText = "NumberofTiem";
            this.numberofTiemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofTiemDataGridViewTextBoxColumn.Name = "numberofTiemDataGridViewTextBoxColumn";
            this.numberofTiemDataGridViewTextBoxColumn.Width = 125;
            // 
            // howToPayDataGridViewTextBoxColumn
            // 
            this.howToPayDataGridViewTextBoxColumn.DataPropertyName = "HowToPay";
            this.howToPayDataGridViewTextBoxColumn.HeaderText = "HowToPay";
            this.howToPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.howToPayDataGridViewTextBoxColumn.Name = "howToPayDataGridViewTextBoxColumn";
            this.howToPayDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // InforCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InforCustomer";
            this.Text = "InforCustomer";
            this.Load += new System.EventHandler(this.InforCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private FinalC_DBDataSet4 finalC_DBDataSet4;
        private System.Windows.Forms.BindingSource dATHANGBindingSource;
        private FinalC_DBDataSet4TableAdapters.DATHANGTableAdapter dATHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATHANGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofCusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofTiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn howToPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}