using Domain.Core;
using Domain.Dtos;
using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class FindUsersPagedRequest 
	{
        [DataMember]
        public UserFilter Filter { get; set; }

        [DataMember]
        public PagedOptions PagedOptions { get; set; }

    } 
}
