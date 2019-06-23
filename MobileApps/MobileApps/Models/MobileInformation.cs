using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace MobileApps.Models
{
     public class MobileInformation
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string IMEI { get; set; }
        public int Price { get; set; }
    }
}
