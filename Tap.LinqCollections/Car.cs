using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.LinqCollections
{
    public class Car
    {
        public int Id { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public bool IsElectric { get; set; }
        public int MaxSpeedKmh { get; set; }
        public int Autonomy { get; set; }
    }
}
