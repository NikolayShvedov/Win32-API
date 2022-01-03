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
    public partial class ClipCursorForm : Form
    {
        public ClipCursorForm()
        {
            InitializeComponent();
            Cursor.Clip = new Rectangle(this.RectangleToScreen(this.ClientRectangle).Location, this.RectangleToScreen(this.ClientRectangle).Size);
        }
    }
}
