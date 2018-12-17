using Domain.Dtos;
using Domain.Entities.Relacional;
using Domain.Factories;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Factories
{
    public class ModuloFactory : IModuloFactory
    {
        public List<ModuleDto> CreateListModules(List<Module> parentsModules, List<Module> modules)
        {
            var children = modules.OrderBy(x => x.Sort).ToList();

            var parents = parentsModules.Where(x=> children.Select(y=>y.IdParent).Contains(x.Id)).OrderBy(x => x.Sort).ToList();

            return parents.Select(x => new ModuleDto()
            {
                Id = x.Id,
                IdParent = x.IdParent,
                Name = x.Name,
                Url = x.Url,
                Sort = x.Sort,
                SubModules = children
                    .Where(y => y.IdParent == x.Id)
                    .Select(y => new ModuleDto()
                    {
                        Id = y.Id,
                        IdParent = y.IdParent,
                        Name = y.Name,
                        Url = y.Url,
                        Sort = y.Sort,
                    }).ToList()
            }).ToList();
        }
    }
}
