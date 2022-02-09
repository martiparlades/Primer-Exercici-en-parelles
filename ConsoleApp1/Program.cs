using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public const int Row = 4;
        public const int Col = 3;
        private static string[,] resultats = new string[Row, Col] {
            { "Empat","Perds","Guanyes"},
            {"Guanyes","Empat","Perds"},
            { "Perds","Guanyes","Empat"},
            { "Perds","Guanyes","Empat"}
        };


        static void Main(string[] args)
        {
            int a;
            Random rnd = new Random();
            int b = rnd.Next(1, 3);
            a = OptionUser();
            CheckWinWin(a, b);
            continuarJugant();
            Console.ReadKey();
        }


        private static int OptionUser()
        {
            Console.WriteLine("Selecciona una opcio (1, 2 o 3)");
            Console.WriteLine("1->PEDRA");
            Console.WriteLine("2->PAPER");
            Console.WriteLine("3->TISORA");
            string input = Console.ReadLine();
            int enter;
            bool ok = int.TryParse(input, out enter);
            //Console.WriteLine(enter);
            //Console.WriteLine(ok);
            if (enter > 3 || enter < 1 || ok == false)
            {
                OptionUser();
            }
            return enter;
        }

        private static void CheckWinWin(int a, int b)
        {
            string A;
            string B;
            string C;
            if (a == 1)
            {
                A = "PEDRA";
            }
            else if (a == 2)
            {
                A = "PAPER";
            }
            else
            {
                A = "TISORA";
            }
            if (b == 1)
            {
                B = "PEDRA";
            }
            else if (b == 2)
            {
                B = "PAPER";
            }
            else
            {
                B = "TISORA";
            }
            Console.WriteLine("        Usuari:" + " " + A);
            Console.WriteLine("        Ordinador:" + " " + B);

            if (a == b)
            {
                C = resultats[1, 1];
            }
            else if (a == 1 && b == 2)
            {
                C = resultats[1, 2];
            }
            else if (a == 1 && b == 3)
            {
                C = resultats[1, 3];
            }
            else if (a == 2 && b == 1)
            {
                C = resultats[2, 1];
            }
            else if (a == 2 && b == 3)
            {
                C = resultats[2, 3];
            }
            else if (a == 3 && b == 1)
            {
                C = resultats[3, 1];
            }
            else if (a == 3 && b == 2)
            {
                C = resultats[3, 2];
            }
            else
            {
                C = resultats[1, 1];
            }

            Console.WriteLine("        " + C);
        }

        private static void continuarJugant()
        {

        }


    }
}
