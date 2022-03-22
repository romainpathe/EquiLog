namespace EquiLog.Models
{
    public class Staff_model
    {
        public int Id { get; set; }
        public string Password { get; set; }
        
        public string Lastname { get; set; }
        
        public string Firstname { get; set; }
        
        public string Job { get; set; }
        
        public int Hours { get; set; }
        
        public int Holidays { get; set; }

        public string Username()
        {
            return Firstname + "." + Lastname[0];
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Job;
        }
    }
}