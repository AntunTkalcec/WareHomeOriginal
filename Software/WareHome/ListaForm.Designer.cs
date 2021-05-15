
namespace WareHome
{
    partial class ListaForm
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
            this.preimenujButton = new System.Windows.Forms.Button();
            this.ukloniButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.povratakButton = new System.Windows.Forms.Button();
            this.namirniceDataGridView = new System.Windows.Forms.DataGridView();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.ukupnoLabel = new System.Windows.Forms.Label();
            this.ukupnoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.namirniceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // preimenujButton
            // 
            this.preimenujButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.preimenujButton.FlatAppearance.BorderSize = 0;
            this.preimenujButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preimenujButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preimenujButton.ForeColor = System.Drawing.Color.White;
            this.preimenujButton.Location = new System.Drawing.Point(630, 16);
            this.preimenujButton.Margin = new System.Windows.Forms.Padding(4);
            this.preimenujButton.Name = "preimenujButton";
            this.preimenujButton.Size = new System.Drawing.Size(165, 28);
            this.preimenujButton.TabIndex = 4;
            this.preimenujButton.Text = "Promijeni naziv";
            this.preimenujButton.UseVisualStyleBackColor = false;
            this.preimenujButton.Click += new System.EventHandler(this.preimenujButton_Click);
            // 
            // ukloniButton
            // 
            this.ukloniButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ukloniButton.FlatAppearance.BorderSize = 0;
            this.ukloniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ukloniButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ukloniButton.ForeColor = System.Drawing.Color.White;
            this.ukloniButton.Location = new System.Drawing.Point(533, 457);
            this.ukloniButton.Margin = new System.Windows.Forms.Padding(4);
            this.ukloniButton.Name = "ukloniButton";
            this.ukloniButton.Size = new System.Drawing.Size(127, 44);
            this.ukloniButton.TabIndex = 2;
            this.ukloniButton.Text = "Ukloni";
            this.ukloniButton.UseVisualStyleBackColor = false;
            this.ukloniButton.Click += new System.EventHandler(this.ukloniButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.dodajButton.FlatAppearance.BorderSize = 0;
            this.dodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajButton.ForeColor = System.Drawing.Color.White;
            this.dodajButton.Location = new System.Drawing.Point(668, 457);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(4);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(127, 44);
            this.dodajButton.TabIndex = 3;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = false;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // povratakButton
            // 
            this.povratakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.povratakButton.FlatAppearance.BorderSize = 0;
            this.povratakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.povratakButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.povratakButton.ForeColor = System.Drawing.Color.White;
            this.povratakButton.Location = new System.Drawing.Point(16, 458);
            this.povratakButton.Margin = new System.Windows.Forms.Padding(4);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(127, 44);
            this.povratakButton.TabIndex = 1;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = false;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // namirniceDataGridView
            // 
            this.namirniceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namirniceDataGridView.Location = new System.Drawing.Point(16, 50);
            this.namirniceDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.namirniceDataGridView.Name = "namirniceDataGridView";
            this.namirniceDataGridView.RowHeadersWidth = 25;
            this.namirniceDataGridView.Size = new System.Drawing.Size(779, 400);
            this.namirniceDataGridView.TabIndex = 0;
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.nazivLabel.Location = new System.Drawing.Point(13, 12);
            this.nazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(99, 34);
            this.nazivLabel.TabIndex = 0;
            this.nazivLabel.Text = "NAZIV";
            // 
            // ukupnoLabel
            // 
            this.ukupnoLabel.AutoSize = true;
            this.ukupnoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ukupnoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ukupnoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.ukupnoLabel.Location = new System.Drawing.Point(578, 468);
            this.ukupnoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ukupnoLabel.Name = "ukupnoLabel";
            this.ukupnoLabel.Size = new System.Drawing.Size(91, 23);
            this.ukupnoLabel.TabIndex = 5;
            this.ukupnoLabel.Text = "Ukupno:";
            // 
            // ukupnoTextBox
            // 
            this.ukupnoTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ukupnoTextBox.Enabled = false;
            this.ukupnoTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ukupnoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.ukupnoTextBox.Location = new System.Drawing.Point(668, 466);
            this.ukupnoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ukupnoTextBox.Name = "ukupnoTextBox";
            this.ukupnoTextBox.Size = new System.Drawing.Size(104, 30);
            this.ukupnoTextBox.TabIndex = 6;
            this.ukupnoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(816, 514);
            this.Controls.Add(this.ukupnoTextBox);
            this.Controls.Add(this.ukupnoLabel);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.preimenujButton);
            this.Controls.Add(this.ukloniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.namirniceDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.ListaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.namirniceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button preimenujButton;
        private System.Windows.Forms.Button ukloniButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button povratakButton;
        private System.Windows.Forms.DataGridView namirniceDataGridView;
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.Label ukupnoLabel;
        private System.Windows.Forms.TextBox ukupnoTextBox;
    }
}