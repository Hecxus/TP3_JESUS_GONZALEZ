namespace FormsAppCatalogo
{
    partial class CatalogoPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbArticulos = new System.Windows.Forms.ListBox();
            this.labelDescriptionHeader = new System.Windows.Forms.Label();
            this.labelDescriptionValue = new System.Windows.Forms.Label();
            this.labelCodArtHeader = new System.Windows.Forms.Label();
            this.labelCodArtValue = new System.Windows.Forms.Label();
            this.labelMarcaValue = new System.Windows.Forms.Label();
            this.labelMarcaHeader = new System.Windows.Forms.Label();
            this.labelCategoriaHeader = new System.Windows.Forms.Label();
            this.labelCategoriaValue = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblPrecioHeader = new System.Windows.Forms.Label();
            this.lblPrecioValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArticulos
            // 
            this.pbArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbArticulos.Location = new System.Drawing.Point(466, 47);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(258, 264);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 1;
            this.pbArticulos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(212, 361);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar un articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(437, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 37);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar un articulo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbArticulos
            // 
            this.lbArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbArticulos.FormattingEnabled = true;
            this.lbArticulos.Location = new System.Drawing.Point(82, 47);
            this.lbArticulos.Name = "lbArticulos";
            this.lbArticulos.Size = new System.Drawing.Size(205, 264);
            this.lbArticulos.TabIndex = 5;
            this.lbArticulos.SelectedValueChanged += new System.EventHandler(this.lbArticulos_SelectedValueChanged);
            // 
            // labelDescriptionHeader
            // 
            this.labelDescriptionHeader.AutoSize = true;
            this.labelDescriptionHeader.Location = new System.Drawing.Point(293, 88);
            this.labelDescriptionHeader.Name = "labelDescriptionHeader";
            this.labelDescriptionHeader.Size = new System.Drawing.Size(66, 13);
            this.labelDescriptionHeader.TabIndex = 6;
            this.labelDescriptionHeader.Text = "Descripcion:";
            // 
            // labelDescriptionValue
            // 
            this.labelDescriptionValue.AutoSize = true;
            this.labelDescriptionValue.Location = new System.Drawing.Point(296, 105);
            this.labelDescriptionValue.Name = "labelDescriptionValue";
            this.labelDescriptionValue.Size = new System.Drawing.Size(32, 13);
            this.labelDescriptionValue.TabIndex = 7;
            this.labelDescriptionValue.Text = "xxxxx";
            // 
            // labelCodArtHeader
            // 
            this.labelCodArtHeader.AutoSize = true;
            this.labelCodArtHeader.Location = new System.Drawing.Point(296, 47);
            this.labelCodArtHeader.Name = "labelCodArtHeader";
            this.labelCodArtHeader.Size = new System.Drawing.Size(96, 13);
            this.labelCodArtHeader.TabIndex = 8;
            this.labelCodArtHeader.Text = "Codigo de Articulo:";
            // 
            // labelCodArtValue
            // 
            this.labelCodArtValue.AutoSize = true;
            this.labelCodArtValue.Location = new System.Drawing.Point(293, 60);
            this.labelCodArtValue.Name = "labelCodArtValue";
            this.labelCodArtValue.Size = new System.Drawing.Size(32, 13);
            this.labelCodArtValue.TabIndex = 9;
            this.labelCodArtValue.Text = "xxxxx";
            // 
            // labelMarcaValue
            // 
            this.labelMarcaValue.AutoSize = true;
            this.labelMarcaValue.Location = new System.Drawing.Point(296, 160);
            this.labelMarcaValue.Name = "labelMarcaValue";
            this.labelMarcaValue.Size = new System.Drawing.Size(37, 13);
            this.labelMarcaValue.TabIndex = 10;
            this.labelMarcaValue.Text = "xxxxxx";
            // 
            // labelMarcaHeader
            // 
            this.labelMarcaHeader.AutoSize = true;
            this.labelMarcaHeader.Location = new System.Drawing.Point(296, 147);
            this.labelMarcaHeader.Name = "labelMarcaHeader";
            this.labelMarcaHeader.Size = new System.Drawing.Size(40, 13);
            this.labelMarcaHeader.TabIndex = 11;
            this.labelMarcaHeader.Text = "Marca:";
            // 
            // labelCategoriaHeader
            // 
            this.labelCategoriaHeader.AutoSize = true;
            this.labelCategoriaHeader.Location = new System.Drawing.Point(296, 190);
            this.labelCategoriaHeader.Name = "labelCategoriaHeader";
            this.labelCategoriaHeader.Size = new System.Drawing.Size(55, 13);
            this.labelCategoriaHeader.TabIndex = 12;
            this.labelCategoriaHeader.Text = "Categoria:";
            // 
            // labelCategoriaValue
            // 
            this.labelCategoriaValue.AutoSize = true;
            this.labelCategoriaValue.Location = new System.Drawing.Point(296, 214);
            this.labelCategoriaValue.Name = "labelCategoriaValue";
            this.labelCategoriaValue.Size = new System.Drawing.Size(32, 13);
            this.labelCategoriaValue.TabIndex = 13;
            this.labelCategoriaValue.Text = "xxxxx";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(318, 361);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 36);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar articulo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 360);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 37);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar Articulo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(82, 317);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 39);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar busqueda";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblPrecioHeader
            // 
            this.lblPrecioHeader.AutoSize = true;
            this.lblPrecioHeader.Location = new System.Drawing.Point(296, 243);
            this.lblPrecioHeader.Name = "lblPrecioHeader";
            this.lblPrecioHeader.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioHeader.TabIndex = 17;
            this.lblPrecioHeader.Text = "Precio:";
            // 
            // lblPrecioValue
            // 
            this.lblPrecioValue.AutoSize = true;
            this.lblPrecioValue.Location = new System.Drawing.Point(296, 270);
            this.lblPrecioValue.Name = "lblPrecioValue";
            this.lblPrecioValue.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioValue.TabIndex = 18;
            this.lblPrecioValue.Text = "xxxxxx";
            // 
            // CatalogoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(745, 438);
            this.Controls.Add(this.lblPrecioValue);
            this.Controls.Add(this.lblPrecioHeader);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.labelCategoriaValue);
            this.Controls.Add(this.labelCategoriaHeader);
            this.Controls.Add(this.labelMarcaHeader);
            this.Controls.Add(this.labelMarcaValue);
            this.Controls.Add(this.labelCodArtValue);
            this.Controls.Add(this.labelCodArtHeader);
            this.Controls.Add(this.labelDescriptionValue);
            this.Controls.Add(this.labelDescriptionHeader);
            this.Controls.Add(this.lbArticulos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(761, 456);
            this.Name = "CatalogoPrincipal";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lbArticulos;
        private System.Windows.Forms.Label labelDescriptionHeader;
        private System.Windows.Forms.Label labelDescriptionValue;
        private System.Windows.Forms.Label labelCodArtHeader;
        private System.Windows.Forms.Label labelCodArtValue;
        private System.Windows.Forms.Label labelMarcaValue;
        private System.Windows.Forms.Label labelMarcaHeader;
        private System.Windows.Forms.Label labelCategoriaHeader;
        private System.Windows.Forms.Label labelCategoriaValue;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblPrecioHeader;
        private System.Windows.Forms.Label lblPrecioValue;
    }
}

