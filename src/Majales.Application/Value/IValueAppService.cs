using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Value.DTO;

namespace Majales.Value
{
    public interface IValueAppService : IApplicationService
    {
        IEnumerable<GetValueOutput> ListAll();
        Task Create(CreateValueInput input);
        void Update(UpdateValueInput input);
        void Delete(DeleteValueInput input);
        GetValueOutput GetValueById(GetValueInput input);

    }
}
