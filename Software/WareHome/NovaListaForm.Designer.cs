
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(13, 162);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(100, 28);
            this.odustaniButton.TabIndex = 1;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(89, 39);
            this.nazivTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(189, 22);
            this.nazivTextBox.TabIndex = 2;
            // 
            // završiButton
            // 
            this.završiButton.Location = new System.Drawing.Point(212, 162);
            this.završiButton.Margin = new System.Windows.Forms.Padding(4);
            this.završiButton.Name = "završiButton";
            this.završiButton.Size = new System.Drawing.Size(100, 28);
            this.završiButton.TabIndex = 3;
            this.završiButton.Text = "Završi";
            this.završiButton.UseVisualStyleBackColor = true;
            this.završiButton.Click += new System.EventHandler(this.završiButton_Click);
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(89, 109);
            this.lozinkaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(189, 22);
            this.lozinkaTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka:";
            // 
            // privatnaCheckBox
            // 
            this.privatnaCheckBox.AutoSize = true;
            this.privatnaCheckBox.Location = new System.Drawing.Point(121, 77);
            this.privatnaCheckBox.Name = "privatnaCheckBox";
            this.privatnaCheckBox.Size = new System.Drawing.Size(18, 17);
            this.privatnaCheckBox.TabIndex = 6;
            this.privatnaCheckBox.UseVisualStyleBackColor = true;
            this.privatnaCheckBox.CheckedChanged += new System.EventHandler(this.privatnaCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Privatna lista:";
            // 
            // NovaListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.privatnaCheckBox);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.završiButton);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NovaListaForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.NovaListaForm_Load);
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
    }
}