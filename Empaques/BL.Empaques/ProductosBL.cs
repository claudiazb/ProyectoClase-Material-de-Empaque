using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Empaques
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Cajas para pizza";
            producto1.Precio = 15;
            producto1.Existencia = 100;
            producto1.Activo = true;

            ListaProductos.Add(producto1);


            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Cajas para zapatos";
            producto2.Precio = 12;
            producto2.Existencia = 0;
            producto2.Activo = false;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Bolsa papel kraft";
            producto3.Precio = 8;
            producto3.Existencia = 50;
            producto3.Activo = true;

            ListaProductos.Add(producto3);
        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }

  }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }

}
