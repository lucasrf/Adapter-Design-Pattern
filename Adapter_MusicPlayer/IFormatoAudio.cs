using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_MusicPlayer
{
    public interface IFormatoAudio
    {
        void Abrir(string arquivo);
        void Reproduzir();
        void Parar();
    }
}
