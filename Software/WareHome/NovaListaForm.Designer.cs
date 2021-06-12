
namespace WareHome
{
    partial class NovaListaForm
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.završiButton = new System.Windows.Forms.Button();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.privatnaCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Naziv:";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(18, 125);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(88, 30);
            this.odustaniButton.TabIndex = 5;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(67, 25);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(143, 20);
            this.nazivTextBox.TabIndex = 1;
            // 
            // završiButton
            // 
            this.završiButton.Location = new System.Drawing.Point(123, 125);
            this.završiButton.Name = "završiButton";
            this.završiButton.Size = new System.Drawing.Size(87, 30);
            this.završiButton.TabIndex = 4;
            this.završiButton.Text = "Završi";
            this.završiButton.UseVisualStyleBackColor = true;
            this.završiButton.Click += new System.EventHandler(this.završiButton_Click);
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(67, 82);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(143, 20);
            this.lozinkaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lozinka:";
            // 
            // privatnaCheckBox
            // 
            this.privatnaCheckBox.AutoSize = true;
            this.privatnaCheckBox.Location = new System.Drawing.Point(91, 56);
            this.privatnaCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.privatnaCheckBox.Name = "privatnaCheckBox";
            this.privatnaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.privatnaCheckBox.TabIndex = 2;
            this.privatnaCheckBox.UseVisualStyleBackColor = true;
            this.privatnaCheckBox.CheckedChanged += new System.EventHandler(this.privatnaCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Privatna lista:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "* obvezno polje";
            // 
            // NovaListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(229, 180);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.privatnaCheckBox);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.završiButton);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NovaListaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.NovaListaForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.NovaListaForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Button završiButton;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox privatnaCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}