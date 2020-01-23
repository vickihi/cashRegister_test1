using System;
namespace CashRegister_WeiweiGuo
{
    public class AddTransactionLine : IAction
    {
        public decimal ApplyAction(decimal unitPrice, int amountOfUnit)
        {
            return +unitPrice * amountOfUnit;
        }

        public string GetActionType()
        {
            return "Add";
        }
    }
}
