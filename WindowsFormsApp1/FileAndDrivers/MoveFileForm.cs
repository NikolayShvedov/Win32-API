using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1.FileAndDrivers
{
    public partial class MoveFileForm : Form
    {
        public MoveFileForm()
        {
            InitializeComponent();
        }

        public static string MoveFile(string sourse, string dest)
        {
            try {
                File.Move(sourse, dest);
                string fileName = Path.GetFileName(sourse);
                string fileNameNew = Path.GetFileName(dest);
                return "Файл " + fileName + " успешно перемещён в выбранный каталог с новым именем " + fileNameNew;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string pathFile = textPathFile.Text;
            string pathNewFile = textNewPathFile.Text;
            listBox1.Items.Add(MoveFile(pathFile, pathNewFile));
        }
    }
}
