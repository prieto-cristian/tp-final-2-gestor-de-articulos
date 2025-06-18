namespace presentacion
{
    partial class frmListadoArticulos
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
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.cbxOrden = new System.Windows.Forms.ComboBox();
            this.lblOrden = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.flpListadoProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFiltroAvanzado = new System.Windows.Forms.Panel();
            this.btnBuscarProductosPorRango = new System.Windows.Forms.Button();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.lblProductosConPrecioAlto = new System.Windows.Forms.Label();
            this.lblProductosConPrecioMedio = new System.Windows.Forms.Label();
            this.lblProductosPrecioBajo = new System.Windows.Forms.Label();
            this.lblFiltroPrecio = new System.Windows.Forms.Label();
            this.cbxFiltroCategorias = new System.Windows.Forms.ComboBox();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.cbxFiltroMarcas = new System.Windows.Forms.ComboBox();
            this.lblFiltroMarcas = new System.Windows.Forms.Label();
            this.btnLimpiarFiltroDePrecios = new System.Windows.Forms.Button();
            this.btnLimpiarFiltroCategoria = new System.Windows.Forms.Button();
            this.btnLimpiarFiltroDeMarca = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelBarraSuperior.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelFiltroAvanzado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panelBarraSuperior.Controls.Add(this.cbxOrden);
            this.panelBarraSuperior.Controls.Add(this.lblOrden);
            this.panelBarraSuperior.Controls.Add(this.panelBusqueda);
            this.panelBarraSuperior.Controls.Add(this.btnAgregarArticulo);
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(1091, 100);
            this.panelBarraSuperior.TabIndex = 4;
            // 
            // cbxOrden
            // 
            this.cbxOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cbxOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrden.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrden.FormattingEnabled = true;
            this.cbxOrden.Location = new System.Drawing.Point(888, 40);
            this.cbxOrden.Name = "cbxOrden";
            this.cbxOrden.Size = new System.Drawing.Size(121, 25);
            this.cbxOrden.TabIndex = 5;
            this.cbxOrden.SelectedIndexChanged += new System.EventHandler(this.cbxOrden_SelectedIndexChanged);
            this.cbxOrden.SelectedValueChanged += new System.EventHandler(this.cbxOrden_SelectedValueChanged);
            this.cbxOrden.Leave += new System.EventHandler(this.cbxOrden_Leave);
            // 
            // lblOrden
            // 
            this.lblOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(789, 43);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(93, 19);
            this.lblOrden.TabIndex = 4;
            this.lblOrden.Text = "Ordenar por";
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBusqueda.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelBusqueda.Controls.Add(this.txtBuscador);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Location = new System.Drawing.Point(314, 32);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(454, 40);
            this.panelBusqueda.TabIndex = 3;
            this.panelBusqueda.Click += new System.EventHandler(this.panel3_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscador.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Nirmala UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(0, 0);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(411, 38);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.Tag = "";
            this.txtBuscador.Click += new System.EventHandler(this.textBox1_Click);
            this.txtBuscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBuscador.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            this.txtBuscador.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.LightCoral;
            this.btnAgregarArticulo.FlatAppearance.BorderSize = 0;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(65, 22);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(129, 50);
            this.btnAgregarArticulo.TabIndex = 0;
            this.btnAgregarArticulo.Text = "Nuevo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // flpListadoProductos
            // 
            this.flpListadoProductos.BackColor = System.Drawing.Color.White;
            this.flpListadoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListadoProductos.Location = new System.Drawing.Point(0, 100);
            this.flpListadoProductos.Name = "flpListadoProductos";
            this.flpListadoProductos.Padding = new System.Windows.Forms.Padding(30, 60, 0, 0);
            this.flpListadoProductos.Size = new System.Drawing.Size(701, 445);
            this.flpListadoProductos.TabIndex = 5;
            // 
            // panelFiltroAvanzado
            // 
            this.panelFiltroAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panelFiltroAvanzado.Controls.Add(this.btnLimpiarFiltroDeMarca);
            this.panelFiltroAvanzado.Controls.Add(this.btnLimpiarFiltroCategoria);
            this.panelFiltroAvanzado.Controls.Add(this.btnLimpiarFiltroDePrecios);
            this.panelFiltroAvanzado.Controls.Add(this.btnBuscarProductosPorRango);
            this.panelFiltroAvanzado.Controls.Add(this.lblMaximo);
            this.panelFiltroAvanzado.Controls.Add(this.lblMinimo);
            this.panelFiltroAvanzado.Controls.Add(this.txtMaximo);
            this.panelFiltroAvanzado.Controls.Add(this.txtMinimo);
            this.panelFiltroAvanzado.Controls.Add(this.lblProductosConPrecioAlto);
            this.panelFiltroAvanzado.Controls.Add(this.lblProductosConPrecioMedio);
            this.panelFiltroAvanzado.Controls.Add(this.lblProductosPrecioBajo);
            this.panelFiltroAvanzado.Controls.Add(this.lblFiltroPrecio);
            this.panelFiltroAvanzado.Controls.Add(this.cbxFiltroCategorias);
            this.panelFiltroAvanzado.Controls.Add(this.lblFiltroCategoria);
            this.panelFiltroAvanzado.Controls.Add(this.cbxFiltroMarcas);
            this.panelFiltroAvanzado.Controls.Add(this.lblFiltroMarcas);
            this.panelFiltroAvanzado.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFiltroAvanzado.Location = new System.Drawing.Point(701, 100);
            this.panelFiltroAvanzado.Name = "panelFiltroAvanzado";
            this.panelFiltroAvanzado.Size = new System.Drawing.Size(390, 445);
            this.panelFiltroAvanzado.TabIndex = 6;
            this.panelFiltroAvanzado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFiltroAvanzado_Paint);
            // 
            // btnBuscarProductosPorRango
            // 
            this.btnBuscarProductosPorRango.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductosPorRango.Location = new System.Drawing.Point(299, 372);
            this.btnBuscarProductosPorRango.Name = "btnBuscarProductosPorRango";
            this.btnBuscarProductosPorRango.Size = new System.Drawing.Size(32, 28);
            this.btnBuscarProductosPorRango.TabIndex = 12;
            this.btnBuscarProductosPorRango.Text = ">";
            this.btnBuscarProductosPorRango.UseVisualStyleBackColor = true;
            this.btnBuscarProductosPorRango.Click += new System.EventHandler(this.btnBuscarProductosPorRango_Click);
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(160, 375);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(35, 19);
            this.lblMaximo.TabIndex = 11;
            this.lblMaximo.Text = "Max";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(24, 375);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(33, 19);
            this.lblMinimo.TabIndex = 10;
            this.lblMinimo.Text = "Min";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximo.Location = new System.Drawing.Point(193, 372);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 25);
            this.txtMaximo.TabIndex = 9;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimo.Location = new System.Drawing.Point(54, 372);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 25);
            this.txtMinimo.TabIndex = 8;
            // 
            // lblProductosConPrecioAlto
            // 
            this.lblProductosConPrecioAlto.AutoSize = true;
            this.lblProductosConPrecioAlto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductosConPrecioAlto.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosConPrecioAlto.Location = new System.Drawing.Point(21, 319);
            this.lblProductosConPrecioAlto.Name = "lblProductosConPrecioAlto";
            this.lblProductosConPrecioAlto.Size = new System.Drawing.Size(16, 19);
            this.lblProductosConPrecioAlto.TabIndex = 7;
            this.lblProductosConPrecioAlto.Text = "a";
            this.lblProductosConPrecioAlto.Click += new System.EventHandler(this.lblProductosConPrecioAlto_Click);
            // 
            // lblProductosConPrecioMedio
            // 
            this.lblProductosConPrecioMedio.AutoSize = true;
            this.lblProductosConPrecioMedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductosConPrecioMedio.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosConPrecioMedio.Location = new System.Drawing.Point(22, 287);
            this.lblProductosConPrecioMedio.Name = "lblProductosConPrecioMedio";
            this.lblProductosConPrecioMedio.Size = new System.Drawing.Size(16, 19);
            this.lblProductosConPrecioMedio.TabIndex = 6;
            this.lblProductosConPrecioMedio.Text = "a";
            this.lblProductosConPrecioMedio.Click += new System.EventHandler(this.lblProductosConPrecioMedio_Click);
            // 
            // lblProductosPrecioBajo
            // 
            this.lblProductosPrecioBajo.AutoSize = true;
            this.lblProductosPrecioBajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductosPrecioBajo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosPrecioBajo.Location = new System.Drawing.Point(22, 251);
            this.lblProductosPrecioBajo.Name = "lblProductosPrecioBajo";
            this.lblProductosPrecioBajo.Size = new System.Drawing.Size(16, 19);
            this.lblProductosPrecioBajo.TabIndex = 5;
            this.lblProductosPrecioBajo.Text = "a";
            this.lblProductosPrecioBajo.Click += new System.EventHandler(this.lblProductosPrecioBajo_Click);
            // 
            // lblFiltroPrecio
            // 
            this.lblFiltroPrecio.AutoSize = true;
            this.lblFiltroPrecio.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroPrecio.Location = new System.Drawing.Point(22, 221);
            this.lblFiltroPrecio.Name = "lblFiltroPrecio";
            this.lblFiltroPrecio.Size = new System.Drawing.Size(52, 19);
            this.lblFiltroPrecio.TabIndex = 4;
            this.lblFiltroPrecio.Text = "Precio";
            // 
            // cbxFiltroCategorias
            // 
            this.cbxFiltroCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroCategorias.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroCategorias.FormattingEnabled = true;
            this.cbxFiltroCategorias.Location = new System.Drawing.Point(25, 170);
            this.cbxFiltroCategorias.Name = "cbxFiltroCategorias";
            this.cbxFiltroCategorias.Size = new System.Drawing.Size(121, 25);
            this.cbxFiltroCategorias.TabIndex = 3;
            this.cbxFiltroCategorias.SelectedValueChanged += new System.EventHandler(this.cbxFiltroCategorias_SelectedValueChanged);
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCategoria.Location = new System.Drawing.Point(25, 139);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(75, 19);
            this.lblFiltroCategoria.TabIndex = 2;
            this.lblFiltroCategoria.Text = "Categoría";
            // 
            // cbxFiltroMarcas
            // 
            this.cbxFiltroMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroMarcas.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroMarcas.FormattingEnabled = true;
            this.cbxFiltroMarcas.Location = new System.Drawing.Point(25, 78);
            this.cbxFiltroMarcas.Name = "cbxFiltroMarcas";
            this.cbxFiltroMarcas.Size = new System.Drawing.Size(121, 25);
            this.cbxFiltroMarcas.TabIndex = 1;
            this.cbxFiltroMarcas.SelectedValueChanged += new System.EventHandler(this.cbxFiltroMarcas_SelectedValueChanged);
            // 
            // lblFiltroMarcas
            // 
            this.lblFiltroMarcas.AutoSize = true;
            this.lblFiltroMarcas.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroMarcas.Location = new System.Drawing.Point(25, 50);
            this.lblFiltroMarcas.Name = "lblFiltroMarcas";
            this.lblFiltroMarcas.Size = new System.Drawing.Size(51, 19);
            this.lblFiltroMarcas.TabIndex = 0;
            this.lblFiltroMarcas.Text = "Marca";
            // 
            // btnLimpiarFiltroDePrecios
            // 
            this.btnLimpiarFiltroDePrecios.Image = global::presentacion.Properties.Resources.escoba;
            this.btnLimpiarFiltroDePrecios.Location = new System.Drawing.Point(80, 221);
            this.btnLimpiarFiltroDePrecios.Name = "btnLimpiarFiltroDePrecios";
            this.btnLimpiarFiltroDePrecios.Size = new System.Drawing.Size(36, 23);
            this.btnLimpiarFiltroDePrecios.TabIndex = 13;
            this.btnLimpiarFiltroDePrecios.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltroDePrecios.Click += new System.EventHandler(this.btnLimpiarFiltroDePrecios_Click);
            // 
            // btnLimpiarFiltroCategoria
            // 
            this.btnLimpiarFiltroCategoria.Image = global::presentacion.Properties.Resources.escoba;
            this.btnLimpiarFiltroCategoria.Location = new System.Drawing.Point(106, 137);
            this.btnLimpiarFiltroCategoria.Name = "btnLimpiarFiltroCategoria";
            this.btnLimpiarFiltroCategoria.Size = new System.Drawing.Size(39, 23);
            this.btnLimpiarFiltroCategoria.TabIndex = 14;
            this.btnLimpiarFiltroCategoria.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltroCategoria.Click += new System.EventHandler(this.btnLimpiarFiltroCategoria_Click);
            // 
            // btnLimpiarFiltroDeMarca
            // 
            this.btnLimpiarFiltroDeMarca.Image = global::presentacion.Properties.Resources.escoba;
            this.btnLimpiarFiltroDeMarca.Location = new System.Drawing.Point(80, 50);
            this.btnLimpiarFiltroDeMarca.Name = "btnLimpiarFiltroDeMarca";
            this.btnLimpiarFiltroDeMarca.Size = new System.Drawing.Size(36, 23);
            this.btnLimpiarFiltroDeMarca.TabIndex = 15;
            this.btnLimpiarFiltroDeMarca.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltroDeMarca.Click += new System.EventHandler(this.btnLimpiarFiltroDeMarca_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::presentacion.Properties.Resources.busqueda;
            this.btnBuscar.Location = new System.Drawing.Point(411, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(43, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1091, 545);
            this.ControlBox = false;
            this.Controls.Add(this.flpListadoProductos);
            this.Controls.Add(this.panelFiltroAvanzado);
            this.Controls.Add(this.panelBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoArticulos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListadoArticulos_Load);
            this.panelBarraSuperior.ResumeLayout(false);
            this.panelBarraSuperior.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelFiltroAvanzado.ResumeLayout(false);
            this.panelFiltroAvanzado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.FlowLayoutPanel flpListadoProductos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Panel panelFiltroAvanzado;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.ComboBox cbxOrden;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label lblFiltroMarcas;
        private System.Windows.Forms.ComboBox cbxFiltroMarcas;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.Label lblFiltroPrecio;
        private System.Windows.Forms.ComboBox cbxFiltroCategorias;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label lblProductosConPrecioAlto;
        private System.Windows.Forms.Label lblProductosConPrecioMedio;
        private System.Windows.Forms.Label lblProductosPrecioBajo;
        private System.Windows.Forms.Button btnBuscarProductosPorRango;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Button btnLimpiarFiltroDeMarca;
        private System.Windows.Forms.Button btnLimpiarFiltroCategoria;
        private System.Windows.Forms.Button btnLimpiarFiltroDePrecios;
    }
}