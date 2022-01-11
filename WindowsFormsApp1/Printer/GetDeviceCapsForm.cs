using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace WindowsFormsApp1.Printer
{
    public partial class GetDeviceCapsForm : Form
    {
        public GetDeviceCapsForm()
        {
            InitializeComponent();
        }

        private static List<string> HasDevice()
        {
            List<string> devicesProperties = new List<string>();
            string query = "SELECT * from Win32_Printer";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            using (ManagementObjectCollection coll = searcher.Get())
            {
                try
                {
                    foreach (ManagementObject printer in coll)
                    {
                        foreach (PropertyData property in printer.Properties)
                        {
                            devicesProperties.Add(string.Format("{0}: {1}", property.Name, property.Value));
                        }
                        devicesProperties.Add("");
                        devicesProperties.Add("-----------------------------");
                        devicesProperties.Add("");
                    }
                }
                catch (ManagementException ex)
                {
                    devicesProperties.Add(ex.Message);
                }
            }

            return devicesProperties;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string device in HasDevice())
            {
                listBox1.Items.Add(device);
            }
        }
    }
}
