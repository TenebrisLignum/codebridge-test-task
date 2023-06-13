using AutoMapper;
using CodebridgeTest.Domain.Entities;
using CodebridgeTest.ViewModels;

namespace CodebridgeTest.Domain.Mapping
{
    public class DogViewModelToEntityMap: Profile
    {
        public DogViewModelToEntityMap()
        {
            CreateMap<Dog, DogViewModel>().ReverseMap();
        }
    }
}
