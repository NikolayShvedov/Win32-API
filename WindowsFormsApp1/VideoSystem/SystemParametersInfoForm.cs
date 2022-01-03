using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.VideoSystem
{
    public partial class SystemParametersInfoForm : Form
    {
        public SystemParametersInfoForm()
        {
            InitializeComponent();
        }

        private static List<string> HasSystemParametersVideoSystem()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            List<string> devicesProperties = new List<string>();
            int i = 1;
            foreach (ManagementObject param in searcher.Get())
            {
                devicesProperties.Add("Видеокарта: " + param.GetPropertyValue("Description"));
                devicesProperties.Add("Частота дисплея: " + param.GetPropertyValue("DisplayFrequency") + " Гц");
                devicesProperties.Add("Высота экрана: " + param.GetPropertyValue("PelsHeight") + " пикселей");
                devicesProperties.Add("Ширина экрана: " + param.GetPropertyValue("PelsWidth") + " пикселей");
                devicesProperties.Add("");
                i++;
            }

            return devicesProperties;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string device in HasSystemParametersVideoSystem())
            {
                listBox1.Items.Add(device);
            }
        }
    }
}
