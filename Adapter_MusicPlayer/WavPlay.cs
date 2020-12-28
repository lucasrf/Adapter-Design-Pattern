using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_MusicPlayer
{
    class WavPlay : IFormatoAudio
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
