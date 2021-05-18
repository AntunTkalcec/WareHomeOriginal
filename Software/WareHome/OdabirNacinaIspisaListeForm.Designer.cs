
namespace WareHome
{
    partial class OdabirNacinaIspisaListeForm
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
            this.opisLabel = new System.Windows.Forms.Label();
            this.silaznoCheckBox = new System.Windows.Forms.CheckBox();
            this.premaTrgoviniCheckBox = new System.Windows.Forms.CheckBox();
            this.premaCijeniCheckBox = new System.Windows.Forms.CheckBox();
            this.premaKoliciniCheckBox = new System.Windows.Forms.CheckBox();
            this.ispisiButton = new System.Windows.Forms.Button();
            this.namirniceDataGridView = new System.Windows.Forms.DataGridView();
            this.uzlaznoCheckBox = new System.Windows.Forms.CheckBox();
            this.povratakButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.namirniceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.opisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.opisLabel.Location = new System.Drawing.Point(8, 18);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(265, 26);
            this.opisLabel.TabIndex = 0;
            this.opisLabel.Text = "Kako želite ispisati listu?";
            // 
            // silaznoCheckBox
            // 
            this.silaznoCheckBox.AutoSize = true;
            this.silaznoCheckBox.Location = new System.Drawing.Point(12, 97);
            this.silaznoCheckBox.Name = "silaznoCheckBox";
            this.silaznoCheckBox.Size = new System.Drawing.Size(76, 24);
            this.silaznoCheckBox.TabIndex = 2;
            this.silaznoCheckBox.Text = "Silazno";
            this.silaznoCheckBox.UseVisualStyleBackColor = true;
            this.silaznoCheckBox.Click += new System.EventHandler(this.silaznoCheckBox_Click);
            // 
            // premaTrgoviniCheckBox
            // 
            this.premaTrgoviniCheckBox.AutoSize = true;
            this.premaTrgoviniCheckBox.Location = new System.Drawing.Point(12, 214);
            this.premaTrgoviniCheckBox.Name = "premaTrgoviniCheckBox";
            this.premaTrgoviniCheckBox.Size = new System.Drawing.Size(134, 24);
            this.premaTrgoviniCheckBox.TabIndex = 3;
            this.premaTrgoviniCheckBox.Text = "Prema trgovini";
            this.premaTrgoviniCheckBox.UseVisualStyleBackColor = true;
            this.premaTrgoviniCheckBox.Click += new System.EventHandler(this.premaTrgoviniCheckBox_Click);
            // 
            // premaCijeniCheckBox
            // 
            this.premaCijeniCheckBox.AutoSize = true;
            this.premaCijeniCheckBox.Location = new System.Drawing.Point(12, 154);
            this.premaCijeniCheckBox.Name = "premaCijeniCheckBox";
            this.premaCijeniCheckBox.Size = new System.Drawing.Size(117, 24);
            this.premaCijeniCheckBox.TabIndex = 4;
            this.premaCijeniCheckBox.Text = "Prema cijeni";
            this.premaCijeniCheckBox.UseVisualStyleBackColor = true;
            this.premaCijeniCheckBox.Click += new System.EventHandler(this.premaCijeniCheckBox_Click);
            // 
            // premaKoliciniCheckBox
            // 
            this.premaKoliciniCheckBox.AutoSize = true;
            this.premaKoliciniCheckBox.Location = new System.Drawing.Point(12, 184);
            this.premaKoliciniCheckBox.Name = "premaKoliciniCheckBox";
            this.premaKoliciniCheckBox.Size = new System.Drawing.Size(128, 24);
            this.premaKoliciniCheckBox.TabIndex = 5;
            this.premaKoliciniCheckBox.Text = "Prema količini";
            this.premaKoliciniCheckBox.UseVisualStyleBackColor = true;
            this.premaKoliciniCheckBox.Click += new System.EventHandler(this.premaKoliciniCheckBox_Click);
            // 
            // ispisiButton
            // 
            this.ispisiButton.FlatAppearance.BorderSize = 0;
            this.ispisiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ispisiButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ispisiButton.ForeColor = System.Drawing.Color.White;
            this.ispisiButton.Location = new System.Drawing.Point(678, 474);
            this.ispisiButton.Name = "ispisiButton";
            this.ispisiButton.Size = new System.Drawing.Size(254, 56);
            this.ispisiButton.TabIndex = 6;
            this.ispisiButton.Text = "Ispiši";
            this.ispisiButton.UseVisualStyleBackColor = true;
            this.ispisiButton.Click += new System.EventHandler(this.ispisiButton_Click);
            // 
            // namirniceDataGridView
            // 
            this.namirniceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namirniceDataGridView.Location = new System.Drawing.Point(153, 67);
            this.namirniceDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.namirniceDataGridView.Name = "namirniceDataGridView";
            this.namirniceDataGridView.RowHeadersWidth = 25;
            this.namirniceDataGridView.Size = new System.Drawing.Size(779, 400);
            this.namirniceDataGridView.TabIndex = 7;
            // 
            // uzlaznoCheckBox
            // 
            this.uzlaznoCheckBox.AutoSize = true;
            this.uzlaznoCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.uzlaznoCheckBox.Location = new System.Drawing.Point(12, 67);
            this.uzlaznoCheckBox.Name = "uzlaznoCheckBox";
            this.uzlaznoCheckBox.Size = new System.Drawing.Size(83, 24);
            this.uzlaznoCheckBox.TabIndex = 1;
            this.uzlaznoCheckBox.Text = "Uzlazno";
            this.uzlaznoCheckBox.UseVisualStyleBackColor = true;
            this.uzlaznoCheckBox.Click += new System.EventHandler(this.uzlaznoCheckBox_Click);
            // 
            // povratakButton
            // 
            this.povratakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.povratakButton.FlatAppearance.BorderSize = 0;
            this.povratakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.povratakButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.povratakButton.ForeColor = System.Drawing.Color.White;
            this.povratakButton.Location = new System.Drawing.Point(13, 476);
            this.povratakButton.Margin = new System.Windows.Forms.Padding(4);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(254, 55);
            this.povratakButton.TabIndex = 9;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = false;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // OdabirNacinaIspisaListeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(967, 556);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.namirniceDataGridView);
            this.Controls.Add(this.ispisiButton);
            this.Controls.Add(this.premaKoliciniCheckBox);
            this.Controls.Add(this.premaCijeniCheckBox);
            this.Controls.Add(this.premaTrgoviniCheckBox);
            this.Controls.Add(this.silaznoCheckBox);
            this.Controls.Add(this.uzlaznoCheckBox);
            this.Controls.Add(this.opisLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OdabirNacinaIspisaListeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ispis liste";
            this.Load += new System.EventHandler(this.OdabirNacinaIspisaListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.namirniceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.CheckBox silaznoCheckBox;
        private System.Windows.Forms.CheckBox premaTrgoviniCheckBox;
        private System.Windows.Forms.CheckBox premaCijeniCheckBox;
        private System.Windows.Forms.CheckBox premaKoliciniCheckBox;
        private System.Windows.Forms.Button ispisiButton;
        private System.Windows.Forms.DataGridView namirniceDataGridView;
        private System.Windows.Forms.CheckBox uzlaznoCheckBox;
        private System.Windows.Forms.Button povratakButton;
    }
}