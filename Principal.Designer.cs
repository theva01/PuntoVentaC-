namespace PuntoVentaCsharp
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.historialDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNfactura = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtBuscarCli = new System.Windows.Forms.TextBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(1075, 547);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuUsuarios,
            this.menuInventario,
            this.reportesToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1173, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFacturaToolStripMenuItem});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // abrirFacturaToolStripMenuItem
            // 
            this.abrirFacturaToolStripMenuItem.Name = "abrirFacturaToolStripMenuItem";
            this.abrirFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirFacturaToolStripMenuItem.Text = "Abrir factura";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuInventario
            // 
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Size = new System.Drawing.Size(72, 20);
            this.menuInventario.Text = "Inventario";
            this.menuInventario.Click += new System.EventHandler(this.menuInventario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntoVentaCsharp.Properties.Resources.bg_evangelion;
            this.pictureBox1.Location = new System.Drawing.Point(-133, -223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 346);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.Location = new System.Drawing.Point(1007, 465);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 33);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(894, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de Producto: ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(1007, 415);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sub Total:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "0.00";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "0.00";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total:";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeFacturasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Location = new System.Drawing.Point(49, 426);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descuento: ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Facturar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // historialDeFacturasToolStripMenuItem
            // 
            this.historialDeFacturasToolStripMenuItem.Name = "historialDeFacturasToolStripMenuItem";
            this.historialDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.historialDeFacturasToolStripMenuItem.Text = "Historial de Facturas";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.Location = new System.Drawing.Point(1007, 439);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(949, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.Location = new System.Drawing.Point(50, 478);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Impuesto Venta: ";
            // 
            // txtNfactura
            // 
            this.txtNfactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNfactura.Location = new System.Drawing.Point(534, 27);
            this.txtNfactura.Name = "txtNfactura";
            this.txtNfactura.ReadOnly = true;
            this.txtNfactura.Size = new System.Drawing.Size(140, 22);
            this.txtNfactura.TabIndex = 18;
            this.txtNfactura.Text = "Numero de Factura";
            this.txtNfactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(822, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(306, 24);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "Cliente";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBuscarCli
            // 
            this.txtBuscarCli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBuscarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCli.Location = new System.Drawing.Point(48, 27);
            this.txtBuscarCli.Name = "txtBuscarCli";
            this.txtBuscarCli.Size = new System.Drawing.Size(198, 22);
            this.txtBuscarCli.TabIndex = 20;
            this.txtBuscarCli.Text = "Buscar Cliente por Codigo";
            this.txtBuscarCli.MouseLeave += new System.EventHandler(this.txtBuscarCli_MouseLeave);
            this.txtBuscarCli.MouseHover += new System.EventHandler(this.txtBuscarCli_MouseHover);
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarCli.Location = new System.Drawing.Point(252, 27);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(105, 22);
            this.btnBuscarCli.TabIndex = 21;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 592);
            this.Controls.Add(this.btnBuscarCli);
            this.Controls.Add(this.txtBuscarCli);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtNfactura);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem abrirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeFacturasToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNfactura;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtBuscarCli;
        private System.Windows.Forms.Button btnBuscarCli;
    }
}