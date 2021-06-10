
namespace WareHome
{
    partial class DodajNaListuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.trgovinaTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trgovina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Količina:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(92, 16);
            this.nazivTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(177, 20);
            this.nazivTextBox.TabIndex = 1;
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.Location = new System.Drawing.Point(92, 48);
            this.cijenaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(87, 20);
            this.cijenaTextBox.TabIndex = 2;
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.Location = new System.Drawing.Point(92, 80);
            this.kolicinaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(87, 20);
            this.kolicinaTextBox.TabIndex = 3;
            // 
            // trgovinaTextBox
            // 
            this.trgovinaTextBox.Location = new System.Drawing.Point(92, 112);
            this.trgovinaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.trgovinaTextBox.Name = "trgovinaTextBox";
            this.trgovinaTextBox.Size = new System.Drawing.Size(177, 20);
            this.trgovinaTextBox.TabIndex = 4;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(171, 156);
            this.dodajButton.Margin = new System.Windows.Forms.Padding(4);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 28);
            this.dodajButton.TabIndex = 5;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(19, 156);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(100, 28);
            this.odustaniButton.TabIndex = 6;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "* obvezno polje";
            // 
            // DodajNaListuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(296, 215);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.trgovinaTextBox);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DodajNaListuForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj namirnicu";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DodajNaListuForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.TextBox trgovinaTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label label5;
    }
}