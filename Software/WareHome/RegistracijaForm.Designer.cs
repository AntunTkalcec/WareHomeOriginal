
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.imeLabel = new System.Windows.Forms.Label();
            this.regImeTextBox = new System.Windows.Forms.TextBox();
            this.regPrezimeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.regMailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.regKorImeTextBox = new System.Windows.Forms.TextBox();
            this.korimeLabel = new System.Windows.Forms.Label();
            this.regLozinkaTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.opisLabel1 = new System.Windows.Forms.Label();
            this.regPotvrdiLozinkuLabel = new System.Windows.Forms.Label();
            this.regPotvrdiLozinkuTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(39, 301);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 7;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // registracijaButton
            // 
            this.registracijaButton.Location = new System.Drawing.Point(121, 301);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(75, 23);
            this.registracijaButton.TabIndex = 6;
            this.registracijaButton.Text = "Registracija";
            this.registracijaButton.UseVisualStyleBackColor = true;
            this.registracijaButton.Click += new System.EventHandler(this.RegistracijaButton_Click);
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(36, 51);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(27, 13);
            this.imeLabel.TabIndex = 24;
            this.imeLabel.Text = "Ime:";
            // 
            // regImeTextBox
            // 
            this.regImeTextBox.Location = new System.Drawing.Point(39, 68);
            this.regImeTextBox.Name = "regImeTextBox";
            this.regImeTextBox.Size = new System.Drawing.Size(157, 20);
            this.regImeTextBox.TabIndex = 0;
            // 
            // regPrezimeTextBox
            // 
            this.regPrezimeTextBox.Location = new System.Drawing.Point(39, 108);
            this.regPrezimeTextBox.Name = "regPrezimeTextBox";
            this.regPrezimeTextBox.Size = new System.Drawing.Size(157, 20);
            this.regPrezimeTextBox.TabIndex = 1;
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(36, 91);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(47, 13);
            this.prezimeLabel.TabIndex = 28;
            this.prezimeLabel.Text = "Prezime:";
            // 
            // regMailTextBox
            // 
            this.regMailTextBox.Location = new System.Drawing.Point(39, 148);
            this.regMailTextBox.Name = "regMailTextBox";
            this.regMailTextBox.Size = new System.Drawing.Size(157, 20);
            this.regMailTextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(36, 131);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email:";
            // 
            // regKorImeTextBox
            // 
            this.regKorImeTextBox.Location = new System.Drawing.Point(39, 188);
            this.regKorImeTextBox.Name = "regKorImeTextBox";
            this.regKorImeTextBox.Size = new System.Drawing.Size(157, 20);
            this.regKorImeTextBox.TabIndex = 3;
            // 
            // korimeLabel
            // 
            this.korimeLabel.AutoSize = true;
            this.korimeLabel.Location = new System.Drawing.Point(36, 171);
            this.korimeLabel.Name = "korimeLabel";
            this.korimeLabel.Size = new System.Drawing.Size(78, 13);
            this.korimeLabel.TabIndex = 32;
            this.korimeLabel.Text = "Korisničko ime:";
            // 
            // regLozinkaTextBox
            // 
            this.regLozinkaTextBox.Location = new System.Drawing.Point(39, 228);
            this.regLozinkaTextBox.Name = "regLozinkaTextBox";
            this.regLozinkaTextBox.Size = new System.Drawing.Size(157, 20);
            this.regLozinkaTextBox.TabIndex = 4;
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.Location = new System.Drawing.Point(36, 211);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(47, 13);
            this.lozinkaLabel.TabIndex = 34;
            this.lozinkaLabel.Text = "Lozinka:";
            // 
            // opisLabel1
            // 
            this.opisLabel1.AutoSize = true;
            this.opisLabel1.Location = new System.Drawing.Point(36, 23);
            this.opisLabel1.Name = "opisLabel1";
            this.opisLabel1.Size = new System.Drawing.Size(155, 13);
            this.opisLabel1.TabIndex = 8;
            this.opisLabel1.Text = "Unesite podatke za registraciju:";
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
            this.regPotvrdiLozinkuTextBox.TabIndex = 5;
            // 
            // RegistracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 336);
            this.Controls.Add(this.regPotvrdiLozinkuTextBox);
            this.Controls.Add(this.regPotvrdiLozinkuLabel);
            this.Controls.Add(this.opisLabel1);
            this.Controls.Add(this.regLozinkaTextBox);
            this.Controls.Add(this.lozinkaLabel);
            this.Controls.Add(this.regKorImeTextBox);
            this.Controls.Add(this.korimeLabel);
            this.Controls.Add(this.regMailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.regPrezimeTextBox);
            this.Controls.Add(this.prezimeLabel);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.regImeTextBox);
            this.Controls.Add(this.imeLabel);
            this.Name = "RegistracijaForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.RegistracijaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button registracijaButton;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox regImeTextBox;
        private System.Windows.Forms.TextBox regPrezimeTextBox;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.TextBox regMailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox regKorImeTextBox;
        private System.Windows.Forms.Label korimeLabel;
        private System.Windows.Forms.TextBox regLozinkaTextBox;
        private System.Windows.Forms.Label lozinkaLabel;
        private System.Windows.Forms.Label opisLabel1;
        private System.Windows.Forms.Label regPotvrdiLozinkuLabel;
        private System.Windows.Forms.TextBox regPotvrdiLozinkuTextBox;
    }
}