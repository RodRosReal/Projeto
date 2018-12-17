using AutoMapper;
using Domain.Dtos;
using Domain.Entities.Relacional;

namespace Infrastructure.Mapper.Profiles
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            this.CreateMap<ModuleDto, Module>();
            this.CreateMap<UserDto, User>();

            //this.CreateMap<TesteDto, Teste>()
            //    .ForMember(x => x.id, source => source.MapFrom(from => from.id2));
        }
    }
}
