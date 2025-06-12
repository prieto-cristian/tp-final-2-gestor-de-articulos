namespace presentacion
{
    partial class frmResumenArticulos
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
            this.lblCantidadArticulos = new System.Windows.Forms.Label();
            this.lblArticuloMasCaro = new System.Windows.Forms.Label();
            this.lblArticuloMasBarato = new System.Windows.Forms.Label();
            this.lblMarcaConMasArticulos = new System.Windows.Forms.Label();
            this.lblNumeroArticulos = new System.Windows.Forms.Label();
            this.lblNumeroArticulosDeUnaMarca = new System.Windows.Forms.Label();
            this.tpArticuloMasBarato = new presentacion.TarjetaProducto();
            this.tpArticuloMasCaro = new presentacion.TarjetaProducto();
            this.SuspendLayout();
            // 
            // lblCantidadArticulos
            // 
            this.lblCantidadArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidadArticulos.AutoSize = true;
            this.lblCantidadArticulos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadArticulos.Location = new System.Drawing.Point(201, 282);
            this.lblCantidadArticulos.Name = "lblCantidadArticulos";
            this.lblCantidadArticulos.Size = new System.Drawing.Size(206, 17);
            this.lblCantidadArticulos.TabIndex = 0;
            this.lblCantidadArticulos.Text = "Cantidad de Articulos Cargados:";
            // 
            // lblArticuloMasCaro
            // 
            this.lblArticuloMasCaro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArticuloMasCaro.AutoSize = true;
            this.lblArticuloMasCaro.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloMasCaro.Location = new System.Drawing.Point(169, 85);
            this.lblArticuloMasCaro.Name = "lblArticuloMasCaro";
            this.lblArticuloMasCaro.Size = new System.Drawing.Size(131, 19);
            this.lblArticuloMasCaro.TabIndex = 1;
            this.lblArticuloMasCaro.Text = "Artículo más caro:";
            // 
            // lblArticuloMasBarato
            // 
            this.lblArticuloMasBarato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArticuloMasBarato.AutoSize = true;
            this.lblArticuloMasBarato.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloMasBarato.Location = new System.Drawing.Point(749, 85);
            this.lblArticuloMasBarato.Name = "lblArticuloMasBarato";
            this.lblArticuloMasBarato.Size = new System.Drawing.Size(146, 19);
            this.lblArticuloMasBarato.TabIndex = 2;
            this.lblArticuloMasBarato.Text = "Artículo más barato:";
            // 
            // lblMarcaConMasArticulos
            // 
            this.lblMarcaConMasArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarcaConMasArticulos.AutoSize = true;
            this.lblMarcaConMasArticulos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaConMasArticulos.Location = new System.Drawing.Point(821, 282);
            this.lblMarcaConMasArticulos.Name = "lblMarcaConMasArticulos";
            this.lblMarcaConMasArticulos.Size = new System.Drawing.Size(161, 17);
            this.lblMarcaConMasArticulos.TabIndex = 3;
            this.lblMarcaConMasArticulos.Text = "Marca con más artículos:";
            // 
            // lblNumeroArticulos
            // 
            this.lblNumeroArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroArticulos.AutoSize = true;
            this.lblNumeroArticulos.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroArticulos.Location = new System.Drawing.Point(272, 322);
            this.lblNumeroArticulos.Name = "lblNumeroArticulos";
            this.lblNumeroArticulos.Size = new System.Drawing.Size(51, 71);
            this.lblNumeroArticulos.TabIndex = 4;
            this.lblNumeroArticulos.Text = "-";
            // 
            // lblNumeroArticulosDeUnaMarca
            // 
            this.lblNumeroArticulosDeUnaMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroArticulosDeUnaMarca.AutoSize = true;
            this.lblNumeroArticulosDeUnaMarca.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroArticulosDeUnaMarca.Location = new System.Drawing.Point(873, 322);
            this.lblNumeroArticulosDeUnaMarca.Name = "lblNumeroArticulosDeUnaMarca";
            this.lblNumeroArticulosDeUnaMarca.Size = new System.Drawing.Size(51, 71);
            this.lblNumeroArticulosDeUnaMarca.TabIndex = 5;
            this.lblNumeroArticulosDeUnaMarca.Text = "-";
            // 
            // tpArticuloMasBarato
            // 
            this.tpArticuloMasBarato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tpArticuloMasBarato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpArticuloMasBarato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpArticuloMasBarato.Location = new System.Drawing.Point(753, 112);
            this.tpArticuloMasBarato.Name = "tpArticuloMasBarato";
            this.tpArticuloMasBarato.Nombre = "Nombre Producto";
            this.tpArticuloMasBarato.Precio = "$ Precio";
            this.tpArticuloMasBarato.Size = new System.Drawing.Size(325, 85);
            this.tpArticuloMasBarato.TabIndex = 7;
            // 
            // tpArticuloMasCaro
            // 
            this.tpArticuloMasCaro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tpArticuloMasCaro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpArticuloMasCaro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpArticuloMasCaro.Location = new System.Drawing.Point(173, 112);
            this.tpArticuloMasCaro.Name = "tpArticuloMasCaro";
            this.tpArticuloMasCaro.Nombre = "Nombre Producto";
            this.tpArticuloMasCaro.Precio = "$ Precio";
            this.tpArticuloMasCaro.Size = new System.Drawing.Size(325, 85);
            this.tpArticuloMasCaro.TabIndex = 6;
            // 
            // frmResumenArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 670);
            this.Controls.Add(this.lblArticuloMasCaro);
            this.Controls.Add(this.tpArticuloMasBarato);
            this.Controls.Add(this.tpArticuloMasCaro);
            this.Controls.Add(this.lblCantidadArticulos);
            this.Controls.Add(this.lblNumeroArticulos);
            this.Controls.Add(this.lblMarcaConMasArticulos);
            this.Controls.Add(this.lblArticuloMasBarato);
            this.Controls.Add(this.lblNumeroArticulosDeUnaMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResumenArticulos";
            this.Text = "frmResumenArticulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmResumenArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadArticulos;
        private System.Windows.Forms.Label lblArticuloMasCaro;
        private System.Windows.Forms.Label lblArticuloMasBarato;
        private System.Windows.Forms.Label lblMarcaConMasArticulos;
        private System.Windows.Forms.Label lblNumeroArticulos;
        private System.Windows.Forms.Label lblNumeroArticulosDeUnaMarca;
        private TarjetaProducto tpArticuloMasCaro;
        private TarjetaProducto tpArticuloMasBarato;
    }
}