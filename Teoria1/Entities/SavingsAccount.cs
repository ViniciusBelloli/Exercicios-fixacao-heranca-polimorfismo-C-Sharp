namespace Teoria1.Entities
{
   // sealed evita que a classe seja herdada e a função sobreposta novamente.
   sealed class SavingsAccount : Account
   {
      public double InterestRate { get; set; }

      public SavingsAccount()
      {
      }

      public SavingsAccount(int number, string holder, double balance, double interestRate)
         : base(number, holder, balance)
      {
         InterestRate = interestRate;
      }

      public void UpdateBalance()
      {
         Balance += Balance * InterestRate;
      }

      public sealed override void Withdraw(double amount)
      {
         //Balance -= amount;
         // Reaproveitar a função da classe Pai
         base.Withdraw(amount);
         Balance -= 2;
      }
   }
}