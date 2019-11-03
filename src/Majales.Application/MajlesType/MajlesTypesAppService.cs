using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.MajlesType.DTO;
using Majales.Core.Models.Manager;

namespace Majales.MajlesType
{
    public class MajlesTypeAppService:ApplicationService, IMajlesTypeAppService
    {
        private readonly IMajlesTypeManager _MajlesTypeManager;
        public MajlesTypeAppService(IMajlesTypeManager MajlesTypeManager)
        {
            _MajlesTypeManager = MajlesTypeManager;
        }

        public async Task Create(CreateMajlesTypeInput input)
        {
            Models.MajlesType output = Mapper.Map<CreateMajlesTypeInput, Models.MajlesType>(input);
            await _MajlesTypeManager.Create(output);
        }
        public void Update(UpdateMajlesTypeInput input)
        {
            Models.MajlesType output = Mapper.Map<UpdateMajlesTypeInput, Models.MajlesType>(input);
            _MajlesTypeManager.Update(output);
        }
        public void Delete(DeleteMajlesTypeInput input)
        {
            _MajlesTypeManager.Delete(input.Id);
        }

 
        public IEnumerable<GetMajlesTypeOutput> GetAll()
        {
            var getAll = _MajlesTypeManager.GetAllList().ToList();
            List<GetMajlesTypeOutput> output = Mapper.Map<List<Models.MajlesType>, List<GetMajlesTypeOutput>>(getAll);
            return output;
        }

        public GetMajlesTypeOutput GetMajlesTypesById(GetMajlesTypeInput input)
        {
            var getMajlesType = _MajlesTypeManager.GetMajlesTypeByID(input.Id);
            GetMajlesTypeOutput output = Mapper.Map<Models.MajlesType, GetMajlesTypeOutput>(getMajlesType);
            return output;
        }
        public GetMajlesTypeOutput GetMajlesTypesByType(GetMajlesTypeInput input)
        {
            var getMajlesType = _MajlesTypeManager.GetMajlesTypeByType(input.Type);
            GetMajlesTypeOutput output = Mapper.Map<Models.MajlesType, GetMajlesTypeOutput>(getMajlesType);
            return output;
        }
    }
}
