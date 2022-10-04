
namespace QRCodeGenrator_5dma
{
    partial class qrCodeGeneratorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qrCodeGeneratorPage));
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.Generatorbtn = new System.Windows.Forms.Button();
            this.Sheetslbl = new System.Windows.Forms.Label();
            this.SheetsNamesBox = new System.Windows.Forms.ComboBox();
            this.SavePlacelbl = new System.Windows.Forms.Label();
            this.SavePlaceBox = new System.Windows.Forms.TextBox();
            this.SavePlacebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path : ";
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(142, 24);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(670, 28);
            this.FileNameBox.TabIndex = 1;
            // 
            // Browsebtn
            // 
            this.Browsebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Browsebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Browsebtn.Location = new System.Drawing.Point(818, 24);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(102, 28);
            this.Browsebtn.TabIndex = 2;
            this.Browsebtn.Text = "Browse";
            this.Browsebtn.UseVisualStyleBackColor = false;
            this.Browsebtn.Click += new System.EventHandler(this.Browsebtn_Click);
            // 
            // Generatorbtn
            // 
            this.Generatorbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Generatorbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Generatorbtn.Location = new System.Drawing.Point(818, 155);
            this.Generatorbtn.Name = "Generatorbtn";
            this.Generatorbtn.Size = new System.Drawing.Size(102, 39);
            this.Generatorbtn.TabIndex = 3;
            this.Generatorbtn.Text = "Generate";
            this.Generatorbtn.UseVisualStyleBackColor = false;
            this.Generatorbtn.Click += new System.EventHandler(this.Generatorbtn_Click);
            // 
            // Sheetslbl
            // 
            this.Sheetslbl.AutoSize = true;
            this.Sheetslbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sheetslbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sheetslbl.Location = new System.Drawing.Point(12, 132);
            this.Sheetslbl.Name = "Sheetslbl";
            this.Sheetslbl.Size = new System.Drawing.Size(91, 23);
            this.Sheetslbl.TabIndex = 0;
            this.Sheetslbl.Text = "Sheets : ";
            // 
            // SheetsNamesBox
            // 
            this.SheetsNamesBox.FormattingEnabled = true;
            this.SheetsNamesBox.Location = new System.Drawing.Point(142, 128);
            this.SheetsNamesBox.Name = "SheetsNamesBox";
            this.SheetsNamesBox.Size = new System.Drawing.Size(240, 27);
            this.SheetsNamesBox.TabIndex = 4;
            this.SheetsNamesBox.SelectedIndexChanged += new System.EventHandler(this.SheetsNamesBox_SelectedIndexChanged);
            this.SheetsNamesBox.TextUpdate += new System.EventHandler(this.SheetsNamesBox_TextUpdate);
            this.SheetsNamesBox.TextChanged += new System.EventHandler(this.SheetsNamesBox_TextChanged);
            // 
            // SavePlacelbl
            // 
            this.SavePlacelbl.AutoSize = true;
            this.SavePlacelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlacelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SavePlacelbl.Location = new System.Drawing.Point(12, 80);
            this.SavePlacelbl.Name = "SavePlacelbl";
            this.SavePlacelbl.Size = new System.Drawing.Size(136, 23);
            this.SavePlacelbl.TabIndex = 0;
            this.SavePlacelbl.Text = "Save Place : ";
            // 
            // SavePlaceBox
            // 
            this.SavePlaceBox.Location = new System.Drawing.Point(142, 75);
            this.SavePlaceBox.Name = "SavePlaceBox";
            this.SavePlaceBox.Size = new System.Drawing.Size(670, 28);
            this.SavePlaceBox.TabIndex = 1;
            // 
            // SavePlacebtn
            // 
            this.SavePlacebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SavePlacebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SavePlacebtn.Location = new System.Drawing.Point(818, 75);
            this.SavePlacebtn.Name = "SavePlacebtn";
            this.SavePlacebtn.Size = new System.Drawing.Size(102, 28);
            this.SavePlacebtn.TabIndex = 2;
            this.SavePlacebtn.Text = "Browse";
            this.SavePlacebtn.UseVisualStyleBackColor = false;
            this.SavePlacebtn.Click += new System.EventHandler(this.SavePlacebtn_Click);
            // 
            // qrCodeGeneratorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(947, 217);
            this.Controls.Add(this.SheetsNamesBox);
            this.Controls.Add(this.Generatorbtn);
            this.Controls.Add(this.SavePlacebtn);
            this.Controls.Add(this.Browsebtn);
            this.Controls.Add(this.SavePlaceBox);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.Sheetslbl);
            this.Controls.Add(this.SavePlacelbl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "qrCodeGeneratorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCodeGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qrCodeGeneratorPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.qrCodeGeneratorPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button Browsebtn;
        private System.Windows.Forms.Button Generatorbtn;
        private System.Windows.Forms.Label Sheetslbl;
        private System.Windows.Forms.ComboBox SheetsNamesBox;
        private System.Windows.Forms.Label SavePlacelbl;
        private System.Windows.Forms.TextBox SavePlaceBox;
        private System.Windows.Forms.Button SavePlacebtn;
    }
}

