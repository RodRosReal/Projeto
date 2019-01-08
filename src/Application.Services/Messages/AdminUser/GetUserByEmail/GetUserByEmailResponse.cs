using Domain.Dtos;
using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class GetUserByEmailResponse 
	{
        [DataMember]
        public UserDto User { get; set; }
    } 
}
