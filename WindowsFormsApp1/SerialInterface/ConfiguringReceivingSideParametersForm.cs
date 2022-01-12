using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.SerialInterface
{
    public partial class ConfiguringReceivingSideParametersForm : Form
    {
        public SerialPort comPortA = new SerialPort();
        public SerialPort comPortB = new SerialPort();
        public delegate void AddDataDelegate(string data, string recvPort);
        public AddDataDelegate myDelegate;
        public ConfiguringReceivingSideParametersForm()
        {
            InitializeComponent();
        }

        private void ConfiguringReceivingSideParametersForm_Load(object sender, EventArgs e)
        {
            //BAUD RATES
            int[] baudRates = new int[] { 300, 600, 1200, 2400, 9600, 14400, 19200, 38400, 57600, 115200 };
            for (int i = 0; i < baudRates.Length; i++)
            {
                baudBoxA.Items.Add(baudRates[i]);
                baudBoxB.Items.Add(baudRates[i]);
            }
            baudBoxA.SelectedIndex = 4;
            baudBoxB.SelectedIndex = 4;

            //PARITY
            string[] parity = new string[] { "None", "Odd", "Even", "Mark", "Space" };
            for (int i = 0; i < parity.Length; i++)
            {
                parityBoxA.Items.Add(parity[i]);
                parityBoxB.Items.Add(parity[i]);
            }
            parityBoxA.SelectedIndex = 0;
            parityBoxB.SelectedIndex = 0;

            //STOP BITS
            double[] stopBits = new double[] { 1, 1.5, 2 };
            for (int i = 0; i < stopBits.Length; i++)
            {
                stopBoxA.Items.Add(stopBits[i]);
                stopBoxB.Items.Add(stopBits[i]);
            }
            stopBoxA.SelectedIndex = 0;
            stopBoxB.SelectedIndex = 0;

            //AVAILABLE COM PORTS
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                comBoxA.Items.Add(ArrayComPortsNames[index]);
                comBoxB.Items.Add(ArrayComPortsNames[index]);
            }
            while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            comBoxA.Text = ArrayComPortsNames[0];
            comBoxB.Text = ArrayComPortsNames[0];

            //Invoke function outside of thread
            this.myDelegate = new AddDataDelegate(PostData);
        }

        private void DataReceivedHandlerA(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            recvTextA.Invoke(this.myDelegate, new Object[] { indata, "A" });
        }
        private void DataReceivedHandlerB(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            recvTextB.Invoke(this.myDelegate, new Object[] { indata, "B" });
        }

        public void PostData(string data, string recvPort)
        {
            if (recvPort == "A")
            {
                recvTextA.Text = Convert.ToString(data);
            }
            else if (recvPort == "B")
            {
                recvTextB.Text = Convert.ToString(data);
            }
        }

        private void portButtonA_Click(object sender, EventArgs e)
        {
            //Open Port
            if (Convert.ToString(portButtonA.Text) == "Connect")
            {
                try
                {
                    //Set Port Settings
                    comPortA.PortName = Convert.ToString(comBoxA.SelectedItem);
                    comPortA.BaudRate = Convert.ToInt32(baudBoxA.SelectedItem);
                    comPortA.DataBits = 8;
                    comPortA.Handshake = Handshake.None;
                    comPortA.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerA);

                    switch (Convert.ToString(stopBoxA.SelectedItem))
                    {
                        case "1":
                            comPortA.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            comPortA.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            comPortA.StopBits = StopBits.Two;
                            break;
                    }

                    switch (Convert.ToString(parityBoxA.SelectedItem))
                    {
                        case "None":
                            comPortA.Parity = Parity.None;
                            break;
                        case "Odd":
                            comPortA.Parity = Parity.Odd;
                            break;
                        case "Even":
                            comPortA.Parity = Parity.Even;
                            break;
                        case "Mark":
                            comPortA.Parity = Parity.Mark;
                            break;
                        case "Space":
                            comPortA.Parity = Parity.Space;
                            break;
                    }
                    comPortA.Open();
                    portButtonA.Text = "Disconnect";
                    comBoxA.Enabled = false;
                    baudBoxA.Enabled = false;
                    parityBoxA.Enabled = false;
                    stopBoxA.Enabled = false;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//Close Port
            else if (Convert.ToString(portButtonA.Text) == "Disconnect")
            {
                comPortA.Close();
                portButtonA.Visible = false;
            }
        }

        private void sendButtonA_Click_1(object sender, EventArgs e)
        {
            if (!(comPortA.IsOpen))
            {
                MessageBox.Show("COM Port A not open. Cannot send message.");
            }
            else //send message
            {
                comPortA.Write(Convert.ToString(msgBoxA.Text));
                msgBoxA.Text = "";
            }
        }

        private void portButtonB_Click(object sender, EventArgs e)
        {
            //Open Port
            if (Convert.ToString(portButtonB.Text) == "Connect")
            {
                try
                {
                    //Set Port Settings
                    comPortB.PortName = Convert.ToString(comBoxB.SelectedItem);
                    comPortB.BaudRate = Convert.ToInt32(baudBoxB.SelectedItem);
                    comPortB.DataBits = 8;
                    comPortB.Handshake = Handshake.None;
                    comPortB.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerB);


                    switch (Convert.ToString(stopBoxB.SelectedItem))
                    {
                        case "1":
                            comPortB.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            comPortB.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            comPortB.StopBits = StopBits.Two;
                            break;
                    }

                    switch (Convert.ToString(parityBoxB.SelectedItem))
                    {
                        case "None":
                            comPortB.Parity = Parity.None;
                            break;
                        case "Odd":
                            comPortB.Parity = Parity.Odd;
                            break;
                        case "Even":
                            comPortB.Parity = Parity.Even;
                            break;
                        case "Mark":
                            comPortB.Parity = Parity.Mark;
                            break;
                        case "Space":
                            comPortB.Parity = Parity.Space;
                            break;
                    }
                    comPortB.Open();
                    portButtonB.Text = "Disconnect";
                    comBoxB.Enabled = false;
                    baudBoxB.Enabled = false;
                    parityBoxB.Enabled = false;
                    stopBoxB.Enabled = false;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//Close port
            else if (Convert.ToString(portButtonB.Text) == "Disconnect")
            {
                comPortB.Close();
                portButtonB.Visible = false;
            }
        }

        private void sendButtonB_Click_1(object sender, EventArgs e)
        {
            if (!(comPortB.IsOpen))
            {
                MessageBox.Show("COM Port B not open. Cannot send message.");
            }
            else //send message
            {
                comPortB.Write(Convert.ToString(msgBoxB.Text));
                msgBoxB.Text = "";
            }
        }
    }
}
