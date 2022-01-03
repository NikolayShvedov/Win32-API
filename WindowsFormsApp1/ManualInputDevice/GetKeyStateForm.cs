using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ManualInputDevice
{
    public partial class GetKeyStateForm : Form
    {
        public GetKeyStateForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void GetKeyStateForm_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Items.Add(e.KeyData.ToString());
        }
    }
}
