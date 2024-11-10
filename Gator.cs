using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype
{
    /// <summary>
    /// Класс вируса шпона 
    /// </summary>
    public class Gator : Spyware
    {
        public int InfectedDevices { get; set; }

        public Gator(string name, DateTime startdate, int infectedCount) : base(name, startdate)
        {
            InfectedDevices = infectedCount;
        }

        public override IMyCloneable Clone()
        {
            return new Gator(Name, DateTime.Now.AddDays(-1), InfectedDevices);
        }
    }
}
