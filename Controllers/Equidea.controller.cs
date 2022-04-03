using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using EquiLog.Models;

namespace EquiLog.Controllers
{
    public class Equidae_controller
    {
        public static List<Equidea_model> equideaList;

        public static void InitRiderList()
        {
            var srConfig = new StreamReader("../../Resources/database/equidea.json");
            equideaList = JsonSerializer.Deserialize<List<Equidea_model>>(srConfig.ReadToEnd());
            srConfig.Close();
        }
        private static void UpdateRiderList()
        {
            var jsonConfigString = JsonSerializer.Serialize(equideaList);
            var swConfig = new StreamWriter("../../Resources/database/equidea.json");
            swConfig.Write(jsonConfigString);
            swConfig.Close();
        }
        public static void AddEquidae(string lastname, string firstname, string gender, int age, string color, int hours)
        {
            equideaList.Add(new Equidea_model(lastname,firstname, gender, age, color, hours));
            UpdateRiderList();
        }
    }
}
