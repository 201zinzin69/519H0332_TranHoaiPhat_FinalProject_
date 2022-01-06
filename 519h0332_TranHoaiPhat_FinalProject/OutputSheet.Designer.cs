
namespace _519h0332_TranHoaiPhat_FinalProject
{
    partial class OutputSheet
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
            this.finalC_DBDataSet1 = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet1();
            this.xUATKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xUATKHOTableAdapter = new _519h0332_TranHoaiPhat_FinalProject.FinalC_DBDataSet1TableAdapters.XUATKHOTableAdapter();
            this.xUATKHOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howToPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xUATKHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xUATKHOIDDataGridViewTextBoxColumn,
            this.nameofItemDataGridViewTextBoxColumn,
            this.numberofItemDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.bookingdateDataGridViewTextBoxColumn,
            this.deliverydateDataGridViewTextBoxColumn,
            this.howToPayDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xUATKHOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-7, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(807, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalC_DBDataSet1
            // 
            this.finalC_DBDataSet1.DataSetName = "FinalC_DBDataSet1";
            this.finalC_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xUATKHOBindingSource
            // 
            this.xUATKHOBindingSource.DataMember = "XUATKHO";
            this.xUATKHOBindingSource.DataSource = this.finalC_DBDataSet1;
            // 
            // xUATKHOTableAdapter
            // 
            this.xUATKHOTableAdapter.ClearBeforeFill = true;
            // 
            // xUATKHOIDDataGridViewTextBoxColumn
            // 
            this.xUATKHOIDDataGridViewTextBoxColumn.DataPropertyName = "XUATKHO_ID";
            this.xUATKHOIDDataGridViewTextBoxColumn.HeaderText = "XUATKHO_ID";
            this.xUATKHOIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xUATKHOIDDataGridViewTextBoxColumn.Name = "xUATKHOIDDataGridViewTextBoxColumn";
            this.xUATKHOIDDataGridViewTextBoxColumn.Width = 125;
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
            // bookingdateDataGridViewTextBoxColumn
            // 
            this.bookingdateDataGridViewTextBoxColumn.DataPropertyName = "Bookingdate";
            this.bookingdateDataGridViewTextBoxColumn.HeaderText = "Bookingdate";
            this.bookingdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingdateDataGridViewTextBoxColumn.Name = "bookingdateDataGridViewTextBoxColumn";
            this.bookingdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "Deliverydate";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "Deliverydate";
            this.deliverydateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            this.deliverydateDataGridViewTextBoxColumn.Width = 125;
            // 
            // howToPayDataGridViewTextBoxColumn
            // 
            this.howToPayDataGridViewTextBoxColumn.DataPropertyName = "HowToPay";
            this.howToPayDataGridViewTextBoxColumn.HeaderText = "HowToPay";
            this.howToPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.howToPayDataGridViewTextBoxColumn.Name = "howToPayDataGridViewTextBoxColumn";
            this.howToPayDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // OutputSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OutputSheet";
            this.Text = "OutputSheet";
            this.Load += new System.EventHandler(this.OutputSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalC_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xUATKHOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private FinalC_DBDataSet1 finalC_DBDataSet1;
        private System.Windows.Forms.BindingSource xUATKHOBindingSource;
        private FinalC_DBDataSet1TableAdapters.XUATKHOTableAdapter xUATKHOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUATKHOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn howToPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}