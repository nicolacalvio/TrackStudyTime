using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrackStudyTime
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string nomeUtente;
        private void Form3_Load(object sender, EventArgs e)
        {
            Tuple<string, double>[] tuplaArray;
            tuplaArray = ConnectionUtil.prendiInfoGrafico(nomeUtente);
            
            for(int i = 0; i < tuplaArray.Length; i++)
            {
                chart1.Series["Ore_studio"].Points.AddXY(tuplaArray[i].Item1, tuplaArray[i].Item2);
            }
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(chart1.Series["Ore_studio"].ChartType.Equals(SeriesChartType.Spline))
            {
                chart1.Series["Ore_studio"].ChartType = SeriesChartType.Column;
            }
            else
            {
                chart1.Series["Ore_studio"].ChartType = SeriesChartType.Spline;
            }
        }
    }
}
