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
            Tuple<string, int>[] tuplaArray;
            tuplaArray = ConnectionUtil.prendiInfoGrafico(nomeUtente);

            for(int i = 0; i < tuplaArray.Length; i++)
            {
                chart1.Series["Ore_studio"].Points.AddXY(tuplaArray[i].Item1, tuplaArray[i].Item2);
            }
        }
    }
}
