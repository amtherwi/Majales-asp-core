using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.MajlesTypes.DTO;

namespace Majales.MajlesTypes
{
    public interface IMajlesTypesAppService: IApplicationService
    {
        IEnumerable<GetMajlesTypesOutput> GetAll();
        Task Create(CreateMajlesTypesInput input);
        void Update(UpdateMajlesTypesInput input);
        void Delete(DeleteMajlesTypesInput input);
        GetMajlesTypesOutput GetMajlesTypesById(GetMajlesTypesInput input);
    }
}
