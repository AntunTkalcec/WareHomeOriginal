
namespace WareHome
{
    partial class PredviđanjeForm
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
            this.predvidanjeDataGridView = new System.Windows.Forms.DataGridView();
            this.ispisButton = new System.Windows.Forms.Button();
            this.povratakButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.predvidanjeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // predvidanjeDataGridView
            // 
            this.predvidanjeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predvidanjeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.predvidanjeDataGridView.Name = "predvidanjeDataGridView";
            this.predvidanjeDataGridView.RowHeadersWidth = 25;
            this.predvidanjeDataGridView.Size = new System.Drawing.Size(750, 406);
            this.predvidanjeDataGridView.TabIndex = 1;
            // 
            // ispisButton
            // 
            this.ispisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ispisButton.FlatAppearance.BorderSize = 0;
            this.ispisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ispisButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ispisButton.ForeColor = System.Drawing.Color.White;
            this.ispisButton.Location = new System.Drawing.Point(635, 425);
            this.ispisButton.Name = "ispisButton";
            this.ispisButton.Size = new System.Drawing.Size(127, 44);
            this.ispisButton.TabIndex = 9;
            this.ispisButton.Text = "Ispis";
            this.ispisButton.UseVisualStyleBackColor = false;
            this.ispisButton.Click += new System.EventHandler(this.ispisButton_Click);
            // 
            // povratakButton
            // 
            this.povratakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.povratakButton.FlatAppearance.BorderSize = 0;
            this.povratakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.povratakButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.povratakButton.ForeColor = System.Drawing.Color.White;
            this.povratakButton.Location = new System.Drawing.Point(13, 425);
            this.povratakButton.Margin = new System.Windows.Forms.Padding(4);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(127, 44);
            this.povratakButton.TabIndex = 8;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = false;
            this.povratakButton.Click += new System.EventHandler(this.povratakButton_Click);
            // 
            // PredviđanjeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(776, 477);
            this.Controls.Add(this.ispisButton);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.predvidanjeDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PredviđanjeForm";
            this.ShowInTaskbar = false;
            this.Text = "Predviđanje potrošnje";
            this.Load += new System.EventHandler(this.PredviđanjeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predvidanjeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView predvidanjeDataGridView;
        private System.Windows.Forms.Button ispisButton;
        private System.Windows.Forms.Button povratakButton;
    }
}