namespace FormsAppCatalogo
{
    partial class frmBuscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.nudPrecioMin = new System.Windows.Forms.NumericUpDown();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.nudPrecioMax = new System.Windows.Forms.NumericUpDown();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.chbCategoria = new System.Windows.Forms.CheckBox();
            this.chbMarca = new System.Windows.Forms.CheckBox();
            this.chbPrecio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rellene los campos de busqueda que quiere usar o deje en blanco los que quiera ig" +
    "norar.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(86, 210);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(67, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio entre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(90, 174);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(106, 138);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(110, 98);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Codigo:";
            // 
            // nudPrecioMin
            // 
            this.nudPrecioMin.BackColor = System.Drawing.Color.Gainsboro;
            this.nudPrecioMin.Location = new System.Drawing.Point(207, 208);
            this.nudPrecioMin.Maximum = new decimal(new int[] {
            499999,
            0,
            0,
            0});
            this.nudPrecioMin.Name = "nudPrecioMin";
            this.nudPrecioMin.Size = new System.Drawing.Size(75, 20);
            this.nudPrecioMin.TabIndex = 6;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.tbCodigo.Location = new System.Drawing.Point(207, 90);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(176, 20);
            this.tbCodigo.TabIndex = 7;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.tbNombre.Location = new System.Drawing.Point(207, 131);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(176, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDescripcion.Location = new System.Drawing.Point(207, 167);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(176, 20);
            this.tbDescripcion.TabIndex = 9;
            // 
            // nudPrecioMax
            // 
            this.nudPrecioMax.BackColor = System.Drawing.Color.Gainsboro;
            this.nudPrecioMax.Location = new System.Drawing.Point(316, 208);
            this.nudPrecioMax.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPrecioMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecioMax.Name = "nudPrecioMax";
            this.nudPrecioMax.Size = new System.Drawing.Size(67, 20);
            this.nudPrecioMax.TabIndex = 10;
            this.nudPrecioMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(101, 247);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(116, 283);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Gainsboro;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(207, 244);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(176, 21);
            this.cbCategoria.TabIndex = 13;
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.Gainsboro;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(207, 275);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(176, 21);
            this.cbMarca.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 359);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(316, 359);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // chbCategoria
            // 
            this.chbCategoria.AutoSize = true;
            this.chbCategoria.Checked = true;
            this.chbCategoria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCategoria.Location = new System.Drawing.Point(398, 248);
            this.chbCategoria.Name = "chbCategoria";
            this.chbCategoria.Size = new System.Drawing.Size(119, 17);
            this.chbCategoria.TabIndex = 17;
            this.chbCategoria.Text = "Incluir en busqueda";
            this.chbCategoria.UseVisualStyleBackColor = true;
            this.chbCategoria.CheckedChanged += new System.EventHandler(this.chbCategoria_CheckedChanged);
            // 
            // chbMarca
            // 
            this.chbMarca.AutoSize = true;
            this.chbMarca.Checked = true;
            this.chbMarca.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMarca.Location = new System.Drawing.Point(398, 279);
            this.chbMarca.Name = "chbMarca";
            this.chbMarca.Size = new System.Drawing.Size(119, 17);
            this.chbMarca.TabIndex = 18;
            this.chbMarca.Text = "Incluir en busqueda";
            this.chbMarca.UseVisualStyleBackColor = true;
            this.chbMarca.CheckedChanged += new System.EventHandler(this.chbMarca_CheckedChanged);
            // 
            // chbPrecio
            // 
            this.chbPrecio.AutoSize = true;
            this.chbPrecio.Checked = true;
            this.chbPrecio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPrecio.Location = new System.Drawing.Point(398, 209);
            this.chbPrecio.Name = "chbPrecio";
            this.chbPrecio.Size = new System.Drawing.Size(119, 17);
            this.chbPrecio.TabIndex = 19;
            this.chbPrecio.Text = "Incluir en busqueda";
            this.chbPrecio.UseVisualStyleBackColor = true;
            this.chbPrecio.CheckedChanged += new System.EventHandler(this.chbPrecio_CheckedChanged);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.chbPrecio);
            this.Controls.Add(this.chbMarca);
            this.Controls.Add(this.chbCategoria);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.nudPrecioMax);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.nudPrecioMin);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuscar";
            this.Text = "Busqueda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBuscar_FormClosed);
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.NumericUpDown nudPrecioMin;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.NumericUpDown nudPrecioMax;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox chbCategoria;
        private System.Windows.Forms.CheckBox chbMarca;
        private System.Windows.Forms.CheckBox chbPrecio;
    }
}