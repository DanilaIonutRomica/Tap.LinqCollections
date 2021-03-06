using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.LinqCollections
{
    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;
        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }
        public IEnumerable<Car> GetCarsHighSpeed()
        {
            IEnumerable<Car> cars = carRepository.GetAll().Where(car => car.MaxSpeedKmh > 180);
            return cars;
        }
        public IEnumerable<Car> GetCarsElectricWithGoodAuthonomy()
        {
            IEnumerable<Car> cars = carRepository.GetAll().Where(car => car.IsElectric == true && car.Autonomy >= 400);
            return cars;
        }
        public int GetNumberCarsMaxSpeed100and200()
        {
            IEnumerable<Car> cars = carRepository.GetAll().Where(car => car.MaxSpeedKmh >= 100 && car.MaxSpeedKmh <= 200);
            var number = cars.Count();
            return number;
        }
        public List<String> GetElectricCars()
        {
            IEnumerable<Car> cars = carRepository.GetAll().Where(car => car.IsElectric == true);
            List<String> brands = new List<string>();
            foreach (Car car in cars)
            {
                brands.Add(car.Brand);
            }
            return brands;
        }
        public IEnumerable<Car> ShowVehiclesOnPage(int pageNumber, int pageSize)
        {
            IEnumerable<Car> cars = carRepository.GetAll().Skip((pageSize - 1) * pageSize).Take(pageSize);
            return cars;
        }


    }
}
