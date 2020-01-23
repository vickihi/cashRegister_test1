using System;
namespace CashRegister_WeiweiGuo
{
    public class CancelTransactionLine : IAction
    {
        public decimal ApplyAction(decimal unitPrice, int amountOfUnit)
        {
            return 0;
        }

        public string GetActionType()
        {
            return "Cancel";
        }
    }
}
