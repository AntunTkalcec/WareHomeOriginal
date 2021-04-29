
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
            this.exitAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // povratiLozinkuButton
            // 
            this.povratiLozinkuButton.FlatAppearance.BorderSize = 0;
            this.povratiLozinkuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.povratiLozinkuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.povratiLozinkuButton.ForeColor = System.Drawing.Color.White;
            this.povratiLozinkuButton.Location = new System.Drawing.Point(70, 121);
            this.povratiLozinkuButton.Name = "povratiLozinkuButton";
            this.povratiLozinkuButton.Size = new System.Drawing.Size(103, 54);
            this.povratiLozinkuButton.TabIndex = 0;
            this.povratiLozinkuButton.Text = "Pošalji mail";
            this.povratiLozinkuButton.UseVisualStyleBackColor = true;
            this.povratiLozinkuButton.Click += new System.EventHandler(this.PovratiLozinkuButton_Click);
            // 
            // opisLabel3
            // 
            this.opisLabel3.AutoSize = true;
            this.opisLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.opisLabel3.Location = new System.Drawing.Point(8, 44);
            this.opisLabel3.Name = "opisLabel3";
            this.opisLabel3.Size = new System.Drawing.Size(174, 21);
            this.opisLabel3.TabIndex = 1;
            this.opisLabel3.Text = "Upišite korisničko ime:";
            // 
            // korimeZaboravljenoTextBox
            // 
            this.korimeZaboravljenoTextBox.Location = new System.Drawing.Point(12, 77);
            this.korimeZaboravljenoTextBox.Name = "korimeZaboravljenoTextBox";
            this.korimeZaboravljenoTextBox.Size = new System.Drawing.Size(219, 27);
            this.korimeZaboravljenoTextBox.TabIndex = 2;
            // 
            // exitAppButton
            // 
            this.exitAppButton.BackColor = System.Drawing.Color.Red;
            this.exitAppButton.FlatAppearance.BorderSize = 0;
            this.exitAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppButton.ForeColor = System.Drawing.Color.Black;
            this.exitAppButton.Location = new System.Drawing.Point(208, 12);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(23, 27);
            this.exitAppButton.TabIndex = 19;
            this.exitAppButton.Text = "X";
            this.exitAppButton.UseVisualStyleBackColor = false;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // ZaboravljenaLozinkaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(243, 187);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.korimeZaboravljenoTextBox);
            this.Controls.Add(this.opisLabel3);
            this.Controls.Add(this.povratiLozinkuButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZaboravljenaLozinkaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZaboravljenaLozinka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button povratiLozinkuButton;
        private System.Windows.Forms.Label opisLabel3;
        private System.Windows.Forms.TextBox korimeZaboravljenoTextBox;
        private System.Windows.Forms.Button exitAppButton;
    }
}