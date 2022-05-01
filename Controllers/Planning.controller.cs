using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using EquiLog.Models;

namespace EquiLog.Controllers
{
    public class Planning_controller
    {
        public static List<Planning_model> planning;
        public static List<Hours_model> Hours;

        public static void InitPlanning()
        {
            var srConfig = new StreamReader("../../Resources/database/planning.json");
            planning = JsonSerializer.Deserialize<List<Planning_model>>(srConfig.ReadToEnd());
            srConfig.Close();
        }
        private static void UpdatePlanning()
        {
            var swConfig = new StreamWriter("../../Resources/database/planning.json");
            swConfig.Write(JsonSerializer.Serialize(planning));
            swConfig.Close();
        }
        
        public static void InitHours()
        {
            var srConfig = new StreamReader("../../Resources/database/hours.json");
            Hours = JsonSerializer.Deserialize<List<Hours_model>>(srConfig.ReadToEnd());
            srConfig.Close();
        }
        
        public List<Planning_model> GetByHour(int hour)
        {
            List<Planning_model> planning_by_hour = new List<Planning_model>();
            foreach (Planning_model planning_model in planning)
            {
                if (planning_model.Hours_id == hour)
                {
                    planning_by_hour.Add(planning_model);
                }
            }
            return planning_by_hour;
        }

        public List<Planning_model> GetByEquidea(int equidea_id)
        {
            List<Planning_model> planning_by_equidea = new List<Planning_model>();
            foreach (Planning_model planning_model in planning)
            {
                if (planning_model.Equidea_id == equidea_id)
                {
                    planning_by_equidea.Add(planning_model);
                }
            }
            return planning_by_equidea;
        }
        
        public List<Planning_model> GetByRider(int rider_id)
        {
            List<Planning_model> planning_by_rider = new List<Planning_model>();
            foreach (Planning_model planning_model in planning)
            {
                if (planning_model.Rider_id == rider_id)
                {
                    planning_by_rider.Add(planning_model);
                }
            }
            return planning_by_rider;
        }

    }
}