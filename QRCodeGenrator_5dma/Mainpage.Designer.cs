
namespace QRCodeGenrator_5dma
{
    partial class Mainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpage));
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.Dashboardlbl = new System.Windows.Forms.Label();
            this.Generatebtn = new System.Windows.Forms.Button();
            this.Scanbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scannerPage = new QRCodeGenrator_5dma.ScannerUserControl();
            this.generatorPage = new QRCodeGenrator_5dma.GeneratorUserControl();
            this.welcomePage = new QRCodeGenrator_5dma.UserControls.WelcomeUserControl();
            this.DashboardPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DashboardPanel.Controls.Add(this.Dashboardlbl);
            this.DashboardPanel.Controls.Add(this.Generatebtn);
            this.DashboardPanel.Controls.Add(this.Scanbtn);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(116, 685);
            this.DashboardPanel.TabIndex = 0;
            // 
            // Dashboardlbl
            // 
            this.Dashboardlbl.AutoSize = true;
            this.Dashboardlbl.Location = new System.Drawing.Point(3, 9);
            this.Dashboardlbl.Name = "Dashboardlbl";
            this.Dashboardlbl.Size = new System.Drawing.Size(110, 22);
            this.Dashboardlbl.TabIndex = 1;
            this.Dashboardlbl.Text = "Dashboard :";
            // 
            // Generatebtn
            // 
            this.Generatebtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Generatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generatebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Generatebtn.Location = new System.Drawing.Point(0, 126);
            this.Generatebtn.Name = "Generatebtn";
            this.Generatebtn.Size = new System.Drawing.Size(116, 56);
            this.Generatebtn.TabIndex = 0;
            this.Generatebtn.Text = "Generate";
            this.Generatebtn.UseVisualStyleBackColor = true;
            this.Generatebtn.Click += new System.EventHandler(this.Generatebtn_Click);
            // 
            // Scanbtn
            // 
            this.Scanbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Scanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scanbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scanbtn.Location = new System.Drawing.Point(0, 65);
            this.Scanbtn.Name = "Scanbtn";
            this.Scanbtn.Size = new System.Drawing.Size(116, 56);
            this.Scanbtn.TabIndex = 0;
            this.Scanbtn.Text = "Scan";
            this.Scanbtn.UseVisualStyleBackColor = true;
            this.Scanbtn.Click += new System.EventHandler(this.Scanbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.welcomePage);
            this.panel2.Controls.Add(this.scannerPage);
            this.panel2.Controls.Add(this.generatorPage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(116, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 685);
            this.panel2.TabIndex = 1;
            // 
            // scannerPage
            // 
            this.scannerPage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.scannerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scannerPage.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scannerPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scannerPage.Location = new System.Drawing.Point(0, 0);
            this.scannerPage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.scannerPage.Name = "scannerPage";
            this.scannerPage.Size = new System.Drawing.Size(1059, 685);
            this.scannerPage.TabIndex = 1;
            // 
            // generatorPage
            // 
            this.generatorPage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.generatorPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generatorPage.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatorPage.Location = new System.Drawing.Point(0, 0);
            this.generatorPage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.generatorPage.Name = "generatorPage";
            this.generatorPage.Size = new System.Drawing.Size(1059, 685);
            this.generatorPage.TabIndex = 0;
            // 
            // welcomePage
            // 
            this.welcomePage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.welcomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePage.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomePage.Location = new System.Drawing.Point(0, 0);
            this.welcomePage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Size = new System.Drawing.Size(1059, 685);
            this.welcomePage.TabIndex = 2;
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DashboardPanel);
            this.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Mainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelQRCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainpage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainpage_FormClosed);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Generatebtn;
        private System.Windows.Forms.Button Scanbtn;
        private System.Windows.Forms.Label Dashboardlbl;
        private GeneratorUserControl generatorPage;
        private ScannerUserControl scannerPage;
        private UserControls.WelcomeUserControl welcomePage;
    }
}