
namespace WareHome
{
    partial class ListeForm
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
            this.listeDataGridView = new System.Windows.Forms.DataGridView();
            this.povratakButton = new System.Windows.Forms.Button();
            this.prikažiButton = new System.Windows.Forms.Button();
            this.kreirajButton = new System.Windows.Forms.Button();
            this.obrišiButton = new System.Windows.Forms.Button();
            this.nisteDioDomacinstvaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listeDataGridView
            // 
            this.listeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeDataGridView.Location = new System.Drawing.Point(16, 15);
            this.listeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.listeDataGridView.Name = "listeDataGridView";
            this.listeDataGridView.RowHeadersWidth = 25;
            this.listeDataGridView.ShowEditingIcon = false;
            this.listeDataGridView.Size = new System.Drawing.Size(600, 300);
            this.listeDataGridView.TabIndex = 0;
            this.listeDataGridView.SelectionChanged += new System.EventHandler(this.listeDataGridView_SelectionChanged);
            // 
            // povratakButton
            // 
            this.povratakButton.FlatAppearance.BorderSize = 0;
            this.povratakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.povratakButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.povratakButton.ForeColor = System.Drawing.Color.White;
            this.povratakButton.Location = new System.Drawing.Point(16, 323);
            this.povratakButton.Margin = new System.Windows.Forms.Padding(4);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(108, 33);
            this.povratakButton.TabIndex = 1;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = true;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // prikažiButton
            // 
            this.prikažiButton.FlatAppearance.BorderSize = 0;
            this.prikažiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikažiButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prikažiButton.ForeColor = System.Drawing.Color.White;
            this.prikažiButton.Location = new System.Drawing.Point(524, 323);
            this.prikažiButton.Margin = new System.Windows.Forms.Padding(4);
            this.prikažiButton.Name = "prikažiButton";
            this.prikažiButton.Size = new System.Drawing.Size(92, 33);
            this.prikažiButton.TabIndex = 4;
            this.prikažiButton.Text = "Prikaži";
            this.prikažiButton.UseVisualStyleBackColor = true;
            this.prikažiButton.Click += new System.EventHandler(this.prikažiButton_Click);
            // 
            // kreirajButton
            // 
            this.kreirajButton.FlatAppearance.BorderSize = 0;
            this.kreirajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kreirajButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kreirajButton.ForeColor = System.Drawing.Color.White;
            this.kreirajButton.Location = new System.Drawing.Point(390, 323);
            this.kreirajButton.Margin = new System.Windows.Forms.Padding(4);
            this.kreirajButton.Name = "kreirajButton";
            this.kreirajButton.Size = new System.Drawing.Size(92, 33);
            this.kreirajButton.TabIndex = 3;
            this.kreirajButton.Text = "Kreiraj";
            this.kreirajButton.UseVisualStyleBackColor = true;
            this.kreirajButton.Click += new System.EventHandler(this.kreirajButton_Click);
            // 
            // obrišiButton
            // 
            this.obrišiButton.FlatAppearance.BorderSize = 0;
            this.obrišiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrišiButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrišiButton.ForeColor = System.Drawing.Color.White;
            this.obrišiButton.Location = new System.Drawing.Point(255, 323);
            this.obrišiButton.Margin = new System.Windows.Forms.Padding(4);
            this.obrišiButton.Name = "obrišiButton";
            this.obrišiButton.Size = new System.Drawing.Size(92, 33);
            this.obrišiButton.TabIndex = 2;
            this.obrišiButton.Text = "Obriši";
            this.obrišiButton.UseVisualStyleBackColor = true;
            this.obrišiButton.Click += new System.EventHandler(this.obrišiButton_Click);
            // 
            // nisteDioDomacinstvaLabel
            // 
            this.nisteDioDomacinstvaLabel.AutoSize = true;
            this.nisteDioDomacinstvaLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nisteDioDomacinstvaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nisteDioDomacinstvaLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nisteDioDomacinstvaLabel.ForeColor = System.Drawing.Color.Red;
            this.nisteDioDomacinstvaLabel.Location = new System.Drawing.Point(127, 160);
            this.nisteDioDomacinstvaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nisteDioDomacinstvaLabel.Name = "nisteDioDomacinstvaLabel";
            this.nisteDioDomacinstvaLabel.Size = new System.Drawing.Size(313, 33);
            this.nisteDioDomacinstvaLabel.TabIndex = 25;
            this.nisteDioDomacinstvaLabel.Text = "Niste dio domaćinstva.";
            this.nisteDioDomacinstvaLabel.Visible = false;
            // 
            // ListeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(636, 373);
            this.Controls.Add(this.nisteDioDomacinstvaLabel);
            this.Controls.Add(this.obrišiButton);
            this.Controls.Add(this.kreirajButton);
            this.Controls.Add(this.prikažiButton);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.listeDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste za kupovinu";
            this.Load += new System.EventHandler(this.ListeForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ListeForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.listeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeDataGridView;
        private System.Windows.Forms.Button povratakButton;
        private System.Windows.Forms.Button prikažiButton;
        private System.Windows.Forms.Button kreirajButton;
        private System.Windows.Forms.Button obrišiButton;
        private System.Windows.Forms.Label nisteDioDomacinstvaLabel;
    }
}