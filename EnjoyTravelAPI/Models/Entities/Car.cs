namespace EnjoyTravelAPI.Models.Entities
{
    public class Car
    {
        public Car(int id, string make, string model, bool isAvailable)
        {
            Id = id;
            Make = make;
            Model = model;
            IsAvailable = isAvailable;
        }

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsAvailable { get; set; }
    }
}
