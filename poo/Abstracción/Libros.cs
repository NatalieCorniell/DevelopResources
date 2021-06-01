using System;
namespace poo.Abstracción
{
    public abstract class Libros
    {
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreLibro;

        public Libros(string nombre, double precio, double costo)
        {
            nombreLibro = nombre;
            costoFabrica = costo;
            precioVenta = precio;
        }

        public abstract string ImprimirDatos();
    }

    public class Novela : Libros
    {
        public Novela(string titulo, double precio, double costo)
            : base(titulo, precio, costo){}

        public override string ImprimirDatos()
        {
            return "Novela: " + nombreLibro + ", Precio: " + precioVenta;
        }
    }

    public class Cuento : Libros
    {
        public Cuento(string titulo, double precio, double costo)
            : base(titulo, precio, costo){}
        public override string ImprimirDatos()
        {
            return "Cuento: " + nombreLibro + " Precio: " + precioVenta;
        }

    }
}
