using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.Classification.DTO;

namespace Majales.Classification
{
    public class ClassificationAppService : ApplicationService, IClassificationAppService
    {
        private readonly IClassificationManager _ClassificationManager;

        public ClassificationAppService(IClassificationManager ClassificationManager)
        {
            _ClassificationManager = ClassificationManager;
        }
        public IEnumerable<GetClassificationOutput> ListAll()
        {
            var getAll = _ClassificationManager.GetAllList().ToList();
            List<GetClassificationOutput> output = Mapper.Map<List<Models.Classification>, List<GetClassificationOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateClassificationInput input)
        {
            Models.Classification output = Mapper.Map<CreateClassificationInput, Models.Classification>(input);
            await _ClassificationManager.Create(output);
        }

        public void Update(UpdateClassificationInput input)
        {
            Models.Classification output = Mapper.Map<UpdateClassificationInput, Models.Classification>(input);
            _ClassificationManager.Update(output);
        }

        public void Delete(DeleteClassificationInput input)
        {
            _ClassificationManager.Delete(input.Id);
        }

        public GetClassificationOutput GetClassificationById(GetClassificationInput input)
        {
            var getClassification = _ClassificationManager.GetClassificationByID(input.Id);
            GetClassificationOutput output = Mapper.Map<Models.Classification, GetClassificationOutput>(getClassification);
            return output;
        }
    }
}
