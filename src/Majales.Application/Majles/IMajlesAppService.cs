using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Majles.DTO;

namespace Majales.Majles
{
    public interface IMajlesAppService:IApplicationService
    {
        IEnumerable<GetMajlesOutput> ListAll();
        Task Create(CreateMajlesInput input);
        void Update(UpdateMajlesInput input);
        void Delete(DeleteMajlesInput input);
        GetMajlesOutput GetMajlesById(GetMajlesInput input);
    }
}