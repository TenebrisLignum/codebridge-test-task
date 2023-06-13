using AutoMapper;
using Codebridge_Test.Domain;
using Codebridge_Test.Domain.Entities;
using Codebridge_Test.Domain.Enums;
using Codebridge_Test.Services.Interfaces;
using Codebridge_Test.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Codebridge_Test.Services
{
    public class DogsService: IDogsService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DogsService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DogTableViewModel> GetTable(DogTableFilterViewModel filter)
        {
            var dogs = await _context.Dogs.ToListAsync();
            var result = SortDogs(dogs, filter);
            var dogVMs = _mapper.Map<List<DogViewModel>>(result);

            var table = new DogTableViewModel() 
            {   
                DogsList = dogVMs,
                TotalDogsCount = dogs.Count,
                Filter = filter 
            };

            return table;
        }

        public async Task Create(DogViewModel dogVM)
        {
            var dog = _mapper.Map<Dog>(dogVM);

            await _context.Dogs.AddAsync(dog);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsDogExist(string name)
        {
            return await _context.Dogs.AnyAsync(x => x.Name == name);
        }

        private static List<Dog> SortDogs(List<Dog> dogs, DogTableFilterViewModel filter)
        {
            switch (filter.FieldName)
            {
                case DogFieldsName.Name:
                    dogs = (filter.SortOrder == SortOrder.Ascending)
                        ? dogs.OrderBy(d => d.Name).ToList()
                        : dogs.OrderByDescending(d => d.Name).ToList();
                    break;
                case DogFieldsName.Color:
                    dogs = (filter.SortOrder == SortOrder.Ascending)
                        ? dogs.OrderBy(d => d.Color).ToList()
                        : dogs.OrderByDescending(d => d.Color).ToList();
                    break;
                case DogFieldsName.TailLength:
                    dogs = (filter.SortOrder == SortOrder.Ascending)
                        ? dogs.OrderBy(d => d.TailLength).ToList()
                        : dogs.OrderByDescending(d => d.TailLength).ToList();
                    break;
                case DogFieldsName.Weight:
                    dogs = (filter.SortOrder == SortOrder.Ascending)
                        ? dogs.OrderBy(d => d.Weight).ToList()
                        : dogs.OrderByDescending(d => d.Weight).ToList();
                    break;
                default:
                    break;
            }

            return dogs.Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToList();
        }
    }
}
