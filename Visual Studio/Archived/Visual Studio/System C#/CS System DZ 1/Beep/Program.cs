using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Beep
{
    //    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    //    public static void Beep(int frequency, int duration);

    //    [DllImport("user32.dll")]
    //    internal static extern bool MessageBeep(
    //  uint uType
    //);


    //[DllImport("kernel32.dll")]
    //public static extern bool Beep(int freq, int duration);

    class Program
    {
        public static void Main()
        {
            
            Note[] Mary =
                {
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.GbelowC, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.B, Duration.HALF),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.A, Duration.HALF),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.D, Duration.QUARTER),
        new Note(Tone.D, Duration.HALF)
        };
           
            Play(Mary);
        }

       
        public static void Play(Note[] tune)
        {
            // Marry
            foreach (Note n in tune)
            {
                if (n.toneVal == Tone.REST)
                {
                    Thread.Sleep((int)n.durVal);
                }
                else
                {
                    Console.Beep((int)n.toneVal, (int)n.durVal);
                }

            }

            /// Star wars
            /// 
            Thread.Sleep(3000);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
        }

   
        public enum Tone
        {
            REST = 0,
            GbelowC = 196,
            A = 220,
            Asharp = 233,
            B = 247,
            C = 262,
            Csharp = 277,
            D = 294,
            Dsharp = 311,
            E = 330,
            F = 349,
            Fsharp = 370,
            G = 392,
            Gsharp = 415,
        }

     
        public enum Duration
        {
            WHOLE = 1600,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        public struct Note
        {
            public Tone toneVal;
            public Duration durVal;

            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

           
          
        }
    }
}

