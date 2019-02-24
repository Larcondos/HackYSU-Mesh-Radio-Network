using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RadioMeshNetwork
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach(string port in ports)
            {
                Console.WriteLine(port);
                COMPortsCheckedListBox.Items.Add(port);
            }


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            // Write to the port
            serialPort.Write(TypeMessageTextbox.Text);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Open a serial comm port
            foreach (int indexChecked in COMPortsCheckedListBox.CheckedIndices)
            {
                serialPort.PortName = COMPortsCheckedListBox.SelectedItem.ToString();
            }

            serialPort.Open();
            serialPort.Write("v");
        }


    }
}
