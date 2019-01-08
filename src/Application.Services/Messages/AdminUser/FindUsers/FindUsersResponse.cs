using Domain.Dtos;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class FindUsersResponse 
	{
        [DataMember]
        public List<UserDto> Users { get; set; }
    } 
}
