/*
* Class name: BankingApp
* Information: Logical operators deonstration
* Version 1
* Author: Christopher Bradley
* Date: September 2024
*/

// Call BankingApp method to begin applicatiom

BuildBankingApp();

void BuildBankingApp()
{
    int choice;
    double depositAmount;
    double withdrawlAmount;
    double accountBalance = 1000.00;

    Console.WriteLine("Please select one of the following options: ");
    Console.WriteLine("============================================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please select an option 1 - 2");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine("Enter 'd' to deposit or 'w' to withdraw:");
        char transactionType = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (transactionType == 'd' || transactionType == 'D')
        {
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter an amount inluding pence using a decimal point");
            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The orignal balance was {0}", accountBalance);
            accountBalance += depositAmount;
            Console.WriteLine("The new balance is now {0}", accountBalance);
            return;
        }
        else if (transactionType == 'w' || transactionType == 'W') // Withdraw
        {
            Console.WriteLine("How much do you want to withdraw?");
            Console.WriteLine("Enter an amount including pence using a decimal point:");
            withdrawlAmount = Convert.ToDouble(Console.ReadLine());

            if (withdrawlAmount > accountBalance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
            else
            {
                Console.WriteLine("The original balance was {0}", accountBalance);
                accountBalance -= withdrawlAmount;
                Console.WriteLine("The new balance is now {0}", accountBalance);
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid transaction type. Please enter 'd' or 'w'.");
        }
    }
 
    if (choice == 2)
    {
        Console.WriteLine("The current account balance is {0}", accountBalance);
        return;
    }
    else
    {
        Console.WriteLine("Please choose a valid menu option 1 or 2");
    }
    BuildBankingApp();
}