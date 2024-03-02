using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bet1
{
    public class devices
    {
        int id { get; set; }
        string deviceName { get; set; }
        string wattage { get; set; }
        int? lifetime { get; set; }
        int? recentuse { get; set; }
        DateTime? optTime { get; set; }
        DateTime? optChargeTime { get; set; }

        public devices(string deviceName, string wattage, int lifetime, int? recentuse, DateTime? optTime, DateTime? optChargeTime)
        {
            //this.id = id;
            this.deviceName = deviceName;
            this.wattage = wattage;
            this.lifetime = lifetime;
            this.recentuse = recentuse;
            this.optTime = optTime;
            this.optChargeTime = optChargeTime;
        }
    }
}
