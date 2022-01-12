using System;
using System.Windows.Forms;
using WindowsFormsApp1.ManualInputDevice;

namespace WindowsFormsApp1.CAD_hardware
{
    public partial class ManualInputDeviceWork : Form
    {
        public ManualInputDeviceWork()
        {
            InitializeComponent();
        }

        private void buttonGetKeyboardType_Click(object sender, EventArgs e)
        {
            GetKeyboardTypeForm keyboardTypeForm = new GetKeyboardTypeForm();
            keyboardTypeForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetKeyStateForm keyStateForm = new GetKeyStateForm();
            keyStateForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemParametersInfoForm systemParametersInfoForm = new SystemParametersInfoForm();
            systemParametersInfoForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SwapMouseButtonForm swapMouseButtonForm = new SwapMouseButtonForm();
            swapMouseButtonForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClipCursorForm clipCursorForm = new ClipCursorForm();
            clipCursorForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetCursorPosForm cursorPosForm = new SetCursorPosForm();
            cursorPosForm.Show();
        }
    }
}
