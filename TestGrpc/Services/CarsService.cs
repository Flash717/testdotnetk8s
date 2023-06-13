using Grpc.Core;
using TestGrpc.Model;

namespace TestGrpc.Services;

public class CarsService : Cars.CarsBase
{
    private readonly ILogger<CarsService> _logger;
    public CarsService(ILogger<CarsService> logger)
    {
        _logger = logger;
    }

    public override Task<CarReply> GetCar(CarRequest request, ServerCallContext context)
    {
        _logger.LogInformation($"GetCar -> {request.Id}");
        if (request.Id >= 0 && request.Id < CarList.Cars.Count) 
        {
            return Task.FromResult(
                new CarReply
                {
                    Make = CarList.Cars[request.Id].Make,
                    Model = CarList.Cars[request.Id].Model
                }
            );
        } else {
            return Task.FromResult(new CarReply
            {

            });
        }
    }
}