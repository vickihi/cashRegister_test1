using System;
namespace CashRegister_WeiweiGuo
{
    public class CashRegister
    {
        public decimal unitPrice { get; set; }
        public int amountOfUnit { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TransactionTotal { get; set; }

        public CashRegister()
        {

        }

        public void CloseRegister()
        {
            Console.WriteLine($"The total amount of today's transaction is {TotalAmount}");
        }

        public decimal DoTransactionLine(IAction operation)
        {
            TransactionTotal = operation.ApplyAction(unitPrice, amountOfUnit);
            TotalAmount += TransactionTotal;

            return TransactionTotal;
        }

    }
}
