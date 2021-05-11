
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
            this.listeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.listeDataGridView.Name = "listeDataGridView";
            this.listeDataGridView.RowHeadersWidth = 51;
            this.listeDataGridView.ShowEditingIcon = false;
            this.listeDataGridView.Size = new System.Drawing.Size(477, 260);
            this.listeDataGridView.TabIndex = 0;
            // 
            // povratakButton
            // 
            this.povratakButton.Location = new System.Drawing.Point(12, 278);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(95, 36);
            this.povratakButton.TabIndex = 1;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = true;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // prikažiButton
            // 
            this.prikažiButton.Location = new System.Drawing.Point(394, 278);
            this.prikažiButton.Name = "prikažiButton";
            this.prikažiButton.Size = new System.Drawing.Size(95, 36);
            this.prikažiButton.TabIndex = 4;
            this.prikažiButton.Text = "Prikaži";
            this.prikažiButton.UseVisualStyleBackColor = true;
            this.prikažiButton.Click += new System.EventHandler(this.prikažiButton_Click);
            // 
            // kreirajButton
            // 
            this.kreirajButton.Location = new System.Drawing.Point(293, 278);
            this.kreirajButton.Name = "kreirajButton";
            this.kreirajButton.Size = new System.Drawing.Size(95, 36);
            this.kreirajButton.TabIndex = 3;
            this.kreirajButton.Text = "Kreiraj";
            this.kreirajButton.UseVisualStyleBackColor = true;
            this.kreirajButton.Click += new System.EventHandler(this.kreirajButton_Click);
            // 
            // obrišiButton
            // 
            this.obrišiButton.Location = new System.Drawing.Point(192, 278);
            this.obrišiButton.Name = "obrišiButton";
            this.obrišiButton.Size = new System.Drawing.Size(95, 36);
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
            this.nisteDioDomacinstvaLabel.Location = new System.Drawing.Point(95, 130);
            this.nisteDioDomacinstvaLabel.Name = "nisteDioDomacinstvaLabel";
            this.nisteDioDomacinstvaLabel.Size = new System.Drawing.Size(313, 33);
            this.nisteDioDomacinstvaLabel.TabIndex = 25;
            this.nisteDioDomacinstvaLabel.Text = "Niste dio domaćinstva.";
            this.nisteDioDomacinstvaLabel.Visible = false;
            // 
            // ListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 334);
            this.Controls.Add(this.nisteDioDomacinstvaLabel);
            this.Controls.Add(this.obrišiButton);
            this.Controls.Add(this.kreirajButton);
            this.Controls.Add(this.prikažiButton);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.listeDataGridView);
            this.Name = "ListeForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.ListeForm_Load);
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