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
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;



namespace Serial03
{
    public partial class Form1 : Form
    {
        private bool IsStart = false;

        byte[] serial_raw_frame = new byte[4];
        byte[] serial_raw_data = new byte[1000];
        int serial_data_index = 0;
        Int16[] serial_comb_data = new Int16[500];

        UInt32 chart_original_index = 0;
        Int16[] chart_original_0 = new Int16[5000];
        Int16[] chart_original_1 = new Int16[5000];
        Int16[] chart_original_2 = new Int16[5000];
        Int16[] chart_original_3 = new Int16[5000];

        public const int RxDataMax = 600;
        public static readonly char[] serial_frame = { '@', '#', '&', '!' };

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void comboSerial_DropDown(object sender, EventArgs e)
        {
            UpdateSerial();
        }

        private void UpdateSerial()
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboSerial.Items.Clear();
            comboSerial.Items.AddRange(ports);
        }

        private void buttonSerial_Click(object sender, EventArgs e)
        {
            //Open serial
            if(!serialPort.IsOpen)
            {
                try
                {
                    serialPort.PortName = comboSerial.Text;
                    serialPort.BaudRate = Convert.ToInt32(Baudrate.Text);
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
         
            }

            //Close serial
            else
            {
                if (IsStart)
                {
                    IsStart = false;
                    //labelStatue.BackColor = IsStart ? Color.Green : Color.Yellow;
                }
                try
                {
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            //Update button and label
            buttonSerial.Text = serialPort.IsOpen ? "Close" : "Open";
            labelStatue.BackColor = serialPort.IsOpen ? Color.Yellow : Color.Red;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close serial
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int max = 0;

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = serialPort.BytesToRead;

            byte[] buf = new byte[n];
            serialPort.Read(buf, 0, n);

            if (n > max)  max = n;

            RxData12.Text = max.ToString();

            for (int i = 0; i < n; i++)
            {
                serial_raw_frame[0] = serial_raw_frame[1];
                serial_raw_frame[1] = serial_raw_frame[2];
                serial_raw_frame[2] = serial_raw_frame[3];
                serial_raw_frame[3] = buf[i];

                if ((serial_raw_frame[3] == serial_frame[3]) && (serial_raw_frame[2] == serial_frame[2]) && (serial_raw_frame[1] == serial_frame[1]) && (serial_raw_frame[0] == serial_frame[0]))
                {
                    serial_data_index = 0;

                    chart_original_0[chart_original_index % 5000] = serial_comb_data[0];
                    chart_original_1[chart_original_index % 5000] = serial_comb_data[1];
                    chart_original_2[chart_original_index % 5000] = serial_comb_data[2];
                    chart_original_3[chart_original_index % 5000] = serial_comb_data[3];
                    chart_original_index++;

                }
                else
                {
                    serial_raw_data[serial_data_index] = buf[i];

                    if ((serial_data_index % 2) == 1)
                    {
                        serial_comb_data[(serial_data_index - 1) / 2] = BitConverter.ToInt16(serial_raw_data, serial_data_index - 1);
                    }

                    serial_data_index++;

                    if (serial_data_index > 100)
                    {
                        serial_data_index = 0;
                        if (MessageBox.Show("No frame header received!") == DialogResult.OK)
                        {
                            serialPort.Close();
                            buttonSerial.Text = "Open";
                            labelStatue.BackColor = Color.Red;
                        }

                    }
                }

            }

            RxData01.Text = serial_comb_data[0].ToString();
            RxData02.Text = serial_comb_data[1].ToString();
            RxData03.Text = serial_comb_data[2].ToString();
            RxData04.Text = serial_comb_data[3].ToString();
            //RxData05.Text = serial_comb_data[4].ToString();
            //RxData06.Text = serial_comb_data[5].ToString();
            //RxData07.Text = serial_comb_data[6].ToString();
            //RxData08.Text = serial_comb_data[7].ToString();
            //RxData09.Text = serial_comb_data[8].ToString();
            //RxData10.Text = serial_comb_data[9].ToString();
            //RxData11.Text = serial_comb_data[10].ToString();
            //RxData12.Text = serial_comb_data[11].ToString();



        }    



        public int ChartPoints = 100;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

    
            Legend myLegend;


            chart.ChartAreas[0].AxisY.Maximum = +4000;
            chart.ChartAreas[0].AxisY.Minimum = -4000;
            chart.ChartAreas[0].CursorX.AutoScroll = true;
            chart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].CursorY.AutoScroll = true;
            chart.ChartAreas[0].AxisY.ScrollBar.Enabled = true;
            chart.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
         
            myLegend = new Legend();
            myLegend.Name = "test";

            chart.Legends.Add(myLegend);

            for (int i = 0; i < 4; i++)
            {
                scopecheck.SetItemChecked(i, true);
            }

            for (int i = 0; i < 500; i++)
            {
                serial_comb_data[i] = 200;
            }

            eventlog = new List<String>();
        }


       // private static System.Timers.Timer aTimer;

       // bool timer_enable = false;


        private void ChartEnable_Click(object sender, EventArgs e)
        {
            ChartPoints = Convert.ToInt32(points.Text);

            for (int i = 0; i < 4; i++)
            {
                if (scopecheck.GetItemChecked(i))
                    chart.Series[i].Points.Clear();
            }

            for (int j = 0; j < ChartPoints; j++)
            {
                chart.Series[0].Points.AddY(chart_original_0[j]);
                chart.Series[1].Points.AddY(chart_original_1[j]);
                chart.Series[2].Points.AddY(chart_original_2[j]);
                chart.Series[3].Points.AddY(chart_original_3[j]);
            }
                


        }

        delegate void dele1();

        private static List<String> eventlog;
        private static int nEventsFired = 0;
        private static DateTime previousTime;

        void Timer_isr(object sender, System.Timers.ElapsedEventArgs e)
        {
            //dele1 deleChartDraw = new dele1(chartDraw);
            //if (this.IsHandleCreated)
            //    chart.Invoke(deleChartDraw);

            Console.WriteLine(String.Format("Elapsed event at {0:HH':'mm':'ss.ffffff} ({1})",
                           e.SignalTime,
                           nEventsFired++ == 0 ?
                              0.0 : (e.SignalTime - previousTime).TotalMilliseconds));
            previousTime = e.SignalTime;
                
        }

        void chartDraw()
        {

            if (chart.ChartAreas[0].AxisX.Maximum - chart.ChartAreas[0].AxisX.Minimum > ChartPoints)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (scopecheck.GetItemChecked(i))
                        chart.Series[i].Points.RemoveAt(0);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (scopecheck.GetItemChecked(i))
                    chart.Series[i].Points.AddY(serial_comb_data[i]);
             }


        }

