
namespace WareHome
{
    partial class GlavnaForm
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
            this.rasporedButton = new System.Windows.Forms.Button();
            this.listeButton = new System.Windows.Forms.Button();
            this.odjavaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rasporedButton
            // 
            this.rasporedButton.Location = new System.Drawing.Point(683, 12);
            this.rasporedButton.Name = "rasporedButton";
            this.rasporedButton.Size = new System.Drawing.Size(105, 36);
            this.rasporedButton.TabIndex = 0;
            this.rasporedButton.Text = "Raspored odlaska u kupovinu";
            this.rasporedButton.UseVisualStyleBackColor = true;
            this.rasporedButton.Click += new System.EventHandler(this.rasporedButton_Click);
            // 
            // listeButton
            // 
            this.listeButton.Location = new System.Drawing.Point(683, 54);
            this.listeButton.Name = "listeButton";
            this.listeButton.Size = new System.Drawing.Size(105, 35);
            this.listeButton.TabIndex = 1;
            this.listeButton.Text = "Liste za kupovinu";
            this.listeButton.UseVisualStyleBackColor = true;
            this.listeButton.Click += new System.EventHandler(this.listeButton_Click);
            // 
            // odjavaButton
            // 
            this.odjavaButton.Location = new System.Drawing.Point(697, 402);
            this.odjavaButton.Name = "odjavaButton";
            this.odjavaButton.Size = new System.Drawing.Size(91, 36);
            this.odjavaButton.TabIndex = 2;
            this.odjavaButton.Text = "Odjava";
            this.odjavaButton.UseVisualStyleBackColor = true;
            this.odjavaButton.Click += new System.EventHandler(this.odjavaButton_Click);
            // 
            // GlavnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odjavaButton);
            this.Controls.Add(this.listeButton);
            this.Controls.Add(this.rasporedButton);
            this.Name = "GlavnaForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.GlavnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rasporedButton;
        private System.Windows.Forms.Button listeButton;
        private System.Windows.Forms.Button odjavaButton;
    }
}