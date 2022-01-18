using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;

namespace WindowsFormsApp1.ManualInputDevice
{
    public partial class GetKeyboardTypeForm : Form
    {
        public GetKeyboardTypeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string device in HasDevice("Keyboard"))
            {
                listBox1.Items.Add(device);
            }
        }

        private static List<string> HasDevice(string typeDevice)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\cimv2", "SELECT * FROM Win32_" + typeDevice);

            List<string> devicesProperties = new List<string>();
            int i = 1;
            foreach (ManagementObject keyboard in searcher.Get())
            {
                if (!keyboard.GetPropertyValue("Name").Equals(""))
                {
                    devicesProperties.Add("Клавиатура " + i + ": " + keyboard.GetPropertyValue("Name"));
                    devicesProperties.Add("Описание: " + keyboard.GetPropertyValue("Description"));
                    devicesProperties.Add("ID устройства: " + keyboard.GetPropertyValue("DeviceID"));
                    devicesProperties.Add("Статус: " + keyboard.GetPropertyValue("Status"));
                    devicesProperties.Add("");
                    i++;
                }
            }

            return devicesProperties;
        }
    }
}
