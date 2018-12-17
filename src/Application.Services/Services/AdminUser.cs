using System;
using Application.Interfaces;
using Application.Messages;

namespace Application.Services
{
	public class AdminUser : AdminUserBase
	{
		#region Constructor
		protected AdminUser()
		{

		}
		#endregion
		
		#region Operation Methods Implementation
		public override GetUserByIdResponse OnGetUserByIdExecute(GetUserByIdRequest request)
        {
            var response = new GetUserByIdResponse();
            //<IMPLEMENT HERE>
            return response;
        }
		#endregion
	}
}
