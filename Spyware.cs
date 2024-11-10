using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// Подкласс шпионских вирусов
    /// </summary>
    public class Spyware : Virus
    {
        public DateTime DateOccurrence { get; set; }

        public Spyware(string name, DateTime startdate) : base(name)
        {
            DateOccurrence = startdate;
        }

        public override IMyCloneable Clone()
        {
            return new Spyware(Name, DateOccurrence);
        }
    }
}
