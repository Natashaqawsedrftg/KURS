namespace KURS
{
    partial class ХарактеристикиБаза
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddHar = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.allDataSet = new KURS.allDataSet();
            this.haracteristikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.haracteristikiTableAdapter = new KURS.allDataSetTableAdapters.HaracteristikiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozrastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanietovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiplicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipVolosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiptovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haracteristikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vozrastDataGridViewTextBoxColumn,
            this.ktoDataGridViewTextBoxColumn,
            this.nazvanietovaraDataGridViewTextBoxColumn,
            this.tiplicaDataGridViewTextBoxColumn,
            this.tipVolosDataGridViewTextBoxColumn,
            this.tiptovaraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.haracteristikiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddHar
            // 
            this.AddHar.Location = new System.Drawing.Point(24, 167);
            this.AddHar.Name = "AddHar";
            this.AddHar.Size = new System.Drawing.Size(75, 23);
            this.AddHar.TabIndex = 1;
            this.AddHar.Text = "Add";
            this.AddHar.UseVisualStyleBackColor = true;
            this.AddHar.Click += new System.EventHandler(this.AddHar_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(116, 167);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Загрузить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // allDataSet
            // 
            this.allDataSet.DataSetName = "allDataSet";
            this.allDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // haracteristikiBindingSource
            // 
            this.haracteristikiBindingSource.DataMember = "Haracteristiki";
            this.haracteristikiBindingSource.DataSource = this.allDataSet;
            // 
            // haracteristikiTableAdapter
            // 
            this.haracteristikiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vozrastDataGridViewTextBoxColumn
            // 
            this.vozrastDataGridViewTextBoxColumn.DataPropertyName = "Vozrast";
            this.vozrastDataGridViewTextBoxColumn.HeaderText = "Vozrast";
            this.vozrastDataGridViewTextBoxColumn.Name = "vozrastDataGridViewTextBoxColumn";
            this.vozrastDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ktoDataGridViewTextBoxColumn
            // 
            this.ktoDataGridViewTextBoxColumn.DataPropertyName = "Kto";
            this.ktoDataGridViewTextBoxColumn.HeaderText = "Kto";
            this.ktoDataGridViewTextBoxColumn.Name = "ktoDataGridViewTextBoxColumn";
            this.ktoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazvanietovaraDataGridViewTextBoxColumn
            // 
            this.nazvanietovaraDataGridViewTextBoxColumn.DataPropertyName = "nazvanietovara";
            this.nazvanietovaraDataGridViewTextBoxColumn.HeaderText = "nazvanietovara";
            this.nazvanietovaraDataGridViewTextBoxColumn.Name = "nazvanietovaraDataGridViewTextBoxColumn";
            this.nazvanietovaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiplicaDataGridViewTextBoxColumn
            // 
            this.tiplicaDataGridViewTextBoxColumn.DataPropertyName = "Tiplica";
            this.tiplicaDataGridViewTextBoxColumn.HeaderText = "Tiplica";
            this.tiplicaDataGridViewTextBoxColumn.Name = "tiplicaDataGridViewTextBoxColumn";
            this.tiplicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipVolosDataGridViewTextBoxColumn
            // 
            this.tipVolosDataGridViewTextBoxColumn.DataPropertyName = "TipVolos";
            this.tipVolosDataGridViewTextBoxColumn.HeaderText = "TipVolos";
            this.tipVolosDataGridViewTextBoxColumn.Name = "tipVolosDataGridViewTextBoxColumn";
            this.tipVolosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiptovaraDataGridViewTextBoxColumn
            // 
            this.tiptovaraDataGridViewTextBoxColumn.DataPropertyName = "Tiptovara";
            this.tiptovaraDataGridViewTextBoxColumn.HeaderText = "Tiptovara";
            this.tiptovaraDataGridViewTextBoxColumn.Name = "tiptovaraDataGridViewTextBoxColumn";
            this.tiptovaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ХарактеристикиБаза
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 222);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.AddHar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ХарактеристикиБаза";
            this.Text = "ХарактеристикиБаза";
            this.Load += new System.EventHandler(this.ХарактеристикиБаза_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haracteristikiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddHar;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private allDataSet allDataSet;
        private allDataSetTableAdapters.HaracteristikiTableAdapter haracteristikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozrastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanietovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiplicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipVolosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiptovaraDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource haracteristikiBindingSource;
    }
}