
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.povratakButton = new System.Windows.Forms.Button();
            this.prikažiButton = new System.Windows.Forms.Button();
            this.kreirajButton = new System.Windows.Forms.Button();
            this.obrišiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // povratakButton
            // 
            this.povratakButton.Location = new System.Drawing.Point(12, 396);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(95, 36);
            this.povratakButton.TabIndex = 1;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = true;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // prikažiButton
            // 
            this.prikažiButton.Location = new System.Drawing.Point(693, 396);
            this.prikažiButton.Name = "prikažiButton";
            this.prikažiButton.Size = new System.Drawing.Size(95, 36);
            this.prikažiButton.TabIndex = 2;
            this.prikažiButton.Text = "Prikaži";
            this.prikažiButton.UseVisualStyleBackColor = true;
            this.prikažiButton.Click += new System.EventHandler(this.prikažiButton_Click);
            // 
            // kreirajButton
            // 
            this.kreirajButton.Location = new System.Drawing.Point(592, 396);
            this.kreirajButton.Name = "kreirajButton";
            this.kreirajButton.Size = new System.Drawing.Size(95, 36);
            this.kreirajButton.TabIndex = 3;
            this.kreirajButton.Text = "Kreiraj";
            this.kreirajButton.UseVisualStyleBackColor = true;
            // 
            // obrišiButton
            // 
            this.obrišiButton.Location = new System.Drawing.Point(491, 396);
            this.obrišiButton.Name = "obrišiButton";
            this.obrišiButton.Size = new System.Drawing.Size(95, 36);
            this.obrišiButton.TabIndex = 4;
            this.obrišiButton.Text = "Obriši";
            this.obrišiButton.UseVisualStyleBackColor = true;
            // 
            // ListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.obrišiButton);
            this.Controls.Add(this.kreirajButton);
            this.Controls.Add(this.prikažiButton);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeForm";
            this.Text = "WareHome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button povratakButton;
        private System.Windows.Forms.Button prikažiButton;
        private System.Windows.Forms.Button kreirajButton;
        private System.Windows.Forms.Button obrišiButton;
    }
}