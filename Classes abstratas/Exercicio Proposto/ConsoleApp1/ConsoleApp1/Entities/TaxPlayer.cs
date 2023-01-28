
namespace ConsoleApp1.Entities
{
    internal abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPlayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double tax();


    }
}
