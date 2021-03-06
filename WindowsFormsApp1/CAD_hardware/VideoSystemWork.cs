using System;
using System.Windows.Forms;
using WindowsFormsApp1.VideoSystem;

namespace WindowsFormsApp1.CAD_hardware
{
    public partial class VideoSystemWork : Form
    {
        public VideoSystemWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemParametersInfoForm systemParametersInfoForm = new SystemParametersInfoForm();
            systemParametersInfoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetSystemMetricsForm systemMetricsForm = new GetSystemMetricsForm();
            systemMetricsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetDeviceCapsForm deviceCapsForm = new GetDeviceCapsForm();
            deviceCapsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeDisplaySettingsForm changeDisplaySettingsForm = new ChangeDisplaySettingsForm();
            changeDisplaySettingsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BitBltForm bitBltForm = new BitBltForm();
            bitBltForm.Show();
        }
    }
}
