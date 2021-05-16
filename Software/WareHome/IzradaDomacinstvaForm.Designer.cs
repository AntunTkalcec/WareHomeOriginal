
namespace WareHome
{
    partial class IzradaDomacinstvaForm
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
            this.domacinstvoLabel = new System.Windows.Forms.Label();
            this.domacinstvoNazivLabel = new System.Windows.Forms.Label();
            this.domacinstvoNazivTextBox = new System.Windows.Forms.TextBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domacinstvoLabel
            // 
            this.domacinstvoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.domacinstvoLabel.AutoSize = true;
            this.domacinstvoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.domacinstvoLabel.Location = new System.Drawing.Point(87, 28);
            this.domacinstvoLabel.Name = "domacinstvoLabel";
            this.domacinstvoLabel.Size = new System.Drawing.Size(168, 21);
            this.domacinstvoLabel.TabIndex = 26;
            this.domacinstvoLabel.Text = "Izrada domaćinstva";
            // 
            // domacinstvoNazivLabel
            // 
            this.domacinstvoNazivLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.domacinstvoNazivLabel.AutoSize = true;
            this.domacinstvoNazivLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.domacinstvoNazivLabel.Location = new System.Drawing.Point(90, 121);
            this.domacinstvoNazivLabel.Name = "domacinstvoNazivLabel";
            this.domacinstvoNazivLabel.Size = new System.Drawing.Size(165, 21);
            this.domacinstvoNazivLabel.TabIndex = 27;
            this.domacinstvoNazivLabel.Text = "Naziv domaćinstva:";
            // 
            // domacinstvoNazivTextBox
            // 
            this.domacinstvoNazivTextBox.Location = new System.Drawing.Point(73, 145);
            this.domacinstvoNazivTextBox.Name = "domacinstvoNazivTextBox";
            this.domacinstvoNazivTextBox.Size = new System.Drawing.Size(194, 27);
            this.domacinstvoNazivTextBox.TabIndex = 1;
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
            this.exitAppButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.FlatAppearance.BorderSize = 0;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(113, 207);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(116, 70);
            this.btnPotvrdi.TabIndex = 28;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // IzradaDomacinstvaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(340, 312);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.domacinstvoNazivTextBox);
            this.Controls.Add(this.domacinstvoNazivLabel);
            this.Controls.Add(this.domacinstvoLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IzradaDomacinstvaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izrada domaćinstva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label domacinstvoLabel;
        private System.Windows.Forms.Label domacinstvoNazivLabel;
        private System.Windows.Forms.TextBox domacinstvoNazivTextBox;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitAppButton;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}