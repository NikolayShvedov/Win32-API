using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.VideoSystem
{
    public partial class GetDeviceCapsForm : Form
    {
        public GetDeviceCapsForm()
        {
            InitializeComponent();
        }

        private static List<string> HasDeviceCaps()
        {
            List<string> devicesCaps = new List<string>();
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                devicesCaps.Add(" 1) Горизонтальное разрешение = " + g.DpiX);
                devicesCaps.Add(" 2) Вертикальное разрешение = " + g.DpiY);

                IntPtr hdc = g.GetHdc();
                devicesCaps.Add(" 3) Версия драйвера устройства = " + GetDeviceCaps(hdc, DeviceCap.DRIVERVERSION).ToString());
                 
                switch (GetDeviceCaps(hdc, DeviceCap.TECHNOLOGY))
                {
                    case 0:
                        devicesCaps.Add(" 4) Классификация устройства = Векторный плоттер");
                        break;
                    case 1:
                        devicesCaps.Add(" 4) Классификация устройства = Растровое отображение");
                        break;
                    case 2:
                        devicesCaps.Add(" 4) Классификация устройства = Растровый принтер");
                        break;
                    case 3:
                        devicesCaps.Add(" 4) Классификация устройства = Растровая камера");
                        break;
                    case 4:
                        devicesCaps.Add(" 4) Классификация устройства = Символьный поток, PLP");
                        break;
                    case 5:
                        devicesCaps.Add(" 4) Классификация устройства = Метафайл, VDM");
                        break;
                    case 6:
                        devicesCaps.Add(" 4) Классификация устройства = Отображаемый файл");
                        break;
                }

                devicesCaps.Add(" 5) Размер по горизонтали = " + GetDeviceCaps(hdc, DeviceCap.HORZSIZE).ToString() + " мм");
                devicesCaps.Add(" 6) Размер по вертикали = " + GetDeviceCaps(hdc, DeviceCap.VERTSIZE).ToString() + " мм");
                devicesCaps.Add(" 7) Ширина по горизонтали = " + GetDeviceCaps(hdc, DeviceCap.HORZRES).ToString() + " px");
                devicesCaps.Add(" 8) Высота по вертикали = " + GetDeviceCaps(hdc, DeviceCap.VERTRES).ToString() + " px");
                devicesCaps.Add(" 9) Количество бит на пиксель = " + GetDeviceCaps(hdc, DeviceCap.BITSPIXEL).ToString());
                devicesCaps.Add(" 10) Количество плоскостей = " + GetDeviceCaps(hdc, DeviceCap.PLANES).ToString());
                devicesCaps.Add(" 11) Количество щеток на устройстве = " + GetDeviceCaps(hdc, DeviceCap.NUMBRUSHES).ToString());
                devicesCaps.Add(" 12) Количество перьев на устройстве = " + GetDeviceCaps(hdc, DeviceCap.NUMPENS).ToString());
                devicesCaps.Add(" 13) Количество маркеров на устройстве = " + GetDeviceCaps(hdc, DeviceCap.NUMMARKERS).ToString());
                devicesCaps.Add(" 14) Количество шрифтов на устройстве = " + GetDeviceCaps(hdc, DeviceCap.NUMFONTS).ToString());
                devicesCaps.Add(" 15) Количество цветов, поддерживаемых устройством = " + GetDeviceCaps(hdc, DeviceCap.NUMCOLORS).ToString());
                devicesCaps.Add(" 16) Размер, необходимый для дескриптора устройства = " + GetDeviceCaps(hdc, DeviceCap.PDEVICESIZE).ToString());
                devicesCaps.Add(" 17) Значение совместимости устройства с кривыми линиями = " + GetDeviceCaps(hdc, DeviceCap.CURVECAPS).ToString());
                devicesCaps.Add(" 18) Значение совместимости устройства с прямыми линиями = " + GetDeviceCaps(hdc, DeviceCap.LINECAPS).ToString());
                devicesCaps.Add(" 19) Значение совместимости устройства с многоугольниками = " + GetDeviceCaps(hdc, DeviceCap.POLYGONALCAPS).ToString());
                devicesCaps.Add(" 20) Значение совместимости устройства с текстом = " + GetDeviceCaps(hdc, DeviceCap.TEXTCAPS).ToString());

                if (GetDeviceCaps(hdc, DeviceCap.CLIPCAPS) == 1)
                {
                    devicesCaps.Add(" 21) Устройство можно отобразить в виде прямоугольника");
                }
                else
                {
                    devicesCaps.Add(" 21) Устройство нельзя отобразить в виде прямоугольника");
                }

                devicesCaps.Add(" 22) Ширина пикселя устройства, использующаяся для рисования линии = " + GetDeviceCaps(hdc, DeviceCap.ASPECTX).ToString());
                devicesCaps.Add(" 23) Высота пикселя устройства, использующаяся для рисования линии = " + GetDeviceCaps(hdc, DeviceCap.ASPECTY).ToString());
                devicesCaps.Add(" 24) Количество зарезервированных цветов в системной палитре = " + GetDeviceCaps(hdc, DeviceCap.NUMRESERVED).ToString());
                devicesCaps.Add(" 25) Актуальное цветовое разрешение устройства в битах на пиксель = " + GetDeviceCaps(hdc, DeviceCap.COLORRES).ToString());
                devicesCaps.Add(" 26) Частота экрана = " + GetDeviceCaps(hdc, DeviceCap.VREFRESH).ToString() + " Гц");
                devicesCaps.Add(" 27) Высота рабочего стола в пикселях = " + GetDeviceCaps(hdc, DeviceCap.DESKTOPVERTRES).ToString());
                devicesCaps.Add(" 28) Ширина рабочего стола в пикселях = " + GetDeviceCaps(hdc, DeviceCap.DESKTOPHORZRES).ToString());

            }

            return devicesCaps;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string deviceCaps in HasDeviceCaps())
            {
                listBox1.Items.Add(deviceCaps);
            }
        }

        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, DeviceCap smIndex);
    }
}
