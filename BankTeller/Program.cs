using System;
using Microsoft.Data.Sqlite;

namespace BankTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the database interface
            DatabaseInterface db = new DatabaseInterface();

            // Check/create the Account table
            db.CheckAccountTable();

            int choice;

            do
            {
                // Show the main menu by invoking the static method
                choice = MainMenu.Show();

                switch (choice)
                {
                    // Menu option 1: Adding account
                    case 1:
                        // Ask user to input customer name
                        string CustomerName = Console.ReadLine();

                        // Insert customer account into database
                        db.Insert($@"
                            INSERT INTO Account
                            (Id, Customer, Balance)
                            VALUES
                            (null, '{CustomerName}', 0)
                        ");
                        break;

                    // Menu option 2: Deposit money
                    case 2:
                        // Logic here
                        Console.WriteLine("Enter customer name for deposit");
                        string DepositorName = Console.ReadLine();
                        int DepositorId = 0;

                        db.Query($@"SELECT Id FROM Account WHERE Customer='{DepositorName}';",
                            (SqliteDataReader reader) =>
                            {
                                while (reader.Read ())
                                {
                                    DepositorId = reader.GetInt32(0);
                                }
                            }
                        );

                        Console.WriteLine("Account Found, How much would you like to deposit?");
                        double depositAmt = Convert.ToDouble(Console.ReadLine());
                    
                        db.Update($@"UPDATE Account
                                    SET Balance = Balance + {depositAmt}
                                    WHERE 
                                    Id={DepositorId};");
                        
                        break;
                    
                    case 3:
                        Console.WriteLine("Enter customer name for withdraw");
                        string recipientName = Console.ReadLine();
                        int recipientId = 0;

                        db.Query($@"SELECT Id FROM Account WHERE Customer='{recipientName}';",
                            (SqliteDataReader reader) =>
                            {
                                while (reader.Read ())
                                {
                                    recipientId = reader.GetInt32(0);
                                }
                            }
                        );

                        Console.WriteLine("Account Found, How much would you like to withdraw?");
                        double withdrawAmt = Convert.ToDouble(Console.ReadLine());
                        
                        db.Update($@"UPDATE Account
                            SET Balance = Balance - {withdrawAmt}
                            WHERE 
                            Id={recipientId};");


                        break;

                    case 4:
                        Console.WriteLine("Enter customer name to display account balance");
                        string balanceCheckName = Console.ReadLine();
                        int balanceCheckId = 0;

                        db.Query($@"SELECT Id FROM Account WHERE Customer='{balanceCheckName}';",
                            (SqliteDataReader reader) =>
                            {
                                while (reader.Read ())
                                {
                                    balanceCheckId = reader.GetInt32(0);
                                }
                            }
                        );

                        double currentBalance = db.getBalance(balanceCheckId);
                        Console.WriteLine($"Current Balance: {currentBalance}, press any key to return to menu.");
                        string empty = Console.ReadLine();
                    

                        break;
                    case 5:
                        Console.WriteLine("[̲̅$̲̅(̲̅ ͡° ͜ʖ ͡°̲̅)̲̅$̲̅] GOODBYE [̲̅$̲̅(̲̅ ͡° ͜ʖ ͡°̲̅)̲̅$̲̅] ");
                        Console.ReadLine();
                        break;
                }
            } while (choice != 5);
        }

    }
}