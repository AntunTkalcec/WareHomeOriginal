﻿
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
            this.danComboBox.Location = new System.Drawing.Point(105, 15);
            this.danComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.danComboBox.Name = "danComboBox";
            this.danComboBox.Size = new System.Drawing.Size(191, 24);
            this.danComboBox.TabIndex = 2;
            this.danComboBox.SelectedIndexChanged += new System.EventHandler(this.danComboBox_SelectedIndexChanged);
            // 
            // ponavljanjeComboBox
            // 
            this.ponavljanjeComboBox.FormattingEnabled = true;
            this.ponavljanjeComboBox.Location = new System.Drawing.Point(160, 81);
            this.ponavljanjeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ponavljanjeComboBox.Name = "ponavljanjeComboBox";
            this.ponavljanjeComboBox.Size = new System.Drawing.Size(65, 24);
            this.ponavljanjeComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = ":";
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(181, 124);
            this.spremiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(97, 42);
            this.spremiButton.TabIndex = 1;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(43, 124);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(97, 42);
            this.odustaniButton.TabIndex = 6;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vrijeme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ponavljanje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "svakih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "tjedan/a";
            // 
            // satComboBox
            // 
            this.satComboBox.FormattingEnabled = true;
            this.satComboBox.Location = new System.Drawing.Point(105, 48);
            this.satComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.satComboBox.Name = "satComboBox";
            this.satComboBox.Size = new System.Drawing.Size(85, 24);
            this.satComboBox.TabIndex = 3;
            // 
            // minutaComboBox
            // 
            this.minutaComboBox.FormattingEnabled = true;
            this.minutaComboBox.Location = new System.Drawing.Point(211, 48);
            this.minutaComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minutaComboBox.Name = "minutaComboBox";
            this.minutaComboBox.Size = new System.Drawing.Size(85, 24);
            this.minutaComboBox.TabIndex = 4;
            // 
            // RasporedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 193);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RasporedForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raspored kupovine";
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