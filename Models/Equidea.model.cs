namespace EquiLog.Models
{
    public class Equidea_model
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }   
        public int Hours { get; set; }

        public Equidea_model(int id, string lastname,string firstname,string gender,int age,string color,int hours)
        {
            Id = id;
            Lastname = lastname;
            Firstname = firstname;
            Gender = gender;
            Age = age;
            Color = color;
            Hours = hours;

        }

        
    }
}