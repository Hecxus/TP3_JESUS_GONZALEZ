using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {

        string rutaBaseDatos = "data source = DESKTOP-FDLLM2V\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
        public List<Categoria> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Categoria> lista = new List<Categoria>();

            conexion.ConnectionString = rutaBaseDatos;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT Id, Descripcion FROM CATEGORIAS";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Categoria aux = new Categoria();
                aux.ID= lector.GetInt32(0);
                aux.Descripcion = lector.GetString(1);

                lista.Add(aux);
            }
            lector.Close();
            conexion.Close();
            return lista;
        }

        public Categoria obtenerCategoria(int id)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            Categoria aux = new Categoria();

            conexion.ConnectionString = rutaBaseDatos;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT Id, Descripcion FROM CATEGORIAS where id= "+id.ToString();
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            if (lector.Read())
            {
                aux.ID = lector.GetInt32(0);
                aux.Descripcion = lector.GetString(1);
            }
            lector.Close();
            conexion.Close();
            return aux;
        }

    }
}
