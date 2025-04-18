using _3LArchitecture.Common.DTO;
using _3LArchitecture.Common.Entities;
using AutoMapper;

namespace _3LArchitecture.Common.Mapping;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<AgeLimitDTO, AgeLimit>().ReverseMap();
        CreateMap<BookDTO, Book>().ReverseMap();
        CreateMap<ProductDTO, Product>().ReverseMap();
        CreateMap<SportsEquipmentDTO, SportsEquipment>().ReverseMap();
        CreateMap<ToyDTO, Toy>().ReverseMap();
    }
}