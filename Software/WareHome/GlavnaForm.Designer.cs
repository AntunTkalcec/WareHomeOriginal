
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rasporedButton = new System.Windows.Forms.Button();
            this.listeButton = new System.Windows.Forms.Button();
            this.odjavaButton = new System.Windows.Forms.Button();
            this.glavnaFormPanelLeft = new System.Windows.Forms.Panel();
            this.pridruziDomacinstvuButton = new System.Windows.Forms.Button();
            this.izradiDomacinstvoButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            this.glavnaFormPanelLeftTop = new System.Windows.Forms.Panel();
            this.warehomePictureBox = new System.Windows.Forms.PictureBox();
            this.namirniceDGV = new System.Windows.Forms.DataGridView();
            this.popisNamirnicaLabel = new System.Windows.Forms.Label();
            this.glavnaFormPanelBottom = new System.Windows.Forms.Panel();
            this.brojNamirnicaLabel2 = new System.Windows.Forms.Label();
            this.trenutnoDomacinstvoLabel2 = new System.Windows.Forms.Label();
            this.brojNamirnicaLabel = new System.Windows.Forms.Label();
            this.trenutnoDomacinstvoLabel = new System.Windows.Forms.Label();
            this.obrisiNamirnicuButton = new System.Windows.Forms.Button();
            this.promijeniNamirnicuButton = new System.Windows.Forms.Button();
            this.dodajNamirnicuButton = new System.Windows.Forms.Button();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.nisteDioDomacinstvaLabel = new System.Windows.Forms.Label();
            this.glavnaFormPanelLeft.SuspendLayout();
            this.glavnaFormPanelLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehomePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namirniceDGV)).BeginInit();
            this.glavnaFormPanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // rasporedButton
            // 
            this.rasporedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.rasporedButton.FlatAppearance.BorderSize = 0;
            this.rasporedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rasporedButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rasporedButton.ForeColor = System.Drawing.Color.White;
            this.rasporedButton.Location = new System.Drawing.Point(0, 545);
            this.rasporedButton.Name = "rasporedButton";
            this.rasporedButton.Size = new System.Drawing.Size(173, 52);
            this.rasporedButton.TabIndex = 0;
            this.rasporedButton.Text = "Raspored odlaska u kupovinu";
            this.rasporedButton.UseVisualStyleBackColor = true;
            this.rasporedButton.Click += new System.EventHandler(this.rasporedButton_Click);
            // 
            // listeButton
            // 
            this.listeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.listeButton.FlatAppearance.BorderSize = 0;
            this.listeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeButton.ForeColor = System.Drawing.Color.White;
            this.listeButton.Location = new System.Drawing.Point(0, 603);
            this.listeButton.Name = "listeButton";
            this.listeButton.Size = new System.Drawing.Size(173, 50);
            this.listeButton.TabIndex = 1;
            this.listeButton.Text = "Liste za kupovinu";
            this.listeButton.UseVisualStyleBackColor = true;
            this.listeButton.Click += new System.EventHandler(this.listeButton_Click);
            // 
            // odjavaButton
            // 
            this.odjavaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.odjavaButton.FlatAppearance.BorderSize = 0;
            this.odjavaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odjavaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjavaButton.ForeColor = System.Drawing.Color.White;
            this.odjavaButton.Location = new System.Drawing.Point(0, 659);
            this.odjavaButton.Name = "odjavaButton";
            this.odjavaButton.Size = new System.Drawing.Size(173, 36);
            this.odjavaButton.TabIndex = 2;
            this.odjavaButton.Text = "Odjava";
            this.odjavaButton.UseVisualStyleBackColor = true;
            this.odjavaButton.Click += new System.EventHandler(this.odjavaButton_Click);
            // 
            // glavnaFormPanelLeft
            // 
            this.glavnaFormPanelLeft.Controls.Add(this.pridruziDomacinstvuButton);
            this.glavnaFormPanelLeft.Controls.Add(this.izradiDomacinstvoButton);
            this.glavnaFormPanelLeft.Controls.Add(this.pdfButton);
            this.glavnaFormPanelLeft.Controls.Add(this.glavnaFormPanelLeftTop);
            this.glavnaFormPanelLeft.Controls.Add(this.rasporedButton);
            this.glavnaFormPanelLeft.Controls.Add(this.listeButton);
            this.glavnaFormPanelLeft.Controls.Add(this.odjavaButton);
            this.glavnaFormPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.glavnaFormPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.glavnaFormPanelLeft.Name = "glavnaFormPanelLeft";
            this.glavnaFormPanelLeft.Size = new System.Drawing.Size(173, 695);
            this.glavnaFormPanelLeft.TabIndex = 3;
            // 
            // pridruziDomacinstvuButton
            // 
            this.pridruziDomacinstvuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.pridruziDomacinstvuButton.FlatAppearance.BorderSize = 0;
            this.pridruziDomacinstvuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pridruziDomacinstvuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pridruziDomacinstvuButton.ForeColor = System.Drawing.Color.White;
            this.pridruziDomacinstvuButton.Location = new System.Drawing.Point(0, 153);
            this.pridruziDomacinstvuButton.Name = "pridruziDomacinstvuButton";
            this.pridruziDomacinstvuButton.Size = new System.Drawing.Size(173, 50);
            this.pridruziDomacinstvuButton.TabIndex = 5;
            this.pridruziDomacinstvuButton.Text = "Pridruži se domaćinstvu";
            this.pridruziDomacinstvuButton.UseVisualStyleBackColor = true;
            // 
            // izradiDomacinstvoButton
            // 
            this.izradiDomacinstvoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.izradiDomacinstvoButton.FlatAppearance.BorderSize = 0;
            this.izradiDomacinstvoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izradiDomacinstvoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izradiDomacinstvoButton.ForeColor = System.Drawing.Color.White;
            this.izradiDomacinstvoButton.Location = new System.Drawing.Point(0, 106);
            this.izradiDomacinstvoButton.Name = "izradiDomacinstvoButton";
            this.izradiDomacinstvoButton.Size = new System.Drawing.Size(173, 40);
            this.izradiDomacinstvoButton.TabIndex = 4;
            this.izradiDomacinstvoButton.Text = "Izradi domaćinstvo";
            this.izradiDomacinstvoButton.UseVisualStyleBackColor = true;
            // 
            // pdfButton
            // 
            this.pdfButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.pdfButton.FlatAppearance.BorderSize = 0;
            this.pdfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfButton.ForeColor = System.Drawing.Color.White;
            this.pdfButton.Location = new System.Drawing.Point(0, 504);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(173, 35);
            this.pdfButton.TabIndex = 3;
            this.pdfButton.Text = "Spremanje u PDF";
            this.pdfButton.UseVisualStyleBackColor = true;
            // 
            // glavnaFormPanelLeftTop
            // 
            this.glavnaFormPanelLeftTop.Controls.Add(this.warehomePictureBox);
            this.glavnaFormPanelLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.glavnaFormPanelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.glavnaFormPanelLeftTop.Name = "glavnaFormPanelLeftTop";
            this.glavnaFormPanelLeftTop.Size = new System.Drawing.Size(173, 100);
            this.glavnaFormPanelLeftTop.TabIndex = 0;
            // 
            // warehomePictureBox
            // 
            this.warehomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("warehomePictureBox.Image")));
            this.warehomePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("warehomePictureBox.InitialImage")));
            this.warehomePictureBox.Location = new System.Drawing.Point(-15, -72);
            this.warehomePictureBox.Name = "warehomePictureBox";
            this.warehomePictureBox.Size = new System.Drawing.Size(201, 135);
            this.warehomePictureBox.TabIndex = 0;
            this.warehomePictureBox.TabStop = false;
            // 
            // namirniceDGV
            // 
            this.namirniceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.namirniceDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.namirniceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.namirniceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namirniceDGV.Location = new System.Drawing.Point(207, 39);
            this.namirniceDGV.Name = "namirniceDGV";
            this.namirniceDGV.RowHeadersWidth = 5;
            this.namirniceDGV.Size = new System.Drawing.Size(1170, 479);
            this.namirniceDGV.TabIndex = 20;
            // 
            // popisNamirnicaLabel
            // 
            this.popisNamirnicaLabel.AutoSize = true;
            this.popisNamirnicaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.popisNamirnicaLabel.Location = new System.Drawing.Point(203, 12);
            this.popisNamirnicaLabel.Name = "popisNamirnicaLabel";
            this.popisNamirnicaLabel.Size = new System.Drawing.Size(131, 21);
            this.popisNamirnicaLabel.TabIndex = 21;
            this.popisNamirnicaLabel.Text = "Popis namirnica";
            // 
            // glavnaFormPanelBottom
            // 
            this.glavnaFormPanelBottom.Controls.Add(this.brojNamirnicaLabel2);
            this.glavnaFormPanelBottom.Controls.Add(this.trenutnoDomacinstvoLabel2);
            this.glavnaFormPanelBottom.Controls.Add(this.brojNamirnicaLabel);
            this.glavnaFormPanelBottom.Controls.Add(this.trenutnoDomacinstvoLabel);
            this.glavnaFormPanelBottom.Controls.Add(this.obrisiNamirnicuButton);
            this.glavnaFormPanelBottom.Controls.Add(this.promijeniNamirnicuButton);
            this.glavnaFormPanelBottom.Controls.Add(this.dodajNamirnicuButton);
            this.glavnaFormPanelBottom.Location = new System.Drawing.Point(179, 524);
            this.glavnaFormPanelBottom.Name = "glavnaFormPanelBottom";
            this.glavnaFormPanelBottom.Size = new System.Drawing.Size(1231, 171);
            this.glavnaFormPanelBottom.TabIndex = 22;
            // 
            // brojNamirnicaLabel2
            // 
            this.brojNamirnicaLabel2.AutoSize = true;
            this.brojNamirnicaLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brojNamirnicaLabel2.ForeColor = System.Drawing.Color.White;
            this.brojNamirnicaLabel2.Location = new System.Drawing.Point(856, 94);
            this.brojNamirnicaLabel2.Name = "brojNamirnicaLabel2";
            this.brojNamirnicaLabel2.Size = new System.Drawing.Size(42, 21);
            this.brojNamirnicaLabel2.TabIndex = 7;
            this.brojNamirnicaLabel2.Text = "N/A";
            // 
            // trenutnoDomacinstvoLabel2
            // 
            this.trenutnoDomacinstvoLabel2.AutoSize = true;
            this.trenutnoDomacinstvoLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trenutnoDomacinstvoLabel2.ForeColor = System.Drawing.Color.White;
            this.trenutnoDomacinstvoLabel2.Location = new System.Drawing.Point(856, 42);
            this.trenutnoDomacinstvoLabel2.Name = "trenutnoDomacinstvoLabel2";
            this.trenutnoDomacinstvoLabel2.Size = new System.Drawing.Size(42, 21);
            this.trenutnoDomacinstvoLabel2.TabIndex = 6;
            this.trenutnoDomacinstvoLabel2.Text = "N/A";
            // 
            // brojNamirnicaLabel
            // 
            this.brojNamirnicaLabel.AutoSize = true;
            this.brojNamirnicaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.brojNamirnicaLabel.Location = new System.Drawing.Point(836, 72);
            this.brojNamirnicaLabel.Name = "brojNamirnicaLabel";
            this.brojNamirnicaLabel.Size = new System.Drawing.Size(123, 21);
            this.brojNamirnicaLabel.TabIndex = 5;
            this.brojNamirnicaLabel.Text = "Broj namirnica:";
            // 
            // trenutnoDomacinstvoLabel
            // 
            this.trenutnoDomacinstvoLabel.AutoSize = true;
            this.trenutnoDomacinstvoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(161)))), ((int)(((byte)(135)))));
            this.trenutnoDomacinstvoLabel.Location = new System.Drawing.Point(836, 21);
            this.trenutnoDomacinstvoLabel.Name = "trenutnoDomacinstvoLabel";
            this.trenutnoDomacinstvoLabel.Size = new System.Drawing.Size(191, 21);
            this.trenutnoDomacinstvoLabel.TabIndex = 3;
            this.trenutnoDomacinstvoLabel.Text = "Trenutno domaćinstvo:";
            // 
            // obrisiNamirnicuButton
            // 
            this.obrisiNamirnicuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.obrisiNamirnicuButton.FlatAppearance.BorderSize = 0;
            this.obrisiNamirnicuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiNamirnicuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiNamirnicuButton.ForeColor = System.Drawing.Color.White;
            this.obrisiNamirnicuButton.Location = new System.Drawing.Point(528, 35);
            this.obrisiNamirnicuButton.Name = "obrisiNamirnicuButton";
            this.obrisiNamirnicuButton.Size = new System.Drawing.Size(244, 94);
            this.obrisiNamirnicuButton.TabIndex = 2;
            this.obrisiNamirnicuButton.Text = "Obriši namirnicu";
            this.obrisiNamirnicuButton.UseVisualStyleBackColor = true;
            this.obrisiNamirnicuButton.Click += new System.EventHandler(this.obrisiNamirnicuButton_Click);
            // 
            // promijeniNamirnicuButton
            // 
            this.promijeniNamirnicuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.promijeniNamirnicuButton.FlatAppearance.BorderSize = 0;
            this.promijeniNamirnicuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promijeniNamirnicuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promijeniNamirnicuButton.ForeColor = System.Drawing.Color.White;
            this.promijeniNamirnicuButton.Location = new System.Drawing.Point(278, 35);
            this.promijeniNamirnicuButton.Name = "promijeniNamirnicuButton";
            this.promijeniNamirnicuButton.Size = new System.Drawing.Size(244, 94);
            this.promijeniNamirnicuButton.TabIndex = 1;
            this.promijeniNamirnicuButton.Text = "Promijeni namirnicu";
            this.promijeniNamirnicuButton.UseVisualStyleBackColor = true;
            this.promijeniNamirnicuButton.Click += new System.EventHandler(this.promijeniNamirnicuButton_Click);
            // 
            // dodajNamirnicuButton
            // 
            this.dodajNamirnicuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.dodajNamirnicuButton.FlatAppearance.BorderSize = 0;
            this.dodajNamirnicuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajNamirnicuButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajNamirnicuButton.ForeColor = System.Drawing.Color.White;
            this.dodajNamirnicuButton.Location = new System.Drawing.Point(28, 35);
            this.dodajNamirnicuButton.Name = "dodajNamirnicuButton";
            this.dodajNamirnicuButton.Size = new System.Drawing.Size(244, 94);
            this.dodajNamirnicuButton.TabIndex = 0;
            this.dodajNamirnicuButton.Text = "Dodaj namirnicu";
            this.dodajNamirnicuButton.UseVisualStyleBackColor = true;
            this.dodajNamirnicuButton.Click += new System.EventHandler(this.dodajNamirnicuButton_Click);
            // 
            // exitAppButton
            // 
            this.exitAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exitAppButton.FlatAppearance.BorderSize = 0;
            this.exitAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppButton.ForeColor = System.Drawing.Color.DarkGray;
            this.exitAppButton.Location = new System.Drawing.Point(1387, 0);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(23, 26);
            this.exitAppButton.TabIndex = 19;
            this.exitAppButton.Text = "X";
            this.exitAppButton.UseVisualStyleBackColor = false;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click_1);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.Location = new System.Drawing.Point(1358, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 26);
            this.minimizeButton.TabIndex = 23;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // nisteDioDomacinstvaLabel
            // 
            this.nisteDioDomacinstvaLabel.AutoSize = true;
            this.nisteDioDomacinstvaLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nisteDioDomacinstvaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nisteDioDomacinstvaLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nisteDioDomacinstvaLabel.ForeColor = System.Drawing.Color.Red;
            this.nisteDioDomacinstvaLabel.Location = new System.Drawing.Point(586, 256);
            this.nisteDioDomacinstvaLabel.Name = "nisteDioDomacinstvaLabel";
            this.nisteDioDomacinstvaLabel.Size = new System.Drawing.Size(313, 33);
            this.nisteDioDomacinstvaLabel.TabIndex = 24;
            this.nisteDioDomacinstvaLabel.Text = "Niste dio domaćinstva.";
            this.nisteDioDomacinstvaLabel.Visible = false;
            // 
            // GlavnaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1410, 695);
            this.Controls.Add(this.nisteDioDomacinstvaLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.glavnaFormPanelBottom);
            this.Controls.Add(this.popisNamirnicaLabel);
            this.Controls.Add(this.namirniceDGV);
            this.Controls.Add(this.glavnaFormPanelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareHome";
            this.Load += new System.EventHandler(this.GlavnaForm_Load);
            this.glavnaFormPanelLeft.ResumeLayout(false);
            this.glavnaFormPanelLeftTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehomePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namirniceDGV)).EndInit();
            this.glavnaFormPanelBottom.ResumeLayout(false);
            this.glavnaFormPanelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rasporedButton;
        private System.Windows.Forms.Button listeButton;
        private System.Windows.Forms.Button odjavaButton;
        private System.Windows.Forms.Panel glavnaFormPanelLeft;
        private System.Windows.Forms.Panel glavnaFormPanelLeftTop;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.DataGridView namirniceDGV;
        private System.Windows.Forms.Label popisNamirnicaLabel;
        private System.Windows.Forms.Panel glavnaFormPanelBottom;
        private System.Windows.Forms.Label trenutnoDomacinstvoLabel;
        private System.Windows.Forms.Button obrisiNamirnicuButton;
        private System.Windows.Forms.Button promijeniNamirnicuButton;
        private System.Windows.Forms.Button dodajNamirnicuButton;
        private System.Windows.Forms.Label brojNamirnicaLabel;
        private System.Windows.Forms.Button pridruziDomacinstvuButton;
        private System.Windows.Forms.Button izradiDomacinstvoButton;
        private System.Windows.Forms.Button exitAppButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label brojNamirnicaLabel2;
        private System.Windows.Forms.Label trenutnoDomacinstvoLabel2;
        private System.Windows.Forms.PictureBox warehomePictureBox;
        private System.Windows.Forms.Label nisteDioDomacinstvaLabel;
    }
}