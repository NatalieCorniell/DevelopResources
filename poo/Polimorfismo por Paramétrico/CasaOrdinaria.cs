using System;
namespace poo.PolimorfismoporParamétrico
{
    public class CasaOrdinaria : InmueblesRecursos
    {
        public CasaOrdinaria()
        {
            AgregarPiso();
            AgregarPuertas();
            AgregarVentanas();
            Pintar();
        }
    }
}
