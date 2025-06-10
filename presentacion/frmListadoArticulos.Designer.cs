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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.flpListadoProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFiltroAvanzadoCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzadoCampo = new System.Windows.Forms.Label();
            this.cbxFiltroAvanzadoCriterio = new System.Windows.Forms.ComboBox();
            this.cbxFiltroAvanzadoCampo = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblNombreFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblNombreFiltro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNombreFiltro);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnAgregarArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 100);
            this.panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(332, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 20);
            this.textBox1.TabIndex = 1;
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
            this.flpListadoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListadoProductos.Location = new System.Drawing.Point(0, 100);
            this.flpListadoProductos.Name = "flpListadoProductos";
            this.flpListadoProductos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.flpListadoProductos.Size = new System.Drawing.Size(1091, 307);
            this.flpListadoProductos.TabIndex = 5;
            // 
            // lblFiltroAvanzadoCriterio
            // 
            this.lblFiltroAvanzadoCriterio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltroAvanzadoCriterio.AutoSize = true;
            this.lblFiltroAvanzadoCriterio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzadoCriterio.Location = new System.Drawing.Point(363, 63);
            this.lblFiltroAvanzadoCriterio.Name = "lblFiltroAvanzadoCriterio";
            this.lblFiltroAvanzadoCriterio.Size = new System.Drawing.Size(58, 17);
            this.lblFiltroAvanzadoCriterio.TabIndex = 4;
            this.lblFiltroAvanzadoCriterio.Text = "Criterio: ";
            // 
            // lblFiltroAvanzadoCampo
            // 
            this.lblFiltroAvanzadoCampo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltroAvanzadoCampo.AutoSize = true;
            this.lblFiltroAvanzadoCampo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzadoCampo.Location = new System.Drawing.Point(177, 63);
            this.lblFiltroAvanzadoCampo.Name = "lblFiltroAvanzadoCampo";
            this.lblFiltroAvanzadoCampo.Size = new System.Drawing.Size(53, 17);
            this.lblFiltroAvanzadoCampo.TabIndex = 3;
            this.lblFiltroAvanzadoCampo.Text = "Campo:";
            // 
            // cbxFiltroAvanzadoCriterio
            // 
            this.cbxFiltroAvanzadoCriterio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxFiltroAvanzadoCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroAvanzadoCriterio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroAvanzadoCriterio.FormattingEnabled = true;
            this.cbxFiltroAvanzadoCriterio.Location = new System.Drawing.Point(427, 55);
            this.cbxFiltroAvanzadoCriterio.Name = "cbxFiltroAvanzadoCriterio";
            this.cbxFiltroAvanzadoCriterio.Size = new System.Drawing.Size(121, 25);
            this.cbxFiltroAvanzadoCriterio.TabIndex = 2;
            // 
            // cbxFiltroAvanzadoCampo
            // 
            this.cbxFiltroAvanzadoCampo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxFiltroAvanzadoCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroAvanzadoCampo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroAvanzadoCampo.FormattingEnabled = true;
            this.cbxFiltroAvanzadoCampo.Location = new System.Drawing.Point(236, 55);
            this.cbxFiltroAvanzadoCampo.Name = "cbxFiltroAvanzadoCampo";
            this.cbxFiltroAvanzadoCampo.Size = new System.Drawing.Size(121, 25);
            this.cbxFiltroAvanzadoCampo.TabIndex = 1;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFiltroAvanzado.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(600, 55);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(167, 25);
            this.txtFiltroAvanzado.TabIndex = 0;
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltroAvanzado.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(796, 49);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(99, 34);
            this.btnFiltroAvanzado.TabIndex = 5;
            this.btnFiltroAvanzado.Text = "Buscar";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lblNombreFiltroAvanzado);
            this.panel2.Controls.Add(this.lblFiltroAvanzado);
            this.panel2.Controls.Add(this.btnFiltroAvanzado);
            this.panel2.Controls.Add(this.lblFiltroAvanzadoCriterio);
            this.panel2.Controls.Add(this.lblFiltroAvanzadoCampo);
            this.panel2.Controls.Add(this.cbxFiltroAvanzadoCriterio);
            this.panel2.Controls.Add(this.cbxFiltroAvanzadoCampo);
            this.panel2.Controls.Add(this.txtFiltroAvanzado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 138);
            this.panel2.TabIndex = 6;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(554, 63);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(40, 17);
            this.lblFiltroAvanzado.TabIndex = 6;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // lblNombreFiltroAvanzado
            // 
            this.lblNombreFiltroAvanzado.AutoSize = true;
            this.lblNombreFiltroAvanzado.Font = new System.Drawing.Font("Nirmala UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFiltroAvanzado.Location = new System.Drawing.Point(13, 7);
            this.lblNombreFiltroAvanzado.Name = "lblNombreFiltroAvanzado";
            this.lblNombreFiltroAvanzado.Size = new System.Drawing.Size(168, 30);
            this.lblNombreFiltroAvanzado.TabIndex = 7;
            this.lblNombreFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // lblNombreFiltro
            // 
            this.lblNombreFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreFiltro.AutoSize = true;
            this.lblNombreFiltro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFiltro.Location = new System.Drawing.Point(291, 45);
            this.lblNombreFiltro.Name = "lblNombreFiltro";
            this.lblNombreFiltro.Size = new System.Drawing.Size(40, 17);
            this.lblNombreFiltro.TabIndex = 2;
            this.lblNombreFiltro.Text = "Filtro:";
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoArticulos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListadoArticulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpListadoProductos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFiltroAvanzadoCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzadoCampo;
        private System.Windows.Forms.ComboBox cbxFiltroAvanzadoCriterio;
        private System.Windows.Forms.ComboBox cbxFiltroAvanzadoCampo;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblNombreFiltroAvanzado;
        private System.Windows.Forms.Label lblNombreFiltro;
    }
}