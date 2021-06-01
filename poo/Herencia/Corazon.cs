using System;
namespace poo.Herencia
{
    public class Corazon
    {
        public bool Sangre { get; set; }
    }

    public class VenaYugular : Corazon{
        private void Herencia()
        {
            Console.WriteLine("Esta vena esta resiviendo sangre? : " +
                (this.Sangre == true ? "si" : "no"));
        }
    }
    class VenaSubClavia : Corazon
    {
        private void Herencia()
        {
            Console.WriteLine("Esta vena esta resiviendo sangre? : " +
               (this.Sangre == true ? "si" : "no"));
        }
    }
}
