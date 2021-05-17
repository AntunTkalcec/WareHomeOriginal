
namespace WareHome
{
    partial class PrijavaProblemaForm
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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.prijavaProblemaLabel = new System.Windows.Forms.Label();
            this.opisProblemaLabel = new System.Windows.Forms.Label();
            this.problemTextBox = new System.Windows.Forms.RichTextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.Location = new System.Drawing.Point(355, -2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 26);
            this.minimizeButton.TabIndex = 25;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitAppButton
            // 
            this.exitAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exitAppButton.FlatAppearance.BorderSize = 0;
            this.exitAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppButton.ForeColor = System.Drawing.Color.DarkGray;
            this.exitAppButton.Location = new System.Drawing.Point(384, -2);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(23, 26);
            this.exitAppButton.TabIndex = 24;
            this.exitAppButton.Text = "X";
            this.exitAppButton.UseVisualStyleBackColor = false;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // prijavaProblemaLabel
            // 
            this.prijavaProblemaLabel.AutoSize = true;
            this.prijavaProblemaLabel.Location = new System.Drawing.Point(134, 32);
            this.prijavaProblemaLabel.Name = "prijavaProblemaLabel";
            this.prijavaProblemaLabel.Size = new System.Drawing.Size(142, 21);
            this.prijavaProblemaLabel.TabIndex = 26;
            this.prijavaProblemaLabel.Text = "Prijava problema";
            // 
            // opisProblemaLabel
            // 
            this.opisProblemaLabel.AutoSize = true;
            this.opisProblemaLabel.Location = new System.Drawing.Point(58, 86);
            this.opisProblemaLabel.Name = "opisProblemaLabel";
            this.opisProblemaLabel.Size = new System.Drawing.Size(295, 21);
            this.opisProblemaLabel.TabIndex = 27;
            this.opisProblemaLabel.Text = "Molimo opišite problem što detaljnije:";
            // 
            // problemTextBox
            // 
            this.problemTextBox.Location = new System.Drawing.Point(26, 126);
            this.problemTextBox.Name = "problemTextBox";
            this.problemTextBox.Size = new System.Drawing.Size(352, 237);
            this.problemTextBox.TabIndex = 1;
            this.problemTextBox.Text = "";
            // 
            // btnPosalji
            // 
            this.btnPosalji.FlatAppearance.BorderSize = 0;
            this.btnPosalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosalji.ForeColor = System.Drawing.Color.White;
            this.btnPosalji.Location = new System.Drawing.Point(129, 370);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(138, 35);
            this.btnPosalji.TabIndex = 2;
            this.btnPosalji.Text = "Pošalji prijavu";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // PrijavaProblemaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(406, 417);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.problemTextBox);
            this.Controls.Add(this.opisProblemaLabel);
            this.Controls.Add(this.prijavaProblemaLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitAppButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrijavaProblemaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrijavaProblemaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitAppButton;
        private System.Windows.Forms.Label prijavaProblemaLabel;
        private System.Windows.Forms.Label opisProblemaLabel;
        private System.Windows.Forms.RichTextBox problemTextBox;
        private System.Windows.Forms.Button btnPosalji;
    }
}