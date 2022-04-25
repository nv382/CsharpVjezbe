/*Napisati program za bankare koji ima deklariran pobrojani tip podataka u kojem se nalaze vrste računa (Štednja, Tekući račun, Žiro račun). 
Unutar programa deklarirati strukturu BankAccount koja će sadržavati tri varijable, broj računa, iznos na računu i vrstu računa. 
Program treba deklarirati polje struktura BankAccount od 5 elemenata, 
te napraviti izbornik koji će imati opcije, upisa novog računa, i ispis svih računa.  
Za ispis svih računa koristiti “foreach” iteraciju.*/
using System;
using System.Collections.Generic;
namespace zad3
{
    enum Account : int
    {
        Stednja,
        Tekuci,
        Ziro,

    }

    struct BankAccount
    {
        public string BrojRacuna;
        public string IznosNaRacunu;
        public string VrstaRacuna;
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> list = new(5);
            int action;
            int type;
            while (true)
            {
                Console.WriteLine("You are in main menu - choose an action: \n1 - Add new account \n2 - Print all \n0 - Exit");
                action = Convert.ToInt32(Console.ReadLine());

                if (action == 1)
                {
                    BankAccount temp = new();
                    Console.WriteLine("Insert the account number: ");
                    temp.BrojRacuna = Console.ReadLine();
                    Console.WriteLine("Insert the amount: ");
                    temp.IznosNaRacunu = Console.ReadLine();
                    Console.WriteLine("Choose the account type:\n0){0}\n1){1}\n2){2}", Account.Stednja, Account.Tekuci, Account.Ziro);
                    type = Convert.ToInt32(Console.ReadLine());
                    temp.VrstaRacuna = (Enum.GetName(typeof(Account), type));
                    list.Add(temp);
                }
                else if (action == 2)
                {
                    foreach (BankAccount account in list)
                    {
                        Console.WriteLine("Account number is {0}, available amount is {1} kn, type is {2}.\n", account.BrojRacuna, account.IznosNaRacunu, account.VrstaRacuna);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
