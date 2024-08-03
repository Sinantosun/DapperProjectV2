namespace DapperProjectV2.Services
{
    public interface IWidgetService
    {
        public Task<int> GetCarOrderThan2012CountAsync();
        public Task<int> GetCarWithManuelGearCountAsync();
        public Task<int> GetCarCountAsync();
        public Task<int> GetRedCarCountAsync();
        public Task<int> GetSedanCarCountAsync();
        public Task<int> GetMotorVolumeCountAsync(); //1300-1600 CC
        public Task<int> GetIstanbulCarPlateCountAsync();
        public Task<int> GetlicensedBefore1998Async();
    }
}
