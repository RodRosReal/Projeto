using Domain.Core;
using Domain.Dtos;
using Domain.Entities.Relacional;
using System.Collections.Generic;

namespace Domain.Factories
{
    public interface IModuloFactory : IFactory
    {
        List<ModuleDto> CreateListModules(List<Module> parentsModules, List<Module> modules);
    }
}
