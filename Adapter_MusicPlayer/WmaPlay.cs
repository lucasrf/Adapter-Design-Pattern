using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_MusicPlayer
{
    class WmaPlay
    {
        public void SetFile(string file)
        {
            Console.WriteLine("Arquivo {0} definido.", file);
        }
        public void Open()
        {
            Console.WriteLine("Arquivo definido foi aberto.");
        }
        public void SetLocation(int posicao = 0) //Caso não seja fornecido um valor para posição, considera 0
        {
            Console.WriteLine("Arquivo com localização definida na posição {0}.", posicao);
        }
        public void Play()
        {
            Console.WriteLine("Arquivo definido foi executado.");
        }
        public void Stop()
        {
            Console.WriteLine("Arquivo definido foi parado.");
        }
    }
}
