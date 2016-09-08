using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Pratikum1_KomunikasiSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string item in SerialPort.GetPortNames())
            {
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                comboBoxSerial.Items.Add(item);
                comboBoxSerial.SelectedIndex = 0;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPortRS232.PortName = comboBoxSerial.Text;
            if (!serialPortRS232.IsOpen)
            {
                serialPortRS232.Open();
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed To Open Port");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPortRS232.IsOpen)
            {
                serialPortRS232.Close();
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
            }

        }


        private void comboBoxSerial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serialPortRS232_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataSerial;
            dataSerial = serialPortRS232.ReadExisting();
            updateText(dataSerial);
        }

        delegate void updateTextFromDelegate(String msg);

        public void updateText(String msg)
        {
            if (!this.IsDisposed && richTextBoxReceiveData.InvokeRequired)
            {
                richTextBoxReceiveData.Invoke(new
updateTextFromDelegate(updateRichTextBox), new Object[] { msg });
            }
        }

        public void updateRichTextBox(String msg)
        {
            richTextBoxReceiveData.Text = msg;
            richTextBoxReceiveData.SelectionStart =
richTextBoxReceiveData.Text.Length;
        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            serialPortRS232.Write(richTextBoxSendData.Text);
            richTextBoxSendData.Text = "";
        }


        }
      
    }

