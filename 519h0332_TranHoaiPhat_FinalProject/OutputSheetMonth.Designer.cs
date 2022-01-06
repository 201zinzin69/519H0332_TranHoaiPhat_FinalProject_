
namespace _519h0332_TranHoaiPhat_FinalProject
{
    partial class OutputSheetMonth
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
            this.Save = new System.Windows.Forms.Button();
            this.finalC_DBDataSet3 = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet3();
            this.tKHANGRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tK_HANGRATableAdapter = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet3TableAdapters.TK_HANGRATableAdapter();
            this.hANGRAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfNikeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfVansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfBalenciagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfConverseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfNewBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfAdidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKHANGRABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hANGRAIDDataGridViewTextBoxColumn,
            this.numberOfNikeDataGridViewTextBoxColumn,
            this.numberOfVansDataGridViewTextBoxColumn,
            this.numberOfBalenciagaDataGridViewTextBoxColumn,
            this.numberOfConverseDataGridViewTextBoxColumn,
            this.numberOfPumaDataGridViewTextBoxColumn,
            this.numberOfNewBalanceDataGridViewTextBoxColumn,
            this.numberOfAdidasDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.monthYearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tKHANGRABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(73, 320);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // finalC_DBDataSet3
            // 
            this.finalC_DBDataSet3.DataSetName = "FinalC_DBDataSet3";
            this.finalC_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKHANGRABindingSource
            // 
            this.tKHANGRABindingSource.DataMember = "TK_HANGRA";
            this.tKHANGRABindingSource.DataSource = this.finalC_DBDataSet3;
            // 
            // tK_HANGRATableAdapter
            // 
            this.tK_HANGRATableAdapter.ClearBeforeFill = true;
            // 
            // hANGRAIDDataGridViewTextBoxColumn
            // 
            this.hANGRAIDDataGridViewTextBoxColumn.DataPropertyName = "HANGRA_ID";
            this.hANGRAIDDataGridViewTextBoxColumn.HeaderText = "HANGRA_ID";
            this.hANGRAIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hANGRAIDDataGridViewTextBoxColumn.Name = "hANGRAIDDataGridViewTextBoxColumn";
            this.hANGRAIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfNikeDataGridViewTextBoxColumn
            // 
            this.numberOfNikeDataGridViewTextBoxColumn.DataPropertyName = "NumberOfNike";
            this.numberOfNikeDataGridViewTextBoxColumn.HeaderText = "NumberOfNike";
            this.numberOfNikeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfNikeDataGridViewTextBoxColumn.Name = "numberOfNikeDataGridViewTextBoxColumn";
            this.numberOfNikeDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfVansDataGridViewTextBoxColumn
            // 
            this.numberOfVansDataGridViewTextBoxColumn.DataPropertyName = "NumberOfVans";
            this.numberOfVansDataGridViewTextBoxColumn.HeaderText = "NumberOfVans";
            this.numberOfVansDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfVansDataGridViewTextBoxColumn.Name = "numberOfVansDataGridViewTextBoxColumn";
            this.numberOfVansDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfBalenciagaDataGridViewTextBoxColumn
            // 
            this.numberOfBalenciagaDataGridViewTextBoxColumn.DataPropertyName = "NumberOfBalenciaga";
            this.numberOfBalenciagaDataGridViewTextBoxColumn.HeaderText = "NumberOfBalenciaga";
            this.numberOfBalenciagaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfBalenciagaDataGridViewTextBoxColumn.Name = "numberOfBalenciagaDataGridViewTextBoxColumn";
            this.numberOfBalenciagaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfConverseDataGridViewTextBoxColumn
            // 
            this.numberOfConverseDataGridViewTextBoxColumn.DataPropertyName = "NumberOfConverse";
            this.numberOfConverseDataGridViewTextBoxColumn.HeaderText = "NumberOfConverse";
            this.numberOfConverseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfConverseDataGridViewTextBoxColumn.Name = "numberOfConverseDataGridViewTextBoxColumn";
            this.numberOfConverseDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfPumaDataGridViewTextBoxColumn
            // 
            this.numberOfPumaDataGridViewTextBoxColumn.DataPropertyName = "NumberOfPuma";
            this.numberOfPumaDataGridViewTextBoxColumn.HeaderText = "NumberOfPuma";
            this.numberOfPumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfPumaDataGridViewTextBoxColumn.Name = "numberOfPumaDataGridViewTextBoxColumn";
            this.numberOfPumaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfNewBalanceDataGridViewTextBoxColumn
            // 
            this.numberOfNewBalanceDataGridViewTextBoxColumn.DataPropertyName = "NumberOfNewBalance";
            this.numberOfNewBalanceDataGridViewTextBoxColumn.HeaderText = "NumberOfNewBalance";
            this.numberOfNewBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfNewBalanceDataGridViewTextBoxColumn.Name = "numberOfNewBalanceDataGridViewTextBoxColumn";
            this.numberOfNewBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfAdidasDataGridViewTextBoxColumn
            // 
            this.numberOfAdidasDataGridViewTextBoxColumn.DataPropertyName = "NumberOfAdidas";
            this.numberOfAdidasDataGridViewTextBoxColumn.HeaderText = "NumberOfAdidas";
            this.numberOfAdidasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfAdidasDataGridViewTextBoxColumn.Name = "numberOfAdidasDataGridViewTextBoxColumn";
            this.numberOfAdidasDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthYearDataGridViewTextBoxColumn
            // 
            this.monthYearDataGridViewTextBoxColumn.DataPropertyName = "Month_Year";
            this.monthYearDataGridViewTextBoxColumn.HeaderText = "Month_Year";
            this.monthYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthYearDataGridViewTextBoxColumn.Name = "monthYearDataGridViewTextBoxColumn";
            this.monthYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // OutputSheetMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OutputSheetMonth";
            this.Text = "OutputSheetMonth";
            this.Load += new System.EventHandler(this.OutputSheetMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKHANGRABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save;
        private FinalC_DBDataSet3 finalC_DBDataSet3;
        private System.Windows.Forms.BindingSource tKHANGRABindingSource;
        private FinalC_DBDataSet3TableAdapters.TK_HANGRATableAdapter tK_HANGRATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hANGRAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfNikeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfVansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfBalenciagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfConverseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfNewBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfAdidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthYearDataGridViewTextBoxColumn;
    }
}