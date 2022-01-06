
namespace _519h0332_TranHoaiPhat_FinalProject
{
    partial class Status
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
            this.finalC_DBDataSet6 = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet6();
            this.tINHTRANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tINHTRANGTableAdapter = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet6TableAdapters.TINHTRANGTableAdapter();
            this.tINHTRANGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTVANCHUYENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTTHANHTOANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tINHTRANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tINHTRANGIDDataGridViewTextBoxColumn,
            this.tTVANCHUYENDataGridViewTextBoxColumn,
            this.tTTHANHTOANDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tINHTRANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalC_DBDataSet6
            // 
            this.finalC_DBDataSet6.DataSetName = "FinalC_DBDataSet6";
            this.finalC_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tINHTRANGBindingSource
            // 
            this.tINHTRANGBindingSource.DataMember = "TINHTRANG";
            this.tINHTRANGBindingSource.DataSource = this.finalC_DBDataSet6;
            // 
            // tINHTRANGTableAdapter
            // 
            this.tINHTRANGTableAdapter.ClearBeforeFill = true;
            // 
            // tINHTRANGIDDataGridViewTextBoxColumn
            // 
            this.tINHTRANGIDDataGridViewTextBoxColumn.DataPropertyName = "TINHTRANG_ID";
            this.tINHTRANGIDDataGridViewTextBoxColumn.HeaderText = "TINHTRANG_ID";
            this.tINHTRANGIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tINHTRANGIDDataGridViewTextBoxColumn.Name = "tINHTRANGIDDataGridViewTextBoxColumn";
            this.tINHTRANGIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tTVANCHUYENDataGridViewTextBoxColumn
            // 
            this.tTVANCHUYENDataGridViewTextBoxColumn.DataPropertyName = "TT_VANCHUYEN";
            this.tTVANCHUYENDataGridViewTextBoxColumn.HeaderText = "TT_VANCHUYEN";
            this.tTVANCHUYENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tTVANCHUYENDataGridViewTextBoxColumn.Name = "tTVANCHUYENDataGridViewTextBoxColumn";
            this.tTVANCHUYENDataGridViewTextBoxColumn.Width = 125;
            // 
            // tTTHANHTOANDataGridViewTextBoxColumn
            // 
            this.tTTHANHTOANDataGridViewTextBoxColumn.DataPropertyName = "TT_THANHTOAN";
            this.tTTHANHTOANDataGridViewTextBoxColumn.HeaderText = "TT_THANHTOAN";
            this.tTTHANHTOANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tTTHANHTOANDataGridViewTextBoxColumn.Name = "tTTHANHTOANDataGridViewTextBoxColumn";
            this.tTTHANHTOANDataGridViewTextBoxColumn.Width = 125;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tINHTRANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private FinalC_DBDataSet6 finalC_DBDataSet6;
        private System.Windows.Forms.BindingSource tINHTRANGBindingSource;
        private FinalC_DBDataSet6TableAdapters.TINHTRANGTableAdapter tINHTRANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tINHTRANGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTVANCHUYENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTTHANHTOANDataGridViewTextBoxColumn;
    }
}