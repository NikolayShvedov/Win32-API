using System;
using System.Windows.Forms;
using WindowsFormsApp1.Printer;

namespace WindowsFormsApp1.CAD_hardware
{
    public partial class PrinterWork : Form
    {
        public PrinterWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetProfileStringForm profileStringForm = new GetProfileStringForm();
            profileStringForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetDeviceCapsForm deviceCapsForm = new GetDeviceCapsForm();
            deviceCapsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDlgForm printDlgForm = new PrintDlgForm();
            printDlgForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WriteFileForm writeFileForm = new WriteFileForm();
            writeFileForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BitBltForm bitBltForm = new BitBltForm();
            bitBltForm.Show();
        }
    }
}
