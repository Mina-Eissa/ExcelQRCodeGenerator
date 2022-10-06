using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;       //Microsoft Excel 16 object in references-> COM tab
using QRCoder;
using System.IO;

namespace QRCodeGenrator_5dma
{
    public partial class GeneratorUserControl : UserControl
    {
        int nameColumnIndex = 0, phoneNumberColumnIndex = 0, qrcodeColumnIndex = 0;
        Excel.Application application;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;
        Excel.Range range;
        Dictionary<string, int> SheetsNamesIndecies;
        string SavePath;
        public GeneratorUserControl()
        {
            InitializeComponent();
        }
        private void GeneratorUserControl_Load(object sender, EventArgs e)
        {
            application = new Excel.Application();
            SheetsNamesIndecies = new Dictionary<string, int>();
            SavePath = "";
        }
        private void InitializeWorkbook(string filePath)
        {
            workbook = application.Workbooks.Open(@filePath);
            SheetsNamesBox.Items.Clear();
            SheetsNamesIndecies.Clear();
            for (int i = 1; i <= workbook.Sheets.Count; i++)
            {
                Excel.Worksheet SheetName = workbook.Sheets[i];
                SheetsNamesBox.Items.Add(SheetName.Name);
                SheetsNamesIndecies[SheetName.Name] = i;
            }
        }
        private void InitializeWorksheet(string SelectedSheet)
        {
            nameColumnIndex = 0;
            phoneNumberColumnIndex = 0;
            qrcodeColumnIndex = 0;
            if (SheetsNamesIndecies.ContainsKey(SelectedSheet) == false)
                return;
            worksheet = workbook.Sheets[SheetsNamesIndecies[SelectedSheet]];
            range = worksheet.UsedRange;
            for (int i = 1; i <= range.Columns.Count; i++)
            {
                string cell = Convert.ToString((range.Cells[1, i] as Excel.Range).Text);
                if (cell == "الاسم" || cell == "Name")
                {
                    nameColumnIndex = i;
                }
                if (cell == "التليفون" || cell.Contains("Phone Number"))
                {
                    phoneNumberColumnIndex = i;
                }
                if (cell == "QRCode")
                {
                    qrcodeColumnIndex = i;
                }
            }
            if (nameColumnIndex != 0 && phoneNumberColumnIndex != 0 && qrcodeColumnIndex == 0)
            {
                qrcodeColumnIndex = range.Columns.Count + 1;
                range.Cells[1, qrcodeColumnIndex] = "QRCode";
            }
        }
        void SaveImage(Bitmap Code, string MemberName)
        {
            string directoryPath = SavePath + "\\Images";
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
            string fileName = directoryPath + "\\" + MemberName + ".jpg";
            Code.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        private void Generatorbtn_Click(object sender, EventArgs e)
        {
            if (application == null)
            {
                return;
            }
            if (workbook == null)
            {
                MessageBox.Show("You should choose excel file first!");
                return;
            }
            if (nameColumnIndex == 0 || phoneNumberColumnIndex == 0)
            {

                MessageBox.Show("Sheet should contain Name colmun and Phone Number colmun!");
                return;
            }
            if (SavePath == "")
            {
                MessageBox.Show("Choose place to save codes.");
                return;
            }
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData data;
            QRCode code;
            Bitmap image;
            string name, phone, qrCodeCheckCell;
            int counterNewMembers = 0;
            for (int i = 2; i <= range.Rows.Count; i++)
            {
                qrCodeCheckCell = Convert.ToString((range.Cells[i, qrcodeColumnIndex] as Excel.Range).Text);
                if (qrCodeCheckCell == "")
                {
                    range.Cells[i, qrcodeColumnIndex] = "QrCode is maded in : " + Application.StartupPath + "\\Images";
                    name = Convert.ToString((range.Cells[i, nameColumnIndex] as Excel.Range).Text);
                    phone = Convert.ToString((range.Cells[i, phoneNumberColumnIndex] as Excel.Range).Text);
                    data = generator.CreateQrCode(name + "-" + phone, QRCodeGenerator.ECCLevel.Q);
                    code = new QRCode(data);
                    image = code.GetGraphic(5);
                    SaveImage(image, name);
                    counterNewMembers++;
                }
            }
            MessageBox.Show("New Members number : " + counterNewMembers.ToString());

        }
        private void SheetsNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedSheet = SheetsNamesBox.Items[SheetsNamesBox.SelectedIndex].ToString();
            InitializeWorksheet(SelectedSheet);
        }
        private void SheetsNamesBox_TextUpdate(object sender, EventArgs e)
        {
            string SelectedSheet = SheetsNamesBox.Text;
            InitializeWorksheet(SelectedSheet);
        }
        private void SheetsNamesBox_TextChanged(object sender, EventArgs e)
        {
            string SelectedSheet = SheetsNamesBox.Text;
            InitializeWorksheet(SelectedSheet);
        }
        private void SavePlaceBrowsebtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    SavePlaceBox.Text = fbd.SelectedPath;
                    SavePath = fbd.SelectedPath;
                }
            }
        }
        public void SaveWorkbook()
        {
            if (workbook != null)
            {
                workbook.Save();
                workbook.Close();
                workbook = null;
            }

        }
        public void CloseExcelApp()
        {
            if (application != null)
            {
                application.Quit();
            }
        }
        public void Kill()
        {
            SaveWorkbook();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (range != null)
                Marshal.ReleaseComObject(range);
            if (worksheet != null)
                Marshal.ReleaseComObject(worksheet);
            if (workbook != null)
                Marshal.ReleaseComObject(workbook);
            if (application != null)
                Marshal.ReleaseComObject(application);
        }
        public void Close()
        {
           
            SaveWorkbook();
            SavePath = "";
            if (SheetsNamesIndecies != null)
                SheetsNamesIndecies.Clear();
            SheetsNamesBox.Items.Clear();
            FileNameBox.Clear();
            SavePlaceBox.Clear();

        }
        private void FileBrowsebtn_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
                workbook.Save();
                workbook.Close();
                workbook = null;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2019 Workbook|*.xls |Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileNameBox.Text = openFileDialog.FileName;
                    InitializeWorkbook(openFileDialog.FileName);
                }
            }
        }
    }
}
