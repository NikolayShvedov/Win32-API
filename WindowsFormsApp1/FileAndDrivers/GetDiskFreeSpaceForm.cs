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
    public partial class GetDiskFreeSpaceForm : Form
    {
        public GetDiskFreeSpaceForm()
        {
            InitializeComponent();
            foreach (string driver in GetLogicalDrives())
            {
                listBox1.Items.Add("На диске " + driver + " свободно: " + GetTotalFreeSpace(driver) + " байт");
            }
        }

        string[] GetLogicalDrives()
        {
            string[] drives = null;
            try
            {
                drives = System.IO.Directory.GetLogicalDrives();
                foreach (string str in drives)
                {
                    System.Console.WriteLine(str);
                }
            }
            catch (System.IO.IOException)
            {
                System.Console.WriteLine("An I/O error occurs.");
            }
            catch (System.Security.SecurityException)
            {
                System.Console.WriteLine("The caller does not have the " +
                    "required permission.");
            }
            return drives;
        }

        long GetTotalFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.AvailableFreeSpace;
                }
            }
            return -1;
        }
    }
}
