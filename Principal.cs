using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using System.Drawing.Printing;

namespace PuntoVentaCsharp
{
    public partial class Principal : Form
    {
        MiddleConnector mCnx = new MiddleConnector();
        DataTable dataTable = new DataTable();
        private double subtotal = 0;
        private double totalG = 0;
        private double descuento = 0;
        public Principal()
        {
            InitializeComponent();
            CargaTabla();
            //ajustarPorcentaje();

        }

        private void CargaTabla() 
        {
            txtNfactura.Text = mCnx.GenerarSiguienteNumeroFactura().ToString();
            dataTable.Columns.Add("Codigo");
            dataTable.Columns.Add("Producto");
            dataTable.Columns.Add("PrecioUnidad");
            dataTable.Columns.Add("Cantidad");
            dataTable.Columns.Add("Descuento");
            dataTable.Columns.Add("Total");
            dataGridView1.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1; // O un valor mayor si deseas que algunas columnas sean más anchas que otras
            }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void itemDescuento_TextChanged(object sender, EventArgs e)
        {
            //List<double> list = new List<double>();
            //list.Add(0);
            //list.Add(0.00);
            //list.Add(0.1);
            //list.Add(0.2);
            //list.Add(0.3);
            //list.Add(0.4);
            //list.Add(0.5);
            //list.Add(0.6);
            //list.Add(0.7);
            //list.Add(0.8);
            //list.Add(0.9);
            //if (double.TryParse(itemDescuento.Text, out double descuento) && descuento >= list.Count && descuento <= 100)
            //{
            //    ajustarPorcentaje();
            //    lblDescuento.Text = $"{itemDescuento.Text}";

            //}
            //else
            //{
            //    MessageBox.Show("Por favor, ingresa un descuento válido entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
            lblDescuento.Text = itemDescuento.Text;
        }

        private void itemIva_TextChanged(object sender, EventArgs e)
        {
            //ajustarPorcentaje();
            lbliva.Text = itemIva.Text;

        }

        private void itemIva_Click(object sender, EventArgs e)
        {
            
        }

      

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado1 = mCnx.consultaCliente(txtBuscarCli.Text);
                double iva, dect;
                iva = double.Parse(lbliva.Text);
                dect = double.Parse(lblDescuento.Text);
                mCnx.GuardarDescuentoIva(iva, dect);
                Factura fac = new Factura();
                List<Factura> facturaList = new List<Factura>();
                foreach (DataRow itemRow in dataTable.Rows)
                {
                    fac.Codigo = itemRow["Codigo"].ToString();
                    fac.Producto = itemRow["Producto"].ToString();
                    fac.PrecioUnidad = itemRow["PrecioUnidad"].ToString();
                    fac.Cantidad = itemRow["Cantidad"].ToString();
                    fac.Descuento = itemRow["Descuento"].ToString();
                    fac.PrecioTotal = itemRow["Total"].ToString();
                    fac.Subtotal = subtotal.ToString();
                    fac.Cliente = resultado1.Item1;
                    fac.DescuentoCli = resultado1.Item2.ToString();
                    fac.TotalFactura = totalG.ToString();
                    fac.Nfactura1 = txtNfactura.Text;
                    facturaList.Add(fac);
                }
                mCnx.insertarFactura(facturaList);
                txtNfactura.Text = mCnx.GenerarSiguienteNumeroFactura().ToString();
            }
            catch (Exception ex) { MessageBox.Show("Error al facturar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;//conectar ambos
            printDocument1.PrintPage += imprimirFactura;
            printDocument1.Print();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            var resultado = mCnx.consultaFactura(txtCodigoProducto.Text);
            
                
            DataRow newRow = dataTable.NewRow();
            newRow["Codigo"] = txtCodigoProducto.Text;
            newRow["Producto"] = resultado.Item1;
            newRow["PrecioUnidad"] = resultado.Item2;
            newRow["Cantidad"] = txtCantidad.Text;
            newRow["Descuento"] = double.Parse(itemDescuento.Text) / 100;
            newRow["Total"] = int.Parse(txtCantidad.Text) * double.Parse(resultado.Item2);

            // Agregar el nuevo DataRow al DataTable
            dataTable.Rows.Add(newRow);

            //subtotal = subtotal + double.Parse(txtCantidad.Text) * double.Parse(resultado.Item2);
            subtotal += int.Parse(txtCantidad.Text) * double.Parse(resultado.Item2);
            lblSubtotal.Text = subtotal.ToString();

            if (double.Parse(itemDescuento.Text) == 0)
            {
                totalG += subtotal + (subtotal * double.Parse(itemIva.Text)/100);
                lblTotal.Text = totalG.ToString();
            }
            

            double totalConIva = subtotal + (subtotal * double.Parse(itemIva.Text) / 100); // Calcular el total con IVA
            double descuentoAplicado = totalConIva * double.Parse(itemDescuento.Text) / 100; // Calcular el descuento aplicado
           /* totalG += totalConIva - descuentoAplicado;*/ // Sumar el total descontando el descuento
            totalG = totalConIva - descuentoAplicado;
            lblTotal.Text = totalG.ToString();
            

            //txtCodigoProducto.Text = "";
            //txtCantidad.Text = "";
            //IMPRESION------------
            

        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemIva_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            var resultado1 = mCnx.consultaCliente(txtBuscarCli.Text);

            try
            {
                txtCliente.Text = resultado1.Item1 + "   DESC: " + resultado1.Item2;
                descuento = resultado1.Item2;
                lblDescuento.Text = descuento.ToString();
                itemDescuento.Text = descuento.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void imprimirFactura(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int ancho = 400;
            int y = 20;
            e.Graphics.DrawString("_____VENTA HARDWARE____", font, Brushes.Black, new RectangleF(110,y += 80,ancho,20));
            e.Graphics.DrawString("Numero Factura: "+ txtNfactura.Text, font, Brushes.Black, new RectangleF(100, y += 90, ancho, 20));
            e.Graphics.DrawString("Cliente: "+ txtCliente.Text, font, Brushes.Black, new RectangleF(100, y += 90, ancho, 20));
            e.Graphics.DrawString("_____PRODUCTOS____", font, Brushes.Black, new RectangleF(110, y += 110, ancho, 20));

            foreach (DataRow itemRow in dataTable.Rows)
            {
                e.Graphics.DrawString(itemRow["Codigo"].ToString() + " " + 
                    itemRow["Producto"].ToString() + " " + 
                    itemRow["Total"].ToString()
                    , font, Brushes.Black, new RectangleF(100, y += 70, ancho, 20));
            }

            e.Graphics.DrawString("---Subtotal: "+subtotal.ToString(), font, Brushes.Black, new RectangleF(60, y += 30, ancho, 20));
            e.Graphics.DrawString("---Total: "+ totalG.ToString(), font, Brushes.Black, new RectangleF(60, y += 50, ancho, 20));
        }

        private void menuGraficoVentas_Click(object sender, EventArgs e)
        {
            Graficos graficos = new Graficos();
            this.Hide();
            graficos.ShowDialog();
            this.Show();
        }
    }
}
