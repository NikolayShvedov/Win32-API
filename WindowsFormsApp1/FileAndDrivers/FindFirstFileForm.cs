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
    public partial class FindFirstFileForm : Form
    {
        public FindFirstFileForm()
        {
            InitializeComponent();
        }

        public static string FindFirstFile(string path, string searchPattern)
        {
            string[] files;
            try
            {
                files = Directory.GetFiles(path, searchPattern, SearchOption.TopDirectoryOnly);
            }
            catch (Exception)
            {
                return string.Empty;
            }

            if (files.Length > 0)
            {
                return files[0];
            }
            else
            {
                string[] directories;
                try
                {
                    directories = Directory.GetDirectories(path);
                }
                catch (Exception)
                {
                    return string.Empty;
                }

                foreach (string directory in directories)
                {
                    string file = FindFirstFile(directory, searchPattern);

                    if (file != string.Empty)
                    {
                        return file;
                    }
                }
            }
            return string.Empty;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(FindFirstFile(textBoxPathFile.Text, textBoxSearchPattern.Text));
        }
    }
}
