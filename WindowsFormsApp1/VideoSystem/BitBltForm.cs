using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1.VideoSystem
{
    public partial class BitBltForm : Form
    {

        public static Int32 SRCINVERT = 0x00660046;

        [DllImport("gdi32.dll")]
        private static extern int BitBlt(
            IntPtr hdcDest,     // handle to destination DC (device context)
            int nXDest,         // x-coord of destination upper-left corner
            int nYDest,         // y-coord of destination upper-left corner
            int nWidth,         // width of destination rectangle
            int nHeight,        // height of destination rectangle
            IntPtr hdcSrc,      // handle to source DC
            int nXSrc,          // x-coordinate of source upper-left corner
            int nYSrc,          // y-coordinate of source upper-left corner
            Int32 dwRop  // raster operation code
      );

        [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr h);

        public void TestXOR()
        {
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawLine(Pens.White, new Point(0, 0), new Point(100, 100));
            bmp.Save(@"D:\testBefore.bmp", ImageFormat.Bmp);
            IntPtr testHDC = g.GetHdc();
            SelectObject(testHDC, bmp.GetHbitmap());
            BitBlt(testHDC, 0, 0, 100, 100, testHDC, 0, 0, SRCINVERT);
            g.ReleaseHdc(testHDC);
            bmp.Save(@"D:\testAfter.bmp", ImageFormat.Bmp);
            g.Dispose();

            MessageBox.Show("Функция успешно отработала!", "Выполнение функции BitBlt!");
        }

        public BitBltForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BitBltForm tst = new BitBltForm();
            tst.TestXOR();
            tst.Dispose();
        }
    }
}
