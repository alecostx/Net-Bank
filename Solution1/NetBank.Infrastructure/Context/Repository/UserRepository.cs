using Microsoft.EntityFrameworkCore;
using NetBank.Domain.Interfaces.Repository;
using NetBank.Domain.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBank.Infrastructure.Context.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
