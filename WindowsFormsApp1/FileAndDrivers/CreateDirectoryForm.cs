using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FileAndDrivers
{
    public partial class CreateDirectoryForm : Form
    {
        public CreateDirectoryForm()
        {
            InitializeComponent();
        }

        public string CreateDirectory()
        {
            string path = textPathFile.Text;
            string subpath = textFolder.Text;
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            return "Каталог " + subpath + " по пути: " + path + " успешно создан!";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(CreateDirectory());
        }
    }
}
