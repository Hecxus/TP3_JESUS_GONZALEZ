using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        //comentario prueba push
        public int ID;
        public string Descripcion;
        //public string categoria;

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
