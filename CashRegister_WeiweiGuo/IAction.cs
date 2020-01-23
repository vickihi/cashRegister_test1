using System;
namespace CashRegister_WeiweiGuo
{
    public interface IAction
    {
        public decimal ApplyAction(decimal unitPrice, int amountOfUnit);

        public string GetActionType();
    }
}
