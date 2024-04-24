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

namespace PuntoVentaCsharp
{
    public partial class Inventario : Form
    {
        MiddleConnector mCnx = new MiddleConnector();
        
        public Inventario()
        {
            InitializeComponent();
            CargaDtg();
        }
        private void CargaDtg() { dataGridView1.DataSource = mCnx.ConsultaUsuarioDt("i"); }
        private void msm(string m) { MessageBox.Show(m); }
        private void limpiarCampos() { txtNombreP.Text = ""; txtPrecio.Text = ""; txtCantidad.Text = ""; txtCategoria.Text = ""; txtId.Text = ""; }
        public static bool ValidarCampos(string nombre, string precio, string cantidad, string categoria)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingresa un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(precio) || !int.TryParse(precio, out _))
            {
                MessageBox.Show("Por favor, ingresa un precio válido (número entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cantidad) || !int.TryParse(cantidad, out _))
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida (número entero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Por favor, ingresa una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        
        public void CrUd(string msj)
        {
            if (ValidarCampos(txtNombreP.Text, txtPrecio.Text, txtCantidad.Text, txtCategoria.Text))
            {
                if (msj == "Registrado")
                {
                    if (mCnx.mCrUd(txtNombreP.Text, txtPrecio.Text, txtCantidad.Text, txtCategoria.Text, "c", 0) == 1)
                    {
                        msm($"{msj} correctamente");
                        limpiarCampos();
                    }
                    else
                    {
                        msm("Registre correctamente los datos del producto");
                    }
                }
                else
                {
                    if (mCnx.mCrUd(txtNombreP.Text, txtPrecio.Text, txtCantidad.Text, txtCategoria.Text, "", Convert.ToInt32(txtId.Text)) == 1)
                    {
                        msm($"{msj} correctamente");
                        limpiarCampos();

                    }
                    else
                    {
                        msm("Registre correctamente los datos del producto");
                    }
                }
                
                CargaDtg();
            }
            else { msm("Ingrese valores adecuados para precio y cantidad"); }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CrUd("Registrado");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CrUd("Actualizado");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                btnRegistrar.Show();
            }else btnRegistrar.Hide();

        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            txtNombreP.Text = ""; txtPrecio.Text = ""; txtCantidad.Text = ""; txtCategoria.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (mCnx.Eliminar(txtId.Text, "i") == 1)
            {
                msm($"Producto con Id: {txtId.Text} eliminado correctamente");
                limpiarCampos();
            }else { msm($"Producto con Id: {txtId.Text} no encontrado"); msm("Intentan con Nuevamente con ID de productos existentes"); }
            CargaDtg();
        }


    }
}
