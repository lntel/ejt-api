using EnjoyTravelAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EnjoyTravelAPI.Models.Interfaces
{
    public interface ICarService
    {
        public List<Car> GetAvailableCars();
        public Car SetAvailability(int id, bool? available);
        public Car DeleteCar(int id);
    }
}
