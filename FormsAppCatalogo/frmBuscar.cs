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
    public partial class frmBuscar : Form
    {
        string queryDinamica;
        int queryParameters = 0;
        public List<Articulos> articulos;
        bool busquedaExitosa = false;
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text != String.Empty)
            {
                queryDinamica += String.Format("codigo = '{0}' ", tbCodigo.Text);
                queryParameters++;
            }
            if (tbNombre.Text != String.Empty)
            {
                if (queryParameters != 0) queryDinamica += " and ";
                queryDinamica += String.Format("nombre = '{0}'", tbNombre.Text);
                queryParameters++;
            }
            if (tbDescripcion.Text != String.Empty)
            {
                if (queryParameters != 0) queryDinamica += " and ";
                queryDinamica += String.Format(" descripcion = '{0}'", tbDescripcion.Text);
                queryParameters++;
            }

            if (chbPrecio.Checked)
            {
                if (queryParameters != 0) queryDinamica += " and ";
                queryDinamica += String.Format(" precio  >= {0} and precio <= {1} ", nudPrecioMin.Value, nudPrecioMax.Value);
            }

            if (chbCategoria.Checked)
            {
                if (queryParameters != 0) queryDinamica += " and ";
                queryDinamica += String.Format(" idcategoria = {0} ", ((Categoria)cbCategoria.SelectedItem).ID);
            }
            if (chbMarca.Checked)
            {
                if (queryParameters != 0) queryDinamica += " and ";
                queryDinamica += String.Format(" idmarca = {0} ", ((Marca)cbMarca.SelectedItem).ID);
            }



            //MessageBox.Show(queryDinamica);

            articulos = new ArticuloNegocio().listarConBusqueda(queryDinamica);

            queryDinamica = String.Empty;
            queryParameters = 0;
            if (articulos.Count()>0)
            {
                busquedaExitosa = true;
                Close();
            }
            else
            {
                MessageBox.Show("La busqueda no trajo resultados.");
            }
            //queryDinamica= 
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = new CategoriaNegocio().listar();
            cbMarca.DataSource = new MarcaNegocio().listar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            articulos = new List<Articulos>();
            Close();
        }

        private void chbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            nudPrecioMin.Enabled = chbPrecio.Checked;
            nudPrecioMax.Enabled = chbPrecio.Checked;
        }

        private void frmBuscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!busquedaExitosa)
                articulos = new List<Articulos>();
        }

        private void chbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoria.Enabled = chbCategoria.Checked;
        }

        private void chbMarca_CheckedChanged(object sender, EventArgs e)
        {
            cbMarca.Enabled = chbMarca.Checked;
        }
    }
}
