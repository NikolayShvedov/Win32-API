using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1.Printer
{
    public partial class WriteFileForm : Form
    {
        public WriteFileForm()
        {
            InitializeComponent();
        }

        void writeFile(string source)
        {
            int i = 1;
            while (File.Exists(source))
            {
                source = @"D:/file" + i + ".doc";
                i++;
            }
            string text = textBox1.Text;
            File.WriteAllText(source, text);
        }

        private void wordExportButton_Click(object sender, EventArgs e)
        {
            string source = @"D:/file.doc";
            writeFile(source);
        }
    }
}
