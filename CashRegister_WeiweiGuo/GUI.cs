using System;
namespace CashRegister_WeiweiGuo
{
    public class GUI
    {
        public void ShowMenu()
        {
            Console.WriteLine("Cash Register");
        }

        public decimal GetUnitPrice (String unitPrice)
        {
            Console.Write($"Enter {unitPrice} ");
            decimal enteredUnitPrice = decimal.Parse(Console.ReadLine());
            return enteredUnitPrice;
        }

        public int GetAmountOfUnit(String amountOfUnit)
        {
            Console.Write($"Enter {amountOfUnit} ");
            int enteredAmountOfUnit = int.Parse(Console.ReadLine());
            return enteredAmountOfUnit;
        }

        public string GetProductName(String productName)
        {
            Console.Write($"Enter {productName} ");
            string enteredUnitPrice = Console.ReadLine();
            return enteredUnitPrice;
        }

        public IAction EnterTransactionLine()
        {
            IAction operation = new AddTransactionLine();
            Console.Write("Transaction type:");
            var operationInput = Console.ReadLine();
            switch (operationInput)
            {
                case "Add":
                    operation = new AddTransactionLine();
                    break;
                case "Delete":
                    operation = new DeleteTransactionLine();
                    break;
                case "Cancel":
                    operation = new CancelTransactionLine();
                    break;
            }
            return operation;
        }

        public void ShowTransactionLine()
        {
            Console.Write($"The product transaction is ");
        }
    }
}
