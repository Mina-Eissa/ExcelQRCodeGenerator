using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.Drawing;
using System.IO;
namespace QRCodeGenrator_5dma
{
    class Generator
    {
        QRCodeGenerator generator;
        QRCodeData data;
        QRCode code;
        Bitmap image;
        public Generator()
        {
            generator = new QRCodeGenerator();
        }
        public void generateQRCode(string codeData,string name,string savePath)
        {
            data = generator.CreateQrCode(codeData, QRCodeGenerator.ECCLevel.Q);
            code = new QRCode(data);
            image = code.GetGraphic(5);
            SaveImage(image, name,savePath);
        }
        private void SaveImage(Bitmap Code, string memberName, string savePath)
        {
            string directoryPath = savePath + "\\Images";
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
            string fileName = directoryPath + "\\" + memberName + ".jpg";
            Code.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
