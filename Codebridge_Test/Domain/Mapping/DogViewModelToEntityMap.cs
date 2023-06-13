using AutoMapper;
using Codebridge_Test.Domain.Entities;
using Codebridge_Test.ViewModels;

namespace Codebridge_Test.Domain.Mapping
{
    public class DogViewModelToEntityMap: Profile
    {
        public DogViewModelToEntityMap()
        {
            CreateMap<Dog, DogViewModel>().ReverseMap();
        }
    }
}
