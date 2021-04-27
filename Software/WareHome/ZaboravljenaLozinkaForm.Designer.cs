
namespace WareHome
{
    partial class ZaboravljenaLozinkaForm
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
            this.povratiLozinkuButton = new System.Windows.Forms.Button();
            this.opisLabel3 = new System.Windows.Forms.Label();
            this.korimeZaboravljenoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // povratiLozinkuButton
            // 
            this.povratiLozinkuButton.Location = new System.Drawing.Point(81, 96);
            this.povratiLozinkuButton.Name = "povratiLozinkuButton";
            this.povratiLozinkuButton.Size = new System.Drawing.Size(75, 23);
            this.povratiLozinkuButton.TabIndex = 0;
            this.povratiLozinkuButton.Text = "Pošalji mail";
            this.povratiLozinkuButton.UseVisualStyleBackColor = true;
            this.povratiLozinkuButton.Click += new System.EventHandler(this.PovratiLozinkuButton_Click);
            // 
            // opisLabel3
            // 
            this.opisLabel3.AutoSize = true;
            this.opisLabel3.Location = new System.Drawing.Point(12, 9);
            this.opisLabel3.Name = "opisLabel3";
            this.opisLabel3.Size = new System.Drawing.Size(112, 13);
            this.opisLabel3.TabIndex = 1;
            this.opisLabel3.Text = "Upišite korisničko ime:";
            // 
            // korimeZaboravljenoTextBox
            // 
            this.korimeZaboravljenoTextBox.Location = new System.Drawing.Point(15, 44);
            this.korimeZaboravljenoTextBox.Name = "korimeZaboravljenoTextBox";
            this.korimeZaboravljenoTextBox.Size = new System.Drawing.Size(211, 20);
            this.korimeZaboravljenoTextBox.TabIndex = 2;
            // 
            // ZaboravljenaLozinkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 131);
            this.Controls.Add(this.korimeZaboravljenoTextBox);
            this.Controls.Add(this.opisLabel3);
            this.Controls.Add(this.povratiLozinkuButton);
            this.Name = "ZaboravljenaLozinkaForm";
            this.Text = "ZaboravljenaLozinka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button povratiLozinkuButton;
        private System.Windows.Forms.Label opisLabel3;
        private System.Windows.Forms.TextBox korimeZaboravljenoTextBox;
    }
}