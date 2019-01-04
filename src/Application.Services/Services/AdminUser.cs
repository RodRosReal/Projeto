using System;
using Application.Interfaces;
using Application.Messages;
using Domain.Core;
using Domain.Dtos;
using Domain.Repositories;
using Domain.ValueObjects;
using Framework.Domain.Core;
using Infrastructure.Context.ServiceContext;
using Infrastructure.Mapper;
using Infrastructure.Repositories.Relational;
using P2A.Leads.Domain.Specifications;

namespace Application.Services
{
	public class AdminUser : AdminUserBase
	{
        protected readonly IMapperService _mapperService = ServiceContext<MapperService>.GetServiceContext();
        protected readonly IUserRepository _userRepository = ServiceContext<UserRepository>.GetServiceContext();
        protected readonly IUnitOfWork _unitOfWork;

        #region Constructor
        protected AdminUser()
		{

		}
		#endregion
		
		#region Operation Methods Implementation
		public override GetUserByIdResponse OnGetUserByIdExecute(GetUserByIdRequest request)
        {
            var response = new GetUserByIdResponse();
            try
            {
                var spec = new UserByIdSpec(request.Id);
                var repository = _userRepository.Get(spec);

                response.User = _mapperService.Map<UserDto>(repository);
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                response.MessageResponse.Add(StatusSeverity.Error, Constants.Cod0001);
            }
            return response;
        }
		#endregion
	}
}
