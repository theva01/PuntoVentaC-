using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVentaCsharp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            this.Hide();
            formUsers.ShowDialog();
            this.Show();
        }

        private void menuInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            this.Hide();
            inventario.ShowDialog();
            this.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarCli_MouseHover(object sender, EventArgs e)
        {
            if (txtBuscarCli.Text == "Buscar Cliente por Codigo") {
                txtBuscarCli.Text = "";
                txtBuscarCli.ReadOnly = false;
            }
            
            
        }

        private void txtBuscarCli_MouseLeave(object sender, EventArgs e)
        {
            if (txtBuscarCli.Text == "") {
                txtBuscarCli.Text = "Buscar Cliente por Codigo";
                txtBuscarCli.ReadOnly = true;
            }
            
            
        }
    }
}
