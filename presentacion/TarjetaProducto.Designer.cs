using System.Drawing;

namespace presentacion
{
    partial class TarjetaProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.pbxImagenProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(86, 40);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(39, 25);
            this.lblPrecioProducto.TabIndex = 5;
            this.lblPrecioProducto.Text = "$ 0";
            this.lblPrecioProducto.Click += new System.EventHandler(this.lblPrecioProducto_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(86, 10);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(119, 19);
            this.lblNombreProducto.TabIndex = 4;
            this.lblNombreProducto.Text = "Nombre Producto";
            this.lblNombreProducto.Click += new System.EventHandler(this.lblNombreProducto_Click);
            // 
            // pbxImagenProducto
            // 
            this.pbxImagenProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxImagenProducto.Enabled = false;
            this.pbxImagenProducto.Location = new System.Drawing.Point(0, 0);
            this.pbxImagenProducto.Name = "pbxImagenProducto";
            this.pbxImagenProducto.Size = new System.Drawing.Size(80, 83);
            this.pbxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenProducto.TabIndex = 3;
            this.pbxImagenProducto.TabStop = false;
            // 
            // TarjetaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.pbxImagenProducto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TarjetaProducto";
            this.Size = new System.Drawing.Size(323, 83);
            this.Click += new System.EventHandler(this.TarjetaProducto_Click_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.PictureBox pbxImagenProducto;
    }
}
