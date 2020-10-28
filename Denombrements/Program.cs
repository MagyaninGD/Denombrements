/**
 * titre: Denombrement
 * auteur: magyanin
 * date création: 27/10/2020
 * date dernière modification: 27/10/2020
 */

using System;
using System.Security.Cryptography;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1, nbElements, nbSousEnsemble;
            long r;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());
                

                switch (c)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        //saisie du nombre d'éléments à gérer
                        nbElements = saisie("nombre total d'éléments à gérer =");
                        //calcul de r
                        r = 1;
                        r = piProduit(1, nbElements, r);
                        Console.WriteLine(nbElements + "! = " + r);
                        break;
                    case 2:
                        //saisie du nombre d'éléments à gérer
                        nbElements = saisie("nombre total d'éléments à gérer");
                        //saisie du nombre d'éléments à gérer dans le sous ensemble
                        nbSousEnsemble = saisie("nombre total d'éléments dans le sous  ensemble =");
                        // calcul de r
                        r = 1;
                        r = piProduit((nbElements - nbSousEnsemble + 1), nbElements, r);
                        Console.WriteLine("A(" + nbElements + "/" + nbSousEnsemble + ") = " + r);
                        break;
                    case 3:
                        //saisie du nombre d'éléments à gérer
                        nbElements = saisie("nombre total d'éléments à gérer = ");

                        //saisie du nombre d'éléments à gérer dans le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        nbSousEnsemble = saisie("nombre d'éléments dans le sous ensemble = ");
                        // calcul de r1
                        long r1 = 1;
                        r1 = piProduit((nbElements - nbSousEnsemble + 1), nbElements, r1);
                        // calcul de r2
                        long r2 = 1;
                        r2 = piProduit(1, nbSousEnsemble, r2);
                        Console.WriteLine("C(" + nbElements + "/" + nbSousEnsemble + ") = " + (r1 / r2));
                        break;
                    default:
                        Console.WriteLine("Entrez un nombre entier entre 0 et 3");
                        break;

                }               
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Permet la saisie du nombre total d'éléments à gérer
        /// </summary>
        /// <param name="message">Le message à afficher lors de la saisie</param>
        /// <returns>Le nombre saisit par l'utilisateur</returns>
        static int saisie(string message)
        {
            Console.Write(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        /// <summary>
        /// Multiplication d'une suite d'entier
        /// </summary>
        /// <param name="valDepart">La valeur de départ</param>
        /// <param name="valFin">La valeur finale</param>
        /// <param name="produit">La valeur du produit de base</param>
        /// <returns>Le produit de tous les facteurs indexés de valDébut à valFin</returns>
        static long piProduit(int valDepart,int valFin, long produit)
        {
            for (int k = valDepart; k <= valFin; k++)
            {
                produit *= k;
            }
            return produit;
        }

    }
}
