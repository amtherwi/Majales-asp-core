using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.Value.DTO;

namespace Majales.Value
{
    public class ValueAppService : ApplicationService, IValueAppService
    {
        private readonly IValueManager _valueManager;

        public ValueAppService(IValueManager valueManager)
        {
            _valueManager = valueManager;
        }
        public IEnumerable<GetValueOutput> ListAll()
        {
            var getAll = _valueManager.GetAllList().ToList();
            List<GetValueOutput> output = Mapper.Map<List<Models.Value>, List<GetValueOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateValueInput input)
        {
            Models.Value output = Mapper.Map<CreateValueInput, Models.Value>(input);
            await _valueManager.Create(output);
        }

        public void Update(UpdateValueInput input)
        {
            Models.Value output = Mapper.Map<UpdateValueInput, Models.Value>(input);
            _valueManager.Update(output);
        }

        public void Delete(DeleteValueInput input)
        {
            _valueManager.Delete(input.Id);
        }

        public GetValueOutput GetValueById(GetValueInput input)
        {
            var getValue = _valueManager.GetValueByID(input.Id);
            GetValueOutput output = Mapper.Map<Models.Value, GetValueOutput>(getValue);
            return output;
        }
    }
}
