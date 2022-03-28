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
        private static void UpdateRiderList()
        {
            var jsonConfigString = JsonSerializer.Serialize(riderList);
            var swConfig = new StreamWriter("../../Resources/database/rider.json");
            swConfig.Write(jsonConfigString);
            swConfig.Close();
        }
        public static void AddRider(string firstname, string lastname,string email,string phone, int course, string level)
        {
            riderList.Add(new Rider_model(riderList.Count,firstname,lastname,email,phone,course,level));
            UpdateRiderList();
        }

    }
}