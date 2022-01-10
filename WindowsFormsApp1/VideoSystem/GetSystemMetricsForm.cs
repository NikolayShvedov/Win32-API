using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.VideoSystem
{
    public partial class GetSystemMetricsForm : Form
    {
        public GetSystemMetricsForm()
        {
            InitializeComponent();
        }

        private static List<string> HasSystemMetrics()
        {
            List<string> devicesProperties = new List<string>();

            devicesProperties.Add(" 1) Ширина и высота рамки окна = " + GetSystemMetrics(SystemMetric.SM_CXBORDER).ToString() + ", " + GetSystemMetrics(SystemMetric.SM_CYBORDER).ToString());
            devicesProperties.Add(" 2) Высота заголовка =  " + GetSystemMetrics(SystemMetric.SM_CYCAPTION).ToString());
            devicesProperties.Add(" 3) Ширина курсора = " + GetSystemMetrics(SystemMetric.SM_CXCURSOR).ToString());
            devicesProperties.Add(" 4) Высота курсора =  " + GetSystemMetrics(SystemMetric.SM_CYCURSOR).ToString());
            devicesProperties.Add(" 5) Ширина иконки =  " + GetSystemMetrics(SystemMetric.SM_CXICON).ToString());
            devicesProperties.Add(" 6) Минимальная ширина окна =  " + GetSystemMetrics(SystemMetric.SM_CXMIN).ToString());
            devicesProperties.Add(" 7) Высота стандартной области заголовка =  " + GetSystemMetrics(SystemMetric.SM_CYCAPTION).ToString());
            devicesProperties.Add(" 8) Количество клавиш мыши =  " + GetSystemMetrics(SystemMetric.SM_CMOUSEBUTTONS).ToString());
            if (GetSystemMetrics(SystemMetric.SM_MOUSEWHEELPRESENT) == 1) {
                devicesProperties.Add(" 9) Наличие колеса прокрутки = присутствует");
            }
            else {
                devicesProperties.Add(" 9) Наличие колеса прокрутки =  отсутствует");
            }
            if (GetSystemMetrics(SystemMetric.SM_SWAPBUTTON) == 1)
            {
                devicesProperties.Add(" 10) Возможно ли клавиши мыши поменять местами = возможно");
            }
            else
            {
                devicesProperties.Add(" 10) Возможно ли клавиши мыши поменять местами = невозможно");
            }
            devicesProperties.Add("");
            return devicesProperties;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string metric in HasSystemMetrics())
            {
                listBox1.Items.Add(metric);
            }
        }

        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(SystemMetric smIndex);
    }
}
