using Domain.Core;
using Domain.Dtos;
using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class FindUsersPagedResponse 
	{
        [DataMember]
        public PagedResult<UserDto> Users { get; set; }
    } 
}
