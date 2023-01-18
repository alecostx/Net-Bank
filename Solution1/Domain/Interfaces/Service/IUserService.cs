using NetBank.Domain.Models.Requests;
using NetBank.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBank.Domain.Interfaces.Service
{
    public interface IUserService
    {
        Task<List<UserResponse>> GetUsersAsync(GetUserRequest request);
    }
}
