using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tap.LinqCollections;

namespace Tap.LinqCollections
{
    public class CarRepository:ICarRepository
    {

        public List<Car> GetAll()
        {
            return new List<Car>()
            {
                new Car { Id = 1, Brand = "Dacia", Model = "Spring", IsElectric = true, Autonomy = 300, MaxSpeedKmh = 120  }
                , new Car { Id = 2, Brand = "Dacia", Model = "Duster", IsElectric = false, Autonomy = 850, MaxSpeedKmh = 180  }
                , new Car { Id = 3, Brand = "Ford", Model = "Focus", IsElectric = false, Autonomy = 950, MaxSpeedKmh = 210  },
                new Car { Id = 4, Brand = "Tesla", Model = "Model 3", IsElectric = true, Autonomy = 500, MaxSpeedKmh = 260  },
                new Car { Id = 5, Brand = "Opel", Model = "Astra", IsElectric = false, Autonomy = 1010, MaxSpeedKmh = 190  }
            };
        }

    }
    public interface ICarRepository
    {
        public List<Car> GetAll();
    }
}
