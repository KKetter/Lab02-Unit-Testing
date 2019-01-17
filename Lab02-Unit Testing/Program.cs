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
            Console.ReadLine();

        }
        // Create ATM Logo and Options, Capture User Input
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
How can we help you?
Enter (1-4) an operation!
");
            try
            {
                int menuInput = Convert.ToInt32(Console.ReadLine());
                ATMFunction(menuInput);
            }
            catch (Exception)
            {

                Console.Write("Sorry something went wrong. Try again.\nPress Enter to Continue.");
                Console.ReadKey();
                Console.Clear();
            }
            finally
            {
                Menu();
            }
        }
        // handle atm Functions
        public static void ATMFunction(int menuSelection)
        {
            switch (menuSelection)
            {
                // Display Balance
                case 1:
                    DisplayBalance(Balance);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                // Deposit Money
                case 2:
                    Console.Write("Type an amount of money to deposit: ");
                    string userInput = Console.ReadLine();
                    double systemInput = Convert.ToDouble(userInput);
                    Balance = NewDeposit(Balance, systemInput);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                // Withdraw Money
                case 3:
                    Console.Write("Type an amount to withdraw: ");
                    string userInput3 = Console.ReadLine();
                    double systemInput3 = Convert.ToDouble(userInput3);
                    Balance = NewWithdraw(Balance, systemInput3);
                    Console.ReadKey();
                    Console.Clear();
                    break;

                // Exit App
                case 4:
                    ExitAtm();
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
        // print balance to screen
        public static double DisplayBalance(double Balance)
        {
            Console.Write($"Your balance is ${Balance}\nPress any key to continue.");
            return Balance;
        }
        // modify balance with deposit transactions
        public static double NewDeposit(double Balance, double systemInput)
        {
            if (systemInput < 0)
            {
                Console.WriteLine("Invalid.\nPress any key to continue.");
            }
            else
            {
                Balance = Balance + systemInput;
                Console.Write($"Your new balance is: ${Balance}\nPress any key to continue.");
            }
            return Balance;
        }
        // modify balance with withdraw transactions
        public static double NewWithdraw(double Balance, double systemInput)
        {
            if (systemInput > Balance)
            {
                Console.WriteLine("Overdraft Fees are the worst so no money for you!\nPress any key to continue.");
            }
            else if (systemInput < 0)
            {
                Console.WriteLine("Sadly this wont add money to your account as the internet said it would.\nPress any key to continue.");
            }
            else
            {
                Balance = Balance - systemInput;
                Console.Write($"Your remaining balance is: ${Balance}\nPress Enter to continue.");
            }
            return Balance;

        }
        // exit program
        public static void ExitAtm()
        {
            Environment.Exit(0);
        }
    }
}

