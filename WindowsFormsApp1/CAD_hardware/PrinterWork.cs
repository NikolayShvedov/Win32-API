using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
