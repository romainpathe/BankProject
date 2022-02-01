using System;
using System.Collections.Generic;

namespace Bank
{
    public static class Menu
    {
        #region Menu

        public static void MainMenu() 
        {
           
            float choixMenu = 0;
            string retour;
            bool bquit = false;
            Console.WriteLine(" ---------------- Bienvenue ------------------ " + "\n" + "\n");
            Console.WriteLine("1 : Client");
            Console.WriteLine("2 : Gestionnaire ");
            Console.WriteLine("3 : Quitter " + "\n");
            Console.WriteLine("Veuillez choisir ce que vous voulez faire: ");
            choixMenu = float.Parse(Console.ReadLine());

            switch (choixMenu)
            {
                case 1:
                    {
                        Client();
                        break;
                    }
                case 2:
                    {
                        Gestionnaire();
                        break;
                    }

                case 3:
                    {
                        Quit();
                        bquit = true;
                        break;
                    }
              
                default:
                    {
                        Console.WriteLine("Veuillez saisir un choix valide");
                        choixMenu = float.Parse(Console.ReadLine());
                        break;
                    }
            }
            if (bquit == false)
            {
                Console.WriteLine("\n" + "Voulez-vous retourner au menu principal Y/N ? "); //retour au menu principal
                retour = Console.ReadLine();
                while (retour != "N" && retour != "Y")
                {
                    Console.WriteLine("Veuillez saisir Y OU N : ");
                    retour = Console.ReadLine();
                }

                if (retour == "N")
                {
                    Console.Clear();
                    Quit();
                }
                else
                {
                    Console.Clear();
                    MainMenu();
                }
            }
        }
        #endregion

        #region Menu quit
        static void Quit()// Menu quitter des jeux 
        {
            
            string choix;
            Console.Clear();
            Console.WriteLine("\n" + "Êtes-vous sûr de vouloir quitter l'application Y/N ? :");
            choix = Console.ReadLine();

            while (choix != "Y" && choix != "N")
            {
                choix = Console.ReadLine();
                Console.WriteLine("Veuillez saisir un choix valide ! : ");
            }

            if (choix == "Y")
            {
                Console.Clear();
                Console.WriteLine("\n" + "\n" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t"  + "                           Au plaisir de vous revoir ! ");
            }
            else
            {
                Console.Clear();
                MainMenu();
            }
        }
        #endregion

        static void Client()
        {
            string nom = "" ,prenom = "",code="";
            float choixMenu = 0;
            string retour;
            List<Customer> DataBase = null; 
            bool bquit = false;
            Console.WriteLine(" ~~~~~~~~~ Menu Client ~~~~~~~~~~" + "\n" + "\n");
            Console.WriteLine("Veuillez saisir vos identifiants : ");
            Console.WriteLine("Nom : ");
            nom=Console.ReadLine();
            Console.WriteLine("Prénom : ");
            prenom = Console.ReadLine();
            Console.WriteLine("Code : ");
            code= Console.ReadLine();

            if(VerifCustomer(DataBase, nom, prenom, code))
            {
                Console.WriteLine(" ~~~~~~~~~ Bienvenue "+prenom+" "+nom+" "+" ~~~~~~~~~~" + "\n" + "\n");
                Console.WriteLine("Effectuer un virement");
                Console.WriteLine("Un retrait ou un dépôt");
                Console.WriteLine("Changer d'agence");
                Console.WriteLine("Consulter son solde");
                Console.WriteLine("Quitter ");
                choixMenu = float.Parse(Console.ReadLine());

                switch (choixMenu)
                {
                    case 1:
                        {
                            Virement();
                            break;
                        }
                    case 2:
                        {
                            Retraitoudepot();
                            break;
                        }

                    case 3:
                        {
                            ChangerAgence();
                            break;
                        }

                    case 4:
                        {
                            ConsulterSolde();
                            break;
                        }
                    case 5:
                        {
                            Quit();
                            bquit = true;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Veuillez saisir un choix valide");
                            choixMenu = float.Parse(Console.ReadLine());
                            break;
                        }
                }
                if (bquit == false)
                {
                    Console.WriteLine("\n" + "Voulez-vous retourner au menu principal Y/N ? "); //retour au menu principal
                    retour = Console.ReadLine();
                    while (retour != "N" && retour != "Y")
                    {
                        Console.WriteLine("Veuillez saisir Y OU N : ");
                        retour = Console.ReadLine();
                    }

                    if (retour == "N")
                    {
                        Console.Clear();
                        Quit();
                    }
                    else
                    {
                        Console.Clear();
                        MainMenu();
                    }
                }
            }
            
        }

        static void Gestionnaire()
        {
            string id = "", code = "";
            float choixMenu = 0;
            string retour;
            List<Customer> DataBase = null;
            bool bquit = false;
            Console.WriteLine(" ~~~~~~~~~ Menu Client ~~~~~~~~~~" + "\n" + "\n");
            Console.WriteLine("Veuillez saisir vos identifiants : ");
            Console.WriteLine("Identifiant : ");
            id = Console.ReadLine();
            Console.WriteLine("Code : ");
            code = Console.ReadLine();

            if (VerifGestio(DataBase, id, code))
            {
                Console.WriteLine(" ~~~~~~~~~ Bienvenue " + id + " " + code + " " + " ~~~~~~~~~~" + "\n" + "\n");
                Console.WriteLine("Liste des agences");
                Console.WriteLine("Liste des comptes affiliés à chacune des agences");
                Console.WriteLine("Information de compte");
                Console.WriteLine("Information de chaque client");
                Console.WriteLine("Quitter ");
                choixMenu = float.Parse(Console.ReadLine());

                switch (choixMenu)
                {
                    case 1:
                        {
                            Listeagence();
                            break;
                        }
                    case 2:
                        {
                            listecomptaff();
                            break;
                        }

                    case 3:
                        {
                            Infocmp();
                            break;
                        }

                    case 4:
                        {
                            InfoClient();
                            break;
                        }
                    case 5:
                        {
                            Quit();
                            bquit = true;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Veuillez saisir un choix valide");
                            choixMenu = float.Parse(Console.ReadLine());
                            break;
                        }
                }
                if (bquit == false)
                {
                    Console.WriteLine("\n" + "Voulez-vous retourner au menu principal Y/N ? "); //retour au menu principal
                    retour = Console.ReadLine();
                    while (retour != "N" && retour != "Y")
                    {
                        Console.WriteLine("Veuillez saisir Y OU N : ");
                        retour = Console.ReadLine();
                    }

                    if (retour == "N")
                    {
                        Console.Clear();
                        Quit();
                    }
                    else
                    {
                        Console.Clear();
                        MainMenu();
                    }
                }
            }
        }


        static bool VerifGestio(List<Customer> database, string id, string c)
        {
                if (id=="admin" && c=="admin" )
                {
                    return true;
                }

            return false;
        }
        static bool VerifCustomer(List<Customer>database,string last,string first, string c)
        {
            for(int i=0;i<database.Count;i++)
            {
                if(database[i].Lastname == last && database[i].Firstname==first && database[i].Code==c)
                {
                    return true;
                }
              
            }
            return false;
        }
    }
}