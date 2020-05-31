namespace WindowsFormsApp35
{
    partial class Form3
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
            this.depo_deneme1DataSet = new WindowsFormsApp35.depo_deneme1DataSet();
            this.tabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabloTableAdapter = new WindowsFormsApp35.depo_deneme1DataSetTableAdapters.tabloTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depo_deneme1DataSet2 = new WindowsFormsApp35.depo_deneme1DataSet2();
            this.tabloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabloTableAdapter1 = new WindowsFormsApp35.depo_deneme1DataSet2TableAdapters.tabloTableAdapter();
            this.deponumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoadediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siniradetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depo_deneme1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_deneme1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // depo_deneme1DataSet
            // 
            this.depo_deneme1DataSet.DataSetName = "depo_deneme1DataSet";
            this.depo_deneme1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabloBindingSource
            // 
            this.tabloBindingSource.DataMember = "tablo";
            this.tabloBindingSource.DataSource = this.depo_deneme1DataSet;
            // 
            // tabloTableAdapter
            // 
            this.tabloTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.tabloBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // depo_deneme1DataSet2
            // 
            this.depo_deneme1DataSet2.DataSetName = "depo_deneme1DataSet2";
            this.depo_deneme1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabloBindingSource1
            // 
            this.tabloBindingSource1.DataMember = "tablo";
            this.tabloBindingSource1.DataSource = this.depo_deneme1DataSet2;
            // 
            // tabloTableAdapter1
            // 
            this.tabloTableAdapter1.ClearBeforeFill = true;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(436, 121);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "213";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depo_deneme1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depo_deneme1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private depo_deneme1DataSet depo_deneme1DataSet;
        private System.Windows.Forms.BindingSource tabloBindingSource;
        private depo_deneme1DataSetTableAdapters.tabloTableAdapter tabloTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private depo_deneme1DataSet2 depo_deneme1DataSet2;
        private System.Windows.Forms.BindingSource tabloBindingSource1;
        private depo_deneme1DataSet2TableAdapters.tabloTableAdapter tabloTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deponumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoadediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siniradetDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}