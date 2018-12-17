using Domain.Core;
using System;
using System.Collections.Generic;

namespace Domain.Dtos
{
    public class UserDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public System.DateTime CreationDate { get; set; }
        public  List<ModuleDto> UserModule { get; set; }
    }
}
