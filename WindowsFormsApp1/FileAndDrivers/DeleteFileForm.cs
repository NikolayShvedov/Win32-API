using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1.FileAndDrivers
{
    public partial class DeleteFileForm : Form
    {
        public DeleteFileForm()
        {
            InitializeComponent();
        }

        public string DeleteFile()
        {
            string pathFile = textPathFile.Text;
            if (File.Exists(pathFile))
            {
                try
                {
                    File.Delete(pathFile);
                    return "Файл " + pathFile + " успешно удалён!";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "Specified file doesn't exist";
            }
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DeleteFile());
        }
    }
}
