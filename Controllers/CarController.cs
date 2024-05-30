using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CarController
    {
        private CarService _service;
        public CarController()
        {
            _service = new CarService();
        }
        public bool Insert(Car car)
        {
            Console.WriteLine("Camada Controller");
            return _service.Insert(car);
        }
        public bool Delete(int id) { return _service.Delete(id); }
        public Car Get(int id) { return _service.Get(id); }
        public bool Update(Car car) { return _service.Update(car); }
        public List<Car> GetAll() { return _service.GetAll(); }
    }
}
