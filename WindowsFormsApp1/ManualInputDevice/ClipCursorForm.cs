using System;
using System.Drawing;
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
