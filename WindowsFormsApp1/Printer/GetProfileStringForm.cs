using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1.Printer
{
    public partial class GetProfileStringForm : Form
    {
        string path = null;

        public GetProfileStringForm()
        {
            InitializeComponent();
            path = new FileInfo("C:/Windows/win.ini").ToString();
        }

        public List<string> IniReadSection()
        {
            string returnString = new string(' ', 65536);
            GetPrivateProfileString(null, null, null, returnString, 65536, path);
            List<string> result = new List<string>(returnString.Split('\0'));
            result.RemoveRange(result.Count - 2, 2);
            return result;
        }

        public List<string> IniReadKey(string section)
        {
            string returnString = new string(' ', 32768);
            GetPrivateProfileString(section, null, null, returnString, 32768, path);
            List<string> result = new List<string>(returnString.Split('\0'));
            result.RemoveRange(result.Count - 2, 2);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string section in IniReadSection())
            {
                listBox1.Items.Add("Секция = " + section);
                foreach (string key in IniReadKey(section))
                {
                    listBox1.Items.Add("Ключ = " + key);
                }
                listBox1.Items.Add("-------------------------------");
                listBox1.Items.Add("");
            }
        }

        [DllImport("KERNEL32.DLL", EntryPoint = "GetPrivateProfileStringW",
            SetLastError = true,
            CharSet = CharSet.Unicode, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            string lpReturnString,
            int nSize,
            string lpFilename);
    }
}
