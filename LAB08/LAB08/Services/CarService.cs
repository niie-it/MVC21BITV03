using LAB08.Entities;

namespace LAB08.Services
{

    public interface ICarService
    {
        List<CarVM> GetCars();
    }

    public class CarService : ICarService
    {
        private readonly CarDealerContext _ctx;

        public CarService(CarDealerContext ctx) { _ctx = ctx; }
        public List<CarVM> GetCars()
        {
            var data = _ctx.Cars.Select(c => new CarVM { Id = c.Id, Model = c.Model, Make=c.Make });
            return data.ToList();
        }
    }

    public class CarVM
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Name => $"{Make} {Model}";
    }
}
