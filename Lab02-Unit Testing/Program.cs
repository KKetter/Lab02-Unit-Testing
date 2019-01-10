using System;

namespace Lab02_Unit_Testing
{
    public class Program
    {
        public static double Balance = 500;
        static void Main(string[] args)
        {
            //Display Application Menu including logo and 4 functions
            Menu();
            ATMFunction();
            Console.ReadLine();


        }
        // Create ATM Logo and Options
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
        // 
        public static void ATMFunction(int menuSelection)
        {
            switch (menuSelection)
            {
                // Display Balance
                case 1:
                    //DisplayBalance(Balance);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                // Deposit Money
                case 2:
                    
                    Console.ReadKey();
                    Console.Clear();
                    break;

                // Withdraw Money
                case 3:

                    Console.ReadKey();
                    Console.Clear();
                    break;

                // Exit App
                case 4:
                    //ExitATM();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                    Console.Write("Apologies we didnt catch that. Please try again. \nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}

