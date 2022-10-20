
namespace QRCodeGenrator_5dma.UserControls
{
    partial class AddMemberUserControl
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
            this.Namelbl = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.addMemberbtn = new System.Windows.Forms.Button();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberlbl = new System.Windows.Forms.Label();
            this.Universitylbl = new System.Windows.Forms.Label();
            this.CollegeBox = new System.Windows.Forms.TextBox();
            this.Collegelbl = new System.Windows.Forms.Label();
            this.Levellbl = new System.Windows.Forms.Label();
            this.UniversityBox = new System.Windows.Forms.ComboBox();
            this.LevelBox = new System.Windows.Forms.ComboBox();
            this.FileBrowsebtn = new System.Windows.Forms.Button();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.Sheetslbl = new System.Windows.Forms.Label();
            this.SheetsNamesBox = new System.Windows.Forms.ComboBox();
            this.FilePathlbl = new System.Windows.Forms.Label();
            this.SavePlaceBrowsebtn = new System.Windows.Forms.Button();
            this.SavePlaceBox = new System.Windows.Forms.TextBox();
            this.SavePlacelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.additionalSheetslbl = new System.Windows.Forms.Label();
            this.additionalSheetsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(65, 54);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(68, 22);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name :";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameBox.Location = new System.Drawing.Point(226, 48);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(262, 28);
            this.NameBox.TabIndex = 0;
            // 
            // addMemberbtn
            // 
            this.addMemberbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addMemberbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMemberbtn.Location = new System.Drawing.Point(912, 590);
            this.addMemberbtn.Name = "addMemberbtn";
            this.addMemberbtn.Size = new System.Drawing.Size(102, 35);
            this.addMemberbtn.TabIndex = 12;
            this.addMemberbtn.Text = "Add";
            this.addMemberbtn.UseVisualStyleBackColor = false;
            this.addMemberbtn.Click += new System.EventHandler(this.addMemberbtn_Click);
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PhoneNumberBox.Location = new System.Drawing.Point(226, 86);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(262, 28);
            this.PhoneNumberBox.TabIndex = 13;
            // 
            // PhoneNumberlbl
            // 
            this.PhoneNumberlbl.AutoSize = true;
            this.PhoneNumberlbl.Location = new System.Drawing.Point(65, 92);
            this.PhoneNumberlbl.Name = "PhoneNumberlbl";
            this.PhoneNumberlbl.Size = new System.Drawing.Size(145, 22);
            this.PhoneNumberlbl.TabIndex = 14;
            this.PhoneNumberlbl.Text = "Phone Number :";
            // 
            // Universitylbl
            // 
            this.Universitylbl.AutoSize = true;
            this.Universitylbl.Location = new System.Drawing.Point(65, 132);
            this.Universitylbl.Name = "Universitylbl";
            this.Universitylbl.Size = new System.Drawing.Size(104, 22);
            this.Universitylbl.TabIndex = 16;
            this.Universitylbl.Text = "University :";
            // 
            // CollegeBox
            // 
            this.CollegeBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CollegeBox.Location = new System.Drawing.Point(226, 166);
            this.CollegeBox.Name = "CollegeBox";
            this.CollegeBox.Size = new System.Drawing.Size(262, 28);
            this.CollegeBox.TabIndex = 17;
            // 
            // Collegelbl
            // 
            this.Collegelbl.AutoSize = true;
            this.Collegelbl.Location = new System.Drawing.Point(65, 172);
            this.Collegelbl.Name = "Collegelbl";
            this.Collegelbl.Size = new System.Drawing.Size(82, 22);
            this.Collegelbl.TabIndex = 18;
            this.Collegelbl.Text = "College :";
            // 
            // Levellbl
            // 
            this.Levellbl.AutoSize = true;
            this.Levellbl.Location = new System.Drawing.Point(65, 212);
            this.Levellbl.Name = "Levellbl";
            this.Levellbl.Size = new System.Drawing.Size(65, 22);
            this.Levellbl.TabIndex = 18;
            this.Levellbl.Text = "Level :";
            // 
            // UniversityBox
            // 
            this.UniversityBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UniversityBox.FormattingEnabled = true;
            this.UniversityBox.Location = new System.Drawing.Point(226, 124);
            this.UniversityBox.Name = "UniversityBox";
            this.UniversityBox.Size = new System.Drawing.Size(262, 29);
            this.UniversityBox.TabIndex = 19;
            // 
            // LevelBox
            // 
            this.LevelBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LevelBox.FormattingEnabled = true;
            this.LevelBox.Location = new System.Drawing.Point(226, 204);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(262, 29);
            this.LevelBox.TabIndex = 19;
            // 
            // FileBrowsebtn
            // 
            this.FileBrowsebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FileBrowsebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FileBrowsebtn.Location = new System.Drawing.Point(912, 398);
            this.FileBrowsebtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FileBrowsebtn.Name = "FileBrowsebtn";
            this.FileBrowsebtn.Size = new System.Drawing.Size(102, 36);
            this.FileBrowsebtn.TabIndex = 25;
            this.FileBrowsebtn.Text = "Browse";
            this.FileBrowsebtn.UseVisualStyleBackColor = false;
            this.FileBrowsebtn.Click += new System.EventHandler(this.FileBrowsebtn_Click);
            // 
            // FilePathBox
            // 
            this.FilePathBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathBox.Location = new System.Drawing.Point(226, 406);
            this.FilePathBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(670, 28);
            this.FilePathBox.TabIndex = 23;
            // 
            // Sheetslbl
            // 
            this.Sheetslbl.AutoSize = true;
            this.Sheetslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sheetslbl.Location = new System.Drawing.Point(65, 450);
            this.Sheetslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sheetslbl.Name = "Sheetslbl";
            this.Sheetslbl.Size = new System.Drawing.Size(77, 22);
            this.Sheetslbl.TabIndex = 20;
            this.Sheetslbl.Text = "Sheets :";
            // 
            // SheetsNamesBox
            // 
            this.SheetsNamesBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetsNamesBox.FormattingEnabled = true;
            this.SheetsNamesBox.Location = new System.Drawing.Point(226, 447);
            this.SheetsNamesBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SheetsNamesBox.Name = "SheetsNamesBox";
            this.SheetsNamesBox.Size = new System.Drawing.Size(230, 29);
            this.SheetsNamesBox.TabIndex = 22;
            this.SheetsNamesBox.SelectedIndexChanged += new System.EventHandler(this.SheetsNamesBox_SelectedIndexChanged);
            this.SheetsNamesBox.TextUpdate += new System.EventHandler(this.SheetsNamesBox_TextUpdate);
            this.SheetsNamesBox.TextChanged += new System.EventHandler(this.SheetsNamesBox_TextChanged);
            // 
            // FilePathlbl
            // 
            this.FilePathlbl.AutoSize = true;
            this.FilePathlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FilePathlbl.Location = new System.Drawing.Point(65, 412);
            this.FilePathlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilePathlbl.Name = "FilePathlbl";
            this.FilePathlbl.Size = new System.Drawing.Size(95, 22);
            this.FilePathlbl.TabIndex = 21;
            this.FilePathlbl.Text = "File Path :";
            // 
            // SavePlaceBrowsebtn
            // 
            this.SavePlaceBrowsebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SavePlaceBrowsebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SavePlaceBrowsebtn.Location = new System.Drawing.Point(912, 350);
            this.SavePlaceBrowsebtn.Name = "SavePlaceBrowsebtn";
            this.SavePlaceBrowsebtn.Size = new System.Drawing.Size(102, 35);
            this.SavePlaceBrowsebtn.TabIndex = 28;
            this.SavePlaceBrowsebtn.Text = "Browse";
            this.SavePlaceBrowsebtn.UseVisualStyleBackColor = false;
            this.SavePlaceBrowsebtn.Click += new System.EventHandler(this.SavePlaceBrowsebtn_Click);
            // 
            // SavePlaceBox
            // 
            this.SavePlaceBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlaceBox.Location = new System.Drawing.Point(226, 357);
            this.SavePlaceBox.Name = "SavePlaceBox";
            this.SavePlaceBox.Size = new System.Drawing.Size(670, 28);
            this.SavePlaceBox.TabIndex = 27;
            // 
            // SavePlacelbl
            // 
            this.SavePlacelbl.AutoSize = true;
            this.SavePlacelbl.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePlacelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SavePlacelbl.Location = new System.Drawing.Point(65, 363);
            this.SavePlacelbl.Name = "SavePlacelbl";
            this.SavePlacelbl.Size = new System.Drawing.Size(116, 22);
            this.SavePlacelbl.TabIndex = 26;
            this.SavePlacelbl.Text = "Save Place : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Address :";
            // 
            // AddressBox
            // 
            this.AddressBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressBox.Location = new System.Drawing.Point(226, 251);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(262, 91);
            this.AddressBox.TabIndex = 17;
            // 
            // additionalSheetslbl
            // 
            this.additionalSheetslbl.AutoSize = true;
            this.additionalSheetslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.additionalSheetslbl.Location = new System.Drawing.Point(65, 492);
            this.additionalSheetslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.additionalSheetslbl.Name = "additionalSheetslbl";
            this.additionalSheetslbl.Size = new System.Drawing.Size(157, 22);
            this.additionalSheetslbl.TabIndex = 30;
            this.additionalSheetslbl.Text = "Additional Sheet :";
            // 
            // additionalSheetsBox
            // 
            this.additionalSheetsBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalSheetsBox.FormattingEnabled = true;
            this.additionalSheetsBox.Location = new System.Drawing.Point(226, 489);
            this.additionalSheetsBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.additionalSheetsBox.Name = "additionalSheetsBox";
            this.additionalSheetsBox.Size = new System.Drawing.Size(230, 29);
            this.additionalSheetsBox.TabIndex = 31;
            this.additionalSheetsBox.SelectedIndexChanged += new System.EventHandler(this.additionalSheetsBox_SelectedIndexChanged);
            this.additionalSheetsBox.TextUpdate += new System.EventHandler(this.additionalSheetsBox_SelectedIndexChanged);
            this.additionalSheetsBox.TextChanged += new System.EventHandler(this.additionalSheetsBox_SelectedIndexChanged);
            this.additionalSheetsBox.Click += new System.EventHandler(this.additionalSheetsBox_Click);
            // 
            // AddMemberUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.additionalSheetslbl);
            this.Controls.Add(this.additionalSheetsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SavePlaceBrowsebtn);
            this.Controls.Add(this.SavePlaceBox);
            this.Controls.Add(this.SavePlacelbl);
            this.Controls.Add(this.FileBrowsebtn);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.Sheetslbl);
            this.Controls.Add(this.SheetsNamesBox);
            this.Controls.Add(this.FilePathlbl);
            this.Controls.Add(this.LevelBox);
            this.Controls.Add(this.UniversityBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.CollegeBox);
            this.Controls.Add(this.Levellbl);
            this.Controls.Add(this.Collegelbl);
            this.Controls.Add(this.Universitylbl);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.PhoneNumberlbl);
            this.Controls.Add(this.addMemberbtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Namelbl);
            this.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddMemberUserControl";
            this.Size = new System.Drawing.Size(1059, 685);
            this.Load += new System.EventHandler(this.AddMemberUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button addMemberbtn;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label PhoneNumberlbl;
        private System.Windows.Forms.Label Universitylbl;
        private System.Windows.Forms.TextBox CollegeBox;
        private System.Windows.Forms.Label Collegelbl;
        private System.Windows.Forms.Label Levellbl;
        private System.Windows.Forms.ComboBox UniversityBox;
        private System.Windows.Forms.ComboBox LevelBox;
        private System.Windows.Forms.Button FileBrowsebtn;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Label Sheetslbl;
        private System.Windows.Forms.ComboBox SheetsNamesBox;
        private System.Windows.Forms.Label FilePathlbl;
        private System.Windows.Forms.Button SavePlaceBrowsebtn;
        private System.Windows.Forms.TextBox SavePlaceBox;
        private System.Windows.Forms.Label SavePlacelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label additionalSheetslbl;
        private System.Windows.Forms.ComboBox additionalSheetsBox;
    }
}
