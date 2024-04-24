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
    public partial class FormUsers : Form
    {
        MiddleConnector mCnx = new MiddleConnector();
        public FormUsers()
        {
            InitializeComponent();
            CargaDtg();
        }

        private void CargaDtg() { dataGridView1.DataSource = mCnx.ConsultaUsuarioDt(); }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            mCnx.RegistrarDt(txtId.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtUsuario.Text, txtClave.Text);
            CargaDtg();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mCnx.ActualizarDt(txtId.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtUsuario.Text, txtClave.Text);
            CargaDtg();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mCnx.Eliminar(txtId.Text);
            CargaDtg();
        }
    }
}
