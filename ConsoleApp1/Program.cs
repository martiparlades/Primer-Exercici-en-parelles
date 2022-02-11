using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public const int Row = 3;
        public const int Col = 3;
        private static string[,] resultats = new string[Row, Col] {
            { "Empat","Perds","Guanyes"},
            { "Guanyes","Empat","Perds"},
            { "Perds","Guanyes","Empat"}
        };


        static void Main(string[] args)
        {
            
            bool jugar = true;
            int nRondes = 0, nGuanyades = 0;

            Console.WriteLine("Benvingut a Pedra/Paper/Tisores");   // Mostrem missatge de benvinguda al joc
            Console.WriteLine("Prem qualsevol tecla per començar a jugar");
            Console.ReadKey();
            Console.WriteLine(resultats[0,1]);

            while (jugar == true) // mentre jugar == true
            {
                int a;
                a = OptionUser(); // cridem al metode opcioUsuari per obtenir la seva opció

                Random rnd = new Random();
                int b = rnd.Next(1, 4); // cridem al mètode Random.Next per obtenir l'opció de l'ordinador a l'atzar
                CheckWinWin(a, b); // cridem al mètode comprovarQuiGuanya per veure qui guanya
                nRondes++; // augmentem nRondes
                Console.WriteLine(b);
                if(resultats[a-1,b-1] == "Guanyes") // augmentem nGuanyades
                {
                    nGuanyades++;
                }

                Console.WriteLine();
                Console.WriteLine("RONDES JUGADES : {0} ", nRondes); // mostrem el nombre de rondes jugades
                Console.WriteLine("RONDES GUANYADES : {0} ", nGuanyades); // mostrem el nombre de rondes guanyades
                continuarJugant(); // tornar a l'inici del bucle
            }
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
            string A = null;
            string B = null;
            string C;

            if (a == 1)
            {
                A = "PEDRA";
            }
            if (a == 2)
            {
                A = "PAPER";
            }
            if (a == 3)
            {
                A = "TISORA";
            }
            if (b == 1)
            {
                B = "PEDRA";
            }
            if (b == 2)
            {
                B = "PAPER";
            }
            if (b == 3)
            {
                B = "TISORA";
            }
            Console.WriteLine("        Usuari:" + " " + A);
            Console.WriteLine("        Ordinador:" + " " + B);

            if (a == 1 && b == 1)
            {
                C = resultats[0, 0];
            }

            else if (a == 1 && b == 2)
            {
                C = resultats[0, 1];
            }

            else if (a == 1 && b == 3)
            {
                C = resultats[0, 2];
            }

            else if (a == 2 && b == 1)
            {
                C = resultats[1, 0];
            }

            else if (a == 2 && b == 2)
            {
                C = resultats[1, 1];
            }

            else if (a == 2 && b == 3)
            {
                C = resultats[1, 2];
            }

            else if (a == 3 && b == 1)
            {
                C = resultats[2, 0];
            }

            else if (a == 3 && b == 2 )
            {
                C = resultats[2, 1];
            }

            else
            {
                C = resultats[2, 2];
            }

            Console.WriteLine("        " + C);
        }

        private static bool continuarJugant()
        {
            Console.WriteLine("Vols continuar jugant? (SI/NO)");
            string answer = Console.ReadLine();

            if (answer.ToUpper() == "SI")
            {
                return true;
            }
            else if (answer.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                continuarJugant();
                return false;
            }


        }


    }
}
