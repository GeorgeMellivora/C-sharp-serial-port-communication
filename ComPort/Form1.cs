using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComPort
{
    public partial class Form1 : Form
    {

        string dataOut = "";
        string sendWith;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            cboxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            cboxRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = false;
            cboxWriteLine.Checked = true;
            cboxWrite.Checked = false;
            sendWith = "WriteLine";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt16(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt16(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();

                progressBar1.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblStatusCom.Text = "ON";
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Errpr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
            }
            else
            {
                MessageBox.Show("請輸入指令");
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tBoxDataOut.Text))
            {
                MessageBox.Show("No Data Exist\nYou can try to input something");
            }
            else
            {
                if(serialPort1.IsOpen)
                    {
                        dataOut = tBoxDataOut.Text;
                        if(sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(dataOut);
                        }
                        else if(sendWith == "Write")
                        {
                            serialPort1.Write(dataOut);
                        }
                    }
            }
        }
        private int clickCount = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text += "0";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            clickCount++;  // 每次按鈕點擊，計數器加一
            tBoxDataOut.Text = "";
        }

            private void btnEtr_Click(object sender, EventArgs e)
            {
                clickCount++;  // 每次按鈕點擊，計數器加一
                tBoxDataOut.Text += Environment.NewLine;
                if(cboxUsingEnter.Checked)
                {
                    SendKeys.Send("{ENTER}");
                }
            }

        private void cboxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void cboxRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxRtsEnable.Checked)
            {
                serialPort1.RtsEnable= true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void btnClearDataOut_Click(object sender, EventArgs e)
        {
            if(tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = null;
            }
            else
            {
                MessageBox.Show("No Data Exist");
            }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOutLength = tBoxDataOut.Text.Length;
            lblDataOutLength.Text = string.Format("{0:0}", dataOutLength);
            if(cboxUsingEnter.Checked)
            {
                tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine,"");
            }
        }

        private void cboxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxUsingButton.Checked)
            {
                btnSendData.Enabled = true;
            }
            else
            {
                btnSendData.Enabled = false;
            }
        }

        private void cboxUsingEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if(cboxUsingEnter.Checked)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOut = tBoxDataOut.Text;
                        if (sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(dataOut);
                        }
                        else if (sendWith == "Write")
                        {
                            serialPort1.Write(dataOut);
                        }
                    }
                }
            }
        }

        private void cboxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                cboxWrite.Checked = false;
            }
        }

        private void cboxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxWrite.Checked)
            {
                sendWith = "Write";
                cboxWriteLine.Checked = false;
            }
        }
    }
}
