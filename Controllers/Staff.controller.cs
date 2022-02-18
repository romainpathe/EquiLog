using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        
    }
}