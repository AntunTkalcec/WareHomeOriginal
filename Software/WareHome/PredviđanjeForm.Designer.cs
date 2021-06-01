
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
            this.povratakButton = new System.Windows.Forms.Button();
            this.ispisiButton = new System.Windows.Forms.Button();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.predvidanjeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // predvidanjeDataGridView
            // 
            this.predvidanjeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predvidanjeDataGridView.Location = new System.Drawing.Point(12, 47);
            this.predvidanjeDataGridView.Name = "predvidanjeDataGridView";
            this.predvidanjeDataGridView.RowHeadersWidth = 25;
            this.predvidanjeDataGridView.Size = new System.Drawing.Size(750, 406);
            this.predvidanjeDataGridView.TabIndex = 1;
            // 
            // povratakButton
            // 
            this.povratakButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.povratakButton.FlatAppearance.BorderSize = 0;
            this.povratakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.povratakButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.povratakButton.ForeColor = System.Drawing.Color.White;
            this.povratakButton.Location = new System.Drawing.Point(13, 480);
            this.povratakButton.Margin = new System.Windows.Forms.Padding(4);
            this.povratakButton.Name = "povratakButton";
            this.povratakButton.Size = new System.Drawing.Size(254, 55);
            this.povratakButton.TabIndex = 11;
            this.povratakButton.Text = "Povratak";
            this.povratakButton.UseVisualStyleBackColor = false;
            // 
            // ispisiButton
            // 
            this.ispisiButton.FlatAppearance.BorderSize = 0;
            this.ispisiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ispisiButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ispisiButton.ForeColor = System.Drawing.Color.White;
            this.ispisiButton.Location = new System.Drawing.Point(508, 479);
            this.ispisiButton.Name = "ispisiButton";
            this.ispisiButton.Size = new System.Drawing.Size(254, 56);
            this.ispisiButton.TabIndex = 10;
            this.ispisiButton.Text = "Ispiši";
            this.ispisiButton.UseVisualStyleBackColor = true;
            this.ispisiButton.Click += new System.EventHandler(this.ispisiButton_Click);
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.nazivLabel.Location = new System.Drawing.Point(7, 9);
            this.nazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(310, 34);
            this.nazivLabel.TabIndex = 12;
            this.nazivLabel.Text = "Predviđanje potrošnje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(9, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "*Predviđena potrošnja nikad nije u potpunosti točna, već služi isključivo kao pom" +
    "oć pri planiranju količina";
            // 
            // PredviđanjeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(774, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazivLabel);
            this.Controls.Add(this.povratakButton);
            this.Controls.Add(this.ispisiButton);
            this.Controls.Add(this.predvidanjeDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PredviđanjeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Predviđanje potrošnje";
            this.Load += new System.EventHandler(this.PredviđanjeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predvidanjeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView predvidanjeDataGridView;
        private System.Windows.Forms.Button povratakButton;
        private System.Windows.Forms.Button ispisiButton;
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.Label label1;
    }
}