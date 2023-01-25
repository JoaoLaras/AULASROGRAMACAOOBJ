

namespace Course.Entities
{   //sealed a classe fica selada, nao podendo ser herdada
    internal sealed class SavingsAccount : Account

    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance = Balance * InterestRate;
        }

        //DESCONTANDO SOMENTE A TAXA DE 5.0;
        /*public override void Withdraw(double amount)
        {
            Balance = Balance - amount;
        }*/

        //DESCONTANDO TAXA DE 5.0 + 2.0;

        //OPERACAO NAO PODE SER SOBRESCRITA NOVAMENTE EM UMA OUTRA SUBCLASSE;
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance = Balance - 2.0;

        }


    }
}
