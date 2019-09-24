using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.MajlesTypes.DTO;
using Majales.Core.Models.Manager;

namespace Majales.MajlesTypes
{
    public class MajlesTypesAppService:ApplicationService, IMajlesTypesAppService
    {
        private readonly IMajlesTypesManager _MajlesTypesManager;
        public MajlesTypesAppService(IMajlesTypesManager MajlesTypesManager)
        {
            _MajlesTypesManager = MajlesTypesManager;
        }

        public async Task Create(CreateMajlesTypesInput input)
        {
            Models.MajlesTypes output = Mapper.Map<CreateMajlesTypesInput, Models.MajlesTypes>(input);
            await _MajlesTypesManager.Create(output);
        }
        public void Update(UpdateMajlesTypesInput input)
        {
            Models.MajlesTypes output = Mapper.Map<UpdateMajlesTypesInput, Models.MajlesTypes>(input);
            _MajlesTypesManager.Update(output);
        }
        public void Delete(DeleteMajlesTypesInput input)
        {
            _MajlesTypesManager.Delete(input.Id);
        }

        public GetMajlesTypesOutput GetMajlesTypesById(GetMajlesTypesInput input)
        {
            var getMajlesTypes = _MajlesTypesManager.GetMajlesTypesByID(input.Id);
            GetMajlesTypesOutput output = Mapper.Map<Models.MajlesTypes, GetMajlesTypesOutput>(getMajlesTypes);
            return output;
        }

        public IEnumerable<GetMajlesTypesOutput> GetAll()
        {
            var getAll = _MajlesTypesManager.GetAllList().ToList();
            List<GetMajlesTypesOutput> output = Mapper.Map<List<Models.MajlesTypes>, List<GetMajlesTypesOutput>>(getAll);
            return output;
        }

    }
}
