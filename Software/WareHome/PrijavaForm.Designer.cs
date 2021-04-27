
namespace WareHome
{
    partial class PrijavaForm
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.korimeLabel = new System.Windows.Forms.Label();
            this.opisLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(117, 164);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 23);
            this.prijavaButton.TabIndex = 20;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.PrijavaButton_Click);
            // 
            // registracijaButton
            // 
            this.registracijaButton.Location = new System.Drawing.Point(35, 164);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(75, 23);
            this.registracijaButton.TabIndex = 19;
            this.registracijaButton.Text = "Registracija";
            this.registracijaButton.UseVisualStyleBackColor = true;
            this.registracijaButton.Click += new System.EventHandler(this.RegistracijaButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(35, 116);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 20);
            this.passwordTextBox.TabIndex = 18;
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.Location = new System.Drawing.Point(32, 99);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(47, 13);
            this.lozinkaLabel.TabIndex = 17;
            this.lozinkaLabel.Text = "Lozinka:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(35, 67);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(157, 20);
            this.usernameTextBox.TabIndex = 16;
            // 
            // korimeLabel
            // 
            this.korimeLabel.AutoSize = true;
            this.korimeLabel.Location = new System.Drawing.Point(32, 50);
            this.korimeLabel.Name = "korimeLabel";
            this.korimeLabel.Size = new System.Drawing.Size(78, 13);
            this.korimeLabel.TabIndex = 15;
            this.korimeLabel.Text = "Korisničko ime:";
            // 
            // opisLabel2
            // 
            this.opisLabel2.AutoSize = true;
            this.opisLabel2.Location = new System.Drawing.Point(32, 22);
            this.opisLabel2.Name = "opisLabel2";
            this.opisLabel2.Size = new System.Drawing.Size(136, 13);
            this.opisLabel2.TabIndex = 14;
            this.opisLabel2.Text = "Unesite podatke za prijavu:";
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 210);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.lozinkaLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.korimeLabel);
            this.Controls.Add(this.opisLabel2);
            this.Name = "PrijavaForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.PrijavaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Button registracijaButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label lozinkaLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label korimeLabel;
        private System.Windows.Forms.Label opisLabel2;
    }
}

