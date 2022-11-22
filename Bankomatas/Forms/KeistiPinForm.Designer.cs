namespace Bankomatas.Forms
{
    partial class form_KeistiPin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_EsamasPin = new System.Windows.Forms.TextBox();
            this.tb_NaujasPin = new System.Windows.Forms.TextBox();
            this.tb_PakartotiNaujaPin = new System.Windows.Forms.TextBox();
            this.button_Keisti = new System.Windows.Forms.Button();
            this.button_Gristi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "PIN kodo keitimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Esamas PIN kodas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naujas PIN kodas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pakartoti naują PIN kodą";
            // 
            // tb_EsamasPin
            // 
            this.tb_EsamasPin.Location = new System.Drawing.Point(294, 149);
            this.tb_EsamasPin.MaxLength = 4;
            this.tb_EsamasPin.Name = "tb_EsamasPin";
            this.tb_EsamasPin.PasswordChar = '*';
            this.tb_EsamasPin.Size = new System.Drawing.Size(126, 27);
            this.tb_EsamasPin.TabIndex = 5;
            // 
            // tb_NaujasPin
            // 
            this.tb_NaujasPin.Location = new System.Drawing.Point(294, 204);
            this.tb_NaujasPin.MaxLength = 4;
            this.tb_NaujasPin.Name = "tb_NaujasPin";
            this.tb_NaujasPin.Size = new System.Drawing.Size(126, 27);
            this.tb_NaujasPin.TabIndex = 6;
            // 
            // tb_PakartotiNaujaPin
            // 
            this.tb_PakartotiNaujaPin.Location = new System.Drawing.Point(294, 254);
            this.tb_PakartotiNaujaPin.MaxLength = 4;
            this.tb_PakartotiNaujaPin.Name = "tb_PakartotiNaujaPin";
            this.tb_PakartotiNaujaPin.Size = new System.Drawing.Size(126, 27);
            this.tb_PakartotiNaujaPin.TabIndex = 7;
            // 
            // button_Keisti
            // 
            this.button_Keisti.Location = new System.Drawing.Point(681, 400);
            this.button_Keisti.Name = "button_Keisti";
            this.button_Keisti.Size = new System.Drawing.Size(107, 38);
            this.button_Keisti.TabIndex = 8;
            this.button_Keisti.Text = "Grįšti";
            this.button_Keisti.UseVisualStyleBackColor = true;
            this.button_Keisti.Click += new System.EventHandler(this.button_Keisti_Click);
            // 
            // button_Gristi
            // 
            this.button_Gristi.Location = new System.Drawing.Point(294, 307);
            this.button_Gristi.Name = "button_Gristi";
            this.button_Gristi.Size = new System.Drawing.Size(107, 38);
            this.button_Gristi.TabIndex = 9;
            this.button_Gristi.Text = "Keisti";
            this.button_Gristi.UseVisualStyleBackColor = true;
            this.button_Gristi.Click += new System.EventHandler(this.button_Gristi_Click);
            // 
            // form_KeistiPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Gristi);
            this.Controls.Add(this.button_Keisti);
            this.Controls.Add(this.tb_PakartotiNaujaPin);
            this.Controls.Add(this.tb_NaujasPin);
            this.Controls.Add(this.tb_EsamasPin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_KeistiPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeistiPinForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_EsamasPin;
        private TextBox tb_NaujasPin;
        private TextBox tb_PakartotiNaujaPin;
        private Button button_Keisti;
        private Button button_Gristi;
    }
}