
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
            this.SuspendLayout();
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(16, 82);
            this.lozinkaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(189, 22);
            this.lozinkaTextBox.TabIndex = 1;
            // 
            // prikažiButton
            // 
            this.prikažiButton.Location = new System.Drawing.Point(117, 136);
            this.prikažiButton.Margin = new System.Windows.Forms.Padding(4);
            this.prikažiButton.Name = "prikažiButton";
            this.prikažiButton.Size = new System.Drawing.Size(100, 28);
            this.prikažiButton.TabIndex = 2;
            this.prikažiButton.Text = "Prikaži";
            this.prikažiButton.UseVisualStyleBackColor = true;
            this.prikažiButton.Click += new System.EventHandler(this.prikažiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(9, 136);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(100, 28);
            this.odustaniButton.TabIndex = 3;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unesite lozinku za listu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // LozinkaZaListuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 187);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prikažiButton);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.label1);
            this.Name = "LozinkaZaListuForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.LozinkaZaListuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Button prikažiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}