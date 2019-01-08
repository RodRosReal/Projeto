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
				
			GetUserByEmailInitialization += OnAdminUserInitialization;
        	GetUserByEmailExecute += OnGetUserByEmailExecute;
        	GetUserByEmailComplete += OnAdminUserComplete;
        	GetUserByEmailError += OnAdminUserError;
				
			FindUsersInitialization += OnAdminUserInitialization;
        	FindUsersExecute += OnFindUsersExecute;
        	FindUsersComplete += OnAdminUserComplete;
        	FindUsersError += OnAdminUserError;
				
			FindUsersPagedInitialization += OnAdminUserInitialization;
        	FindUsersPagedExecute += OnFindUsersPagedExecute;
        	FindUsersPagedComplete += OnAdminUserComplete;
        	FindUsersPagedError += OnAdminUserError;
				
		}
		#endregion
		
		#region Operation Events
		
		public event Action< GetUserByIdRequest, GetUserByIdResponse> GetUserByIdInitialization;
		public event Func< GetUserByIdRequest, GetUserByIdResponse> GetUserByIdExecute;
		public event Action< GetUserByIdRequest, GetUserByIdResponse> GetUserByIdComplete;
		public event Action< GetUserByIdRequest, GetUserByIdResponse, Exception> GetUserByIdError;
		
		public event Action< GetUserByEmailRequest, GetUserByEmailResponse> GetUserByEmailInitialization;
		public event Func< GetUserByEmailRequest, GetUserByEmailResponse> GetUserByEmailExecute;
		public event Action< GetUserByEmailRequest, GetUserByEmailResponse> GetUserByEmailComplete;
		public event Action< GetUserByEmailRequest, GetUserByEmailResponse, Exception> GetUserByEmailError;
		
		public event Action< FindUsersRequest, FindUsersResponse> FindUsersInitialization;
		public event Func< FindUsersRequest, FindUsersResponse> FindUsersExecute;
		public event Action< FindUsersRequest, FindUsersResponse> FindUsersComplete;
		public event Action< FindUsersRequest, FindUsersResponse, Exception> FindUsersError;
		
		public event Action< FindUsersPagedRequest, FindUsersPagedResponse> FindUsersPagedInitialization;
		public event Func< FindUsersPagedRequest, FindUsersPagedResponse> FindUsersPagedExecute;
		public event Action< FindUsersPagedRequest, FindUsersPagedResponse> FindUsersPagedComplete;
		public event Action< FindUsersPagedRequest, FindUsersPagedResponse, Exception> FindUsersPagedError;
		#endregion
		
		#region Abstract Service Methods
		public virtual void OnAdminUserInitialization(AdminUserRequest request, AdminUserResponse response) {}
      	public virtual void OnAdminUserComplete(AdminUserRequest request, AdminUserResponse response) {}
        public virtual void OnAdminUserError(AdminUserRequest request, AdminUserResponse response, Exception exception) { throw exception; }
		#endregion
		
		#region Abstract Operation Methods
				
		public abstract GetUserByIdResponse OnGetUserByIdExecute(GetUserByIdRequest request);
				
		public abstract GetUserByEmailResponse OnGetUserByEmailExecute(GetUserByEmailRequest request);
				
		public abstract FindUsersResponse OnFindUsersExecute(FindUsersRequest request);
				
		public abstract FindUsersPagedResponse OnFindUsersPagedExecute(FindUsersPagedRequest request);
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
				
		public virtual GetUserByEmailResponse GetUserByEmail(GetUserByEmailRequest request) {
			var response = new GetUserByEmailResponse();
			try {
				// Raise Initialization Event
				var initialization = GetUserByEmailInitialization;
				if (initialization != null) initialization(request, response);
				// Raise Execute Event
				var execute = GetUserByEmailExecute;
				if (execute != null) response = execute(request);
				// Raise Complete Event
				var complete = GetUserByEmailComplete;
				if (complete != null) complete(request, response);
			}
			catch (Exception exception) {
				// Raise Error Event
				var error = GetUserByEmailError;
				if (error != null) error(request, response, exception);
			}
			return response;
		}
				
		public virtual FindUsersResponse FindUsers(FindUsersRequest request) {
			var response = new FindUsersResponse();
			try {
				// Raise Initialization Event
				var initialization = FindUsersInitialization;
				if (initialization != null) initialization(request, response);
				// Raise Execute Event
				var execute = FindUsersExecute;
				if (execute != null) response = execute(request);
				// Raise Complete Event
				var complete = FindUsersComplete;
				if (complete != null) complete(request, response);
			}
			catch (Exception exception) {
				// Raise Error Event
				var error = FindUsersError;
				if (error != null) error(request, response, exception);
			}
			return response;
		}
				
		public virtual FindUsersPagedResponse FindUsersPaged(FindUsersPagedRequest request) {
			var response = new FindUsersPagedResponse();
			try {
				// Raise Initialization Event
				var initialization = FindUsersPagedInitialization;
				if (initialization != null) initialization(request, response);
				// Raise Execute Event
				var execute = FindUsersPagedExecute;
				if (execute != null) response = execute(request);
				// Raise Complete Event
				var complete = FindUsersPagedComplete;
				if (complete != null) complete(request, response);
			}
			catch (Exception exception) {
				// Raise Error Event
				var error = FindUsersPagedError;
				if (error != null) error(request, response, exception);
			}
			return response;
		}
				#endregion
	}
}
