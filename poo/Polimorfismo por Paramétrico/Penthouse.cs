using System;
namespace poo.PolimorfismoporParamétrico
{
    public class Penthouse : InmueblesRecursos
    {
        public Penthouse()
        {
            AgregarPiso();
            AgregarPuertas();
            AgregarVentanas();
            Pintar();
        }
    }
}
