using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRendreLaMonnaie
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                //* Trouver un chiffre aléatoire
                Random alea = new Random();
                decimal x = Math.Round((decimal)alea.NextDouble() * (200 - 1) + 1, 2);

                Console.WriteLine($" Voici le montant à régler: {x}");
                Console.WriteLine("Veuillez saisir le montant à régler (0 pour mettre fin au programme): ");
                decimal montant = decimal.Parse(Console.ReadLine());



                //* Gestion d'erreurs
                if (montant == 0)
                {
                    Console.WriteLine("Fin du programme");
                    return;
                }


                if (x > montant)
                {
                    while (x > montant)
                    {
                        Console.WriteLine($"\nLe montant réglé ne peut être inférieur à {x}");
                        Console.WriteLine("Veuillez re-saisir (0 pour mettre fin au programme):");
                        decimal montant2 = decimal.Parse(Console.ReadLine());
                        if (montant2 == 0) return;
                        montant = montant2;
                        continue;
                    }

                } 

                if (x == montant)
                {
                    Console.WriteLine($"\nMontant réglé : {x}");                    
                }


                //*Calcul du montant à rendre
                decimal montantaRendre = (montant - x);


                //* Compteurs billets
                int billet20 = 0;
                int billet10 = 0;
                int billet5 = 0;
                int piece2 = 0;
                int piece1 = 0;
                int piece50 = 0;
                int piece20 = 0;
                int piece10 = 0;
                int piece05 = 0;
                int piece02 = 0;
                int piece01 = 0;


                //* Affichage du montant à rendre/réglé et détail de la monnaie.                
                if (montant > x)
                {

                    Console.WriteLine($"\nMontant réglé : {montant}");


                    Console.WriteLine($"Montant à rendre {montantaRendre}");
                    Console.WriteLine("\nDétail de votre monnaie:");                    
                }




                //* Billet de 20
                while (montantaRendre >= 20)
                {
                    montantaRendre = montantaRendre - 20;
                    billet20 = billet20 + 1;
                }

                if (billet20 > 1)
                {
                    Console.WriteLine($"{billet20} billets de 20");
                }
                else if (billet20 == 1)
                {
                    Console.WriteLine("1 billet de 20");
                }


                //* Billet de 10
                while (montantaRendre >= 10)
                {
                    montantaRendre = montantaRendre - 10;
                    billet10 = billet10 + 1;
                }

                if (billet10 > 1)
                {
                    Console.WriteLine($"{billet10} billets de 10");
                }
                else if (billet10 == 1)
                {
                    Console.WriteLine("1 billet de 10");
                }


                //* Billet de 5
                while (montantaRendre >= 5)
                {
                    montantaRendre = montantaRendre - 5;
                    billet5 = billet5 + 1;
                }

                if (billet5 > 1)
                {
                    Console.WriteLine($"{billet5} billets de 5");
                }
                else if (billet5 == 1)
                {
                    Console.WriteLine("1 billet de 5");
                }


                //* Pièce de 2
                while (montantaRendre >= 2)
                {
                    montantaRendre = montantaRendre - 2;
                    piece2 = piece2 + 1;
                }

                if (piece2 > 1)
                {
                    Console.WriteLine($"{piece2} pièces de 2");
                }
                else if (piece2 == 1)
                {
                    Console.WriteLine("1 pièce de 2");
                }


                //* Pièce de 1
                while (montantaRendre >= 1)
                {
                    montantaRendre = montantaRendre - 1;
                    piece1 = piece1 + 1;
                }

                if (piece1 > 1)
                {
                    Console.WriteLine($"{piece1} pièces de 1");
                }
                else if (piece1 == 1)
                {
                    Console.WriteLine("1 pièce de 1");
                }


                //* Pièce de 0.50
                while (montantaRendre >= (decimal)0.50)
                {
                    montantaRendre = montantaRendre - (decimal)0.50;
                    piece50 = piece50 + 1;
                }

                if (piece50 > 1)
                {
                    Console.WriteLine($"{piece50} pièces de 50 centimes");
                }
                else if (piece50 == 1)
                {
                    Console.WriteLine("1 pièce de 50 centime");
                }


                //* Pièce de 0.20
                while (montantaRendre >= (decimal)0.20)
                {
                    montantaRendre = montantaRendre - (decimal)0.20;
                    piece20 = piece20 + 1;
                }

                if (piece20 > 1)
                {
                    Console.WriteLine($"{piece20} pièces de 20 centimes");
                }
                else if (piece20 == 1)
                {
                    Console.WriteLine("1 pièce de 20 centime");
                }


                //* Pièce de 0.10
                while (montantaRendre >= (decimal)0.10)
                {
                    montantaRendre = montantaRendre - (decimal)0.10;
                    piece10 = piece10 + 1;
                }

                if (piece10 > 1)
                {
                    Console.WriteLine($"{piece10} pièces de 10 centimes");
                }
                else if (piece10 == 1)
                {
                    Console.WriteLine("1 pièce de 10 centime");
                }


                //* Pièce de 0.05
                while (montantaRendre >= (decimal)0.05)
                {
                    montantaRendre = montantaRendre - (decimal)0.05;
                    piece05 = piece05 + 1;
                }

                if (piece05 > 1)
                {
                    Console.WriteLine($"{piece05} pièces de 5 centimes");
                }
                else if (piece05 == 1)
                {
                    Console.WriteLine("1 pièce de 5 centime");
                }


                //* Pièce de 0.02
                while (montantaRendre >= (decimal)0.02)
                {
                    montantaRendre = montantaRendre - (decimal)0.02;
                    piece02 = piece02 + 1;
                }

                if (piece02 > 1)
                {
                    Console.WriteLine($"{piece02} pièces de 2 centimes");
                }
                else if (piece02 == 1)
                {
                    Console.WriteLine("1 pièce de 2 centime");
                }


                //* Pièce de 0.01
                while (montantaRendre >= (decimal)0.01)
                {
                    montantaRendre = montantaRendre - (decimal)0.01;
                    piece01 = piece01 + 1;
                }

                if (piece01 > 1)
                {
                    Console.WriteLine($"{piece01} pièces de 1 centimes");
                }
                else if (piece01 == 1)
                {
                    Console.WriteLine("1 pièce de 1 centime");
                }


                Console.WriteLine("\n---------------------------------\n");

            }
        }
    }
}
