﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.LinqCollections
{
    public interface ICarService
    {
        public IEnumerable<Car> GetCarsHighSpeed();
    }
}
