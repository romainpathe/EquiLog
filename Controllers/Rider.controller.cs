using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using EquiLog.Models;

namespace EquiLog.Controllers
{
    public class Rider_controller
    {
        public static List<Rider_model> riderList;
        
        public static void InitRiderList()
        {
            var srConfig = new StreamReader("../../Resources/database/rider.json");
            riderList = JsonSerializer.Deserialize<List<Rider_model>>(srConfig.ReadToEnd());
            srConfig.Close();
        }
    }
}