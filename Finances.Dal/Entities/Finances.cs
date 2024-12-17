namespace Finances.Dal.Entities
{
    public class Finances
    {
        public int UserId { get; set; }
        public string Period { get; set; }
        public double TotalWastedSum { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public double SavingGoal { get; set; }
        public double AmountOfMoney { get; set; }
        public double Debt { get; set; }
        public double Income { get; set; }
        public double AverageWasted { get; set; }
        public double AverageSurplus { get; set; }
        public double MountsToGoal { get; set; }
    }
}