using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Empaques
{
    public class Datosdeinicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new  Categoria();
            categoria1.Descripcion = "Alimentos";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new  Categoria();
            categoria2.Descripcion = "Utileria y oficina";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new  Categoria();
            categoria3.Descripcion = "Electrodomesticos";
            contexto.Categorias.Add(categoria3);

            var tipo1 = new  Tipo();
            tipo1.Descripcion = "Corrugado";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new  Tipo();
            tipo2.Descripcion = "Cartoncillo";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new  Tipo();
            tipo3.Descripcion = "Carton piedra";
            contexto.Tipos.Add(tipo3);


            base.Seed(contexto);
        }
    }
}
