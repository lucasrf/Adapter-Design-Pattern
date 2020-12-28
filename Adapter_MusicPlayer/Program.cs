using System;

namespace Adapter_MusicPlayer
{
    public interface IFormatoAudio
    {
        void Abrir(string arquivo);
        void Reproduzir();
        void Parar();
    }
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
    class Program
    {
        static void Main(string[] args)
        {
            WmaPlayAdapter wmaPlay = new WmaPlayAdapter(new WmaPlay());
            Mp3Play mp3Play = new Mp3Play();
            WavPlay wavPlay = new WavPlay();
            string arquivoWma = "C:/Musicas/baroes_da_pisadinha.wma";
            string arquivoMp3 = "C:/Musicas/nerdcast_757.mp3";
            string arquivoWav = "C:/Musicas/dingle_bells.wav";
            IFormatoAudio reprodutor;

            Console.WriteLine("Testando arquivo WMA:");
            reprodutor = wmaPlay;
            reprodutor.Abrir(arquivoWma);
            reprodutor.Reproduzir();
            reprodutor.Parar();

            Console.WriteLine("\nTestando arquivo MP3:");
            reprodutor = mp3Play;
            reprodutor.Abrir(arquivoMp3);
            reprodutor.Reproduzir();
            reprodutor.Parar();

            Console.WriteLine("\nTestando arquivo WAV:");
            reprodutor = wavPlay;
            reprodutor.Abrir(arquivoWav);
            reprodutor.Reproduzir();
            reprodutor.Parar();

            Console.ReadKey();
        }
    }
}
