using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Timers;


namespace RadioMeshNetwork
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.ReadTimeout = 2000;
            serialPort.WriteTimeout = -1;

            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
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
            string messageToWrite = "";

            //messageToWrite = messageToWrite + AvaialbleRadiosCheckedListBox.SelectedItem.ToString();    //Append the radio to send message to

            messageToWrite += DateTime.Now.ToString("hh:mm:ss") + ": ";

            messageToWrite += TypeMessageTextbox.Text;

            while (messageToWrite.Length > 0)
            {
                if ( messageToWrite.Length > 32)
                {
                    messageToWrite.Substring(0, 32);
                    serialPort.Write(messageToWrite.Substring(0, 32));
                    MessagesListBox.Items.Add(messageToWrite.Substring(0, 32));
                    messageToWrite = messageToWrite.Remove(0, 32);
                }
                else
                {
                    serialPort.Write(messageToWrite);
                    MessagesListBox.Items.Add(messageToWrite);
                    messageToWrite = "";
                }

            }


            //Thread.Sleep(1000);
           

            // Nice little trick, selects focus on the last item in the listbox (A.K.A. newest message), 
            // and then unselects it to keep focus off again.
            MessagesListBox.SelectedIndex = MessagesListBox.Items.Count - 1;
            MessagesListBox.SelectedIndex = -1;

            TypeMessageTextbox.Clear();
            TypeMessageTextbox.Focus();
            

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Open a serial comm port
            foreach (int indexChecked in COMPortsCheckedListBox.CheckedIndices)
            {
                serialPort.PortName = COMPortsCheckedListBox.SelectedItem.ToString();
            }

            try
            {
                serialPort.Open();
                serialPort.Write("v");

                ConfirmationTextbox.Text = serialPort.ReadLine();
                SendMessageButton.Enabled = true;
                fetchRadiosButton.Enabled = true;
                RestartButton.Enabled = true;
                NetworkUpdateButton.Enabled = true;
            }
            catch (Exception)
            {
                serialPort.Close();
            }
        }

        private void NetworkUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                String serialRead = serialPort.ReadLine();
                serialRead = serialRead.Substring(1);
                MessagesListBox.Items.Add(serialRead);
            }
            catch (TimeoutException)
            {
            }
        }

        private void fetchRadiosButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("f");
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                MessagesListBox.Items.Add(serialPort.ReadLine());
                MessagesListBox.SelectedIndex = MessagesListBox.Items.Count - 1;
            }
            catch (Exception)
            {

            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            serialPort.Close();

            // Open a serial comm port
            foreach (int indexChecked in COMPortsCheckedListBox.CheckedIndices)
            {
                serialPort.PortName = COMPortsCheckedListBox.SelectedItem.ToString();
            }

            try
            {
                serialPort.Open();
                serialPort.Write("v");

                ConfirmationTextbox.Text = serialPort.ReadLine();
                SendMessageButton.Enabled = true;
                fetchRadiosButton.Enabled = true;
            }
            catch (TimeoutException)
            {
                serialPort.Close();
            }
        }

        private void TypeMessageTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessageButton_Click(this, new EventArgs());
            }
        }

       

    }

    static class StringExtensions
    {

        public static IEnumerable<String> SplitInParts(this String s, Int32 partLength)
        {
            if (s == null)
                throw new ArgumentNullException("s");
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", "partLength");

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }

    }


}
