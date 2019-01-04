using Domain.Core;
using System.Collections.Generic;

namespace Domain.Dtos
{
    public class ModuleDto : IDto
    {
        public int Id { get; set; }
        public int IdParent { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Sort { get; set; }

        public List<ModuleDto> SubModules { get; set; }
    }
}
