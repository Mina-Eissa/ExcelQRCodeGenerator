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
namespace QRCodeGenrator_5dma.UserControls
{
    public partial class AddMemberUserControl : UserControl
    {
        int Nameindex = 0,
            phoneNumberindex = 0,
            Universityindex = 0,
            Collegeindex = 0,
            Levelindex = 0,
            Addressindex = 0,
            qrcodeColumnIndex = 0,
            LastRowindex = 0;
        bool message = false;
        Excel.Application application;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet,addWorksheet;
        Excel.Range range,addRange;
        Dictionary<string, int> SheetsNamesIndecies;
        string SavePath = "";
        public AddMemberUserControl()
        {
            InitializeComponent();
        }
        private void AddMemberUserControl_Load(object sender, EventArgs e)
        {
            application = new Excel.Application();
            SheetsNamesIndecies = new Dictionary<string, int>();
            fillUniversities();
            fillLevels();
        }
        public void fillUniversities()
        {
            UniversityBox.Items.Add("أسيوط");
            UniversityBox.Items.Add("Sphinx");
            UniversityBox.Items.Add("الأهلية");
            UniversityBox.Items.Add("أخرى");
        }
        public void fillLevels()
        {
            for(int i = 1; i <= 7; i++)
            {
                LevelBox.Items.Add(i);
            }
        }
        private void addMemberbtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" ||
               PhoneNumberBox.Text == "" ||
               UniversityBox.Text == "" ||
               CollegeBox.Text == "" ||
               LevelBox.Text == "" ||
               AddressBox.Text == "")
            {
                MessageBox.Show("fill fileds first!.");
                return;
            }
            else if (worksheet == null)
            {
                MessageBox.Show("choose excel file and sheet have this attributes to save in.");
                return;
            }
            else if (isExist())
            {
                MessageBox.Show("this member is exist");
                return;
            }
            else if (Nameindex == 0 ||
                phoneNumberindex == 0 ||
                Universityindex == 0 ||
                Collegeindex == 0 ||
                Levelindex == 0 ||
                Addressindex == 0)
            {
                MessageBox.Show("choose sheet has this attributes!!");
                return;
            }
            Generator generator = new Generator();
            generator.generateQRCode(NameBox.Text + "-" + PhoneNumberBox.Text, NameBox.Text, SavePath);
            range.Cells[LastRowindex, Nameindex] = NameBox.Text;
            range.Cells[LastRowindex, phoneNumberindex] = PhoneNumberBox.Text;
            range.Cells[LastRowindex, Universityindex] = UniversityBox.Text;
            range.Cells[LastRowindex, Collegeindex] = CollegeBox.Text;
            range.Cells[LastRowindex, Levelindex] = LevelBox.Text;
            range.Cells[LastRowindex, Addressindex] = $"\"{AddressBox.Text}\"";
            range.Cells[LastRowindex, qrcodeColumnIndex] = SavePath + "\\Images";
            if (addWorksheet != null)
            {
                addRange.Cells[addRange.Rows.Count + 1, 1] = $"\"{NameBox.Text}\"";
            }
            MessageBox.Show("This data saved successfuly.");
            ClearFields();
        }
        public void Kill()
        {
            SaveWorkBook();
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
            SaveWorkBook();
            SheetsNamesBox.Items.Clear();
            ClearFields();
        }
        public void SaveWorkBook()
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
        private void InitializeWorkbook(string filePath)
        {
            workbook = application.Workbooks.Open(@filePath);
            SheetsNamesBox.Items.Clear();
            SheetsNamesIndecies.Clear();
            for (int i = 1; i <= workbook.Sheets.Count; i++)
            {
                Excel.Worksheet SheetName = workbook.Sheets[i];
                SheetsNamesBox.Items.Add(SheetName.Name);
                additionalSheetsBox.Items.Add(SheetName.Name);
                SheetsNamesIndecies[SheetName.Name] = i;
            }
        }
        private void InitializeWorksheet(string SelectedSheet)
        {
            Nameindex = 0; phoneNumberindex = 0;
            Universityindex = 0; Collegeindex = 0;
            Levelindex = 0; Addressindex = 0;
            if (SheetsNamesIndecies.ContainsKey(SelectedSheet) == false)
                return;
            worksheet = workbook.Sheets[SheetsNamesIndecies[SelectedSheet]];
            range = worksheet.UsedRange;
            for (int i = 1; i <= range.Columns.Count; i++)
            {
                string cell = Convert.ToString((range.Cells[1, i] as Excel.Range).Text);
                if (cell == "الاسم" || cell == "Name")
                    Nameindex = i;
                else if (cell.Contains("Phone Number") || cell == "التليفون")
                    phoneNumberindex = i;
                else if (cell == "University" || cell == "الجامعة" || cell == "الجامعه")
                    Universityindex = i;
                else if (cell == "College" || cell == "الكلية" || cell == "الكليه")
                    Collegeindex = i;
                else if (cell == "Level" || cell == "المرحلة" || cell == "المرحله")
                    Levelindex = i;
                else if (cell == "Address" || cell == "العنوان")
                    Addressindex = i;
                else if (cell == "QRCode")
                {
                    qrcodeColumnIndex = i;
                }
            }
            if (Nameindex == 0 ||
                phoneNumberindex == 0 ||
                Universityindex == 0 ||
                Collegeindex == 0 ||
                Levelindex == 0 ||
                Addressindex == 0)
            {
                MessageBox.Show("choose sheet has this attributes!!");
                return;
            }
            LastRowindex = range.Rows.Count + 1;
            if (qrcodeColumnIndex == 0)
            {
                qrcodeColumnIndex = range.Columns.Count + 1;
                range.Cells[1, qrcodeColumnIndex] = "QRCode";
            }
        }

        private void additionalSheetsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedSheet = SheetsNamesBox.Items[additionalSheetsBox.SelectedIndex].ToString();
            InitializeAdditionalSheet(SelectedSheet);
        }

        private void InitializeAdditionalSheet(string SelectedSheet)
        {
            if (SheetsNamesIndecies.ContainsKey(SelectedSheet) == false)
                return;
            string cell= Convert.ToString((range.Cells[1, 1] as Excel.Range).Text);
            if (cell != "Name")
            {
                MessageBox.Show("Cell 1A must contain Name");
                return;
            }
            addWorksheet = workbook.Sheets[SheetsNamesIndecies[SelectedSheet]];
            addRange = addWorksheet.UsedRange;
        }
        private void additionalSheetsBox_Click(object sender, EventArgs e)
        {
            if (!message)
            {
                MessageBox.Show("cell 1A must contain Name");
                message = true;
            }
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
                    FilePathBox.Text = openFileDialog.FileName;
                    InitializeWorkbook(openFileDialog.FileName);
                }
            }
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
        private bool isExist()
        {
            
            string name, phone, uni, col, level,addr;
            for (int i = 2; i <= range.Cells.Rows.Count; i++)
            {
                name = Convert.ToString((range.Cells[i, Nameindex] as Excel.Range).Text);
                phone = Convert.ToString((range.Cells[i, phoneNumberindex] as Excel.Range).Text);
                uni = Convert.ToString((range.Cells[i, Universityindex] as Excel.Range).Text);
                col = Convert.ToString((range.Cells[i, Collegeindex] as Excel.Range).Text);
                level = Convert.ToString((range.Cells[i, Levelindex] as Excel.Range).Text);
                addr = Convert.ToString((range.Cells[i, Addressindex] as Excel.Range).Text);
                if (name == NameBox.Text &&
                    phone == PhoneNumberBox.Text &&
                    uni == UniversityBox.Text &&
                    col == CollegeBox.Text &&
                    level == LevelBox.Text &&
                    addr == $"\"{AddressBox.Text}\"")
                {
                    return true;
                }
            }
            return false;
        }
        private void ClearFields()
        {
            NameBox.Text = "";
            PhoneNumberBox.Text = "";
            UniversityBox.Text = "";
            CollegeBox.Text = "";
            LevelBox.Text = "";
            AddressBox.Text = "";
            FilePathBox.Text = "";
            SheetsNamesBox.Text = "";
            SavePlaceBox.Text = "";
            additionalSheetsBox.Text = "";
        }
    }
}
