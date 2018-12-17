using System.CodeDom.Compiler;
using System.ServiceModel;
using Application.Messages;

namespace Application.Interfaces
{
	[GeneratedCode("Service Generator", "1.0")]
	[ServiceContract]
	public partial interface IAdminUser
	{
		[OperationContract]
		GetUserByIdResponse GetUserById (GetUserByIdRequest request);
			
	}
}
