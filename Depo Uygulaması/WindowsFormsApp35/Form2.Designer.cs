namespace WindowsFormsApp35
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txturunkod = new System.Windows.Forms.TextBox();
            this.txturunaciklama = new System.Windows.Forms.TextBox();
            this.txtdepoadedi = new System.Windows.Forms.TextBox();
            this.txtsiniradedi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deponumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siniradetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depo_deneme1DataSet1 = new WindowsFormsApp35.depo_deneme1DataSet1();
            this.tabloTableAdapter = new WindowsFormsApp35.depo_deneme1DataSet1TableAdapters.tabloTableAdapter();
            this.btnoncekiekran = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_deneme1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu                  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Açıklaması       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depo Adedi                :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınır Adedi                :";
            // 
            // txturunkod
            // 
            this.txturunkod.Location = new System.Drawing.Point(160, 29);
            this.txturunkod.Name = "txturunkod";
            this.txturunkod.Size = new System.Drawing.Size(116, 20);
            this.txturunkod.TabIndex = 4;
            // 
            // txturunaciklama
            // 
            this.txturunaciklama.Location = new System.Drawing.Point(160, 54);
            this.txturunaciklama.Name = "txturunaciklama";
            this.txturunaciklama.Size = new System.Drawing.Size(116, 20);
            this.txturunaciklama.TabIndex = 5;
            // 
            // txtdepoadedi
            // 
            this.txtdepoadedi.Location = new System.Drawing.Point(160, 81);
            this.txtdepoadedi.Name = "txtdepoadedi";
            this.txtdepoadedi.Size = new System.Drawing.Size(116, 20);
            this.txtdepoadedi.TabIndex = 6;
            // 
            // txtsiniradedi
            // 
            this.txtsiniradedi.Location = new System.Drawing.Point(160, 108);
            this.txtsiniradedi.Name = "txtsiniradedi";
            this.txtsiniradedi.Size = new System.Drawing.Size(116, 20);
            this.txtsiniradedi.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnoncekiekran);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtsiniradedi);
            this.groupBox1.Controls.Add(this.txtdepoadedi);
            this.groupBox1.Controls.Add(this.txturunaciklama);
            this.groupBox1.Controls.Add(this.txturunkod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 242);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekleme";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deponumDataGridViewTextBoxColumn,
            this.urunaciklamaDataGridViewTextBoxColumn,
            this.depoadediDataGridViewTextBoxColumn,
            this.siniradetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(324, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 231);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // deponumDataGridViewTextBoxColumn
            // 
            this.deponumDataGridViewTextBoxColumn.DataPropertyName = "deponum";
            this.deponumDataGridViewTextBoxColumn.HeaderText = "deponum";
            this.deponumDataGridViewTextBoxColumn.Name = "deponumDataGridViewTextBoxColumn";
            // 
            // urunaciklamaDataGridViewTextBoxColumn
            // 
            this.urunaciklamaDataGridViewTextBoxColumn.DataPropertyName = "urunaciklama";
            this.urunaciklamaDataGridViewTextBoxColumn.HeaderText = "urunaciklama";
            this.urunaciklamaDataGridViewTextBoxColumn.Name = "urunaciklamaDataGridViewTextBoxColumn";
            // 
            // depoadediDataGridViewTextBoxColumn
            // 
            this.depoadediDataGridViewTextBoxColumn.DataPropertyName = "depoadedi";
            this.depoadediDataGridViewTextBoxColumn.HeaderText = "depoadedi";
            this.depoadediDataGridViewTextBoxColumn.Name = "depoadediDataGridViewTextBoxColumn";
            // 
            // siniradetDataGridViewTextBoxColumn
            // 
            this.siniradetDataGridViewTextBoxColumn.DataPropertyName = "siniradet";
            this.siniradetDataGridViewTextBoxColumn.HeaderText = "siniradet";
            this.siniradetDataGridViewTextBoxColumn.Name = "siniradetDataGridViewTextBoxColumn";
            // 
            // tabloBindingSource
            // 
            this.tabloBindingSource.DataMember = "tablo";
            this.tabloBindingSource.DataSource = this.depo_deneme1DataSet1;
            // 
            // depo_deneme1DataSet1
            // 
            this.depo_deneme1DataSet1.DataSetName = "depo_deneme1DataSet1";
            this.depo_deneme1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabloTableAdapter
            // 
            this.tabloTableAdapter.ClearBeforeFill = true;
            // 
            // btnoncekiekran
            // 
            this.btnoncekiekran.Location = new System.Drawing.Point(143, 151);
            this.btnoncekiekran.Name = "btnoncekiekran";
            this.btnoncekiekran.Size = new System.Drawing.Size(131, 55);
            this.btnoncekiekran.TabIndex = 9;
            this.btnoncekiekran.Text = "Önceki Ekrana Dön";
            this.btnoncekiekran.UseVisualStyleBackColor = true;
            this.btnoncekiekran.Click += new System.EventHandler(this.btnoncekiekran_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(780, 264);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form2";
            this.Text = "Düzenleme";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_deneme1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txturunkod;
        private System.Windows.Forms.TextBox txturunaciklama;
        private System.Windows.Forms.TextBox txtdepoadedi;
        private System.Windows.Forms.TextBox txtsiniradedi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private depo_deneme1DataSet1 depo_deneme1DataSet1;
        private System.Windows.Forms.BindingSource tabloBindingSource;
        private depo_deneme1DataSet1TableAdapters.tabloTableAdapter tabloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deponumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siniradetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnoncekiekran;
    }
}