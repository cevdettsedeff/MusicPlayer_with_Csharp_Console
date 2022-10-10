using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace MusicPlayer_with_Csharp_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cevdettsedeff

            SoundPlayer voice = new SoundPlayer();
            string adress;

            adress = @"C:\Users\Cevsev\Desktop\Wavfile.wav";

            Console.WriteLine("----------------");

            voice.SoundLocation= adress;

            voice.Play();
            Console.WriteLine("\nMusic is playing...");
            Console.WriteLine("\nIf you want to stop to music, please press the enter!");
            Console.WriteLine("\n----------------");

            Console.ReadLine();

            voice.Stop();

            Console.WriteLine("\nMusic is stopped...");

            //cevdettsedeff

            Console.ReadLine();

        }
    }
}
