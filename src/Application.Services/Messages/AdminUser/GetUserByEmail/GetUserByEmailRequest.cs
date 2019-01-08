using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class GetUserByEmailRequest 
	{
        [DataMember]
        public string Email { get; set; }
    } 
}
