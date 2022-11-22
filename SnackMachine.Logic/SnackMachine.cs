using System;
using System.Linq;

namespace SnackMachineLogic
{
    public class SnackMachine
    {
        public Money MoneyInside { get; protected set; } = Money.None;
        public Money MoneyInTransaction { get; protected set; } = Money.None;

        public void InsertMoney(Money money)
        {
            Money[] coinsAndNotes =
            {
                Money.Cent, Money.TenCent, Money.Quarter, Money.Dollar, Money.FiveDollar, Money.TwentyDollar
            };
            if (!coinsAndNotes.Contains(money))
                throw new InvalidOperationException();

            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
            MoneyInTransaction = Money.None;
        }

        public void BuySnack()
        {
            MoneyInside += MoneyInTransaction;
            MoneyInTransaction = Money.None;
        }
    }
}
