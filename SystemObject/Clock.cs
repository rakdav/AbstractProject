using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObject
{
    internal class Clock
    {
        public int Houres { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            return $"{Houres}:{Minutes}:{Seconds}";
        }

        public override int GetHashCode()
        {
            return Houres.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj is Clock clock) return Houres== clock.Houres&&
                                          Minutes==clock.Minutes&&
                                          Seconds==clock.Seconds;
            return false;
        }
    }
}
