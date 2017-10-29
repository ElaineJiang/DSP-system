namespace Serial03
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboSerial = new System.Windows.Forms.ComboBox();
            this.Baudrate = new System.Windows.Forms.TextBox();
            this.buttonSerial = new System.Windows.Forms.Button();
            this.labelStatue = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.RxData01 = new System.Windows.Forms.TextBox();
            this.Parameters = new System.Windows.Forms.Label();
            this.RxData02 = new System.Windows.Forms.TextBox();
            this.RxData03 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RxData06 = new System.Windows.Forms.TextBox();
            this.RxData05 = new System.Windows.Forms.TextBox();
            this.RxData04 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RxData09 = new System.Windows.Forms.TextBox();
            this.RxData08 = new System.Windows.Forms.TextBox();
            this.RxData07 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RxData12 = new System.Windows.Forms.TextBox();
            this.RxData11 = new System.Windows.Forms.TextBox();
            this.RxData10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxData12 = new System.Windows.Forms.TextBox();
            this.TxData11 = new System.Windows.Forms.TextBox();
            this.TxData10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxData09 = new System.Windows.Forms.TextBox();
            this.TxData08 = new System.Windows.Forms.TextBox();
            this.TxData07 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxData06 = new System.Windows.Forms.TextBox();
            this.TxData05 = new System.Windows.Forms.TextBox();
            this.TxData04 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxData03 = new System.Windows.Forms.TextBox();
            this.TxData02 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxData01 = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartEnable = new System.Windows.Forms.Button();
            this.interval = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.scopecheck = new System.Windows.Forms.CheckedListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSerial
            // 
            this.comboSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSerial.FormattingEnabled = true;
            this.comboSerial.Location = new System.Drawing.Point(1043, 15);
            this.comboSerial.Name = "comboSerial";
            this.comboSerial.Size = new System.Drawing.Size(79, 20);
            this.comboSerial.TabIndex = 0;
            this.comboSerial.DropDown += new System.EventHandler(this.comboSerial_DropDown);
            // 
            // Baudrate
            // 
            this.Baudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Baudrate.Location = new System.Drawing.Point(1144, 15);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(70, 21);
            this.Baudrate.TabIndex = 1;
            this.Baudrate.Text = "115200";
            // 
            // buttonSerial
            // 
            this.buttonSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSerial.Location = new System.Drawing.Point(1230, 13);
            this.buttonSerial.Name = "buttonSerial";
            this.buttonSerial.Size = new System.Drawing.Size(75, 23);
            this.buttonSerial.TabIndex = 2;
            this.buttonSerial.Text = "Open";
            this.buttonSerial.UseVisualStyleBackColor = true;
            this.buttonSerial.Click += new System.EventHandler(this.buttonSerial_Click);
            // 
            // labelStatue
            // 
            this.labelStatue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatue.AutoSize = true;
            this.labelStatue.BackColor = System.Drawing.Color.Red;
            this.labelStatue.Location = new System.Drawing.Point(1007, 18);
            this.labelStatue.Name = "labelStatue";
            this.labelStatue.Size = new System.Drawing.Size(23, 12);
            this.labelStatue.TabIndex = 3;
            this.labelStatue.Text = "   ";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // RxData01
            // 
            this.RxData01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData01.Location = new System.Drawing.Point(1048, 77);
            this.RxData01.Name = "RxData01";
            this.RxData01.ReadOnly = true;
            this.RxData01.Size = new System.Drawing.Size(90, 21);
            this.RxData01.TabIndex = 11;
            this.RxData01.Text = "0";
            // 
            // Parameters
            // 
            this.Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameters.AutoSize = true;
            this.Parameters.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Parameters.Location = new System.Drawing.Point(1040, 42);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(98, 16);
            this.Parameters.TabIndex = 12;
            this.Parameters.Text = "Parameters";
            // 
            // RxData02
            // 
            this.RxData02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData02.Location = new System.Drawing.Point(1144, 77);
            this.RxData02.Name = "RxData02";
            this.RxData02.ReadOnly = true;
            this.RxData02.Size = new System.Drawing.Size(90, 21);
            this.RxData02.TabIndex = 13;
            this.RxData02.Text = "0";
            // 
            // RxData03
            // 
            this.RxData03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData03.Location = new System.Drawing.Point(1240, 77);
            this.RxData03.Name = "RxData03";
            this.RxData03.ReadOnly = true;
            this.RxData03.Size = new System.Drawing.Size(90, 21);
            this.RxData03.TabIndex = 14;
            this.RxData03.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1007, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "1-3";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1007, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "4-6";
            // 
            // RxData06
            // 
            this.RxData06.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData06.Location = new System.Drawing.Point(1240, 104);
            this.RxData06.Name = "RxData06";
            this.RxData06.ReadOnly = true;
            this.RxData06.Size = new System.Drawing.Size(90, 21);
            this.RxData06.TabIndex = 18;
            this.RxData06.Text = "0";
            // 
            // RxData05
            // 
            this.RxData05.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData05.Location = new System.Drawing.Point(1144, 104);
            this.RxData05.Name = "RxData05";
            this.RxData05.ReadOnly = true;
            this.RxData05.Size = new System.Drawing.Size(90, 21);
            this.RxData05.TabIndex = 17;
            this.RxData05.Text = "0";
            // 
            // RxData04
            // 
            this.RxData04.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData04.Location = new System.Drawing.Point(1048, 104);
            this.RxData04.Name = "RxData04";
            this.RxData04.ReadOnly = true;
            this.RxData04.Size = new System.Drawing.Size(90, 21);
            this.RxData04.TabIndex = 16;
            this.RxData04.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1007, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "7-9";
            // 
            // RxData09
            // 
            this.RxData09.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData09.Location = new System.Drawing.Point(1240, 131);
            this.RxData09.Name = "RxData09";
            this.RxData09.ReadOnly = true;
            this.RxData09.Size = new System.Drawing.Size(90, 21);
            this.RxData09.TabIndex = 22;
            this.RxData09.Text = "0";
            // 
            // RxData08
            // 
            this.RxData08.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData08.Location = new System.Drawing.Point(1144, 131);
            this.RxData08.Name = "RxData08";
            this.RxData08.ReadOnly = true;
            this.RxData08.Size = new System.Drawing.Size(90, 21);
            this.RxData08.TabIndex = 21;
            this.RxData08.Text = "0";
            // 
            // RxData07
            // 
            this.RxData07.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData07.Location = new System.Drawing.Point(1048, 131);
            this.RxData07.Name = "RxData07";
            this.RxData07.ReadOnly = true;
            this.RxData07.Size = new System.Drawing.Size(90, 21);
            this.RxData07.TabIndex = 20;
            this.RxData07.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1007, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "10-12";
            // 
            // RxData12
            // 
            this.RxData12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData12.Location = new System.Drawing.Point(1240, 158);
            this.RxData12.Name = "RxData12";
            this.RxData12.ReadOnly = true;
            this.RxData12.Size = new System.Drawing.Size(90, 21);
            this.RxData12.TabIndex = 26;
            this.RxData12.Text = "0";
            // 
            // RxData11
            // 
            this.RxData11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData11.Location = new System.Drawing.Point(1144, 158);
            this.RxData11.Name = "RxData11";
            this.RxData11.ReadOnly = true;
            this.RxData11.Size = new System.Drawing.Size(90, 21);
            this.RxData11.TabIndex = 25;
            this.RxData11.Text = "0";
            // 
            // RxData10
            // 
            this.RxData10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RxData10.Location = new System.Drawing.Point(1048, 158);
            this.RxData10.Name = "RxData10";
            this.RxData10.ReadOnly = true;
            this.RxData10.Size = new System.Drawing.Size(90, 21);
            this.RxData10.TabIndex = 24;
            this.RxData10.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1032, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 44;
            this.label5.Text = "7-8";
            // 
            // TxData12
            // 
            this.TxData12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData12.Location = new System.Drawing.Point(1227, 376);
            this.TxData12.Name = "TxData12";
            this.TxData12.Size = new System.Drawing.Size(90, 21);
            this.TxData12.TabIndex = 43;
            this.TxData12.Text = "-2016";
            // 
            // TxData11
            // 
            this.TxData11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData11.Location = new System.Drawing.Point(1105, 376);
            this.TxData11.Name = "TxData11";
            this.TxData11.Size = new System.Drawing.Size(90, 21);
            this.TxData11.TabIndex = 42;
            this.TxData11.Text = "1111";
            // 
            // TxData10
            // 
            this.TxData10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData10.Location = new System.Drawing.Point(1227, 349);
            this.TxData10.Name = "TxData10";
            this.TxData10.Size = new System.Drawing.Size(90, 21);
            this.TxData10.TabIndex = 41;
            this.TxData10.Text = "23569";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1032, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "5-6";
            // 
            // TxData09
            // 
            this.TxData09.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData09.Location = new System.Drawing.Point(1105, 349);
            this.TxData09.Name = "TxData09";
            this.TxData09.Size = new System.Drawing.Size(90, 21);
            this.TxData09.TabIndex = 39;
            this.TxData09.Text = "0";
            // 
            // TxData08
            // 
            this.TxData08.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData08.Location = new System.Drawing.Point(1227, 322);
            this.TxData08.Name = "TxData08";
            this.TxData08.Size = new System.Drawing.Size(90, 21);
            this.TxData08.TabIndex = 38;
            this.TxData08.Text = "0";
            // 
            // TxData07
            // 
            this.TxData07.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData07.Location = new System.Drawing.Point(1105, 322);
            this.TxData07.Name = "TxData07";
            this.TxData07.Size = new System.Drawing.Size(90, 21);
            this.TxData07.TabIndex = 37;
            this.TxData07.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1032, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "3-4";
            // 
            // TxData06
            // 
            this.TxData06.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData06.Location = new System.Drawing.Point(1227, 295);
            this.TxData06.Name = "TxData06";
            this.TxData06.Size = new System.Drawing.Size(90, 21);
            this.TxData06.TabIndex = 35;
            this.TxData06.Text = "345";
            // 
            // TxData05
            // 
            this.TxData05.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData05.Location = new System.Drawing.Point(1105, 295);
            this.TxData05.Name = "TxData05";
            this.TxData05.Size = new System.Drawing.Size(90, 21);
            this.TxData05.TabIndex = 34;
            this.TxData05.Text = "999";
            // 
            // TxData04
            // 
            this.TxData04.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData04.Location = new System.Drawing.Point(1227, 268);
            this.TxData04.Name = "TxData04";
            this.TxData04.Size = new System.Drawing.Size(90, 21);
            this.TxData04.TabIndex = 33;
            this.TxData04.Text = "-1000";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1004, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 36);
            this.label8.TabIndex = 32;
            this.label8.Text = "FIR:LP-0;HP-1;\r\n    BP-2;BS-3\r\nIIR:LP-4;HP-5";
            // 
            // TxData03
            // 
            this.TxData03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData03.Location = new System.Drawing.Point(1105, 268);
            this.TxData03.Name = "TxData03";
            this.TxData03.Size = new System.Drawing.Size(90, 21);
            this.TxData03.TabIndex = 31;
            this.TxData03.Text = "-10000";
            // 
            // TxData02
            // 
            this.TxData02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData02.Location = new System.Drawing.Point(1227, 241);
            this.TxData02.Name = "TxData02";
            this.TxData02.Size = new System.Drawing.Size(90, 21);
            this.TxData02.TabIndex = 30;
            this.TxData02.Text = "100";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(1040, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Commands";
            // 
            // TxData01
            // 
            this.TxData01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxData01.Location = new System.Drawing.Point(1105, 241);
            this.TxData01.Name = "TxData01";
            this.TxData01.Size = new System.Drawing.Size(90, 21);
            this.TxData01.TabIndex = 28;
            this.TxData01.Text = "1";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 42);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "S1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "S2";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "S3";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series3.Name = "Series3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.LegendText = "S4";
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series4.Name = "Series4";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.LegendText = "S5";
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series5.Name = "Series5";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.LegendText = "S6";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series6.Name = "Series6";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.LegendText = "S7";
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series7.Name = "Series7";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.LegendText = "S8";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star6;
            series8.Name = "Series8";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Series.Add(series7);
            this.chart.Series.Add(series8);
            this.chart.Size = new System.Drawing.Size(973, 666);
            this.chart.TabIndex = 45;
            this.chart.Text = "chart1";
            // 
            // ChartEnable
            // 
            this.ChartEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartEnable.Location = new System.Drawing.Point(1230, 436);
            this.ChartEnable.Name = "ChartEnable";
            this.ChartEnable.Size = new System.Drawing.Size(75, 23);
            this.ChartEnable.TabIndex = 46;
            this.ChartEnable.Text = "Run";
            this.ChartEnable.UseVisualStyleBackColor = true;
            this.ChartEnable.Click += new System.EventHandler(this.ChartEnable_Click);
            // 
            // interval
            // 
            this.interval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.interval.Location = new System.Drawing.Point(1105, 501);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(90, 21);
            this.interval.TabIndex = 47;
            this.interval.Text = "10";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(1040, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Waves";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1103, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "interval(ms)";
            // 
            // points
            // 
            this.points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.points.Location = new System.Drawing.Point(1227, 501);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(90, 21);
            this.points.TabIndex = 50;
            this.points.Text = "100";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1225, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 51;
            this.label12.Text = "points";
            // 
            // scopecheck
            // 
            this.scopecheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scopecheck.CheckOnClick = true;
            this.scopecheck.FormattingEnabled = true;
            this.scopecheck.Items.AddRange(new object[] {
            "S1",
            "S2",
            "S3",
            "S4",
            "S5",
            "S6",
            "S7",
            "S8"});
            this.scopecheck.Location = new System.Drawing.Point(893, 197);
            this.scopecheck.Name = "scopecheck";
            this.scopecheck.Size = new System.Drawing.Size(50, 132);
            this.scopecheck.TabIndex = 52;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(1230, 197);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 53;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(1040, 553);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 54;
            this.label13.Text = "Elaine";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Serial03.Properties.Resources.sjtu;
            this.pictureBox1.Location = new System.Drawing.Point(1043, 582);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 84);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1032, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 56;
            this.label14.Text = "9-10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1032, 379);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 57;
            this.label15.Text = "11-12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 720);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.scopecheck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.points);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.ChartEnable);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxData12);
            this.Controls.Add(this.TxData11);
            this.Controls.Add(this.TxData10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxData09);
            this.Controls.Add(this.TxData08);
            this.Controls.Add(this.TxData07);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxData06);
            this.Controls.Add(this.TxData05);
            this.Controls.Add(this.TxData04);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxData03);
            this.Controls.Add(this.TxData02);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxData01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RxData12);
            this.Controls.Add(this.RxData11);
            this.Controls.Add(this.RxData10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RxData09);
            this.Controls.Add(this.RxData08);
            this.Controls.Add(this.RxData07);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RxData06);
            this.Controls.Add(this.RxData05);
            this.Controls.Add(this.RxData04);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RxData03);
            this.Controls.Add(this.RxData02);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.RxData01);
            this.Controls.Add(this.labelStatue);
            this.Controls.Add(this.buttonSerial);
            this.Controls.Add(this.Baudrate);
            this.Controls.Add(this.comboSerial);
            this.Name = "Form1";
            this.Text = "EmbeddedSystemCourse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSerial;
        private System.Windows.Forms.TextBox Baudrate;
        private System.Windows.Forms.Button buttonSerial;
        private System.Windows.Forms.Label labelStatue;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox RxData01;
        private System.Windows.Forms.Label Parameters;
        private System.Windows.Forms.TextBox RxData02;
        private System.Windows.Forms.TextBox RxData03;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RxData06;
        private System.Windows.Forms.TextBox RxData05;
        private System.Windows.Forms.TextBox RxData04;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RxData09;
        private System.Windows.Forms.TextBox RxData08;
        private System.Windows.Forms.TextBox RxData07;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RxData12;
        private System.Windows.Forms.TextBox RxData11;
        private System.Windows.Forms.TextBox RxData10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxData12;
        private System.Windows.Forms.TextBox TxData11;
        private System.Windows.Forms.TextBox TxData10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxData09;
        private System.Windows.Forms.TextBox TxData08;
        private System.Windows.Forms.TextBox TxData07;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxData06;
        private System.Windows.Forms.TextBox TxData05;
        private System.Windows.Forms.TextBox TxData04;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxData03;
        private System.Windows.Forms.TextBox TxData02;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxData01;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button ChartEnable;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox points;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox scopecheck;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

