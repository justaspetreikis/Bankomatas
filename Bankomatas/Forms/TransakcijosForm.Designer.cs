namespace Bankomatas.Forms
{
    partial class form_Transakcijos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kortelesNumerisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacijosLaikasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacijosTipasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piniguSumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transakcijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_VisosTransakcijos = new System.Windows.Forms.Button();
            this.button_Paskutines5 = new System.Windows.Forms.Button();
            this.buttonPiniguInesimai = new System.Windows.Forms.Button();
            this.button_PiniguIsemimai = new System.Windows.Forms.Button();
            this.button_Gristi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transakcijos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kortelesNumerisDataGridViewTextBoxColumn,
            this.operacijosLaikasDataGridViewTextBoxColumn,
            this.operacijosTipasDataGridViewTextBoxColumn,
            this.piniguSumaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transakcijaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(803, 285);
            this.dataGridView1.TabIndex = 3;
            // 
            // kortelesNumerisDataGridViewTextBoxColumn
            // 
            this.kortelesNumerisDataGridViewTextBoxColumn.DataPropertyName = "KortelesNumeris";
            this.kortelesNumerisDataGridViewTextBoxColumn.HeaderText = "KortelesNumeris";
            this.kortelesNumerisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kortelesNumerisDataGridViewTextBoxColumn.Name = "kortelesNumerisDataGridViewTextBoxColumn";
            this.kortelesNumerisDataGridViewTextBoxColumn.Width = 300;
            // 
            // operacijosLaikasDataGridViewTextBoxColumn
            // 
            this.operacijosLaikasDataGridViewTextBoxColumn.DataPropertyName = "OperacijosLaikas";
            this.operacijosLaikasDataGridViewTextBoxColumn.HeaderText = "OperacijosLaikas";
            this.operacijosLaikasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operacijosLaikasDataGridViewTextBoxColumn.Name = "operacijosLaikasDataGridViewTextBoxColumn";
            this.operacijosLaikasDataGridViewTextBoxColumn.Width = 200;
            // 
            // operacijosTipasDataGridViewTextBoxColumn
            // 
            this.operacijosTipasDataGridViewTextBoxColumn.DataPropertyName = "OperacijosTipas";
            this.operacijosTipasDataGridViewTextBoxColumn.HeaderText = "OperacijosTipas";
            this.operacijosTipasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operacijosTipasDataGridViewTextBoxColumn.Name = "operacijosTipasDataGridViewTextBoxColumn";
            this.operacijosTipasDataGridViewTextBoxColumn.Width = 125;
            // 
            // piniguSumaDataGridViewTextBoxColumn
            // 
            this.piniguSumaDataGridViewTextBoxColumn.DataPropertyName = "PiniguSuma";
            this.piniguSumaDataGridViewTextBoxColumn.HeaderText = "PiniguSuma";
            this.piniguSumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.piniguSumaDataGridViewTextBoxColumn.Name = "piniguSumaDataGridViewTextBoxColumn";
            this.piniguSumaDataGridViewTextBoxColumn.Width = 125;
            // 
            // transakcijaBindingSource
            // 
            this.transakcijaBindingSource.DataSource = typeof(Bankomatas.Class.Transakcija);
            // 
            // button_VisosTransakcijos
            // 
            this.button_VisosTransakcijos.Location = new System.Drawing.Point(54, 368);
            this.button_VisosTransakcijos.Name = "button_VisosTransakcijos";
            this.button_VisosTransakcijos.Size = new System.Drawing.Size(143, 48);
            this.button_VisosTransakcijos.TabIndex = 4;
            this.button_VisosTransakcijos.Text = "Visos Transakcijos";
            this.button_VisosTransakcijos.UseVisualStyleBackColor = true;
            this.button_VisosTransakcijos.Click += new System.EventHandler(this.button_Prideti_Click);
            // 
            // button_Paskutines5
            // 
            this.button_Paskutines5.Location = new System.Drawing.Point(218, 368);
            this.button_Paskutines5.Name = "button_Paskutines5";
            this.button_Paskutines5.Size = new System.Drawing.Size(143, 48);
            this.button_Paskutines5.TabIndex = 5;
            this.button_Paskutines5.Text = "Paskutinės 5 Transakcijos";
            this.button_Paskutines5.UseVisualStyleBackColor = true;
            this.button_Paskutines5.Click += new System.EventHandler(this.button_Paskutines5_Click);
            // 
            // buttonPiniguInesimai
            // 
            this.buttonPiniguInesimai.Location = new System.Drawing.Point(383, 368);
            this.buttonPiniguInesimai.Name = "buttonPiniguInesimai";
            this.buttonPiniguInesimai.Size = new System.Drawing.Size(143, 48);
            this.buttonPiniguInesimai.TabIndex = 6;
            this.buttonPiniguInesimai.Text = "Pinigų Įnėšimai";
            this.buttonPiniguInesimai.UseVisualStyleBackColor = true;
            this.buttonPiniguInesimai.Click += new System.EventHandler(this.buttonPiniguInesimai_Click);
            // 
            // button_PiniguIsemimai
            // 
            this.button_PiniguIsemimai.Location = new System.Drawing.Point(555, 368);
            this.button_PiniguIsemimai.Name = "button_PiniguIsemimai";
            this.button_PiniguIsemimai.Size = new System.Drawing.Size(143, 48);
            this.button_PiniguIsemimai.TabIndex = 7;
            this.button_PiniguIsemimai.Text = "Pinigų Išėmimai";
            this.button_PiniguIsemimai.UseVisualStyleBackColor = true;
            this.button_PiniguIsemimai.Click += new System.EventHandler(this.button_PiniguIsemimai_Click);
            // 
            // button_Gristi
            // 
            this.button_Gristi.Location = new System.Drawing.Point(714, 368);
            this.button_Gristi.Name = "button_Gristi";
            this.button_Gristi.Size = new System.Drawing.Size(143, 48);
            this.button_Gristi.TabIndex = 8;
            this.button_Gristi.Text = "Grįšti";
            this.button_Gristi.UseVisualStyleBackColor = true;
            this.button_Gristi.Click += new System.EventHandler(this.button_Gristi_Click);
            // 
            // form_Transakcijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.button_Gristi);
            this.Controls.Add(this.button_PiniguIsemimai);
            this.Controls.Add(this.buttonPiniguInesimai);
            this.Controls.Add(this.button_Paskutines5);
            this.Controls.Add(this.button_VisosTransakcijos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "form_Transakcijos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transakcijos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button_VisosTransakcijos;
        private BindingSource transakcijaBindingSource;
        private DataGridViewTextBoxColumn kortelesNumerisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn operacijosLaikasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn operacijosTipasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn piniguSumaDataGridViewTextBoxColumn;
        private Button button_Paskutines5;
        private Button buttonPiniguInesimai;
        private Button button_PiniguIsemimai;
        private Button button_Gristi;
    }
}