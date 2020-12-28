using System;

namespace Adapter_MusicPlayer
{
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
