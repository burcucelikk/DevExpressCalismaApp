using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCalismaApp
{
    public partial class ChartControl : Form
    {
        public ChartControl()
        {
            InitializeComponent();
        }

        private void ChartControl_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Şehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Ankara", 3));
            chartControl1.Series["Şehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Bursa", 5));
            chartControl1.Series["Şehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("İstanbul", 7));
            chartControl1.Series["Şehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Eskişehir", 16));
            chartControl1.Series["Şehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Denizli", 3));
            chartControl1.Series["Şehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Muş", 1));
            chartControl1.Series["Şehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("İzmir", 6));
        }
    }
}
