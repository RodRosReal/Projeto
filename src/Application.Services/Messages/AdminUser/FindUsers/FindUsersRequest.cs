using Domain.Dtos;
using Domain.ValueObjects;
using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class FindUsersRequest 
	{
        [DataMember]
        public UserFilter Filter { get; set; }

        [DataMember]
        public string OrderBy { get; set; }

        [DataMember]
        public SortDirection Direction { get; set; }
    } 
}
