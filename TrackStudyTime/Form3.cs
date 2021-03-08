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
        private void generaGrafico()
        {
            Tuple<string, double>[] tuplaArray;
            tuplaArray = ConnectionUtil.prendiInfoGrafico(nomeUtente, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            for (int i = 0; i < tuplaArray.Length; i++)
            {
                chart1.Series["Ore_studio"].Points.AddXY(tuplaArray[i].Item1, tuplaArray[i].Item2);
            }
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }
        private void generaStatistiche()
        {
            //ore totali label6
            //media giornaliera label 8
            string[] stats = ConnectionUtil.returnStats(nomeUtente, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            label6.Text = Convert.ToString(Convert.ToInt32(stats[0])/60/60);
            label8.Text = stats[1];
            label11.Text = stats[2];
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now;
            DateTime[] res = StoreRetriveData.getGrafico();
            if ( res != null)
            {
                dateTimePicker1.Value = res[0];
                //dateTimePicker2.Value = res[1];
                generaGrafico();
                generaStatistiche();
            }
            else
            {
                MessageBox.Show("compila le date");
            }
            
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
        private void resetGrafico()
        {
            chart1.Series["Ore_studio"].Points.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StoreRetriveData.settinggGrafico(dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            resetGrafico();
            generaGrafico();
            generaStatistiche();
        }
    }
}
