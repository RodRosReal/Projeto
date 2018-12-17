using System;
using Application.Interfaces;
using Application.Messages;

namespace Application.Services
{
	public abstract partial class AdminUserBase : IAdminUser
	{
		#region Constructor
		protected AdminUserBase()
		{
				
			GetUserByIdInitialization += OnAdminUserInitialization;
        	GetUserByIdExecute += OnGetUserByIdExecute;
        	GetUserByIdComplete += OnAdminUserComplete;
        	GetUserByIdError += OnAdminUserError;
				
		}
		#endregion
		
		#region Operation Events
		
		public event Action< GetUserByIdRequest, GetUserByIdResponse> GetUserByIdInitialization;
		public event Func< GetUserByIdRequest, GetUserByIdResponse> GetUserByIdExecute;
		public event Action< GetUserByIdRequest, GetUserByIdResponse> GetUserByIdComplete;
		public event Action< GetUserByIdRequest, GetUserByIdResponse, Exception> GetUserByIdError;
		#endregion
		
		#region Abstract Service Methods
		public virtual void OnAdminUserInitialization(AdminUserRequest request, AdminUserResponse response) {}
      	public virtual void OnAdminUserComplete(AdminUserRequest request, AdminUserResponse response) {}
        public virtual void OnAdminUserError(AdminUserRequest request, AdminUserResponse response, Exception exception) { throw exception; }
		#endregion
		
		#region Abstract Operation Methods
				
		public abstract GetUserByIdResponse OnGetUserByIdExecute(GetUserByIdRequest request);
		#endregion
		
		#region Operation Implementations
				
		public virtual GetUserByIdResponse GetUserById(GetUserByIdRequest request) {
			var response = new GetUserByIdResponse();
			try {
				// Raise Initialization Event
				var initialization = GetUserByIdInitialization;
				if (initialization != null) initialization(request, response);
				// Raise Execute Event
				var execute = GetUserByIdExecute;
				if (execute != null) response = execute(request);
				// Raise Complete Event
				var complete = GetUserByIdComplete;
				if (complete != null) complete(request, response);
			}
			catch (Exception exception) {
				// Raise Error Event
				var error = GetUserByIdError;
				if (error != null) error(request, response, exception);
			}
			return response;
		}
				#endregion
	}
}
