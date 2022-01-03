using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FileAndDrivers;

namespace WindowsFormsApp1.CAD_hardware
{
    public partial class FileSystemWork : Form
    {
        public FileSystemWork()
        {
            InitializeComponent();
        }

        private void buttonLogicalDrives_Click(object sender, EventArgs e)
        {
            GetLogicalDrivesForm logicalDrivesForm = new GetLogicalDrivesForm();
            logicalDrivesForm.Show();
        }

        private void buttonDiskFreeSpace_Click(object sender, EventArgs e)
        {
            GetDiskFreeSpaceForm diskFreeSpaceForm = new GetDiskFreeSpaceForm();
            diskFreeSpaceForm.Show();
        }

        private void buttonFindFirstFile_Click(object sender, EventArgs e)
        {
            FindFirstFileForm firstFileForm = new FindFirstFileForm();
            firstFileForm.Show();
        }

        private void buttonCreateDirectory_Click(object sender, EventArgs e)
        {
            CreateDirectoryForm createDirectoryForm = new CreateDirectoryForm();
            createDirectoryForm.Show();
        }

        private void buttonRemoveDirectory_Click(object sender, EventArgs e)
        {
            RemoveDirectoryForm removeDirectoryForm = new RemoveDirectoryForm();
            removeDirectoryForm.Show();
        }

        private void buttonMoveFile_Click(object sender, EventArgs e)
        {
            MoveFileForm moveFileForm = new MoveFileForm();
            moveFileForm.Show();
        }
    }
}
