using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plano_Cartesiano_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                X = int.Parse(s[0]);
                Y = int.Parse(s[1]);

                if (X == 0 || Y == 0)
                    break;
                else if (X > 0 && Y > 0)
                    Console.WriteLine("primeiro");
                else if (X > 0 && Y < 0)
                    Console.WriteLine("quarto");
                else if (X < 0 && Y < 0)
                    Console.WriteLine("terceiro");
                else if (X < 0 && Y > 0)
                    Console.WriteLine("segundo");             //Complete o código nos espaços em branco
            }
            Console.ReadLine();
        }
    }
}
