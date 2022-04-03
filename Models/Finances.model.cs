namespace EquiLog.Models
{
    public class Finances_model
    {
        public double Spendings { get; set; }
        public double Profits { get; set; }

        public int PackagePaid { get; set; }

        public int PackageToPay { get; set; }

        public Finances_model(double spendings,double profits,int packagepaid,int packagetopay)
        {
           Spendings = spendings;
            Profits = profits;
            PackagePaid = packagepaid;
            PackageToPay = packagetopay;

        }
    }
}