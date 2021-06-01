using System;
namespace poo.Polimorfismoporinclusion
{
    public  abstract class VisitaInmuebles
    {
        public abstract void Direccion(string ruta);
    }
    public class LocalComercial : VisitaInmuebles
    {
        public override void Direccion(string ruta)
        {
            Console.WriteLine("Esta es la ruta: " + ruta);
        }
    }
    public class Penthouse : VisitaInmuebles
    {
        public override void Direccion(string ruta)
        {
            Console.WriteLine("Esta es la ruta: " + ruta);
        }
    }
    public class CasaOrdinaria : VisitaInmuebles
    {
        public override void Direccion(string ruta)
        {
            Console.WriteLine("Esta es la ruta: " + ruta);
        }
    }
}
