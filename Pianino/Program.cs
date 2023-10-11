using System.Threading;
using System;
using System.Diagnostics;

namespace Pianino
{
    internal class Program
    {
        static int[] l = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
        static void Main()
        {
            Console.WriteLine("Переключние между октавами Ctrl + F(Номер октавы)");
            Console.WriteLine("Можно выбрать октавы в диапазоне 2-8");
            Console.WriteLine("Изначально выбрана 8 октава");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Modifiers.HasFlag(ConsoleModifiers.Control))
                {
                    Oktava(key);
                }
                Clavishi(key);
            }
        }
        static void Oktava(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.F8: l = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 }; Console.WriteLine("Выбрана 8 октава"); break;
                case ConsoleKey.F7: l = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 }; Console.WriteLine("Выбрана 7 октава"); break;
                case ConsoleKey.F6: l = new int[12] { 1046, 1108, 1174, 1244, 1318, 1397, 1480, 1568, 1661, 1760, 1864, 1975 }; Console.WriteLine("Выбрана 6 октава"); break;
                case ConsoleKey.F5: l = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 }; Console.WriteLine("Выбрана 5 октава"); break;
                case ConsoleKey.F4: l = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 }; Console.WriteLine("Выбрана 4 октава"); break;
                case ConsoleKey.F3: l = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 }; Console.WriteLine("Выбрана 3 октава"); break;
                case ConsoleKey.F2: l = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 }; Console.WriteLine("Выбрана 2 октава"); break;
            }
        }
        static void Clavishi(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.Q: Console.Beep(l[0], 100); break;
                case ConsoleKey.W: Console.Beep(l[1], 100); break;
                case ConsoleKey.E: Console.Beep(l[2], 100); break;
                case ConsoleKey.R: Console.Beep(l[3], 100); break;
                case ConsoleKey.T: Console.Beep(l[4], 100); break;
                case ConsoleKey.Y: Console.Beep(l[5], 100); break;
                case ConsoleKey.A: Console.Beep(l[6], 100); break;
                case ConsoleKey.S: Console.Beep(l[7], 100); break;
                case ConsoleKey.D: Console.Beep(l[8], 100); break;
                case ConsoleKey.F: Console.Beep(l[9], 100); break;
                case ConsoleKey.G: Console.Beep(l[10], 100); break;
                case ConsoleKey.H: Console.Beep(l[11], 100); break;
            }
        }
    }
}

/*Console.Write("l = new int[12] {");
for (int i = 0; i < 12; i++)
{

    Console.Write(l[i] / 2);
    Console.Write(", "); 
}
Console.Write("};");*/
