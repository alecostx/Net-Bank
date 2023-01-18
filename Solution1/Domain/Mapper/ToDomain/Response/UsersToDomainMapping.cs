using NetBank.Domain.Models.Context;
using NetBank.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBank.Domain.Mapper.ToDomain.Response
{
    public class UsersToDomainMapping
    {
        internal static List<UserResponse> ListUsers(List<User> response)
        {
            if (response == null)
            {
                return null;
            }

            var domain = new List<UserResponse>();

            response.ForEach(content =>
            {
                domain.Add(new UserResponse
                {
                    UserId = content.UserId,
                    Name= content.Name,
                    Email = content.Email,
                    Document = content.Document
                });
            });

            return domain;
        }
    }
}
