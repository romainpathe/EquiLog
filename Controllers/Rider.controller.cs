using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            int id = 1;
            if (riderList.Count > 0)
            {
                id = riderList.Last().Id + 1;
            }
            riderList.Add(new Rider_model(id,firstname,lastname,email,phone,course,level));
            UpdateRiderList();
        }
        
        public static void RemoveRider(int id)
        {
            riderList.Remove(riderList.Find(x => x.Id == id));
            UpdateRiderList();
        }
        
        
    }
}