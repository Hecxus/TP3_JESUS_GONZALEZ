using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.AccessControl;

namespace Negocio
{
    public class ArticuloNegocio
    {
        string rutaBaseDatos = "data source = MATIASLENOVO\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
        public List<Articulos> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulos> lista = new List<Articulos>();
            
            conexion.ConnectionString = rutaBaseDatos;
            comando.CommandType = System.Data.CommandType.Text;
            //SELECT id,codigo,Nombre, descripcion,idMarca,idCategoria, ImagenUrl FROM ARTICULO
            comando.CommandText = "SELECT ARTICULOS.id,ARTICULOS.codigo,ARTICULOS.Nombre, ARTICULOS.descripcion,ARTICULOS.idMarca,ARTICULOS.idCategoria, MARCAS.Descripcion Marca, CATEGORIAS.Descripcion,ARTICULOS.precio, ImagenUrl FROM ARTICULOS, CATEGORIAS, MARCAS WHERE ARTICULOS.IdCategoria = CATEGORIAS.Id AND ARTICULOS.IdMarca = MARCAS.Id ";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while(lector.Read())
            {
                Articulos aux = new Articulos();
                aux.ID= lector.GetInt32(0);


                try {aux.codArticulo = lector.GetString(1); 
                }catch (Exception E)
                {aux.codArticulo = "Sin codigo";}
                
                aux.Nombre = lector.GetString(2);

                try { aux.Descripcion = lector.GetString(3);
                }catch { aux.Descripcion = "Sin descripcion"; }




                aux.marca = new Marca();
                aux.categoria = new Categoria();
                aux.marca.ID = lector.GetInt32(4);
                aux.categoria.ID = lector.GetInt32(5);

                aux.marca.Descripcion = lector.GetString(6);
                aux.categoria.Descripcion = lector.GetString(7);

                aux.Precio = (float)lector.GetDecimal(8);

                

                try
                {
                    aux.Imagen = (string)lector["ImagenUrl"];
                }
                catch (Exception E)
                {

                }
                lista.Add(aux);
            }
            lector.Close();
            conexion.Close();
            return lista;
        }



        public List<Articulos> listarConBusqueda(string query)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulos> lista = new List<Articulos>();

            conexion.ConnectionString = rutaBaseDatos;
            comando.CommandType = System.Data.CommandType.Text;
            //SELECT id,codigo,Nombre, descripcion,idMarca,idCategoria, ImagenUrl FROM ARTICULO
            comando.CommandText = "SELECT id,codigo,Nombre, descripcion,idMarca,idCategoria,precio,  ImagenUrl FROM ARTICULOS WHERE "+query;
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Articulos aux = new Articulos();
                aux.ID = lector.GetInt32(0);

                try
                {
                    aux.codArticulo = lector.GetString(1);
                }
                catch (Exception E)
                { aux.codArticulo = "Sin codigo"; }

                aux.Nombre = lector.GetString(2);

                try
                {
                    aux.Descripcion = lector.GetString(3);
                }
                catch { aux.Descripcion = "Sin descripcion"; }



                aux.categoria = new CategoriaNegocio().obtenerCategoria(lector.GetInt32(4));
                aux.marca = new MarcaNegocio().obtenerMarca(lector.GetInt32(5));
                aux.Precio = (float)lector.GetDecimal(6);

                try
                {
                    aux.Imagen = (string)lector["ImagenUrl"];
                }
                catch (Exception E)
                {

                }
                lista.Add(aux);
            }
            lector.Close();
            conexion.Close();
            return lista;
        }

        public bool modificar(Articulos actualizar)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = rutaBaseDatos;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = " UPDATE ARTICULOS SET codigo = @Codigo, nombre= @Nombre, Descripcion = @Descripcion,IdCategoria = @IdCategoria, IdMarca = @IdMarca , Precio = @Precio ,ImagenUrl = @ImagenUrl WHERE Id = @ID";
                comando.Parameters.AddWithValue("@Codigo", actualizar.codArticulo);
                comando.Parameters.AddWithValue("@Nombre", actualizar.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", actualizar.Descripcion);
                comando.Parameters.AddWithValue("@IdCategoria", actualizar.categoria.ID);
                comando.Parameters.AddWithValue("@IdMarca", actualizar.marca.ID);
                comando.Parameters.AddWithValue("@Precio", actualizar.Precio);
                comando.Parameters.AddWithValue("@ImagenUrl", actualizar.Imagen);
                comando.Parameters.AddWithValue("@ID", actualizar.ID);


                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();
                return true;
            }catch
            {
                return false;
            }

        }

        public void agregar(Articulos nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = rutaBaseDatos;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio,imagenurl) " + "VALUES('"+nuevo.codArticulo+"','" +
                nuevo.Nombre +"', '" + nuevo.Descripcion + "', " + nuevo.marca.ID + ", " + nuevo.categoria.ID +", '"+ nuevo.Precio +"','"+nuevo.Imagen+"')";
            
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
        }


        public bool Delete(Articulos articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            { 
                conexion.ConnectionString = rutaBaseDatos;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = String.Format("delete from articulos where id = {0}",articulo.ID);
            
                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();
                return true;
            }catch
            {
                return false;
            }
        }
    }
}
