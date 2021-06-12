
namespace WareHome
{
    partial class LozinkaZaListuForm
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
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.prikažiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(16, 84);
            this.lozinkaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(175, 20);
            this.lozinkaTextBox.TabIndex = 1;
            // 
            // prikažiButton
            // 
            this.prikažiButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.prikažiButton.Location = new System.Drawing.Point(104, 130);
            this.prikažiButton.Margin = new System.Windows.Forms.Padding(4);
            this.prikažiButton.Name = "prikažiButton";
            this.prikažiButton.Size = new System.Drawing.Size(87, 28);
            this.prikažiButton.TabIndex = 2;
            this.prikažiButton.Text = "Prikaži";
            this.prikažiButton.UseVisualStyleBackColor = false;
            this.prikažiButton.Click += new System.EventHandler(this.prikažiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.odustaniButton.Location = new System.Drawing.Point(16, 130);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(80, 28);
            this.odustaniButton.TabIndex = 3;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv liste:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Enabled = false;
            this.nazivTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivTextBox.Location = new System.Drawing.Point(16, 36);
            this.nazivTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(175, 20);
            this.nazivTextBox.TabIndex = 4;
            // 
            // LozinkaZaListuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(209, 177);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prikažiButton);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LozinkaZaListuForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentikacija";
            this.Load += new System.EventHandler(this.LozinkaZaListuForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.LozinkaZaListuForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Button prikažiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivTextBox;
    }
}