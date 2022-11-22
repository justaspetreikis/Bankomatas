namespace Bankomatas
{
    partial class Form_bankomatas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_bankoKortelesNumeris = new System.Windows.Forms.TextBox();
            this.tb_pinKodas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Iseiti = new System.Windows.Forms.Button();
            this.button_Prisijungti = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_NaujaKortele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_bankoKortelesNumeris
            // 
            this.tb_bankoKortelesNumeris.Location = new System.Drawing.Point(279, 125);
            this.tb_bankoKortelesNumeris.Name = "tb_bankoKortelesNumeris";
            this.tb_bankoKortelesNumeris.Size = new System.Drawing.Size(339, 27);
            this.tb_bankoKortelesNumeris.TabIndex = 0;
            // 
            // tb_pinKodas
            // 
            this.tb_pinKodas.Location = new System.Drawing.Point(279, 186);
            this.tb_pinKodas.Name = "tb_pinKodas";
            this.tb_pinKodas.PasswordChar = '*';
            this.tb_pinKodas.Size = new System.Drawing.Size(339, 27);
            this.tb_pinKodas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banko kortelės numeris";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "PIN kodas";
            // 
            // button_Iseiti
            // 
            this.button_Iseiti.Location = new System.Drawing.Point(471, 248);
            this.button_Iseiti.Name = "button_Iseiti";
            this.button_Iseiti.Size = new System.Drawing.Size(147, 39);
            this.button_Iseiti.TabIndex = 4;
            this.button_Iseiti.Text = "Išeiti";
            this.button_Iseiti.UseVisualStyleBackColor = true;
            this.button_Iseiti.Click += new System.EventHandler(this.button_Iseiti_Click);
            // 
            // button_Prisijungti
            // 
            this.button_Prisijungti.Location = new System.Drawing.Point(279, 248);
            this.button_Prisijungti.Name = "button_Prisijungti";
            this.button_Prisijungti.Size = new System.Drawing.Size(147, 39);
            this.button_Prisijungti.TabIndex = 5;
            this.button_Prisijungti.Text = "Prisijungti";
            this.button_Prisijungti.UseVisualStyleBackColor = true;
            this.button_Prisijungti.Click += new System.EventHandler(this.button_Prisijungti_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_NaujaKortele
            // 
            this.button_NaujaKortele.Location = new System.Drawing.Point(22, 387);
            this.button_NaujaKortele.Name = "button_NaujaKortele";
            this.button_NaujaKortele.Size = new System.Drawing.Size(173, 39);
            this.button_NaujaKortele.TabIndex = 7;
            this.button_NaujaKortele.Text = "Kurti Naują Kortelę";
            this.button_NaujaKortele.UseVisualStyleBackColor = true;
            this.button_NaujaKortele.Click += new System.EventHandler(this.button_NaujaKortele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(313, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "\"ŪKIO BANKAS\"";
            // 
            // Form_bankomatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_NaujaKortele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Prisijungti);
            this.Controls.Add(this.button_Iseiti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pinKodas);
            this.Controls.Add(this.tb_bankoKortelesNumeris);
            this.Name = "Form_bankomatas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankomatas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_bankoKortelesNumeris;
        private TextBox tb_pinKodas;
        private Label label1;
        private Label label2;
        private Button button_Iseiti;
        private Button button_Prisijungti;
        private Button button1;
        private Button button_NaujaKortele;
        private Label label3;
    }
}