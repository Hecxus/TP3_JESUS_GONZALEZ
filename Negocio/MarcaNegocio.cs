using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcaNegocio
    {
        string rutaBaseDatos = "data source = MATIASLENOVO\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
        public List<Marca> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Marca> lista = new List<Marca>();

            conexion.ConnectionString = rutaBaseDatos;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT Id, Descripcion FROM MARCAS";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Marca aux = new Marca();
                aux.ID = lector.GetInt32(0);
                aux.Descripcion = lector.GetString(1);

                lista.Add(aux);
            }
            lector.Close();
            conexion.Close();
            return lista;
        }
        public Marca obtenerMarca(int id)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            Marca aux = new Marca();

            conexion.ConnectionString = rutaBaseDatos;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT Id, Descripcion FROM MARCAS where id= " + id.ToString();
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
