using System;
using System.Collections.Generic;

namespace CashRegister_WeiweiGuo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesToContinue = true;

            GUI gui = new GUI();
            CashRegister cashRegister = new CashRegister();

            IList<Record> recordsList = new List<Record>();

            while (yesToContinue)
            {
                Console.Clear();
                foreach (Record rec in recordsList)
                {
                    rec.Display();
                }

                gui.ShowMenu();

                var productName = gui.GetProductName("product name");
                var unitPrice = gui.GetUnitPrice("unit price");
                var amountOfUnit = gui.GetAmountOfUnit("amount of unit");

                IAction operation = gui.EnterTransactionLine();

                cashRegister.unitPrice = unitPrice;
                cashRegister.amountOfUnit = amountOfUnit;
                var transactionAmount = cashRegister.DoTransactionLine(operation);


                Record record = new Record();
                record.unitName = productName;
                record.unitPrice = unitPrice;
                record.amountOfUnit = amountOfUnit;
                record.transactionType = operation.GetActionType();
                record.transactionAmount = transactionAmount;

                recordsList.Add(record);

          

                Console.Write("Continue: (Y/N)? ");
                var contKey = Console.ReadKey();
                yesToContinue = (contKey.Key == ConsoleKey.Y ? true : false);

            }

            cashRegister.CloseRegister();

        }
    }
}
