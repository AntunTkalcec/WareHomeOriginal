
namespace WareHome
{
    partial class TestiranjeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.odjavaDomacinstvaButton = new System.Windows.Forms.Button();
            this.nazivDomacinstvaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.predvidanjeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // predvidanjeDataGridView
            // 
            this.predvidanjeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predvidanjeDataGridView.Location = new System.Drawing.Point(12, 25);
            this.predvidanjeDataGridView.Name = "predvidanjeDataGridView";
            this.predvidanjeDataGridView.RowHeadersWidth = 25;
            this.predvidanjeDataGridView.Size = new System.Drawing.Size(750, 406);
            this.predvidanjeDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Predviđanje potrošnje:";
            // 
            // odjavaDomacinstvaButton
            // 
            this.odjavaDomacinstvaButton.Location = new System.Drawing.Point(650, 437);
            this.odjavaDomacinstvaButton.Name = "odjavaDomacinstvaButton";
            this.odjavaDomacinstvaButton.Size = new System.Drawing.Size(112, 39);
            this.odjavaDomacinstvaButton.TabIndex = 2;
            this.odjavaDomacinstvaButton.Text = "Odjava iz domaćinstva";
            this.odjavaDomacinstvaButton.UseVisualStyleBackColor = true;
            this.odjavaDomacinstvaButton.Click += new System.EventHandler(this.odjavaDomacinstvaButton_Click);
            // 
            // nazivDomacinstvaButton
            // 
            this.nazivDomacinstvaButton.Location = new System.Drawing.Point(532, 437);
            this.nazivDomacinstvaButton.Name = "nazivDomacinstvaButton";
            this.nazivDomacinstvaButton.Size = new System.Drawing.Size(112, 39);
            this.nazivDomacinstvaButton.TabIndex = 3;
            this.nazivDomacinstvaButton.Text = "Promijeni naziv domaćinstva";
            this.nazivDomacinstvaButton.UseVisualStyleBackColor = true;
            // 
            // TestiranjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 488);
            this.Controls.Add(this.nazivDomacinstvaButton);
            this.Controls.Add(this.odjavaDomacinstvaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predvidanjeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestiranjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Testiranje neimplementiranihi funkcija";
            this.Load += new System.EventHandler(this.TestiranjeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predvidanjeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView predvidanjeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odjavaDomacinstvaButton;
        private System.Windows.Forms.Button nazivDomacinstvaButton;
    }
}