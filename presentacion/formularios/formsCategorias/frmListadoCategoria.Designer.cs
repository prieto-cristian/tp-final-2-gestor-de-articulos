namespace presentacion
{
    partial class frmListadoCategoria
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblNombreFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(527, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(342, 361);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 50);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeColumns = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(147, 106);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(509, 249);
            this.dgvCategorias.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrear.BackColor = System.Drawing.Color.LightCoral;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(147, 361);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(129, 50);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.txtFiltro);
            this.panelSuperior.Controls.Add(this.lblNombreFiltro);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 100);
            this.panelSuperior.TabIndex = 6;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFiltro.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(292, 38);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(238, 25);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblNombreFiltro
            // 
            this.lblNombreFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreFiltro.AutoSize = true;
            this.lblNombreFiltro.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFiltro.Location = new System.Drawing.Point(243, 44);
            this.lblNombreFiltro.Name = "lblNombreFiltro";
            this.lblNombreFiltro.Size = new System.Drawing.Size(43, 19);
            this.lblNombreFiltro.TabIndex = 1;
            this.lblNombreFiltro.Text = "Filtro:";
            // 
            // frmListadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoCategoria";
            this.Text = "frmListadoCategoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListadoCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblNombreFiltro;
    }
}