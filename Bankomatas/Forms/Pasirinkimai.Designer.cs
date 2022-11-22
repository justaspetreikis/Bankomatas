namespace Bankomatas.Forms
{
    partial class form_Pasirinkimai
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_saskaitosLikutis = new System.Windows.Forms.TextBox();
            this.button_inestiPinigus = new System.Windows.Forms.Button();
            this.button_pakeisitPin = new System.Windows.Forms.Button();
            this.button_Iseiti = new System.Windows.Forms.Button();
            this.button_isimtiPinigus = new System.Windows.Forms.Button();
            this.button_transakcijos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sąskaitos Likutis";
            // 
            // tb_saskaitosLikutis
            // 
            this.tb_saskaitosLikutis.BackColor = System.Drawing.SystemColors.Window;
            this.tb_saskaitosLikutis.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_saskaitosLikutis.Location = new System.Drawing.Point(274, 115);
            this.tb_saskaitosLikutis.Name = "tb_saskaitosLikutis";
            this.tb_saskaitosLikutis.ReadOnly = true;
            this.tb_saskaitosLikutis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_saskaitosLikutis.Size = new System.Drawing.Size(282, 38);
            this.tb_saskaitosLikutis.TabIndex = 1;
            this.tb_saskaitosLikutis.TextChanged += new System.EventHandler(this.tb_saskaitosLikutis_TextChanged);
            // 
            // button_inestiPinigus
            // 
            this.button_inestiPinigus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_inestiPinigus.Location = new System.Drawing.Point(104, 313);
            this.button_inestiPinigus.Name = "button_inestiPinigus";
            this.button_inestiPinigus.Size = new System.Drawing.Size(160, 49);
            this.button_inestiPinigus.TabIndex = 2;
            this.button_inestiPinigus.Text = "Įnešti pinigus";
            this.button_inestiPinigus.UseVisualStyleBackColor = true;
            this.button_inestiPinigus.Click += new System.EventHandler(this.button_inestiPinigus_Click);
            // 
            // button_pakeisitPin
            // 
            this.button_pakeisitPin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_pakeisitPin.Location = new System.Drawing.Point(330, 313);
            this.button_pakeisitPin.Name = "button_pakeisitPin";
            this.button_pakeisitPin.Size = new System.Drawing.Size(160, 49);
            this.button_pakeisitPin.TabIndex = 3;
            this.button_pakeisitPin.Text = "Pakeisti PIN kodą";
            this.button_pakeisitPin.UseVisualStyleBackColor = true;
            this.button_pakeisitPin.Click += new System.EventHandler(this.button_pakeisitPin_Click);
            // 
            // button_Iseiti
            // 
            this.button_Iseiti.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Iseiti.Location = new System.Drawing.Point(545, 313);
            this.button_Iseiti.Name = "button_Iseiti";
            this.button_Iseiti.Size = new System.Drawing.Size(160, 49);
            this.button_Iseiti.TabIndex = 4;
            this.button_Iseiti.Text = "Išeiti";
            this.button_Iseiti.UseVisualStyleBackColor = true;
            this.button_Iseiti.Click += new System.EventHandler(this.button_Iseiti_Click);
            // 
            // button_isimtiPinigus
            // 
            this.button_isimtiPinigus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_isimtiPinigus.Location = new System.Drawing.Point(104, 209);
            this.button_isimtiPinigus.Name = "button_isimtiPinigus";
            this.button_isimtiPinigus.Size = new System.Drawing.Size(160, 49);
            this.button_isimtiPinigus.TabIndex = 5;
            this.button_isimtiPinigus.Text = "Išsiimti pinigus";
            this.button_isimtiPinigus.UseVisualStyleBackColor = true;
            this.button_isimtiPinigus.Click += new System.EventHandler(this.button_isimtiPinigus_Click);
            // 
            // button_transakcijos
            // 
            this.button_transakcijos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_transakcijos.Location = new System.Drawing.Point(330, 209);
            this.button_transakcijos.Name = "button_transakcijos";
            this.button_transakcijos.Size = new System.Drawing.Size(160, 49);
            this.button_transakcijos.TabIndex = 6;
            this.button_transakcijos.Text = "5 Transakcijos";
            this.button_transakcijos.UseVisualStyleBackColor = true;
            this.button_transakcijos.Click += new System.EventHandler(this.button_transakcijos_Click);
            // 
            // form_Pasirinkimai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_transakcijos);
            this.Controls.Add(this.button_isimtiPinigus);
            this.Controls.Add(this.button_Iseiti);
            this.Controls.Add(this.button_pakeisitPin);
            this.Controls.Add(this.button_inestiPinigus);
            this.Controls.Add(this.tb_saskaitosLikutis);
            this.Controls.Add(this.label1);
            this.Name = "form_Pasirinkimai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasirinkimai";
            this.Load += new System.EventHandler(this.form_Pasirinkimai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_saskaitosLikutis;
        private Button button_inestiPinigus;
        private Button button_pakeisitPin;
        private Button button_Iseiti;
        private Button button_isimtiPinigus;
        private Button button_transakcijos;
    }
}