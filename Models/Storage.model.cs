using System;

namespace EquiLog.Models
{
    public class Storage_model
    {
        public int Saddle { get; set; }
        public int Briddle { get; set; }
        public int Granule { get; set; }
        public int Blanket { get; set;}
        public int Hay { get; set; }
        public int SaddlePad { get; set; }
        public int StirrupStraps { get; set; }
        public int Stirrup { get; set; }
       
        public Storage_model(int hay,int saddle, int briddle, int granule, int blanket, int saddlepad, int stirrupstraps, int stirrup)
        {
            Hay = hay;
            Saddle = saddle;    
            Briddle = briddle;
            Granule = granule;
            Blanket = blanket;
            SaddlePad = saddlepad;
            StirrupStraps = stirrupstraps;
            Stirrup = stirrup;
          
        }

        
   
       
        public Storage_model()
        {
            Hay = 0;
            Saddle = 0;
            Briddle = 0;
            Granule = 0;
            Blanket = 0;
            SaddlePad = 0;
            Stirrup = 0;
            StirrupStraps= 0;   
            
        }
        

    }
}