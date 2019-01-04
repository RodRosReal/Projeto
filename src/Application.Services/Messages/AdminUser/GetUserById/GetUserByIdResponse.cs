using Domain.Dtos;
using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class GetUserByIdResponse 
	{
        [DataMember]
        public UserDto User { get; set; }
    } 
}
