namespace EquiLog.Models
{
    public class Staff_model
    {
        public string Username { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return Id+": "+Username + "  " + Password;
        }
    }
}