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

        public Staff_model(int id, string firstname, string lastname, string password, string job, int hours, int holidays)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            Job = job;
            Hours = hours;
            Holidays = holidays;
        }
        
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