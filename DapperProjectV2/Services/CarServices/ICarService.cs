using DapperProjectV2.Dtos.CarDtos;
using DapperProjectV2.Dtos.ChartDto;

namespace DapperProjectV2.Services.CarServices
{
    public interface ICarService
    {
        Task<List<ResultRandomCarDto>> Get10HeigestCarModelAsync();
        Task<List<ResultCarDto>> GetCarListAsync();

        Task<List<ResultCarFuelDto>> GetCarUsingFuelChartAsync();
        Task<List<ResultCarBrandDto>> GetCarOfBrandCountAsync();
        Task<List<ResultMotorVolumeDto>> GetMotorVolumeCountAsync();
    }

}
