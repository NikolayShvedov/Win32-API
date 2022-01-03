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

namespace WindowsFormsApp1.ManualInputDevice
{
    public partial class SetCursorPosForm : Form
    {
        public SetCursorPosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetCursorPos(Int32.Parse(textBoxX.Text), Int32.Parse(textBoxY.Text));
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int xPos, int yPos);
    }
}
