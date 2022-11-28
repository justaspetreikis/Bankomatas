namespace Bankomatas.Forms
{
    partial class form_KurtiKortele
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
            this.button_generuotiKortelesNumeri = new System.Windows.Forms.Button();
            this.button_generuotiPinKoda = new System.Windows.Forms.Button();
            this.tb_kortelesNumeris = new System.Windows.Forms.TextBox();
            this.tb_PinKodas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_gristi = new System.Windows.Forms.Button();
            this.button_kurtiKortele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_generuotiKortelesNumeri
            // 
            this.button_generuotiKortelesNumeri.Location = new System.Drawing.Point(572, 93);
            this.button_generuotiKortelesNumeri.Name = "button_generuotiKortelesNumeri";
            this.button_generuotiKortelesNumeri.Size = new System.Drawing.Size(135, 29);
            this.button_generuotiKortelesNumeri.TabIndex = 0;
            this.button_generuotiKortelesNumeri.Text = "Generuoti";
            this.button_generuotiKortelesNumeri.UseVisualStyleBackColor = true;
            this.button_generuotiKortelesNumeri.Click += new System.EventHandler(this.button_generuotiKortelesNumeri_Click);
            // 
            // button_generuotiPinKoda
            // 
            this.button_generuotiPinKoda.Location = new System.Drawing.Point(572, 189);
            this.button_generuotiPinKoda.Name = "button_generuotiPinKoda";
            this.button_generuotiPinKoda.Size = new System.Drawing.Size(135, 29);
            this.button_generuotiPinKoda.TabIndex = 1;
            this.button_generuotiPinKoda.Text = "Generuoti";
            this.button_generuotiPinKoda.UseVisualStyleBackColor = true;
            this.button_generuotiPinKoda.Click += new System.EventHandler(this.button_generuotiPinKoda_Click);
            // 
            // tb_kortelesNumeris
            // 
            this.tb_kortelesNumeris.Location = new System.Drawing.Point(236, 95);
            this.tb_kortelesNumeris.Name = "tb_kortelesNumeris";
            this.tb_kortelesNumeris.ReadOnly = true;
            this.tb_kortelesNumeris.Size = new System.Drawing.Size(330, 27);
            this.tb_kortelesNumeris.TabIndex = 2;
            // 
            // tb_PinKodas
            // 
            this.tb_PinKodas.Location = new System.Drawing.Point(236, 191);
            this.tb_PinKodas.Name = "tb_PinKodas";
            this.tb_PinKodas.ReadOnly = true;
            this.tb_PinKodas.Size = new System.Drawing.Size(330, 27);
            this.tb_PinKodas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kortelės numeris";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "PIN kodas";
            // 
            // button_gristi
            // 
            this.button_gristi.Location = new System.Drawing.Point(656, 399);
            this.button_gristi.Name = "button_gristi";
            this.button_gristi.Size = new System.Drawing.Size(115, 29);
            this.button_gristi.TabIndex = 6;
            this.button_gristi.Text = "Grišti";
            this.button_gristi.UseVisualStyleBackColor = true;
            this.button_gristi.Click += new System.EventHandler(this.button_iseiti_Click);
            // 
            // button_kurtiKortele
            // 
            this.button_kurtiKortele.Location = new System.Drawing.Point(325, 264);
            this.button_kurtiKortele.Name = "button_kurtiKortele";
            this.button_kurtiKortele.Size = new System.Drawing.Size(208, 29);
            this.button_kurtiKortele.TabIndex = 7;
            this.button_kurtiKortele.Text = "Sukurti Naują Kortelę";
            this.button_kurtiKortele.UseVisualStyleBackColor = true;
            this.button_kurtiKortele.Click += new System.EventHandler(this.button_kurtiKortele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(202, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naujos kortelės sukūrimas";
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(713, 94);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(75, 29);
            this.button_copy.TabIndex = 9;
            this.button_copy.Text = "Copy";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // form_KurtiKortele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_kurtiKortele);
            this.Controls.Add(this.button_gristi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_PinKodas);
            this.Controls.Add(this.tb_kortelesNumeris);
            this.Controls.Add(this.button_generuotiPinKoda);
            this.Controls.Add(this.button_generuotiKortelesNumeri);
            this.Name = "form_KurtiKortele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurti Naują Kortelę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_generuotiKortelesNumeri;
        private Button button_generuotiPinKoda;
        private TextBox tb_kortelesNumeris;
        private TextBox tb_PinKodas;
        private Label label1;
        private Label label2;
        private Button button_gristi;
        private Button button_kurtiKortele;
        private Label label3;
        private Button button_copy;
    }
}