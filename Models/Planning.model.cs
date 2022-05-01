namespace EquiLog.Models
{
    public class Planning_model
    {
        public int Equidea_id { get; set; }
        public int Rider_id { get; set; }
        public int Hours_id { get; set; }
        
        public Planning_model(int equideaId,  int hoursId, int riderId)
        {
            Equidea_id = equideaId;
            Rider_id = riderId;
            Hours_id = hoursId;
        }
        
        
        
    }
}