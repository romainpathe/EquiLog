namespace EquiLog.Models
{
    public class Rider_model
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Course { get; set; }
        public string Level { get; set; }

        public Rider_model(int id, string firstname, string lastname,string email,string phone, int course, string level)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phone = phone;
            Course = course;
            Level = level;
        }       
        
    }
}