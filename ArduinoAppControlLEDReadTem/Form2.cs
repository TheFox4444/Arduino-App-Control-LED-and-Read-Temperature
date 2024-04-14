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
using ZedGraph;


namespace ArduinoAppControlLEDReadTem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            GraphPane zg = zedGraphControl1.GraphPane;

            

            //zedGraphControl1.GraphPane.Fill.Color = System.Drawing.Color.Red;
            //zedGraphControl1.GraphPane.Chart.Fill.Brush = new System.Drawing.SolidBrush(Color.Blue);
            zedGraphControl1.GraphPane.Fill = new Fill(Color.FromArgb(255, 255, 255));
            zedGraphControl1.GraphPane.Chart.Fill = new Fill(Color.FromArgb(255, 200, 100));

            serCOM.PortName = "COM4";
            serCOM.Open();
            serCOM.Write("TS");

            zg.Title.Text = "Temperature Sensor";
            zg.YAxis.Title.Text = "Degrees Celsius";
            zg.XAxis.Title.Text = "Time";

            RollingPointPairList list = new RollingPointPairList(500000);

            LineItem line = zg.AddCurve("Tem", list, Color.FromArgb(0, 0, 255), SymbolType.Diamond);

            zg.XAxis.Scale.Min = 0;
            zg.XAxis.Scale.Max = 50;
            zg.XAxis.Scale.MinorStep = 1;
            zg.XAxis.Scale.MajorStep = 2;

            zg.YAxis.Scale.Min = 0;
            zg.YAxis.Scale.Max = 50;
            zg.YAxis.Scale.MinorStep = 1;
            zg.YAxis.Scale.MajorStep = 2;

            zedGraphControl1.AxisChange();

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
            tong += 2;

        }

        private void serCOM_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            string AllData = "";
            AllData = serCOM.ReadLine();
            AllData = AllData.Trim();
            int len = AllData.Length;
            if (len > 0)
            {
                try
                {
                    TemShow.Text = "Temperature:" + AllData;
                    Invoke(new MethodInvoker(() => draw(Convert.ToDouble(AllData))));
                }
                catch
                {

                }
 
            }
        }
    }
}
