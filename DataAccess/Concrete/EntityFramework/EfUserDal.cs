using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal: EfEntityRepositoryBase<User,ReCapProjectContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.Id
                             select new UserDetailDto
                             {
                                CompanyName = c.CompanyName,
                                FirstName = u.FirstName,
                                LastName = u.LastName,
                                Email = u.Email,
                             };
                return result.ToList();
            }
        }
    }
}
