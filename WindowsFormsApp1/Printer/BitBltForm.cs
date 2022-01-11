using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp1.Printer
{
    public partial class BitBltForm : Form
    {
        public BitBltForm()
        {
            InitializeComponent();
        }

        private System.IO.Stream streamToPrint;
        string streamType;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern bool BitBlt
        (
        IntPtr hdcDest,         // handle to destination DC  
            int nXDest,         // x-coord of destination upper-left corner  
            int nYDest,         // y-coord of destination upper-left corner  
            int nWidth,         // width of destination rectangle  
            int nHeight,        // height of destination rectangle  
        IntPtr hdcSrc,          // handle to source DC  
            int nXSrc,          // x-coordinate of source upper-left corner  
            int nYSrc,          // y-coordinate of source upper-left corner  
        Int32 dwRop      // raster operation code  
        );

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image image = Image.FromStream(streamToPrint);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;
            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            Rectangle destRect = new Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }

        public void StartPrint(Stream streamToPrint, string streamType)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            this.streamToPrint = streamToPrint;
            this.streamType = streamType;
            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDoc;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDoc.Print(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g1 = CreateGraphics();
            Image MyImage = new Bitmap(ClientRectangle.Width, ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, ClientRectangle.Width, ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            MyImage.Save(@"D:\PrintPage.jpg", ImageFormat.Jpeg);
            FileStream fileStream = new FileStream(@"D:\PrintPage.jpg", FileMode.Open, FileAccess.Read);
            StartPrint(fileStream, "Image");
            fileStream.Close();
            if (File.Exists(@"D:\PrintPage.jpg"))
            {
                File.Delete(@"D:\PrintPage.jpg");
            }
        }
    }
}
