using AutoMapper;
using Domain.Dtos;
using Domain.Entities.Relacional;

namespace Infrastructure.Mapper.Profiles
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            this.CreateMap<Module, ModuleDto>();
            this.CreateMap<User, UserDto>();

            //this.CreateMap<Teste, TesteDto>()
            //    .ForMember(x => x.id2, source => source.MapFrom(from => from.id));
        }
    }
}
