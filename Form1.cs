using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPortIO
{
    public partial class Form1 : Form
    {
        private SerialPort inputSP = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (inputCheck.Checked)
            {
                if (inputSP.BytesToRead > 0)
                {
                    String line = inputSP.ReadLine();
                    inputMessage.Text = line;
                    inputData.Text = line + inputData.Text;
                }
            }
        }

        private void outputSend_Click(object sender, EventArgs e)
        {
            if (outputPort.Text.Length == 0 | outputMessage.Text.Length == 0)
                MessageBox.Show("Required Input Incomplete");
            else
            {
                SerialPort sp = new SerialPort(outputPort.Text);
                sp.Open();
                sp.WriteLine(outputMessage.Text);
                sp.Close();
                outputData.Text = outputMessage.Text + outputData.Text;
            }
        }

        private void outputCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (outputCheck.Checked)
            {
                outputSend.Enabled = true;
                outputPort.Enabled = true;
                outputMessage.Enabled = true;
                outputData.Enabled = true;
            }
            else
            {
                outputSend.Enabled = false;
                outputPort.Enabled = false;
                outputMessage.Enabled = false;
                outputData.Enabled = false;
            }
        }

        private void inputCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (inputPort.Text.Length == 0)
            {
                MessageBox.Show("Required Input Incomplete");
                inputCheck.Checked = false;
            }
            else
            {
                if (inputCheck.Checked)
                {
                    inputSP.PortName = inputPort.Text;
                    inputSP.Open();
                }
                else
                {
                    if (inputSP.IsOpen)
                        inputSP.Close();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            clear_Click();
        }

        private void clear_Click()
        {

        }
    }
}
