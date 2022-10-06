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
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QRCodeGenrator_5dma
{

    public partial class ScannerUserControl : UserControl
    {
        int nameColumnIndex = 0, dateColumnIndex = 0;
        Excel.Application application;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;
        Excel.Range range;
        Dictionary<string, int> SheetsNamesIndecies;
        string SavePath = "";
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public ScannerUserControl()
        {
            InitializeComponent();
        }
        private void ScannerUserControl_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Today.ToString("dd-MM-yyyy");
            application = new Excel.Application();
            SheetsNamesIndecies = new Dictionary<string, int>();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterInfoCollection)
            {
                CamerasBox.Items.Add(device.Name);
            }
            CamerasBox.SelectedIndex = 0;
        }
        public void Kill()
        {
            SaveWorkBook();
            CloseCamera();
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
            CloseCamera();
            videoTimer.Stop();
            VideoBox.Image = null;
            FilePathBox.Clear();
            SheetsNamesBox.Items.Clear();
            SheetsNamesBox.Text = "";
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
        public void CloseCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
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
                SheetsNamesIndecies[SheetName.Name] = i;
            }
        }
        private void InitializeWorksheet(string SelectedSheet)
        {
            nameColumnIndex = 0;
            if (SheetsNamesIndecies.ContainsKey(SelectedSheet) == false)
                return;
            worksheet = workbook.Sheets[SheetsNamesIndecies[SelectedSheet]];
            range = worksheet.UsedRange;
            nameColumnIndex = 1;
            MessageBox.Show(range.Columns.Count.ToString());
            //for (int i = 1; i <= range.Columns.Count; i++)
            //{
            //    string cell = Convert.ToString((range.Cells[1, i] as Excel.Range).Text);
            //    if (cell == "الاسم" || cell == "Name")
            //    {
            //        nameColumnIndex = i;
            //    }
            //}
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
        private void Scanbtn_Click(object sender, EventArgs e)
        {
            if (nameColumnIndex == 0)
            {
                MessageBox.Show("you should choose sheet has Name or الاسم column!");
                return;
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[CamerasBox.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += CaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            videoTimer.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            VideoBox.Image = (Bitmap)eventArgs.Frame.Clone();

        }
        private int isExist(string memberName)
        {
            for(int i = 2; i <= range.Rows.Count; i++)
            {
                string cell = Convert.ToString((range.Cells[i, nameColumnIndex] as Excel.Range).Text);
                if(cell.Contains(memberName)==true)
                {
                    return i;
                }
            }
            return 0;
        }
        private string SeperateName(string Word)
        {
            string Name = "";
            for(int i = 0; i < Word.Length && Word[i] != '-'; i++)
            {
                Name += Word[i];
            }
            Name.Remove(Name.Length - 1);
            return Name;
        }
        private void setAttendance(int rowNumber,string memberName)
        {
            AttendanceList.Items.Add(memberName);
            AttendanceCounterBox.Text = AttendanceList.Items.Count.ToString();

            int lastCellNotEmpty = range.Columns.Count;
            string cell = Convert.ToString((range.Cells[1, lastCellNotEmpty] as Excel.Range).Text),
                   date = DateTime.Today.ToString("dd-MM-yyyy");
            if (cell != date)
            {
                dateColumnIndex = lastCellNotEmpty + 1;
                range.Cells[1, dateColumnIndex] = date;
            }
            //cell = Convert.ToString((range.Cells[1, lastCellNotEmpty+1] as Excel.Range).Text);
            //MessageBox.Show(cell + " row : " + rowNumber + " " + date);
            range.Cells[rowNumber, dateColumnIndex] = "+";
        }
        private bool isAttend(string memberName)
        {
            foreach(string member in AttendanceList.Items)
            {
                if (member == memberName)
                    return true;
            }
            return false;
        }
        private void videoTimer_Tick(object sender, EventArgs e)
        {
            if (VideoBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)VideoBox.Image);
                if (result != null)
                {
                    string memberName = SeperateName(result.ToString());
                    if (isAttend(memberName) == true)
                    {
                        MessageBox.Show("Member " + memberName + " attends.");

                    }
                    else
                    {
                        int rowNumber = isExist(memberName);
                        if (rowNumber == 0)
                        {
                            MessageBox.Show("Member " + memberName + " doesn't exist.");
                        }
                        else
                        {
                            MessageBox.Show("Welcome, " + memberName + " :)");
                            setAttendance(rowNumber, memberName);
                        }
                    }
                    videoTimer.Start();
                }
            }
        }
    }
}
