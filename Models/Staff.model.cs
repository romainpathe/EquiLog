namespace EquiLog.Models
{
    public class Staff_model
    {
        public string Username { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }

        public Staff_model(string username, string password)
        {
            Username = username;
            Password = password;
        }
        
        public override string ToString()
        {
            return Id+": "+Username + "  " + Password;
        }
    }
}