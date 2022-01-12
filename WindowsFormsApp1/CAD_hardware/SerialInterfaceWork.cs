using System;
using System.Windows.Forms;
using WindowsFormsApp1.SerialInterface;

namespace WindowsFormsApp1.CAD_hardware
{
    public partial class SerialInterfaceWork : Form
    {
        public SerialInterfaceWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfiguringReceivingSideParametersForm configuringReceivingSideParametersForm = new ConfiguringReceivingSideParametersForm();
            configuringReceivingSideParametersForm.Show();
        }
    }
}
