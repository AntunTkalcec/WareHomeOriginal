﻿
namespace WareHome
{
    partial class TestiranjeForm
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
            this.odjavaDomacinstvaButton = new System.Windows.Forms.Button();
            this.tester1Button = new System.Windows.Forms.Button();
            this.preimenovanjeDomacinstvaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ukućaniDataGridView = new System.Windows.Forms.DataGridView();
            this.nazivDomacinstvaTextBox = new System.Windows.Forms.TextBox();
            this.brojNamirnicaLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brojUkucanaLabel1 = new System.Windows.Forms.Label();
            this.trenutnoDomacinstvoLabel = new System.Windows.Forms.Label();
            this.korisnikLabel1 = new System.Windows.Forms.Label();
            this.povratakButton = new System.Windows.Forms.Button();
            this.korisnikLabel2 = new System.Windows.Forms.TextBox();
            this.trenutnoDomacinstvoLabel2 = new System.Windows.Forms.TextBox();
            this.brojUkucanaLabel2 = new System.Windows.Forms.TextBox();
            this.brojNamirnicaLabel2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.postavkeImeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.postavkePrezimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.postavkeMailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.postavkeKorisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postavkeLozinkaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.postavkePoništiButton = new System.Windows.Forms.Button();
            this.postavkeSpremiButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ukućaniDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // odjavaDomacinstvaButton
            // 
            this.odjavaDomacinstvaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.odjavaDomacinstvaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjavaDomacinstvaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odjavaDomacinstvaButton.Location = new System.Drawing.Point(315, 258);
            this.odjavaDomacinstvaButton.Name = "odjavaDomacinstvaButton";
            this.odjavaDomacinstvaButton.Size = new System.Drawing.Size(112, 39);
            this.odjavaDomacinstvaButton.TabIndex = 2;
            this.odjavaDomacinstvaButton.Text = "Odjava iz domaćinstva";
            this.odjavaDomacinstvaButton.UseVisualStyleBackColor = false;
            this.odjavaDomacinstvaButton.Click += new System.EventHandler(this.odjavaDomacinstvaButton_Click);
            // 
            // tester1Button
            // 
            this.tester1Button.Location = new System.Drawing.Point(528, 322);
            this.tester1Button.Name = "tester1Button";
            this.tester1Button.Size = new System.Drawing.Size(112, 39);
            this.tester1Button.TabIndex = 3;
            this.tester1Button.Text = "Kultura i decimal separator";
            this.tester1Button.UseVisualStyleBackColor = true;
            this.tester1Button.Click += new System.EventHandler(this.tester1Button_Click_1);
            // 
            // preimenovanjeDomacinstvaButton
            // 
            this.preimenovanjeDomacinstvaButton.Location = new System.Drawing.Point(197, 258);
            this.preimenovanjeDomacinstvaButton.Name = "preimenovanjeDomacinstvaButton";
            this.preimenovanjeDomacinstvaButton.Size = new System.Drawing.Size(112, 39);
            this.preimenovanjeDomacinstvaButton.TabIndex = 4;
            this.preimenovanjeDomacinstvaButton.Text = "Promjena naziva domaćinstva";
            this.preimenovanjeDomacinstvaButton.UseVisualStyleBackColor = true;
            this.preimenovanjeDomacinstvaButton.Click += new System.EventHandler(this.preimenovanjeDomacinstvaButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brojNamirnicaLabel2);
            this.groupBox1.Controls.Add(this.brojUkucanaLabel2);
            this.groupBox1.Controls.Add(this.trenutnoDomacinstvoLabel2);
            this.groupBox1.Controls.Add(this.korisnikLabel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ukućaniDataGridView);
            this.groupBox1.Controls.Add(this.nazivDomacinstvaTextBox);
            this.groupBox1.Controls.Add(this.brojNamirnicaLabel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.preimenovanjeDomacinstvaButton);
            this.groupBox1.Controls.Add(this.brojUkucanaLabel1);
            this.groupBox1.Controls.Add(this.odjavaDomacinstvaButton);
            this.groupBox1.Controls.Add(this.trenutnoDomacinstvoLabel);
            this.groupBox1.Controls.Add(this.korisnikLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postavke domaćinstva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ukućani:";
            // 
            // ukućaniDataGridView
            // 
            this.ukućaniDataGridView.AllowUserToAddRows = false;
            this.ukućaniDataGridView.AllowUserToDeleteRows = false;
            this.ukućaniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ukućaniDataGridView.Location = new System.Drawing.Point(9, 78);
            this.ukućaniDataGridView.Name = "ukućaniDataGridView";
            this.ukućaniDataGridView.ReadOnly = true;
            this.ukućaniDataGridView.RowHeadersWidth = 30;
            this.ukućaniDataGridView.Size = new System.Drawing.Size(418, 174);
            this.ukućaniDataGridView.TabIndex = 0;
            // 
            // nazivDomacinstvaTextBox
            // 
            this.nazivDomacinstvaTextBox.Location = new System.Drawing.Point(84, 268);
            this.nazivDomacinstvaTextBox.Name = "nazivDomacinstvaTextBox";
            this.nazivDomacinstvaTextBox.Size = new System.Drawing.Size(107, 20);
            this.nazivDomacinstvaTextBox.TabIndex = 6;
            // 
            // brojNamirnicaLabel1
            // 
            this.brojNamirnicaLabel1.AutoSize = true;
            this.brojNamirnicaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.brojNamirnicaLabel1.Location = new System.Drawing.Point(324, 17);
            this.brojNamirnicaLabel1.Name = "brojNamirnicaLabel1";
            this.brojNamirnicaLabel1.Size = new System.Drawing.Size(76, 13);
            this.brojNamirnicaLabel1.TabIndex = 13;
            this.brojNamirnicaLabel1.Text = "Broj namirnica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Domaćinstvo:";
            // 
            // brojUkucanaLabel1
            // 
            this.brojUkucanaLabel1.AutoSize = true;
            this.brojUkucanaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.brojUkucanaLabel1.Location = new System.Drawing.Point(218, 16);
            this.brojUkucanaLabel1.Name = "brojUkucanaLabel1";
            this.brojUkucanaLabel1.Size = new System.Drawing.Size(73, 13);
            this.brojUkucanaLabel1.TabIndex = 8;
            this.brojUkucanaLabel1.Text = "Broj ukućana:";
            // 
            // trenutnoDomacinstvoLabel
            // 
            this.trenutnoDomacinstvoLabel.AutoSize = true;
            this.trenutnoDomacinstvoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.trenutnoDomacinstvoLabel.Location = new System.Drawing.Point(112, 16);
            this.trenutnoDomacinstvoLabel.Name = "trenutnoDomacinstvoLabel";
            this.trenutnoDomacinstvoLabel.Size = new System.Drawing.Size(72, 13);
            this.trenutnoDomacinstvoLabel.TabIndex = 11;
            this.trenutnoDomacinstvoLabel.Text = "Domaćinstvo:";
            // 
            // korisnikLabel1
            // 
            this.korisnikLabel1.AutoSize = true;
            this.korisnikLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.korisnikLabel1.Location = new System.Drawing.Point(6, 16);
            this.korisnikLabel1.Name = "korisnikLabel1";
            this.korisnikLabel1.Size = new System.Drawing.Size(78, 13);
            this.korisnikLabel1.TabIndex = 10;
            this.korisnikLabel1.Text = "Korisničko ime:";
            // 
            // povratakButton
            // 
            this.povratakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.povratakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.povratakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.povratakButton.ForeColor = System.Drawing.Color.White;
            this.povratakButton.Location = new System.Drawing.Point(12, 322);
            this.povratakButton.Margin = new System.Windows.Forms.Padding(4);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(111, 38);
            this.povratakButton.TabIndex = 12;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = false;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // korisnikLabel2
            // 
            this.korisnikLabel2.Enabled = false;
            this.korisnikLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnikLabel2.ForeColor = System.Drawing.Color.Black;
            this.korisnikLabel2.Location = new System.Drawing.Point(9, 36);
            this.korisnikLabel2.Name = "korisnikLabel2";
            this.korisnikLabel2.Size = new System.Drawing.Size(100, 20);
            this.korisnikLabel2.TabIndex = 16;
            // 
            // trenutnoDomacinstvoLabel2
            // 
            this.trenutnoDomacinstvoLabel2.Enabled = false;
            this.trenutnoDomacinstvoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trenutnoDomacinstvoLabel2.ForeColor = System.Drawing.Color.Black;
            this.trenutnoDomacinstvoLabel2.Location = new System.Drawing.Point(115, 36);
            this.trenutnoDomacinstvoLabel2.Name = "trenutnoDomacinstvoLabel2";
            this.trenutnoDomacinstvoLabel2.Size = new System.Drawing.Size(100, 20);
            this.trenutnoDomacinstvoLabel2.TabIndex = 17;
            // 
            // brojUkucanaLabel2
            // 
            this.brojUkucanaLabel2.Enabled = false;
            this.brojUkucanaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojUkucanaLabel2.ForeColor = System.Drawing.Color.Black;
            this.brojUkucanaLabel2.Location = new System.Drawing.Point(221, 36);
            this.brojUkucanaLabel2.Name = "brojUkucanaLabel2";
            this.brojUkucanaLabel2.Size = new System.Drawing.Size(100, 20);
            this.brojUkucanaLabel2.TabIndex = 18;
            // 
            // brojNamirnicaLabel2
            // 
            this.brojNamirnicaLabel2.Enabled = false;
            this.brojNamirnicaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojNamirnicaLabel2.ForeColor = System.Drawing.Color.Black;
            this.brojNamirnicaLabel2.Location = new System.Drawing.Point(327, 36);
            this.brojNamirnicaLabel2.Name = "brojNamirnicaLabel2";
            this.brojNamirnicaLabel2.Size = new System.Drawing.Size(100, 20);
            this.brojNamirnicaLabel2.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.postavkePoništiButton);
            this.groupBox2.Controls.Add(this.postavkeSpremiButton);
            this.groupBox2.Controls.Add(this.postavkeLozinkaTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.postavkeKorisnickoImeTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.postavkeMailTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.postavkePrezimeTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.postavkeImeTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(453, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 303);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postavke korisničkog računa";
            // 
            // postavkeImeTextBox
            // 
            this.postavkeImeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postavkeImeTextBox.ForeColor = System.Drawing.Color.Black;
            this.postavkeImeTextBox.Location = new System.Drawing.Point(6, 43);
            this.postavkeImeTextBox.Name = "postavkeImeTextBox";
            this.postavkeImeTextBox.Size = new System.Drawing.Size(162, 20);
            this.postavkeImeTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ime:";
            // 
            // postavkePrezimeTextBox
            // 
            this.postavkePrezimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postavkePrezimeTextBox.ForeColor = System.Drawing.Color.Black;
            this.postavkePrezimeTextBox.Location = new System.Drawing.Point(6, 86);
            this.postavkePrezimeTextBox.Name = "postavkePrezimeTextBox";
            this.postavkePrezimeTextBox.Size = new System.Drawing.Size(162, 20);
            this.postavkePrezimeTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Prezime:";
            // 
            // postavkeMailTextBox
            // 
            this.postavkeMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postavkeMailTextBox.ForeColor = System.Drawing.Color.Black;
            this.postavkeMailTextBox.Location = new System.Drawing.Point(6, 129);
            this.postavkeMailTextBox.Name = "postavkeMailTextBox";
            this.postavkeMailTextBox.Size = new System.Drawing.Size(162, 20);
            this.postavkeMailTextBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.label5.Location = new System.Drawing.Point(3, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mail adresa:";
            // 
            // postavkeKorisnickoImeTextBox
            // 
            this.postavkeKorisnickoImeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postavkeKorisnickoImeTextBox.ForeColor = System.Drawing.Color.Black;
            this.postavkeKorisnickoImeTextBox.Location = new System.Drawing.Point(6, 172);
            this.postavkeKorisnickoImeTextBox.Name = "postavkeKorisnickoImeTextBox";
            this.postavkeKorisnickoImeTextBox.Size = new System.Drawing.Size(162, 20);
            this.postavkeKorisnickoImeTextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Korisničko ime:";
            // 
            // postavkeLozinkaTextBox
            // 
            this.postavkeLozinkaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postavkeLozinkaTextBox.ForeColor = System.Drawing.Color.Black;
            this.postavkeLozinkaTextBox.Location = new System.Drawing.Point(6, 215);
            this.postavkeLozinkaTextBox.Name = "postavkeLozinkaTextBox";
            this.postavkeLozinkaTextBox.Size = new System.Drawing.Size(162, 20);
            this.postavkeLozinkaTextBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.label7.Location = new System.Drawing.Point(3, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Lozinka:";
            // 
            // postavkePoništiButton
            // 
            this.postavkePoništiButton.Location = new System.Drawing.Point(6, 259);
            this.postavkePoništiButton.Name = "postavkePoništiButton";
            this.postavkePoništiButton.Size = new System.Drawing.Size(87, 38);
            this.postavkePoništiButton.TabIndex = 21;
            this.postavkePoništiButton.Text = "Poništi unos";
            this.postavkePoništiButton.UseVisualStyleBackColor = true;
            this.postavkePoništiButton.Click += new System.EventHandler(this.postavkePoništiButton_Click);
            // 
            // postavkeSpremiButton
            // 
            this.postavkeSpremiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.postavkeSpremiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postavkeSpremiButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postavkeSpremiButton.Location = new System.Drawing.Point(94, 258);
            this.postavkeSpremiButton.Name = "postavkeSpremiButton";
            this.postavkeSpremiButton.Size = new System.Drawing.Size(87, 39);
            this.postavkeSpremiButton.TabIndex = 20;
            this.postavkeSpremiButton.Text = "Spremi";
            this.postavkeSpremiButton.UseVisualStyleBackColor = false;
            this.postavkeSpremiButton.Click += new System.EventHandler(this.postavkeSpremiButton_Click);
            // 
            // TestiranjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tester1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestiranjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Testiranje neimplementiranihi funkcija";
            this.Load += new System.EventHandler(this.TestiranjeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ukućaniDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button odjavaDomacinstvaButton;
        private System.Windows.Forms.Button tester1Button;
        private System.Windows.Forms.Button preimenovanjeDomacinstvaButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nazivDomacinstvaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label brojNamirnicaLabel1;
        private System.Windows.Forms.Label brojUkucanaLabel1;
        private System.Windows.Forms.Label korisnikLabel1;
        private System.Windows.Forms.Button povratakButton;
        private System.Windows.Forms.Label trenutnoDomacinstvoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ukućaniDataGridView;
        private System.Windows.Forms.TextBox korisnikLabel2;
        private System.Windows.Forms.TextBox brojNamirnicaLabel2;
        private System.Windows.Forms.TextBox brojUkucanaLabel2;
        private System.Windows.Forms.TextBox trenutnoDomacinstvoLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button postavkePoništiButton;
        private System.Windows.Forms.Button postavkeSpremiButton;
        private System.Windows.Forms.TextBox postavkeLozinkaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox postavkeKorisnickoImeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox postavkeMailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox postavkePrezimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postavkeImeTextBox;
        private System.Windows.Forms.Label label3;
    }
}