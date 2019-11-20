using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.MajlesType.DTO;

namespace Majales.MajlesType
{
    public interface IMajlesTypeAppService: IApplicationService
    {
        IEnumerable<GetMajlesTypeOutput> GetAll();
        Task Create(CreateMajlesTypeInput input);
        void Update(UpdateMajlesTypeInput input);
        void Delete(DeleteMajlesTypeInput input);
        GetMajlesTypeOutput GetMajlesTypesById(GetMajlesTypeInput input);
        GetMajlesTypeOutput GetMajlesTypesByType(GetMajlesTypeInput input);

    }
}
