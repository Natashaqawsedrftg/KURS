namespace kursOOPpart2
{
    partial class Postav
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.caterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.myDBDataSet2 = new kursOOPpart2.myDBDataSet5();
            this.caterTableAdapter = new KURS.allDataSetTableAdapters.CatererTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.caterBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(KURS.allDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Просмотреть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Отправить поставщику";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "Создать в Writer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caterBindingSource, "ID", true));
            this.listBox1.DataSource = this.caterBindingSource;
            this.listBox1.DisplayMember = "email";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 43);
            this.listBox1.TabIndex = 5;
            this.listBox1.ValueMember = "ID";
            // 
            // caterBindingSource
            // 
            //this.caterBindingSource.DataMember = "Cater";
            //this.caterBindingSource.DataSource = this.myDBDataSet2;
            //// 
            // myDBDataSet2
            // 
            //this.myDBDataSet2.DataSetName = "myDBDataSet2";
            //this.myDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            // caterTableAdapter
            // 
            this.caterTableAdapter.ClearBeforeFill = true;
            // 
            // Postav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 195);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Postav";
            this.Text = "Postav";
            this.Load += new System.EventHandler(this.Postav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caterBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        //public myDBDataSet5 myDBDataSet2;
        public System.Windows.Forms.BindingSource caterBindingSource;
        public KURS.allDataSetTableAdapters.CatererTableAdapter caterTableAdapter;
    }
}