using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Classification.DTO;

namespace Majales.Classification
{
    public interface IClassificationAppService : IApplicationService
    {
        IEnumerable<GetClassificationOutput> GetAll();
        Task Create(CreateClassificationInput input);
        void Update(UpdateClassificationInput input);
        void Delete(DeleteClassificationInput input);
        GetClassificationOutput GetClassificationById(GetClassificationInput input);
       GetClassificationOutput GetClassificationByMajlesTypeId(GetClassificationInput input);


    }
}
