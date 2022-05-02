using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        
        public static void AddPlanning(int EquideaId, int HoursId, int RiderId)
        {
            planning.Add(new Planning_model(EquideaId, HoursId,RiderId));
            UpdatePlanning();
        }
        
        public static void ClearPlanning()
        {
            planning.Clear();
            UpdatePlanning();
        }
        
        public static void InitHours()
        {
            var srConfig = new StreamReader("../../Resources/database/hours.json");
            Hours = JsonSerializer.Deserialize<List<Hours_model>>(srConfig.ReadToEnd());
            srConfig.Close();
        }

    }
}