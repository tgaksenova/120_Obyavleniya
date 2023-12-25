namespace Privateads
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aDSDataSet = new Privateads.ADSDataSet();
            this.aDSPRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDSPRTableAdapter = new Privateads.ADSDataSetTableAdapters.ADSPRTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.adsDataSet1 = new Privateads.ADSDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапубликацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idпродавцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idкатегорииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеобъявленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниетовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способдоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aDSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSPRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 33);
            this.textBox1.TabIndex = 1;
            // 
            // aDSDataSet
            // 
            this.aDSDataSet.DataSetName = "ADSDataSet";
            this.aDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDSPRBindingSource
            // 
            this.aDSPRBindingSource.DataMember = "ADSPR";
            this.aDSPRBindingSource.DataSource = this.aDSDataSet;
            // 
            // aDSPRTableAdapter
            // 
            this.aDSPRTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adsDataSet1
            // 
            this.adsDataSet1.DataSetName = "ADSDataSet";
            this.adsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.датапубликацииDataGridViewTextBoxColumn,
            this.idпродавцаDataGridViewTextBoxColumn,
            this.idкатегорииDataGridViewTextBoxColumn,
            this.названиеобъявленияDataGridViewTextBoxColumn,
            this.стоимостьтовараDataGridViewTextBoxColumn,
            this.состояниетовараDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.способоплатыDataGridViewTextBoxColumn,
            this.способдоставкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aDSPRBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 380);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датапубликацииDataGridViewTextBoxColumn
            // 
            this.датапубликацииDataGridViewTextBoxColumn.DataPropertyName = "дата_публикации";
            this.датапубликацииDataGridViewTextBoxColumn.HeaderText = "дата_публикации";
            this.датапубликацииDataGridViewTextBoxColumn.Name = "датапубликацииDataGridViewTextBoxColumn";
            // 
            // idпродавцаDataGridViewTextBoxColumn
            // 
            this.idпродавцаDataGridViewTextBoxColumn.DataPropertyName = "id_продавца";
            this.idпродавцаDataGridViewTextBoxColumn.HeaderText = "id_продавца";
            this.idпродавцаDataGridViewTextBoxColumn.Name = "idпродавцаDataGridViewTextBoxColumn";
            // 
            // idкатегорииDataGridViewTextBoxColumn
            // 
            this.idкатегорииDataGridViewTextBoxColumn.DataPropertyName = "id_категории";
            this.idкатегорииDataGridViewTextBoxColumn.HeaderText = "id_категории";
            this.idкатегорииDataGridViewTextBoxColumn.Name = "idкатегорииDataGridViewTextBoxColumn";
            // 
            // названиеобъявленияDataGridViewTextBoxColumn
            // 
            this.названиеобъявленияDataGridViewTextBoxColumn.DataPropertyName = "название_объявления";
            this.названиеобъявленияDataGridViewTextBoxColumn.HeaderText = "название_объявления";
            this.названиеобъявленияDataGridViewTextBoxColumn.Name = "названиеобъявленияDataGridViewTextBoxColumn";
            // 
            // стоимостьтовараDataGridViewTextBoxColumn
            // 
            this.стоимостьтовараDataGridViewTextBoxColumn.DataPropertyName = "стоимость_товара";
            this.стоимостьтовараDataGridViewTextBoxColumn.HeaderText = "стоимость_товара";
            this.стоимостьтовараDataGridViewTextBoxColumn.Name = "стоимостьтовараDataGridViewTextBoxColumn";
            // 
            // состояниетовараDataGridViewTextBoxColumn
            // 
            this.состояниетовараDataGridViewTextBoxColumn.DataPropertyName = "состояние_товара";
            this.состояниетовараDataGridViewTextBoxColumn.HeaderText = "состояние_товара";
            this.состояниетовараDataGridViewTextBoxColumn.Name = "состояниетовараDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // способоплатыDataGridViewTextBoxColumn
            // 
            this.способоплатыDataGridViewTextBoxColumn.DataPropertyName = "способ_оплаты";
            this.способоплатыDataGridViewTextBoxColumn.HeaderText = "способ_оплаты";
            this.способоплатыDataGridViewTextBoxColumn.Name = "способоплатыDataGridViewTextBoxColumn";
            // 
            // способдоставкиDataGridViewTextBoxColumn
            // 
            this.способдоставкиDataGridViewTextBoxColumn.DataPropertyName = "способ_доставки";
            this.способдоставкиDataGridViewTextBoxColumn.HeaderText = "способ_доставки";
            this.способдоставкиDataGridViewTextBoxColumn.Name = "способдоставкиDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aDSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDSPRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private ADSDataSet aDSDataSet;
        private System.Windows.Forms.BindingSource aDSPRBindingSource;
        private ADSDataSetTableAdapters.ADSPRTableAdapter aDSPRTableAdapter;
        private System.Windows.Forms.Button button1;
        private ADSDataSet adsDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапубликацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idпродавцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idкатегорииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеобъявленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниетовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn способоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn способдоставкиDataGridViewTextBoxColumn;
    }
}