using System;

namespace Animation
{
    class Menu
    {
        public static void Inicio()
        {
            Console.Clear();
            Console.Write(@"███۞███████ ]▄▄▄▄▄▄▄▄▄▄▄▄▃Marcio Marques                    |
▂▄▅█████████▅▄▃▂
I███████████████████].
◥⊙▲⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤…");
            Thread.Sleep(500);

            Frame1();
        }
        public static void Frame1()
        {
            Console.Clear();
            Console.Write(@"۞███████ ]▄▄▄▄▄▄▄▄▄▄▄▄▃     Marcio Marques              |
█████████▅▄▃▂
█████████████████].
⊙▲⊙▲⊙▲⊙▲⊙▲⊙◤…");
            Thread.Sleep(500);

            Frame2();
        }
        public static void Frame2()
        {
            Console.Clear();
            Console.Write(@"███ ]▄▄▄▄▄▄▄▄▄▄▄▄▃          Marcio Marques          |
████▅▄▃▂
████████████].
▲⊙▲⊙▲⊙◤…");
            Thread.Sleep(500);
            Frame3();
        }
        public static void Frame3()
        {
            Console.Clear();
            Console.Write(@"]▄▄▄▄▄▄▄▄▄▄▄▄▃              Marcio Marques      |
▅▄▃▂
████████].
▲⊙◤…");
            Thread.Sleep(500);
            Frame4();
        }
        public static void Frame4()
        {
            Console.Clear();
            Console.Write(@"▄▄▄▄▄▄▄▄▄▃                  Marcio Marques  |

████].
");
            Thread.Sleep(500);
            Frame5();
        }
        public static void Frame5()
        {
            Console.Clear();
            Console.Write(@"▄▄▄▄▄▃                      Marcio Marques|

].
");
            Thread.Sleep(500);
            Frame6();
        }
        public static void Frame6()
        {
            Console.Clear();
            Console.Write(@"▄▃                          Marcio Marqu|

");
            Thread.Sleep(500);
            Fim();
        }
        public static void Fim()
        {
            Console.Clear();
            Console.Write("                             Marcio Mar|");

            Thread.Sleep(500);
            Fim2();
        }
        public static void Fim2()
        {
            Console.Clear();
            Console.Write("                             Marcio M|");

            Thread.Sleep(500);
            Fim3();
        }
        public static void Fim3()
        {
            Console.Clear();
            Console.Write("                             Marcio|");

            Thread.Sleep(1000);
        }
    }
}