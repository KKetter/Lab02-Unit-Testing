using System;

namespace Lab02_Unit_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Display Application Menu including logo and 4 functions
            Menu();
            //ATMFunction();
            Console.ReadLine();


        }
        public static void Menu()
        {
            Console.WriteLine(@"
    ~~~~~~~~~
   /Automatic\   
  /   Teller  \ 
 /   Machine   \ 
 ~~~~~~~~~~~~~~~~
(1) Display Balance
(2) Deposit Money
(3) Withdrawl Money
(4) Exit
");
        }
        public static void MenuOptions(int menuSelection)
        {
            switch (menuSelection)
            {
                // Display Balance
                case 0:
                    DisplayBalance(Balance);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                // Deposit Money
                case 1:
                    Console.ReadKey();
                
                // Exit Method
                default:
                    Console.Write("Apologies we didnt catch that. Please try again. \nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}

