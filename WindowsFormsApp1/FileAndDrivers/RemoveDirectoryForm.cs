using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1.FileAndDrivers
{
    public partial class RemoveDirectoryForm : Form
    {
        public RemoveDirectoryForm()
        {
            InitializeComponent();
        }

        public string RemoveDirectory()
        {
            string path = textPathFile.Text;
            string subpath = textFolder.Text;
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path + subpath);
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удалён");
                return "Каталог " + subpath + " по пути: " + path + " успешно удалён!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(RemoveDirectory());
        }
    }
}
