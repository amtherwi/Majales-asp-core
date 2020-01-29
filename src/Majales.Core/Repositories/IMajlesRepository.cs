using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Repositories;
using Majales.Models;

namespace Majales.Repositories
{
    public interface IMajlesRepository : IRepository<Majles,int>
    {
        int GetMajlesQuantity(int userid);
    }
}