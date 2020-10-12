using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppCatalogo
{
    public partial class FormModificar : Form
    {
        Articulos articulo;
        public FormModificar(Articulos _articulo)
        {
            articulo = _articulo;
            InitializeComponent();

        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbxMarca.DataSource = marcaNegocio.listar();
            txtCodArt.Text = articulo.codArticulo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            txtURL.Text = articulo.Imagen;
            nudPrecio.Value = (decimal)articulo.Precio;

            cbxMarca.ValueMember = "Id";
            cbxMarca.DisplayMember = "Descripcion";
            cbxMarca.SelectedValue = articulo.marca.ID;
            //

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoria.DataSource = categoriaNegocio.listar();

            //cbxCategoria.ValueMember = "Id";
            //cbxCategoria.DisplayMember = "Descripcion";
            //cbxCategoria.SelectedValue = articulo.categoria.ID;
            //

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulos artTemporal = new Articulos();

            artTemporal.ID = articulo.ID;
            artTemporal.codArticulo = txtCodArt.Text;
            artTemporal.Nombre = txtNombre.Text;
            artTemporal.Descripcion = txtDescripcion.Text;
            artTemporal.categoria = new Categoria();
            artTemporal.categoria.ID = ((Categoria)cbxCategoria.SelectedItem).ID;

            artTemporal.marca = new Marca();
            artTemporal.marca.ID = ((Marca)cbxMarca.SelectedItem).ID;

            artTemporal.Precio = (float)nudPrecio.Value;
            artTemporal.Imagen = txtURL.Text;
            if (negocio.modificar(artTemporal))
            {
                MessageBox.Show("Articulo modificado correctamente.");
                Close();
            }
            else
            {
                MessageBox.Show("El articulo no pudo ser modificado.");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
