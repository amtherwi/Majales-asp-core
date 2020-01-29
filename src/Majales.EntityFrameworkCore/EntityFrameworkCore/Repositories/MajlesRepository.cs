using Abp.EntityFrameworkCore;
using Majales.Models;
using Majales.Repositories;
using Majales.Core.Models.Manager;
using System.Linq;

namespace Majales.EntityFrameworkCore.Repositories
{
    public class MajlesRepository : MajalesRepositoryBase<Majles,int> , IMajlesRepository
    {
        public MajlesRepository(IDbContextProvider<MajalesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
 
        }

        private MajalesDbContext db  ;
        public int GetMajlesQuantity(int userid)
        {

            var a = (from m in db.Members
                    join o in db.MajlisMembership on m.UserId equals o.Id
                    join b in db.MembershipRoles on m.UserId equals b.Id
                    where m.UserId == userid
                    select b).Count();
            return a;

        }
    }
}