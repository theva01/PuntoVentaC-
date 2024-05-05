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

namespace PuntoVentaCsharp
{
    public partial class Form1 : Form
    {
        MiddleConnector mCnx = new MiddleConnector();
        public Form1()
        {
            InitializeComponent();
        }

        private void msm(string m) { MessageBox.Show(m); }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (mCnx.cnxSQL(txtUsuario.Text, txtPword.Text) == 1)
            {
                msm("Encontrado el usuario");
                this.Hide();
            Principal p1 = new Principal();
            p1.ShowDialog();
            }
            else { msm("No existe el usuario"); }
        }
    }
}
