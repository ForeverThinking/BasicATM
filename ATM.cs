﻿using System;

namespace BasicATM
{
  class ATM
  {
    static void Main(string[] args)
    {
      // set variables
      int balance, depositAmt, withdrawAmt;
      int choice = 0, pin = 0;
      Console.WriteLine("Enter your ledger balance");
      balance = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter your PIN Number ");
      pin = int.Parse(Console.ReadLine());

      // reject user if incirrect pin
      if (pin != 1234)
      {
        Console.WriteLine("Invalid PIN");
        Console.ReadKey(false);
        return;
      }

      while (choice != 4)
      {
        Console.WriteLine("********Welcome to C# Cash Services**************\n");
        Console.WriteLine("1. Check Balance\n");
        Console.WriteLine("2. Withdraw Cash\n");
        Console.WriteLine("3. Deposit Cash\n");
        Console.WriteLine("4. Quit\n");
        Console.WriteLine("*********************************************\n\n"); Console.WriteLine("Enter your choice: ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
          case 1: // check balance
            Console.WriteLine("\n Your balance is $ : {0} ", balance);
            Console.ReadLine();
            break;
          case 2: // withdraw amount
            Console.WriteLine("\n Enter the amount you want to withdraw: ");
            withdrawAmt = int.Parse(Console.ReadLine());
            if (withdrawAmt % 100 != 0)
            {
              Console.WriteLine("\n Denominations present are 100, 500 and 2000. Your amount cannot be processed");
            }
            else if (withdrawAmt > balance)
            {
              Console.WriteLine("\n Sorry, insufficient balance.");
            }
            else
            {
              balance = balance - withdrawAmt;
              Console.WriteLine("\n\n Your transaction is processed.");
              Console.WriteLine("\n Current Balance is {0}", balance);
            }
            break;
          case 3: // deposit amount
            Console.WriteLine("\n Enter amount you want to deposit");
            depositAmt = int.Parse(Console.ReadLine());
            balance = balance + depositAmt;
            Console.WriteLine("Your ledger balance is {0}", balance);
            break;
          case 4: // leave ATM
            Console.WriteLine("\n Thank you for using C# Cash services.");
            break;
        }
      }
      Console.ReadLine();
    }
  }
}
