
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
            ((System.ComponentModel.ISupportInitialize)(this.namirniceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // preimenujButton
            // 
            this.preimenujButton.Location = new System.Drawing.Point(693, 12);
            this.preimenujButton.Name = "preimenujButton";
            this.preimenujButton.Size = new System.Drawing.Size(95, 23);
            this.preimenujButton.TabIndex = 9;
            this.preimenujButton.Text = "Promijeni naziv";
            this.preimenujButton.UseVisualStyleBackColor = true;
            // 
            // ukloniButton
            // 
            this.ukloniButton.Location = new System.Drawing.Point(592, 399);
            this.ukloniButton.Name = "ukloniButton";
            this.ukloniButton.Size = new System.Drawing.Size(95, 36);
            this.ukloniButton.TabIndex = 8;
            this.ukloniButton.Text = "Ukloni";
            this.ukloniButton.UseVisualStyleBackColor = true;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(693, 399);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(95, 36);
            this.dodajButton.TabIndex = 7;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // povratakButton
            // 
            this.povratakButton.Location = new System.Drawing.Point(12, 399);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(95, 36);
            this.povratakButton.TabIndex = 6;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = true;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // namirniceDataGridView
            // 
            this.namirniceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namirniceDataGridView.Location = new System.Drawing.Point(12, 41);
            this.namirniceDataGridView.Name = "namirniceDataGridView";
            this.namirniceDataGridView.Size = new System.Drawing.Size(776, 335);
            this.namirniceDataGridView.TabIndex = 5;
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivLabel.Location = new System.Drawing.Point(9, 13);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(64, 18);
            this.nazivLabel.TabIndex = 10;
            this.nazivLabel.Text = "NAZIV";
            // 
            // ListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.preimenujButton);
            this.Controls.Add(this.ukloniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.namirniceDataGridView);
            this.Name = "ListaForm";
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
    }
}