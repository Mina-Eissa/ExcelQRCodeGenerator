
namespace QRCodeGenrator_5dma
{
    partial class ScannerUserControl
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
            this.components = new System.ComponentModel.Container();
            this.AttendanceList = new System.Windows.Forms.ListBox();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Scanbtn = new System.Windows.Forms.Button();
            this.FileBrowsebtn = new System.Windows.Forms.Button();
            this.AttendanceCounterBox = new System.Windows.Forms.TextBox();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.VideoBox = new System.Windows.Forms.PictureBox();
            this.Sheetslbl = new System.Windows.Forms.Label();
            this.SheetsNamesBox = new System.Windows.Forms.ComboBox();
            this.FilePathlbl = new System.Windows.Forms.Label();
            this.CamerasBox = new System.Windows.Forms.ComboBox();
            this.Canmeralbl = new System.Windows.Forms.Label();
            this.Attendancelbl = new System.Windows.Forms.Label();
            this.videoTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VideoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceList
            // 
            this.AttendanceList.FormattingEnabled = true;
            this.AttendanceList.ItemHeight = 22;
            this.AttendanceList.Location = new System.Drawing.Point(598, 141);
            this.AttendanceList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AttendanceList.Name = "AttendanceList";
            this.AttendanceList.ScrollAlwaysVisible = true;
            this.AttendanceList.Size = new System.Drawing.Size(378, 400);
            this.AttendanceList.TabIndex = 19;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Datelbl.Location = new System.Drawing.Point(863, 53);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(114, 22);
            this.Datelbl.TabIndex = 18;
            this.Datelbl.Text = "dd/mm/yyyy";
            // 
            // Scanbtn
            // 
            this.Scanbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Scanbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scanbtn.Location = new System.Drawing.Point(882, 598);
            this.Scanbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Scanbtn.Name = "Scanbtn";
            this.Scanbtn.Size = new System.Drawing.Size(94, 33);
            this.Scanbtn.TabIndex = 16;
            this.Scanbtn.Text = "Scan";
            this.Scanbtn.UseVisualStyleBackColor = false;
            this.Scanbtn.Click += new System.EventHandler(this.Scanbtn_Click);
            // 
            // FileBrowsebtn
            // 
            this.FileBrowsebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FileBrowsebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FileBrowsebtn.Location = new System.Drawing.Point(882, 560);
            this.FileBrowsebtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FileBrowsebtn.Name = "FileBrowsebtn";
            this.FileBrowsebtn.Size = new System.Drawing.Size(94, 36);
            this.FileBrowsebtn.TabIndex = 17;
            this.FileBrowsebtn.Text = "Browse";
            this.FileBrowsebtn.UseVisualStyleBackColor = false;
            this.FileBrowsebtn.Click += new System.EventHandler(this.FileBrowsebtn_Click);
            // 
            // AttendanceCounterBox
            // 
            this.AttendanceCounterBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceCounterBox.Location = new System.Drawing.Point(876, 105);
            this.AttendanceCounterBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AttendanceCounterBox.Name = "AttendanceCounterBox";
            this.AttendanceCounterBox.Size = new System.Drawing.Size(101, 28);
            this.AttendanceCounterBox.TabIndex = 14;
            // 
            // FilePathBox
            // 
            this.FilePathBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathBox.Location = new System.Drawing.Point(185, 560);
            this.FilePathBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(692, 28);
            this.FilePathBox.TabIndex = 15;
            // 
            // VideoBox
            // 
            this.VideoBox.BackColor = System.Drawing.SystemColors.Control;
            this.VideoBox.Location = new System.Drawing.Point(87, 116);
            this.VideoBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VideoBox.Name = "VideoBox";
            this.VideoBox.Size = new System.Drawing.Size(501, 428);
            this.VideoBox.TabIndex = 13;
            this.VideoBox.TabStop = false;
            // 
            // Sheetslbl
            // 
            this.Sheetslbl.AutoSize = true;
            this.Sheetslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sheetslbl.Location = new System.Drawing.Point(83, 604);
            this.Sheetslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sheetslbl.Name = "Sheetslbl";
            this.Sheetslbl.Size = new System.Drawing.Size(77, 22);
            this.Sheetslbl.TabIndex = 7;
            this.Sheetslbl.Text = "Sheets :";
            // 
            // SheetsNamesBox
            // 
            this.SheetsNamesBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheetsNamesBox.FormattingEnabled = true;
            this.SheetsNamesBox.Location = new System.Drawing.Point(185, 602);
            this.SheetsNamesBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SheetsNamesBox.Name = "SheetsNamesBox";
            this.SheetsNamesBox.Size = new System.Drawing.Size(230, 29);
            this.SheetsNamesBox.TabIndex = 11;
            this.SheetsNamesBox.SelectedIndexChanged += new System.EventHandler(this.SheetsNamesBox_SelectedIndexChanged);
            this.SheetsNamesBox.TextUpdate += new System.EventHandler(this.SheetsNamesBox_TextUpdate);
            this.SheetsNamesBox.TextChanged += new System.EventHandler(this.SheetsNamesBox_TextChanged);
            // 
            // FilePathlbl
            // 
            this.FilePathlbl.AutoSize = true;
            this.FilePathlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FilePathlbl.Location = new System.Drawing.Point(83, 566);
            this.FilePathlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilePathlbl.Name = "FilePathlbl";
            this.FilePathlbl.Size = new System.Drawing.Size(95, 22);
            this.FilePathlbl.TabIndex = 8;
            this.FilePathlbl.Text = "File Path :";
            // 
            // CamerasBox
            // 
            this.CamerasBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamerasBox.FormattingEnabled = true;
            this.CamerasBox.Location = new System.Drawing.Point(185, 53);
            this.CamerasBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CamerasBox.Name = "CamerasBox";
            this.CamerasBox.Size = new System.Drawing.Size(404, 29);
            this.CamerasBox.TabIndex = 12;
            // 
            // Canmeralbl
            // 
            this.Canmeralbl.AutoSize = true;
            this.Canmeralbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Canmeralbl.Location = new System.Drawing.Point(83, 56);
            this.Canmeralbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Canmeralbl.Name = "Canmeralbl";
            this.Canmeralbl.Size = new System.Drawing.Size(89, 22);
            this.Canmeralbl.TabIndex = 9;
            this.Canmeralbl.Text = "Camera : ";
            // 
            // Attendancelbl
            // 
            this.Attendancelbl.AutoSize = true;
            this.Attendancelbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Attendancelbl.Location = new System.Drawing.Point(601, 116);
            this.Attendancelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Attendancelbl.Name = "Attendancelbl";
            this.Attendancelbl.Size = new System.Drawing.Size(122, 22);
            this.Attendancelbl.TabIndex = 10;
            this.Attendancelbl.Text = "Attendance :-";
            // 
            // videoTimer
            // 
            this.videoTimer.Interval = 1000;
            this.videoTimer.Tick += new System.EventHandler(this.videoTimer_Tick);
            // 
            // ScannerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.AttendanceList);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.Scanbtn);
            this.Controls.Add(this.FileBrowsebtn);
            this.Controls.Add(this.AttendanceCounterBox);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.VideoBox);
            this.Controls.Add(this.Sheetslbl);
            this.Controls.Add(this.SheetsNamesBox);
            this.Controls.Add(this.FilePathlbl);
            this.Controls.Add(this.CamerasBox);
            this.Controls.Add(this.Canmeralbl);
            this.Controls.Add(this.Attendancelbl);
            this.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ScannerUserControl";
            this.Size = new System.Drawing.Size(1058, 685);
            this.Load += new System.EventHandler(this.ScannerUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AttendanceList;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Button Scanbtn;
        private System.Windows.Forms.Button FileBrowsebtn;
        private System.Windows.Forms.TextBox AttendanceCounterBox;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.PictureBox VideoBox;
        private System.Windows.Forms.Label Sheetslbl;
        private System.Windows.Forms.ComboBox SheetsNamesBox;
        private System.Windows.Forms.Label FilePathlbl;
        private System.Windows.Forms.ComboBox CamerasBox;
        private System.Windows.Forms.Label Canmeralbl;
        private System.Windows.Forms.Label Attendancelbl;
        private System.Windows.Forms.Timer videoTimer;
    }
}
