
namespace QRCodeGenrator_5dma
{
    partial class GeneratorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SheetsNamesBox = new System.Windows.Forms.ComboBox();
            this.Generatorbtn = new System.Windows.Forms.Button();
            this.SavePlaceBrowsebtn = new System.Windows.Forms.Button();
            this.FileBrowsebtn = new System.Windows.Forms.Button();
            this.SavePlaceBox = new System.Windows.Forms.TextBox();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.Sheetslbl = new System.Windows.Forms.Label();
            this.SavePlacelbl = new System.Windows.Forms.Label();
            this.FilePathlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SheetsNamesBox
            // 
            this.SheetsNamesBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetsNamesBox.FormattingEnabled = true;
            this.SheetsNamesBox.Location = new System.Drawing.Point(201, 361);
            this.SheetsNamesBox.Name = "SheetsNamesBox";
            this.SheetsNamesBox.Size = new System.Drawing.Size(240, 29);
            this.SheetsNamesBox.TabIndex = 13;
            this.SheetsNamesBox.SelectedIndexChanged += new System.EventHandler(this.SheetsNamesBox_SelectedIndexChanged);
            this.SheetsNamesBox.TextUpdate += new System.EventHandler(this.SheetsNamesBox_TextUpdate);
            this.SheetsNamesBox.TextChanged += new System.EventHandler(this.SheetsNamesBox_TextChanged);
            // 
            // Generatorbtn
            // 
            this.Generatorbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Generatorbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Generatorbtn.Location = new System.Drawing.Point(877, 388);
            this.Generatorbtn.Name = "Generatorbtn";
            this.Generatorbtn.Size = new System.Drawing.Size(102, 39);
            this.Generatorbtn.TabIndex = 12;
            this.Generatorbtn.Text = "Generate";
            this.Generatorbtn.UseVisualStyleBackColor = false;
            this.Generatorbtn.Click += new System.EventHandler(this.Generatorbtn_Click);
            // 
            // SavePlaceBrowsebtn
            // 
            this.SavePlaceBrowsebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SavePlaceBrowsebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SavePlaceBrowsebtn.Location = new System.Drawing.Point(877, 304);
            this.SavePlaceBrowsebtn.Name = "SavePlaceBrowsebtn";
            this.SavePlaceBrowsebtn.Size = new System.Drawing.Size(102, 35);
            this.SavePlaceBrowsebtn.TabIndex = 10;
            this.SavePlaceBrowsebtn.Text = "Browse";
            this.SavePlaceBrowsebtn.UseVisualStyleBackColor = false;
            this.SavePlaceBrowsebtn.Click += new System.EventHandler(this.SavePlaceBrowsebtn_Click);
            // 
            // FileBrowsebtn
            // 
            this.FileBrowsebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FileBrowsebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FileBrowsebtn.Location = new System.Drawing.Point(877, 253);
            this.FileBrowsebtn.Name = "FileBrowsebtn";
            this.FileBrowsebtn.Size = new System.Drawing.Size(102, 35);
            this.FileBrowsebtn.TabIndex = 11;
            this.FileBrowsebtn.Text = "Browse";
            this.FileBrowsebtn.UseVisualStyleBackColor = false;
            this.FileBrowsebtn.Click += new System.EventHandler(this.FileBrowsebtn_Click);
            // 
            // SavePlaceBox
            // 
            this.SavePlaceBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlaceBox.Location = new System.Drawing.Point(201, 311);
            this.SavePlaceBox.Name = "SavePlaceBox";
            this.SavePlaceBox.Size = new System.Drawing.Size(670, 28);
            this.SavePlaceBox.TabIndex = 8;
            // 
            // FileNameBox
            // 
            this.FileNameBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameBox.Location = new System.Drawing.Point(201, 260);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(670, 28);
            this.FileNameBox.TabIndex = 9;
            // 
            // Sheetslbl
            // 
            this.Sheetslbl.AutoSize = true;
            this.Sheetslbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sheetslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sheetslbl.Location = new System.Drawing.Point(71, 367);
            this.Sheetslbl.Name = "Sheetslbl";
            this.Sheetslbl.Size = new System.Drawing.Size(91, 23);
            this.Sheetslbl.TabIndex = 5;
            this.Sheetslbl.Text = "Sheets : ";
            // 
            // SavePlacelbl
            // 
            this.SavePlacelbl.AutoSize = true;
            this.SavePlacelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlacelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SavePlacelbl.Location = new System.Drawing.Point(71, 316);
            this.SavePlacelbl.Name = "SavePlacelbl";
            this.SavePlacelbl.Size = new System.Drawing.Size(136, 23);
            this.SavePlacelbl.TabIndex = 6;
            this.SavePlacelbl.Text = "Save Place : ";
            // 
            // FilePathlbl
            // 
            this.FilePathlbl.AutoSize = true;
            this.FilePathlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FilePathlbl.Location = new System.Drawing.Point(71, 265);
            this.FilePathlbl.Name = "FilePathlbl";
            this.FilePathlbl.Size = new System.Drawing.Size(109, 23);
            this.FilePathlbl.TabIndex = 7;
            this.FilePathlbl.Text = "File Path : ";
            // 
            // GeneratorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.SheetsNamesBox);
            this.Controls.Add(this.Generatorbtn);
            this.Controls.Add(this.SavePlaceBrowsebtn);
            this.Controls.Add(this.FileBrowsebtn);
            this.Controls.Add(this.SavePlaceBox);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.Sheetslbl);
            this.Controls.Add(this.SavePlacelbl);
            this.Controls.Add(this.FilePathlbl);
            this.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GeneratorUserControl";
            this.Size = new System.Drawing.Size(1059, 685);
            this.Load += new System.EventHandler(this.GeneratorUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SheetsNamesBox;
        private System.Windows.Forms.Button Generatorbtn;
        private System.Windows.Forms.Button SavePlaceBrowsebtn;
        private System.Windows.Forms.Button FileBrowsebtn;
        private System.Windows.Forms.TextBox SavePlaceBox;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Label Sheetslbl;
        private System.Windows.Forms.Label SavePlacelbl;
        private System.Windows.Forms.Label FilePathlbl;
    }
}
