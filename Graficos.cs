using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace PuntoVentaCsharp
{
    public partial class Graficos : Form
    {
        MiddleConnector mCnx = new MiddleConnector();
        public Graficos()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            DataTable DT = mCnx.consultaFactDT();
            chart1.Titles.Add("Total Productos Vendidos");
            foreach (DataRow row in DT.Rows)
            {
                Series series = chart1.Series.Add(row["Producto"].ToString());
                series.Points.Add(Convert.ToDouble(row["Total"].ToString()));
                series.Label = row["Total"].ToString();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
