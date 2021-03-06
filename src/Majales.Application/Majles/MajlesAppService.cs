using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using Majales.Authorization;
using Majales.Core.Models.Manager;
using Majales.Majles.DTO;
using Majales.Models;

namespace Majales.Majles
{
        // [AbpAuthorize(PermissionNames.Pages_Majles)]
    //public class MajlesAppService : CrudAppService<Models.Majles, MajlesDto>
    //{
    //    public MajlesAppService(IRepository<Models.Majles, int> repository) 
    //    :base(repository)
    //    {
            
    //    }
        
    //}
    //  [AbpAuthorize(PermissionNames.Pages_Majles)]
     public class MajlesAppService : ApplicationService,IMajlesAppService
     {
         private readonly IMajlesManager _majlesManager;

         public MajlesAppService(IMajlesManager majlesManager)
         {
             _majlesManager = majlesManager;
         }
         public IEnumerable<GetMajlesOutput> GetAll()
         {
             var getAll = _majlesManager.GetAllList().ToList();
             List<GetMajlesOutput> output = Mapper.Map<List<Models.Majles>, List<GetMajlesOutput>>(getAll);
             return output;
         }

         public GetMajlesOutput GetMajlesById(GetMajlesInput input)
         {
             var getMajles = _majlesManager.GetMajlesByID(input.Id);
             GetMajlesOutput output = Mapper.Map<Models.Majles, GetMajlesOutput>(getMajles);
             return output;
         }

         public async Task Create(CreateMajlesInput input)
         {
             Models.Majles output = Mapper.Map<CreateMajlesInput, Models.Majles>(input);
             await _majlesManager.Create(output);
         }

         public void Update(UpdateMajlesInput input)
         {
             Models.Majles output = Mapper.Map<UpdateMajlesInput, Models.Majles>(input);
             _majlesManager.Update(output);
         }

         public void Delete(DeleteMajlesInput input)
         {
             _majlesManager.Delete(input.Id);
         }

    
     }
}