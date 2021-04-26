
namespace WareHome
{
    partial class RasporedForm
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
            this.danComboBox = new System.Windows.Forms.ComboBox();
            this.ponavljanjeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.satComboBox = new System.Windows.Forms.ComboBox();
            this.minutaComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // danComboBox
            // 
            this.danComboBox.FormattingEnabled = true;
            this.danComboBox.Location = new System.Drawing.Point(79, 12);
            this.danComboBox.Name = "danComboBox";
            this.danComboBox.Size = new System.Drawing.Size(144, 21);
            this.danComboBox.TabIndex = 0;
            // 
            // ponavljanjeComboBox
            // 
            this.ponavljanjeComboBox.FormattingEnabled = true;
            this.ponavljanjeComboBox.Location = new System.Drawing.Point(120, 66);
            this.ponavljanjeComboBox.Name = "ponavljanjeComboBox";
            this.ponavljanjeComboBox.Size = new System.Drawing.Size(50, 21);
            this.ponavljanjeComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(136, 101);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(73, 34);
            this.spremiButton.TabIndex = 6;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(32, 101);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(73, 34);
            this.odustaniButton.TabIndex = 7;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vrijeme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ponavljanje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "svakih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "tjedan/a";
            // 
            // satComboBox
            // 
            this.satComboBox.FormattingEnabled = true;
            this.satComboBox.Location = new System.Drawing.Point(79, 39);
            this.satComboBox.Name = "satComboBox";
            this.satComboBox.Size = new System.Drawing.Size(65, 21);
            this.satComboBox.TabIndex = 13;
            // 
            // minutaComboBox
            // 
            this.minutaComboBox.FormattingEnabled = true;
            this.minutaComboBox.Location = new System.Drawing.Point(158, 39);
            this.minutaComboBox.Name = "minutaComboBox";
            this.minutaComboBox.Size = new System.Drawing.Size(65, 21);
            this.minutaComboBox.TabIndex = 14;
            // 
            // RasporedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 157);
            this.Controls.Add(this.minutaComboBox);
            this.Controls.Add(this.satComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ponavljanjeComboBox);
            this.Controls.Add(this.danComboBox);
            this.Name = "RasporedForm";
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.RasporedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox danComboBox;
        private System.Windows.Forms.ComboBox ponavljanjeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox satComboBox;
        private System.Windows.Forms.ComboBox minutaComboBox;
    }
}