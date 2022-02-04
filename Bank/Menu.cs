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
            List<Customer> DataBase = new List<Customer>();
            Bank bank = new Bank();
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
                            BankAccount account1=GetBankAccount(DataBase);
                            BankAccount account2=GetBankAccount(DataBase);

                            Console.WriteLine("Combien voulez vous tranférer : ");
                            double value=Convert.ToDouble(Console.ReadLine());
                            Console.Write(account1.Transfer(account2, value));
                            break;
                        }
                    case 2:
                        {
                            BankAccount account = GetBankAccount(DataBase);
                            Console.WriteLine("Combien voulez vous tranférer : ");
                            double value = Convert.ToDouble(Console.ReadLine());
                            if (value < 0)
                            {
                                var (b, txt) = account.Withdraw(-value);
                                if (!b)
                                {
                                    Console.WriteLine(txt);
                                }

                            }
                            else
                            {
                                account.Deposit(value);
                            }
                            break;
                        }

                    case 3:
                        {
                            
                           

                            for (int i=0;i<bank.AgencyList.Count;i++)
                            {
                                Console.WriteLine(i+" : "+bank.AgencyList[i]);
                            }
                            Console.WriteLine("Veuillez choisir la nouvelle agence : ");
                            int value=Convert.ToInt32(Console.ReadLine());

                            BankAccount account= GetBankAccount(DataBase);
                            account.Agency = bank.AgencyList[value];

                            break;
                        }

                    case 4:
                        {
                            BankAccount account1 = GetBankAccount(DataBase);
                            Console.WriteLine("Votre solde est de : " + account1.Solde);
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

        static BankAccount GetBankAccount(List<Customer>DataBase)
        {
            Console.WriteLine("Choissisez l'utilisateur : ");
            for (int i = 0; i < DataBase.Count; i++)
            {
                Console.WriteLine(i + " : " + DataBase[i].Lastname + " " + DataBase[i].Firstname);
            }
            int value = int.Parse(Console.ReadLine());
            Customer customer1 = DataBase[value];
            Console.WriteLine("Choissisez le compte  :");
            for (int i = 0; i < DataBase[value].Accounts.Count; i++)
            {
                Console.WriteLine(i + " : " + DataBase[value].Accounts[i].Name);
            }
            int value2 = int.Parse(Console.ReadLine());
           BankAccount account = customer1.Accounts[value2];

            return account;

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