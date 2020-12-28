using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_MusicPlayer
{
    class WmaPlayAdapter : IFormatoAudio
    {
        private readonly WmaPlay _wmaPlay;

        public WmaPlayAdapter(WmaPlay wmaPlay)
        {
            this._wmaPlay = wmaPlay;
        }

        public void Abrir(string arquivo)
        {
            _wmaPlay.SetFile(arquivo);
            _wmaPlay.Open();
        }

        public void Parar()
        {
            _wmaPlay.Stop();
        }

        public void Reproduzir()
        {
            _wmaPlay.SetLocation(0);
            _wmaPlay.Play();
        }
    }
}
