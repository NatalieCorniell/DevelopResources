using System;
namespace poo
{
    //Natalie's code ejemplo: Polimorfismo por Sobrecarga
    public class Inmuebles
    {
        public void Inmueble(int numeroSalas, int numeroHab, bool galeria,
            int numerococina, int numerobaño)
        {
            Console.WriteLine("Esta es una casa Ordinaria!");
            Console.WriteLine("Número de salas: " + numeroSalas);
            Console.WriteLine("Número de habitaciones: " + numeroHab);
            Console.WriteLine("Número de cocina: " + numerococina);
            Console.WriteLine("Número de baños: " + numerobaño);
            Console.WriteLine(galeria == true ? "Llevara galeria" : "No llevara galeria");
        }
        public void Inmueble(int numeroSalas, int numeroHab, bool galeria, int numerococina,
            int numerobaño, bool terraza, int noCuartoServicio)
        {
            Console.WriteLine("Este inmueble es un Penthouse!");
            Console.WriteLine("Número de salas: " + numeroSalas);
            Console.WriteLine("Número de habitaciones: " + numeroHab);
            Console.WriteLine("Número de cocina: " + numerococina);
            Console.WriteLine("Número de baños: " + numerobaño);
            Console.WriteLine(galeria == true ? "Llevara galeria" : "No llevara galeria");
            Console.WriteLine(terraza == true ? "Llevara terraza" : "No llevara terraza");
            Console.WriteLine("Número de Cuarto de Servicio: " + noCuartoServicio);
        }
        public void Inmueble(int salones, int baños)
        {
            Console.WriteLine("Este inmueble es un Local Comercial!");
            Console.WriteLine("Número de salas: " + salones);
            Console.WriteLine("Número de habitaciones: " + baños);
        }
    }
}
