using Abp.EntityFrameworkCore;
using Majales.Models;
using Majales.Repositories;

namespace Majales.EntityFrameworkCore.Repositories
{
    public class MajlesRepository : MajalesRepositoryBase<Majles,int> , IMajlesRepository
    {
        public MajlesRepository(IDbContextProvider<MajalesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
 
        }

        public int GetMajlesQuantity(int majlesId)
        {
            return 10;
        }
    }
}