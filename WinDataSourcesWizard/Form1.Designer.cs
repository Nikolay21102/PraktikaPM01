
namespace WinDataSourcesWizard
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rBProductDataSet = new WinDataSourcesWizard.RBProductDataSet();
            this.rBProductDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new WinDataSourcesWizard.RBProductDataSetTableAdapters.ПоставщикиTableAdapter();
            this.кодПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.поставщикиИТоварыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщики_и_товарыTableAdapter = new WinDataSourcesWizard.RBProductDataSetTableAdapters.Поставщики_и_товарыTableAdapter();
            this.кодПоставщикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПоставщикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBProductDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBProductDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиИТоварыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПоставщикаDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.адресПоставщикаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поставщикиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // rBProductDataSet
            // 
            this.rBProductDataSet.DataSetName = "RBProductDataSet";
            this.rBProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rBProductDataSetBindingSource
            // 
            this.rBProductDataSetBindingSource.DataSource = this.rBProductDataSet;
            this.rBProductDataSetBindingSource.Position = 0;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.rBProductDataSetBindingSource;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // кодПоставщикаDataGridViewTextBoxColumn
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.HeaderText = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.Name = "кодПоставщикаDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            // 
            // адресПоставщикаDataGridViewTextBoxColumn
            // 
            this.адресПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Адрес поставщика";
            this.адресПоставщикаDataGridViewTextBoxColumn.HeaderText = "Адрес поставщика";
            this.адресПоставщикаDataGridViewTextBoxColumn.Name = "адресПоставщикаDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПоставщикаDataGridViewTextBoxColumn1,
            this.поставщикDataGridViewTextBoxColumn1,
            this.адресПоставщикаDataGridViewTextBoxColumn1,
            this.ценаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn,
            this.кодПродуктаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.поставщикиИТоварыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(291, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // поставщикиИТоварыBindingSource
            // 
            this.поставщикиИТоварыBindingSource.DataMember = "Поставщики и товары";
            this.поставщикиИТоварыBindingSource.DataSource = this.rBProductDataSetBindingSource;
            // 
            // поставщики_и_товарыTableAdapter
            // 
            this.поставщики_и_товарыTableAdapter.ClearBeforeFill = true;
            // 
            // кодПоставщикаDataGridViewTextBoxColumn1
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn1.DataPropertyName = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn1.HeaderText = "Код поставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn1.Name = "кодПоставщикаDataGridViewTextBoxColumn1";
            // 
            // поставщикDataGridViewTextBoxColumn1
            // 
            this.поставщикDataGridViewTextBoxColumn1.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn1.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn1.Name = "поставщикDataGridViewTextBoxColumn1";
            // 
            // адресПоставщикаDataGridViewTextBoxColumn1
            // 
            this.адресПоставщикаDataGridViewTextBoxColumn1.DataPropertyName = "Адрес поставщика";
            this.адресПоставщикаDataGridViewTextBoxColumn1.HeaderText = "Адрес поставщика";
            this.адресПоставщикаDataGridViewTextBoxColumn1.Name = "адресПоставщикаDataGridViewTextBoxColumn1";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена, $";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена, $";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn1
            // 
            this.телефонDataGridViewTextBoxColumn1.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn1.Name = "телефонDataGridViewTextBoxColumn1";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // кодПродуктаDataGridViewTextBoxColumn
            // 
            this.кодПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.HeaderText = "Код продукта";
            this.кодПродуктаDataGridViewTextBoxColumn.Name = "кодПродуктаDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBProductDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBProductDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиИТоварыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rBProductDataSetBindingSource;
        private RBProductDataSet rBProductDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private RBProductDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource поставщикиИТоварыBindingSource;
        private RBProductDataSetTableAdapters.Поставщики_и_товарыTableAdapter поставщики_и_товарыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставщикаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПоставщикаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродуктаDataGridViewTextBoxColumn;
    }
}

