using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using System.Timers;*/
using System.IO.Ports;
using System.IO;
using System.Xml;
using System.Linq.Expressions;
using System.CodeDom;
using System.Diagnostics;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Collections;


namespace ArduinoAppControlLEDReadTem
{
    public partial class Form1 : Form
    {
        //PointPairList list = new PointPairList();
        //bool bStopTest = false;
        /*public static Timer aTmr = new Timer(1000);*/
        public Form1()
        {
            InitializeComponent();



            string[] Baud = { "1200", "2400", "4800", "9600", "19200" };
            cRate.Items.AddRange(Baud);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cPort.DataSource = SerialPort.GetPortNames();

            //cRate.Text = "9600";
            cRate.SelectedIndex = 3;



            GraphPane myPanne = zedGraphControl1.GraphPane;

            //zedGraphControl1.GraphPane.Fill.Color = System.Drawing.Color.Red;
            //zedGraphControl1.GraphPane.Chart.Fill.Brush = new System.Drawing.SolidBrush(Color.Blue);

            zedGraphControl1.GraphPane.Fill = new Fill(Color.FromArgb(255, 255, 255));
            zedGraphControl1.GraphPane.Chart.Fill = new Fill(Color.FromArgb(255, 200, 100));

            //serCOM.PortName = "COM4";
            //serCOM.Open();
            //serCOM.Write("TS");

            myPanne.Title.Text = "Temperature Sensor";
            myPanne.YAxis.Title.Text = "Degrees Celsius";
            myPanne.XAxis.Title.Text = "Time";

            RollingPointPairList list = new RollingPointPairList(500000);
            //PointPairList list = new PointPairList();

            LineItem line = myPanne.AddCurve("Tem", list, Color.Blue, SymbolType.Diamond);

            myPanne.XAxis.Scale.Min = 0;
            myPanne.XAxis.Scale.Max = 50;
            myPanne.XAxis.Scale.MinorStep = 1;
            myPanne.XAxis.Scale.MajorStep = 2;

            myPanne.YAxis.Scale.Min = 0;
            myPanne.YAxis.Scale.Max = 50;
            myPanne.YAxis.Scale.MinorStep = 1;
            myPanne.YAxis.Scale.MajorStep = 2;

            zedGraphControl1.AxisChange();



        }

        private void bConnect_Click(object sender, EventArgs e)
        {

            if (!serCOM.IsOpen && cPort.Items.Count != 0)
            {
                try
                {
                    bConnect.Text = "Disconnect";
                    Note.Text = "Connected";
                    serCOM.PortName = cPort.Text;
                    serCOM.BaudRate = Convert.ToInt32(cRate.Text);

                    serCOM.Open();
                }
                catch
                {

                    Note.Text = "Detect COM port change during connect";
                    bConnect.Text = "Connect";
                    //serCOM.Close();
                }
            }
            else
            {
                if (cPort.Items.Count == 0)
                {
                    Note.Text = "Can not find COM port";
                }
                else
                {

                    //aTmr.Elapsed += ATmr_Elapsed;
                    //aTmr.Enabled = true;
                    //aTmr.AutoReset = true;
                    //aTmr.Start();
                    //Note.Text = "Disconnecting...";


                    // no ko nhay xuong dong nay duoc vi khi thao Port ra no tu nhan COMport la Close
                    // ma dieu kien de chay dong nay chay la COMport Open va co COMport hien thi trong ComboBox
                    try
                    {
                        bConnect.Text = "Connect";
                        serCOM.Close();
                        Note.Text = "Note:";
                        TemShow.Text = "Temperature:";
                    }
                    catch
                    {
                        Note.Text = "Detect COM port get wrong";
                        bConnect.Text = "Connect";
                        //serCOM.Close();
                    }

                    /* private static void ATmr_Elapsed(object sender, ElapsedEventArgs e)
                        {
                                           Note.Text = "Note:";
                        }                                   */
                }
            }
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            if(serCOM.IsOpen)
            {
                serCOM.Write("OFF13");
            }
            serCOM.Close();
            Application.Exit();
        }

        private void bLED13_ON_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                Note.Text = "COMPort is not connected";
            }
            else
            {
                serCOM.Write("ON13");
                Note.Text = "LED 13 ON";
            }
        }

        private void bLED13_OFF_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                Note.Text = "COMPort is not connected";
                //bStopTest = true;
            }
            else
            {
                serCOM.Write("OFF13");
                Note.Text = "LED 13 OFF";
            }
        }


        private async void LoadPort()
        {
            //Console.WriteLine("CoLoadPort");
            cPort.DataSource = null;
            cPort.Items.Clear();

            await Task.Run(() =>
            {
                string[] portNames = SerialPort.GetPortNames();
                return portNames;
            });
            cPort.DataSource = SerialPort.GetPortNames();
            cRate.SelectedIndex = 3;
        }

        private void bRefresh_Click_1(object sender, EventArgs e)
        {
            //Console.WriteLine("Cochay");

            LoadPort();
        }

        private void bTS_Click(object sender, EventArgs e)
        {
            //serCOM.Close();
            //this.WindowState = FormWindowState.Minimized;
            //Form2 TemSen = new Form2();
            //TemSen.ShowDialog();
            //this.WindowState = FormWindowState.Normal;
            if (!serCOM.IsOpen)
            {
                Note.Text = "COMPort is not connected";
            }
            else
            {
                serCOM.Write("TS");
                Note.Text = "Temperature Sensor Working";
            }
        }

        int tong = 0;

        public void draw(double line)
        {
            LineItem theLine = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if (theLine == null)
            {
                return;
            }
            IPointListEdit list = theLine.Points as IPointListEdit;
            if (list == null)
            {
                return;
            }

            list.Add(tong, line);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            //zedGraphControl1.Update();
            //zedGraphControl1.Refresh();
            tong++;
            //tong += 2;

        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string AllData = "";
            AllData = serCOM.ReadLine();
            AllData = AllData.Trim();

            int len = AllData.Length;
            if (len > 0)
            {
                TemShow.Text = "Temperature:" + AllData;
                Invoke(new MethodInvoker(() => draw(Convert.ToDouble(AllData))));

                //while (true)
                //{
                //    list.Add(tong, Convert.ToDouble(AllData));
                //    tong++;

                //    zedGraphControl1.AxisChange();
                //    zedGraphControl1.Invalidate();
                //    zedGraphControl1.Update();
                //    zedGraphControl1.Refresh();

                //    if (bStopTest)
                //    {
                //        break;
                //    }
                //}

            }
        }

        private void bOG_Click(object sender, EventArgs e)
        {
            serCOM.Close();
            this.WindowState = FormWindowState.Minimized;
            Form2 TemSen = new Form2();
            TemSen.ShowDialog();
            this.WindowState = FormWindowState.Normal;


            //bStopTest = false;
            ////CaculateAndFill();
            //list.Clear();

            //Thread plotThread = new Thread(new ThreadStart(serCOM_DataReceived));
            //plotThread.Start();
        }
    }
}
