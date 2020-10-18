using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{

    public class Carrito
    {
        public List<Articulos> listaArticulos { get; set; }

        public Carrito()
            {
            listaArticulos = new List<Articulos>();
            }

    }
}
