using System.Runtime.Serialization;
namespace Application.Messages
{
	[DataContract]
	public partial class GetUserByIdRequest 
	{
        [DataMember]
        public int Id { get; set; }
    } 
}
