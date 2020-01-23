using System;
namespace CashRegister_WeiweiGuo
{
    public class Record
    {
        public string unitName { get; set; }
        public decimal unitPrice { get; set; }
        public int amountOfUnit { get; set; }
        public string transactionType { get; set; }
        public decimal transactionAmount { get; set; }

        public void Display()
        {
            Console.WriteLine(  $"unit name: {unitName}, " +
                                $"unit price: {unitPrice}, " +
                                $"amount of unit: {amountOfUnit}, " +
                                $"transaction type: {transactionType}, " +
                                $"transaction amount: {transactionAmount}");
        }

    }
}
