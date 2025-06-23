using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmVentanaPrincipal : Form
    {
        private Form hijoActual = null;
        private Button botonActivoActual = null;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            frmResumenArticulos frmResumen = new frmResumenArticulos();
            frmResumen.MdiParent = this;
            panel1.Controls.Add(frmResumen);
            panel1.Tag = frmResumen;
            CambiarBotonActual(btnInicio);
            frmResumen.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            cerrarVentanaActual();
            frmResumenArticulos frmResumen = new frmResumenArticulos();
            frmResumen.MdiParent = this;
            panel1.Controls.Add(frmResumen);
            panel1.Tag = frmResumen;
            CambiarBotonActual(btnInicio);
            frmResumen.Show();
            CambiarNombreVentanaActual();
        }
        
        private void btnArticulos_Click(object sender, EventArgs e)
        {
            cerrarVentanaActual();
            CambiarNombreVentanaActual();
            CambiarBotonActual(btnArticulos);
            frmListadoArticulos frmListado = new frmListadoArticulos();
            frmListado.MdiParent = this;
            panel1.Controls.Add(frmListado);
            panel1.Tag = frmListado;
            frmListado.Show();
        }
        private void cerrarVentanaActual()
        {
            panel1.Controls.Clear();
            if (hijoActual != null) {
                hijoActual.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            cerrarVentanaActual();
            frmListadoMarcas ventanaMarca = new frmListadoMarcas();
            ventanaMarca.MdiParent = this;
            panel1.Controls.Add(ventanaMarca);
            panel1.Tag = ventanaMarca;
            CambiarBotonActual(btnMarcas);
            ventanaMarca.Show();
            CambiarNombreVentanaActual();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            cerrarVentanaActual();
            frmListadoCategoria ventanaCategoria = new frmListadoCategoria();
            ventanaCategoria.MdiParent = this;
            panel1.Controls.Add(ventanaCategoria);
            panel1.Tag = ventanaCategoria;
            CambiarBotonActual(btnCategoria);
            ventanaCategoria.Show();
            CambiarNombreVentanaActual();
        }
        private void CambiarNombreVentanaActual()
        {
            lblNombreVentana.Text = botonActivoActual.Text.Trim().ToUpper();
        }
        private void CambiarBotonActual(Button boton)
        {
            if(botonActivoActual != null)
            {
                this.botonActivoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            }
            this.botonActivoActual = boton;
            this.botonActivoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(131)))), ((int)(((byte)(84)))));
        }
    }
}
