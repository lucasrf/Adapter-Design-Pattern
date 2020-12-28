using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_MusicPlayer
{
    class Mp3Play : IFormatoAudio
    {
        public void Abrir(string arquivo)
        {
            Console.WriteLine("Arquivo {0} aberto.", arquivo);
        }

        public void Parar()
        {
            Console.WriteLine("Reprodução parada");
        }

        public void Reproduzir()
        {
            Console.WriteLine("Reprodução iniciada.");
        }
    }
}
