using EnjoyTravelAPI.Models.Dtos;
using EnjoyTravelAPI.Models.Entities;
using EnjoyTravelAPI.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EnjoyTravelAPI.Controllers
{
    [ApiController]
    [Route("/cars")]
    public class CarsController(ICarService _carService) : ControllerBase
    {
        [HttpGet("available")]
        public List<Car> GetAvailableCars()
        {
            return _carService.GetAvailableCars();
        }
        
        [HttpPut("modify/{id}")]
        public Car ModifyCar(int id, [FromBody] CarUpdateDto updateDto)
        {
            return _carService.SetAvailability(id, updateDto.IsAvailable);
        }
        
        [HttpDelete("{id}")]
        public Car DeleteCar(int id)
        {
            return _carService.DeleteCar(id);
        }
    }
}
