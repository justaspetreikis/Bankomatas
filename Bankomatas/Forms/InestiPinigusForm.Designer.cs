namespace Bankomatas.Forms
{
    partial class InestiPinigusForm
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
            this.tb_iveskitePiniguSuma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Prideti = new System.Windows.Forms.Button();
            this.button_gristi = new System.Windows.Forms.Button();
            this.button_iseiti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Įnešti Pinigus";
            // 
            // tb_iveskitePiniguSuma
            // 
            this.tb_iveskitePiniguSuma.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_iveskitePiniguSuma.Location = new System.Drawing.Point(439, 136);
            this.tb_iveskitePiniguSuma.Name = "tb_iveskitePiniguSuma";
            this.tb_iveskitePiniguSuma.Size = new System.Drawing.Size(187, 43);
            this.tb_iveskitePiniguSuma.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Įveskite įnešamų pinigų sumą";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(643, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eur";
            // 
            // button_Prideti
            // 
            this.button_Prideti.Location = new System.Drawing.Point(439, 210);
            this.button_Prideti.Name = "button_Prideti";
            this.button_Prideti.Size = new System.Drawing.Size(187, 50);
            this.button_Prideti.TabIndex = 5;
            this.button_Prideti.Text = "Pridėti";
            this.button_Prideti.UseVisualStyleBackColor = true;
            this.button_Prideti.Click += new System.EventHandler(this.button_Prideti_Click);
            // 
            // button_gristi
            // 
            this.button_gristi.Location = new System.Drawing.Point(534, 391);
            this.button_gristi.Name = "button_gristi";
            this.button_gristi.Size = new System.Drawing.Size(124, 47);
            this.button_gristi.TabIndex = 6;
            this.button_gristi.Text = "Grįšti";
            this.button_gristi.UseVisualStyleBackColor = true;
            this.button_gristi.Click += new System.EventHandler(this.button_gristi_Click);
            // 
            // button_iseiti
            // 
            this.button_iseiti.Location = new System.Drawing.Point(664, 391);
            this.button_iseiti.Name = "button_iseiti";
            this.button_iseiti.Size = new System.Drawing.Size(124, 47);
            this.button_iseiti.TabIndex = 7;
            this.button_iseiti.Text = "Išeiti";
            this.button_iseiti.UseVisualStyleBackColor = true;
            this.button_iseiti.Click += new System.EventHandler(this.button_iseiti_Click);
            // 
            // InestiPinigusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_iseiti);
            this.Controls.Add(this.button_gristi);
            this.Controls.Add(this.button_Prideti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_iveskitePiniguSuma);
            this.Controls.Add(this.label1);
            this.Name = "InestiPinigusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inesti Pinigus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_iveskitePiniguSuma;
        private Label label2;
        private Label label3;
        private Button button_Prideti;
        private Button button_gristi;
        private Button button_iseiti;
    }
}