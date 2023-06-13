using Codebridge_Test.ViewModels;

namespace Codebridge_Test.Services.Interfaces
{
    public interface IDogsService
    {
        public Task<DogTableViewModel> GetTable(DogTableFilterViewModel filter);
        public Task Create(DogViewModel dogVM);
        Task<bool> IsDogExist(string name);
    }
}
