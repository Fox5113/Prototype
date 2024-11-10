using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// Базовый класс, представляющий компьютерный вирус.
    /// </summary>
    public class Virus : IMyCloneable, ICloneable
    {
        /// <summary>
        /// Название вируса
        /// </summary>
        public string Name { get; set; }

        public Virus(string name)
        {
            Name = name;
        }

        public virtual IMyCloneable Clone()
        {
            return new Virus(Name);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