        public const int TxDataNum = 12;
        Int16[] Command_Send = new Int16[TxDataNum];
        private void buttonSend_Click(object sender, EventArgs e)
        {
            Command_Send[0] = Convert.ToInt16(TxData01.Text);
            Command_Send[1] = Convert.ToInt16(TxData02.Text);
            Command_Send[2] = Convert.ToInt16(TxData03.Text);
            Command_Send[3] = Convert.ToInt16(TxData04.Text);
            Command_Send[4] = Convert.ToInt16(TxData05.Text);
            Command_Send[5] = Convert.ToInt16(TxData06.Text);
            Command_Send[6] = Convert.ToInt16(TxData07.Text);
            Command_Send[7] = Convert.ToInt16(TxData08.Text);
            Command_Send[8] = Convert.ToInt16(TxData09.Text);
            Command_Send[9] = Convert.ToInt16(TxData10.Text);
            Command_Send[10] = Convert.ToInt16(TxData11.Text);
            Command_Send[11] = Convert.ToInt16(TxData12.Text);

            byte[] tx_raw_data = new byte[Command_Send.Length * sizeof(Int16)];

            Buffer.BlockCopy(Command_Send, 0, tx_raw_data, 0, tx_raw_data.Length);

            Console.WriteLine(tx_raw_data.Length.ToString());

            serialPort.Write("@#&!");
            serialPort.Write(tx_raw_data, 0, tx_raw_data.Length);
            serialPort.Write("----");


        } 


    }
}
