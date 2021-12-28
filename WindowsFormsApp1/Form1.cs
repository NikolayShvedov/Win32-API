using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CAD_hardware;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFileSystemWork_Click(object sender, EventArgs e)
        {
            FileSystemWork videoSystemWork = new FileSystemWork();
            videoSystemWork.Show();
        }

        private void buttonManualInputDeviceWork_Click(object sender, EventArgs e)
        {
            ManualInputDeviceWork manualInputDeviceWork = new ManualInputDeviceWork();
            manualInputDeviceWork.Show();
        }

        private void buttonVideoSystemWork_Click(object sender, EventArgs e)
        {
            VideoSystemWork videoSystemWork = new VideoSystemWork();
            videoSystemWork.Show();
        }

        private void buttonPrinterWork_Click(object sender, EventArgs e)
        {
            PrinterWork printerWork = new PrinterWork();
            printerWork.Show();
        }

        private void buttonSerialInterfaceWork_Click(object sender, EventArgs e)
        {
            SerialInterfaceWork serialInterfaceWork = new SerialInterfaceWork();
            serialInterfaceWork.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
