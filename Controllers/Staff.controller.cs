using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using EquiLog.Models;

namespace EquiLog
{
    public class Staff_controller
    {
        public static List<Staff_model> staffList;
        public static int actifUserId;
        public static void InitStaffList()
        {
            var srConfig = new StreamReader("../../Resources/database/staff.json");
            staffList = JsonSerializer.Deserialize<List<Staff_model>>(srConfig.ReadToEnd());
            srConfig.Close();
        }
        
        private static void UpdateStaffList()
        {
            var jsonConfigString = JsonSerializer.Serialize(staffList);
            var swConfig = new StreamWriter("../../Resources/database/staff.json");
            swConfig.Write(jsonConfigString);
            swConfig.Close();
        }

        public static void AddStaff(string firstname, string lastname, string password, string job, int hours, int holidays)
        {
            int id = 1;
            if (staffList.Count > 0)
            {
                id = staffList.Last().Id + 1;
            }
            staffList.Add(new Staff_model(id, firstname,lastname,password,job,hours,holidays));
            UpdateStaffList();
        }
        
        public static void RemoveStaff(int id)
        {
            staffList.Remove(staffList.Find(x => x.Id == id));
            UpdateStaffList();
        }
        
    }
}