namespace EquiLog.Models
{
    public class Planning_model
    {
        public int Equidea_id { get; set; }
        public int Rider_id { get; set; }
        public int Hours_id { get; set; }
        
        public Planning_model(int equidea_id,  int hours_id, int rider_id)
        {
            Equidea_id = equidea_id;
            Rider_id = rider_id;
            Hours_id = hours_id;
        }
        
        
    }
}