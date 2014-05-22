namespace KURS
{
    partial class Vremen
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
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.myDBDataSet = new KURS.myDBDataSet();
            this.smotrimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smotrimTableAdapter = new KURS.myDBDataSetTableAdapters.SmotrimTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vampodhoditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potipuvolosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potipulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smotrimBindingSource)).BeginInit();
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
            this.vampodhoditDataGridViewTextBoxColumn,
            this.potipuvolosDataGridViewTextBoxColumn,
            this.potipulicaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.smotrimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "рекомендовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "myDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smotrimBindingSource
            // 
            this.smotrimBindingSource.DataMember = "Smotrim";
            this.smotrimBindingSource.DataSource = this.myDBDataSet;
            // 
            // smotrimTableAdapter
            // 
            this.smotrimTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vampodhoditDataGridViewTextBoxColumn
            // 
            this.vampodhoditDataGridViewTextBoxColumn.DataPropertyName = "vampodhodit";
            this.vampodhoditDataGridViewTextBoxColumn.HeaderText = "vampodhodit";
            this.vampodhoditDataGridViewTextBoxColumn.Name = "vampodhoditDataGridViewTextBoxColumn";
            this.vampodhoditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potipuvolosDataGridViewTextBoxColumn
            // 
            this.potipuvolosDataGridViewTextBoxColumn.DataPropertyName = "potipuvolos";
            this.potipuvolosDataGridViewTextBoxColumn.HeaderText = "potipuvolos";
            this.potipuvolosDataGridViewTextBoxColumn.Name = "potipuvolosDataGridViewTextBoxColumn";
            this.potipuvolosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // potipulicaDataGridViewTextBoxColumn
            // 
            this.potipulicaDataGridViewTextBoxColumn.DataPropertyName = "potipulica";
            this.potipulicaDataGridViewTextBoxColumn.HeaderText = "potipulica";
            this.potipulicaDataGridViewTextBoxColumn.Name = "potipulicaDataGridViewTextBoxColumn";
            this.potipulicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Vremen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vremen";
            this.Text = "Vremen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vremen_FormClosing);
            this.Load += new System.EventHandler(this.Vremen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smotrimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private myDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource smotrimBindingSource;
        private myDBDataSetTableAdapters.SmotrimTableAdapter smotrimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vampodhoditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potipuvolosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potipulicaDataGridViewTextBoxColumn;

    }
}