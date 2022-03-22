namespace EquiLog.Models
{
    public class Finances_model
    {
        public double Spendings { get; set; }
        public double Profits { get; set; }

        public int PackagePaid { get; set; }

        public int PackageToPay { get; set; }
    }
}