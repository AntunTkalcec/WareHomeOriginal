
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForm));
            this.prijavaButton = new System.Windows.Forms.Button();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.korimeLabel = new System.Windows.Forms.Label();
            this.opisLabel2 = new System.Windows.Forms.Label();
            this.zaboravljenaLozinkaButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prijavaButton
            // 
            this.prijavaButton.FlatAppearance.BorderSize = 0;
            this.prijavaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijavaButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijavaButton.ForeColor = System.Drawing.Color.White;
            this.prijavaButton.Location = new System.Drawing.Point(181, 195);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(103, 50);
            this.prijavaButton.TabIndex = 3;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.PrijavaButton_Click);
            // 
            // registracijaButton
            // 
            this.registracijaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.registracijaButton.FlatAppearance.BorderSize = 0;
            this.registracijaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registracijaButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registracijaButton.ForeColor = System.Drawing.Color.White;
            this.registracijaButton.Location = new System.Drawing.Point(61, 195);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(103, 50);
            this.registracijaButton.TabIndex = 4;
            this.registracijaButton.Text = "Registracija";
            this.registracijaButton.UseVisualStyleBackColor = false;
            this.registracijaButton.Click += new System.EventHandler(this.RegistracijaButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(89, 162);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 27);
            this.passwordTextBox.TabIndex = 2;
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.lozinkaLabel.Location = new System.Drawing.Point(85, 138);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(70, 21);
            this.lozinkaLabel.TabIndex = 17;
            this.lozinkaLabel.Text = "Lozinka:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(89, 108);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(157, 27);
            this.usernameTextBox.TabIndex = 1;
            // 
            // korimeLabel
            // 
            this.korimeLabel.AutoSize = true;
            this.korimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.korimeLabel.Location = new System.Drawing.Point(85, 84);
            this.korimeLabel.Name = "korimeLabel";
            this.korimeLabel.Size = new System.Drawing.Size(120, 21);
            this.korimeLabel.TabIndex = 15;
            this.korimeLabel.Text = "Korisničko ime:";
            // 
            // opisLabel2
            // 
            this.opisLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opisLabel2.AutoSize = true;
            this.opisLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.opisLabel2.Location = new System.Drawing.Point(79, 40);
            this.opisLabel2.Name = "opisLabel2";
            this.opisLabel2.Size = new System.Drawing.Size(177, 25);
            this.opisLabel2.TabIndex = 14;
            this.opisLabel2.Text = "Prijava korisnika";
            // 
            // zaboravljenaLozinkaButton
            // 
            this.zaboravljenaLozinkaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zaboravljenaLozinkaButton.FlatAppearance.BorderSize = 0;
            this.zaboravljenaLozinkaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zaboravljenaLozinkaButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaboravljenaLozinkaButton.ForeColor = System.Drawing.Color.White;
            this.zaboravljenaLozinkaButton.Location = new System.Drawing.Point(12, 276);
            this.zaboravljenaLozinkaButton.Name = "zaboravljenaLozinkaButton";
            this.zaboravljenaLozinkaButton.Size = new System.Drawing.Size(129, 24);
            this.zaboravljenaLozinkaButton.TabIndex = 5;
            this.zaboravljenaLozinkaButton.Text = "Zaboravljena lozinka";
            this.zaboravljenaLozinkaButton.UseVisualStyleBackColor = true;
            this.zaboravljenaLozinkaButton.Click += new System.EventHandler(this.zaboravljenaLozinkaButton_Click);
            // 
            // exitAppButton
            // 
            this.exitAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exitAppButton.FlatAppearance.BorderSize = 0;
            this.exitAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppButton.ForeColor = System.Drawing.Color.DarkGray;
            this.exitAppButton.Location = new System.Drawing.Point(315, 0);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(23, 26);
            this.exitAppButton.TabIndex = 18;
            this.exitAppButton.Text = "X";
            this.exitAppButton.UseVisualStyleBackColor = false;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.Location = new System.Drawing.Point(283, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 26);
            this.minimizeButton.TabIndex = 19;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // PrijavaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(340, 312);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.zaboravljenaLozinkaButton);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.lozinkaLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.korimeLabel);
            this.Controls.Add(this.opisLabel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrijavaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button zaboravljenaLozinkaButton;
        private System.Windows.Forms.Button exitAppButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}

