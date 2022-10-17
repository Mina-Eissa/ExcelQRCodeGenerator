using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenrator_5dma
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void Mainpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            generatorPage.Kill();
            scannerPage.Kill();
            addMemberPage.Kill();
        }
        private void Mainpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            generatorPage.Kill();
            scannerPage.Kill();
            addMemberPage.Kill();
        }

        private void Scanbtn_Click(object sender, EventArgs e)
        {
            generatorPage.Close();
            addMemberPage.Close();
            scannerPage.BringToFront();
        }
        private void Generatebtn_Click(object sender, EventArgs e)
        {
            scannerPage.Close();
            addMemberPage.Close();
            generatorPage.BringToFront();
        }

        private void addMemberbtn_Click(object sender, EventArgs e)
        {
            scannerPage.Close();
            generatorPage.Close();
            addMemberPage.BringToFront();
        }
    }
}
