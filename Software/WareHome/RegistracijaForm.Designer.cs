
namespace WareHome
{
    partial class RegistracijaForm
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
            this.prijavaButton = new System.Windows.Forms.Button();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.regImeTextBox = new System.Windows.Forms.TextBox();
            this.regPrezimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regMailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regKorImeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regLozinkaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regPotvrdiLozinkuLabel = new System.Windows.Forms.Label();
            this.regPotvrdiLozinkuTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(39, 301);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 23);
            this.prijavaButton.TabIndex = 27;
            this.prijavaButton.Text = "Odustani";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.PrijavaButton_Click);
            // 
            // registracijaButton
            // 
            this.registracijaButton.Location = new System.Drawing.Point(121, 301);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(75, 23);
            this.registracijaButton.TabIndex = 26;
            this.registracijaButton.Text = "Registracija";
            this.registracijaButton.UseVisualStyleBackColor = true;
            this.registracijaButton.Click += new System.EventHandler(this.RegistracijaButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ime:";
            // 
            // regImeTextBox
            // 
            this.regImeTextBox.Location = new System.Drawing.Point(39, 68);
            this.regImeTextBox.Name = "regImeTextBox";
            this.regImeTextBox.Size = new System.Drawing.Size(157, 20);
            this.regImeTextBox.TabIndex = 25;
            // 
            // regPrezimeTextBox
            // 
            this.regPrezimeTextBox.Location = new System.Drawing.Point(39, 108);
            this.regPrezimeTextBox.Name = "regPrezimeTextBox";
            this.regPrezimeTextBox.Size = new System.Drawing.Size(157, 20);
            this.regPrezimeTextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prezime:";
            // 
            // regMailTextBox
            // 
            this.regMailTextBox.Location = new System.Drawing.Point(39, 148);
            this.regMailTextBox.Name = "regMailTextBox";
            this.regMailTextBox.Size = new System.Drawing.Size(157, 20);
            this.regMailTextBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Email:";
            // 
            // regKorImeTextBox
            // 
            this.regKorImeTextBox.Location = new System.Drawing.Point(39, 188);
            this.regKorImeTextBox.Name = "regKorImeTextBox";
            this.regKorImeTextBox.Size = new System.Drawing.Size(157, 20);
            this.regKorImeTextBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Korisničko ime:";
            // 
            // regLozinkaTextBox
            // 
            this.regLozinkaTextBox.Location = new System.Drawing.Point(39, 228);
            this.regLozinkaTextBox.Name = "regLozinkaTextBox";
            this.regLozinkaTextBox.Size = new System.Drawing.Size(157, 20);
            this.regLozinkaTextBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Lozinka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Unesite podatke za registraciju:";
            // 
            // regPotvrdiLozinkuLabel
            // 
            this.regPotvrdiLozinkuLabel.AutoSize = true;
            this.regPotvrdiLozinkuLabel.Location = new System.Drawing.Point(36, 251);
            this.regPotvrdiLozinkuLabel.Name = "regPotvrdiLozinkuLabel";
            this.regPotvrdiLozinkuLabel.Size = new System.Drawing.Size(79, 13);
            this.regPotvrdiLozinkuLabel.TabIndex = 37;
            this.regPotvrdiLozinkuLabel.Text = "Potvrdi lozinku:";
            // 
            // regPotvrdiLozinkuTextBox
            // 
            this.regPotvrdiLozinkuTextBox.Location = new System.Drawing.Point(39, 267);
            this.regPotvrdiLozinkuTextBox.Name = "regPotvrdiLozinkuTextBox";
            this.regPotvrdiLozinkuTextBox.Size = new System.Drawing.Size(157, 20);
            this.regPotvrdiLozinkuTextBox.TabIndex = 38;
            // 
            // RegistracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 336);
            this.Controls.Add(this.regPotvrdiLozinkuTextBox);
            this.Controls.Add(this.regPotvrdiLozinkuLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regLozinkaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regKorImeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regMailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regPrezimeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.regImeTextBox);
            this.Controls.Add(this.label6);
            this.Name = "RegistracijaForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.RegistracijaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Button registracijaButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regImeTextBox;
        private System.Windows.Forms.TextBox regPrezimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regMailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regKorImeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regLozinkaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label regPotvrdiLozinkuLabel;
        private System.Windows.Forms.TextBox regPotvrdiLozinkuTextBox;
    }
}