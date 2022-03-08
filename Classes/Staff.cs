using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiLog
{
    internal class Staff
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Job { get; set; }
        public int Hours { get; set; }
        public int Holidays { get; set; }
    }
}
