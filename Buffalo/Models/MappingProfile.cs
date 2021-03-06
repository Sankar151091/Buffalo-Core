using AutoMapper;
using Buffalo.Entities.DataTransferObjects;
using Buffalo.Entities.Models;

namespace Buffalo.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                    .ForMember(c => c.FullAddress,
                        opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
        }
    }
}
