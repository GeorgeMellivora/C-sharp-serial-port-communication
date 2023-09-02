namespace ComPort
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxRtsEnable = new System.Windows.Forms.CheckBox();
            this.cboxDtrEnable = new System.Windows.Forms.CheckBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.btnEtr = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cboxWrite = new System.Windows.Forms.CheckBox();
            this.cboxWriteLine = new System.Windows.Forms.CheckBox();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboxUsingEnter = new System.Windows.Forms.CheckBox();
            this.cboxUsingButton = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearDataIn = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.cBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxRtsEnable);
            this.groupBox1.Controls.Add(this.cboxDtrEnable);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // cboxRtsEnable
            // 
            this.cboxRtsEnable.AutoSize = true;
            this.cboxRtsEnable.Location = new System.Drawing.Point(183, 173);
            this.cboxRtsEnable.Name = "cboxRtsEnable";
            this.cboxRtsEnable.Size = new System.Drawing.Size(98, 19);
            this.cboxRtsEnable.TabIndex = 15;
            this.cboxRtsEnable.Text = "RTS Enable";
            this.cboxRtsEnable.UseVisualStyleBackColor = true;
            this.cboxRtsEnable.CheckedChanged += new System.EventHandler(this.cboxRtsEnable_CheckedChanged);
            // 
            // cboxDtrEnable
            // 
            this.cboxDtrEnable.AutoSize = true;
            this.cboxDtrEnable.Location = new System.Drawing.Point(38, 173);
            this.cboxDtrEnable.Name = "cboxDtrEnable";
            this.cboxDtrEnable.Size = new System.Drawing.Size(100, 19);
            this.cboxDtrEnable.TabIndex = 14;
            this.cboxDtrEnable.Text = "DTR Enable";
            this.cboxDtrEnable.UseVisualStyleBackColor = true;
            this.cboxDtrEnable.CheckedChanged += new System.EventHandler(this.cboxDtrEnable_CheckedChanged);
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(122, 134);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(159, 23);
            this.cBoxParityBits.TabIndex = 13;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(122, 105);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(159, 23);
            this.cBoxStopBits.TabIndex = 12;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(122, 76);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(159, 23);
            this.cBoxDataBits.TabIndex = 11;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(122, 47);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(159, 23);
            this.cBoxBaudRate.TabIndex = 10;
            this.cBoxBaudRate.Text = "9600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(122, 18);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(159, 23);
            this.cBoxComPort.TabIndex = 4;
            // 
            // btnEtr
            // 
            this.btnEtr.Location = new System.Drawing.Point(200, 177);
            this.btnEtr.Name = "btnEtr";
            this.btnEtr.Size = new System.Drawing.Size(54, 45);
            this.btnEtr.TabIndex = 25;
            this.btnEtr.Text = "Etr";
            this.btnEtr.UseVisualStyleBackColor = true;
            this.btnEtr.Click += new System.EventHandler(this.btnEtr_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(120, 177);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(54, 45);
            this.btn0.TabIndex = 24;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(40, 177);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(54, 45);
            this.btnClr.TabIndex = 23;
            this.btnClr.Text = "Clr";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(200, 126);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 45);
            this.btn9.TabIndex = 22;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(120, 126);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(54, 45);
            this.btn8.TabIndex = 21;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(40, 126);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 45);
            this.btn7.TabIndex = 20;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(200, 75);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 45);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(120, 75);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 45);
            this.btn5.TabIndex = 18;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(40, 75);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 45);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(200, 24);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 45);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(120, 24);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 45);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(40, 24);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 45);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 24);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(70, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(6, 24);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(321, 316);
            this.tBoxDataOut.TabIndex = 2;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(146, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblStatusCom);
            this.groupBox9.Location = new System.Drawing.Point(160, 15);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(119, 69);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Com Port Status";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCom.Location = new System.Drawing.Point(27, 21);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(64, 33);
            this.lblStatusCom.TabIndex = 0;
            this.lblStatusCom.Text = "OFF";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(82, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 40);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(83, 45);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "SEND DATA";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn3);
            this.groupBox3.Controls.Add(this.btnEtr);
            this.groupBox3.Controls.Add(this.btn8);
            this.groupBox3.Controls.Add(this.btn7);
            this.groupBox3.Controls.Add(this.btn1);
            this.groupBox3.Controls.Add(this.btn9);
            this.groupBox3.Controls.Add(this.btn0);
            this.groupBox3.Controls.Add(this.btn4);
            this.groupBox3.Controls.Add(this.btn6);
            this.groupBox3.Controls.Add(this.btn5);
            this.groupBox3.Controls.Add(this.btn2);
            this.groupBox3.Controls.Add(this.btnClr);
            this.groupBox3.Location = new System.Drawing.Point(12, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 243);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tBoxDataOut);
            this.groupBox4.Location = new System.Drawing.Point(308, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 552);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transmitter Control";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.btnClearDataOut);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.btnSendData);
            this.groupBox5.Location = new System.Drawing.Point(6, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(321, 200);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblDataOutLength);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(6, 135);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(309, 38);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Location = new System.Drawing.Point(200, 13);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(21, 15);
            this.lblDataOutLength.TabIndex = 8;
            this.lblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data OUT Length :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cboxWrite);
            this.groupBox7.Controls.Add(this.cboxWriteLine);
            this.groupBox7.Location = new System.Drawing.Point(216, 33);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(99, 96);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // cboxWrite
            // 
            this.cboxWrite.AutoSize = true;
            this.cboxWrite.Location = new System.Drawing.Point(6, 68);
            this.cboxWrite.Name = "cboxWrite";
            this.cboxWrite.Size = new System.Drawing.Size(61, 19);
            this.cboxWrite.TabIndex = 1;
            this.cboxWrite.Text = "Write";
            this.cboxWrite.UseVisualStyleBackColor = true;
            this.cboxWrite.CheckedChanged += new System.EventHandler(this.cboxWrite_CheckedChanged);
            // 
            // cboxWriteLine
            // 
            this.cboxWriteLine.AutoSize = true;
            this.cboxWriteLine.Location = new System.Drawing.Point(6, 24);
            this.cboxWriteLine.Name = "cboxWriteLine";
            this.cboxWriteLine.Size = new System.Drawing.Size(91, 19);
            this.cboxWriteLine.TabIndex = 0;
            this.cboxWriteLine.Text = "Write Line";
            this.cboxWriteLine.UseVisualStyleBackColor = true;
            this.cboxWriteLine.CheckedChanged += new System.EventHandler(this.cboxWriteLine_CheckedChanged);
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Location = new System.Drawing.Point(6, 91);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(83, 45);
            this.btnClearDataOut.TabIndex = 4;
            this.btnClearDataOut.Text = "Clear Data Out";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboxUsingEnter);
            this.groupBox6.Controls.Add(this.cboxUsingButton);
            this.groupBox6.Location = new System.Drawing.Point(95, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(115, 96);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // cboxUsingEnter
            // 
            this.cboxUsingEnter.AutoSize = true;
            this.cboxUsingEnter.Location = new System.Drawing.Point(6, 68);
            this.cboxUsingEnter.Name = "cboxUsingEnter";
            this.cboxUsingEnter.Size = new System.Drawing.Size(97, 19);
            this.cboxUsingEnter.TabIndex = 1;
            this.cboxUsingEnter.Text = "Using Enter";
            this.cboxUsingEnter.UseVisualStyleBackColor = true;
            this.cboxUsingEnter.CheckedChanged += new System.EventHandler(this.cboxUsingEnter_CheckedChanged);
            // 
            // cboxUsingButton
            // 
            this.cboxUsingButton.AutoSize = true;
            this.cboxUsingButton.Location = new System.Drawing.Point(6, 24);
            this.cboxUsingButton.Name = "cboxUsingButton";
            this.cboxUsingButton.Size = new System.Drawing.Size(104, 19);
            this.cboxUsingButton.TabIndex = 0;
            this.cboxUsingButton.Text = "Using Button";
            this.cboxUsingButton.UseVisualStyleBackColor = true;
            this.cboxUsingButton.CheckedChanged += new System.EventHandler(this.cboxUsingButton_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.tBoxDataIn);
            this.groupBox10.Location = new System.Drawing.Point(650, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(336, 552);
            this.groupBox10.TabIndex = 28;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Receiver Controler";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.btnClearDataIn);
            this.groupBox11.Controls.Add(this.groupBox14);
            this.groupBox11.Location = new System.Drawing.Point(6, 346);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(321, 200);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lblDataInLength);
            this.groupBox12.Controls.Add(this.label8);
            this.groupBox12.Location = new System.Drawing.Point(6, 134);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(309, 38);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Location = new System.Drawing.Point(200, 13);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(21, 15);
            this.lblDataInLength.TabIndex = 8;
            this.lblDataInLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data In Length :";
            // 
            // btnClearDataIn
            // 
            this.btnClearDataIn.Location = new System.Drawing.Point(48, 39);
            this.btnClearDataIn.Name = "btnClearDataIn";
            this.btnClearDataIn.Size = new System.Drawing.Size(83, 96);
            this.btnClearDataIn.TabIndex = 4;
            this.btnClearDataIn.Text = "Clear Data In";
            this.btnClearDataIn.UseVisualStyleBackColor = true;
            this.btnClearDataIn.Click += new System.EventHandler(this.btnClearDataIn_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cBoxAddToOldData);
            this.groupBox14.Controls.Add(this.cBoxAlwaysUpdate);
            this.groupBox14.Location = new System.Drawing.Point(137, 32);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(132, 96);
            this.groupBox14.TabIndex = 5;
            this.groupBox14.TabStop = false;
            // 
            // cBoxAddToOldData
            // 
            this.cBoxAddToOldData.AutoSize = true;
            this.cBoxAddToOldData.Location = new System.Drawing.Point(6, 68);
            this.cBoxAddToOldData.Name = "cBoxAddToOldData";
            this.cBoxAddToOldData.Size = new System.Drawing.Size(128, 19);
            this.cBoxAddToOldData.TabIndex = 1;
            this.cBoxAddToOldData.Text = "Add To Old Data";
            this.cBoxAddToOldData.UseVisualStyleBackColor = true;
            this.cBoxAddToOldData.CheckedChanged += new System.EventHandler(this.cBoxAddToOldData_CheckedChanged);
            // 
            // cBoxAlwaysUpdate
            // 
            this.cBoxAlwaysUpdate.AutoSize = true;
            this.cBoxAlwaysUpdate.Location = new System.Drawing.Point(6, 24);
            this.cBoxAlwaysUpdate.Name = "cBoxAlwaysUpdate";
            this.cBoxAlwaysUpdate.Size = new System.Drawing.Size(115, 19);
            this.cBoxAlwaysUpdate.TabIndex = 0;
            this.cBoxAlwaysUpdate.Text = "Always Update";
            this.cBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.cBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.cBoxAlwaysUpdate_CheckedChanged);
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Location = new System.Drawing.Point(6, 24);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.Size = new System.Drawing.Size(321, 316);
            this.tBoxDataIn.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 581);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C# Com Port Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSendData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnEtr;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cboxRtsEnable;
        private System.Windows.Forms.CheckBox cboxDtrEnable;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cboxWrite;
        private System.Windows.Forms.CheckBox cboxWriteLine;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cboxUsingEnter;
        private System.Windows.Forms.CheckBox cboxUsingButton;
        private System.Windows.Forms.Button btnClearDataOut;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearDataIn;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox cBoxAddToOldData;
        private System.Windows.Forms.CheckBox cBoxAlwaysUpdate;
        private System.Windows.Forms.TextBox tBoxDataIn;
    }
}

