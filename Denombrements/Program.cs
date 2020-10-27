/**
 * titre: Denombrement
 * auteur: magyanin
 * date création: 27/10/2020
 * date dernière modification: 27/10/2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) {
                    Environment.Exit(0);
                }

                if (c == 1)
                {
                    //saisie du nombre d'éléments à gérer
                    Console.Write("nombre total d'éléments à gérer = "); 
                    int n = int.Parse(Console.ReadLine()); 
                    //calcul de r                                       
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                    {
                        r *= k;
                    }
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        //saisie du nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int t = int.Parse(Console.ReadLine());
                        //saisie du nombre d'éléments à gérer dans le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int n = int.Parse(Console.ReadLine()); 
                        // calcul de r
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r *= k;
                        }
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        //saisie du nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        //saisie du nombre d'éléments à gérer dans le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int n = int.Parse(Console.ReadLine());
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r1 *= k;
                        }
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                        {
                            r2 *= k;
                        }
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
