using NetBank.Domain.Interfaces.Repository;
using NetBank.Domain.Interfaces.Service;
using NetBank.Domain.Mapper.ToDomain.Response;
using NetBank.Domain.Models.Requests;
using NetBank.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBank.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserResponse>> GetUsersAsync(GetUserRequest request)
        {
            var users = await _userRepository.GetAsync();
            var result = UsersToDomainMapping.ListUsers(users);
            return result;
        }
    }
}
