
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
            ((System.ComponentModel.ISupportInitialize)(this.listeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listeDataGridView
            // 
            this.listeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeDataGridView.Location = new System.Drawing.Point(16, 15);
            this.listeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.listeDataGridView.Name = "listeDataGridView";
            this.listeDataGridView.RowHeadersWidth = 51;
            this.listeDataGridView.ShowEditingIcon = false;
            this.listeDataGridView.Size = new System.Drawing.Size(636, 320);
            this.listeDataGridView.TabIndex = 0;
            // 
            // povratakButton
            // 
            this.povratakButton.Location = new System.Drawing.Point(16, 342);
            this.povratakButton.Margin = new System.Windows.Forms.Padding(4);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(127, 44);
            this.povratakButton.TabIndex = 1;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = true;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // prikažiButton
            // 
            this.prikažiButton.Location = new System.Drawing.Point(525, 342);
            this.prikažiButton.Margin = new System.Windows.Forms.Padding(4);
            this.prikažiButton.Name = "prikažiButton";
            this.prikažiButton.Size = new System.Drawing.Size(127, 44);
            this.prikažiButton.TabIndex = 4;
            this.prikažiButton.Text = "Prikaži";
            this.prikažiButton.UseVisualStyleBackColor = true;
            this.prikažiButton.Click += new System.EventHandler(this.prikažiButton_Click);
            // 
            // kreirajButton
            // 
            this.kreirajButton.Location = new System.Drawing.Point(391, 342);
            this.kreirajButton.Margin = new System.Windows.Forms.Padding(4);
            this.kreirajButton.Name = "kreirajButton";
            this.kreirajButton.Size = new System.Drawing.Size(127, 44);
            this.kreirajButton.TabIndex = 3;
            this.kreirajButton.Text = "Kreiraj";
            this.kreirajButton.UseVisualStyleBackColor = true;
            this.kreirajButton.Click += new System.EventHandler(this.kreirajButton_Click);
            // 
            // obrišiButton
            // 
            this.obrišiButton.Location = new System.Drawing.Point(256, 342);
            this.obrišiButton.Margin = new System.Windows.Forms.Padding(4);
            this.obrišiButton.Name = "obrišiButton";
            this.obrišiButton.Size = new System.Drawing.Size(127, 44);
            this.obrišiButton.TabIndex = 2;
            this.obrišiButton.Text = "Obriši";
            this.obrišiButton.UseVisualStyleBackColor = true;
            this.obrišiButton.Click += new System.EventHandler(this.obrišiButton_Click);
            // 
            // ListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 411);
            this.Controls.Add(this.obrišiButton);
            this.Controls.Add(this.kreirajButton);
            this.Controls.Add(this.prikažiButton);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.listeDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.ListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listeDataGridView;
        private System.Windows.Forms.Button povratakButton;
        private System.Windows.Forms.Button prikažiButton;
        private System.Windows.Forms.Button kreirajButton;
        private System.Windows.Forms.Button obrišiButton;
    }
}