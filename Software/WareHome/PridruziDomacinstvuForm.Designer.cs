
namespace WareHome
{
    partial class PridruziDomacinstvuForm
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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.domacinstvoLabel = new System.Windows.Forms.Label();
            this.domacinstvoNazivLabel = new System.Windows.Forms.Label();
            this.domacinstvoNazivTextBox = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
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
            this.exitAppButton.TabIndex = 0;
            this.exitAppButton.Text = "X";
            this.exitAppButton.UseVisualStyleBackColor = false;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // domacinstvoLabel
            // 
            this.domacinstvoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.domacinstvoLabel.AutoSize = true;
            this.domacinstvoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domacinstvoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.domacinstvoLabel.Location = new System.Drawing.Point(40, 40);
            this.domacinstvoLabel.Name = "domacinstvoLabel";
            this.domacinstvoLabel.Size = new System.Drawing.Size(253, 23);
            this.domacinstvoLabel.TabIndex = 0;
            this.domacinstvoLabel.Text = "Pridruživanje domaćinstvu";
            // 
            // domacinstvoNazivLabel
            // 
            this.domacinstvoNazivLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.domacinstvoNazivLabel.AutoSize = true;
            this.domacinstvoNazivLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.domacinstvoNazivLabel.Location = new System.Drawing.Point(90, 105);
            this.domacinstvoNazivLabel.Name = "domacinstvoNazivLabel";
            this.domacinstvoNazivLabel.Size = new System.Drawing.Size(165, 21);
            this.domacinstvoNazivLabel.TabIndex = 0;
            this.domacinstvoNazivLabel.Text = "Naziv domaćinstva:";
            // 
            // domacinstvoNazivTextBox
            // 
            this.domacinstvoNazivTextBox.Location = new System.Drawing.Point(75, 135);
            this.domacinstvoNazivTextBox.Name = "domacinstvoNazivTextBox";
            this.domacinstvoNazivTextBox.Size = new System.Drawing.Size(194, 27);
            this.domacinstvoNazivTextBox.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.FlatAppearance.BorderSize = 0;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(75, 210);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(194, 70);
            this.btnPotvrdi.TabIndex = 2;
            this.btnPotvrdi.Text = "Pridruži se";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // PridruziDomacinstvuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(340, 312);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.domacinstvoNazivTextBox);
            this.Controls.Add(this.domacinstvoNazivLabel);
            this.Controls.Add(this.domacinstvoLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitAppButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PridruziDomacinstvuForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pridruživanje domaćinstvu";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PridruziDomacinstvuForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitAppButton;
        private System.Windows.Forms.Label domacinstvoLabel;
        private System.Windows.Forms.Label domacinstvoNazivLabel;
        private System.Windows.Forms.TextBox domacinstvoNazivTextBox;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}