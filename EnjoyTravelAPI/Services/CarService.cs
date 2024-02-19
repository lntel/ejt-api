using EnjoyTravelAPI.Models.Entities;
using EnjoyTravelAPI.Models.Interfaces;

namespace EnjoyTravelAPI.Services
{
    public class CarService(ApplicationDbContext _dbContext) : ICarService
    {
        public Car DeleteCar(int id)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.Id == id);

            if (car == null)
            {
                throw new KeyNotFoundException(nameof(car));
            }

            _dbContext.Cars.Remove(car);

            _dbContext.SaveChanges();

            return car;
        }

        public List<Car> GetAvailableCars()
        {
            return _dbContext.Cars.Where(p => p.IsAvailable).ToList();
        }

        public Car SetAvailability(int id, bool? available)
        {
            var car = _dbContext.Cars.FirstOrDefault(p => p.Id == id);

            if (car == null)
            {
                throw new KeyNotFoundException(nameof(car));
            }

            car.IsAvailable = available ?? false;

            _dbContext.SaveChanges();

            return car;
        }
    }
}
