using System;

namespace Domain.Core
{
    public interface IMapperService : IService
    {
        object Map(object source, Type destinationType);

        TDestination Map<TDestination>(object source);

        void Map(object source, object destination);
    }
}
