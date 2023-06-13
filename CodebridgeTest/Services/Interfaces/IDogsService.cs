using CodebridgeTest.ViewModels;

namespace CodebridgeTest.Services.Interfaces
{
    public interface IDogsService
    {
        public Task<DogTableViewModel> GetTable(DogTableFilterViewModel filter);
        public Task Create(DogViewModel dogVM);
        Task<bool> IsDogExist(string name);
    }
}
