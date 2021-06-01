using System;
namespace poo.Encapsulamiento
{
    public class Perritos
    {
        //Atributos
        private int _fechaNacimiento;
        //Propiedades
        public int FechaNacimiento
        {
            get //Encapsulación nivel abierto por defecto.
            {
                return _fechaNacimiento;
            }
            private set //Encapsulación nivel cerrado- Privado
            {
                _fechaNacimiento = value;
            }
        }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public void VerRaza()
        {
            Console.WriteLine("La raza del perrito es: " + Raza);
        }
        private void CalEdad(DateTime _fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            Edad = fechaActual.Year - _fechaNacimiento.Year;
        }
    }
}