using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using EquiLog.Models;


namespace EquiLog.Controllers
{
    public class Storage_controller
    {
        public static List<Storage_model> storageList;

        public static void InitStorageList()
        {
            var srConfig = new StreamReader("../../Resources/database/storage.json");
            storageList = JsonSerializer.Deserialize<List<Storage_model>>(srConfig.ReadToEnd());
            srConfig.Close();
        }
        
        public static void AddStorage(Storage_model storage)
        {
            storageList.Add(storage);
            //storageList.Last().Hay;
        }
        
        private static void SaveStorageList()
        {
            var swConfig = new StreamWriter("../../Resources/database/storage.json");
            swConfig.Write(JsonSerializer.Serialize(storageList));
            swConfig.Close();
        }
        
        
    }
}