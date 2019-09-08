using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Classification.DTO;
using Majales.Core.Models.Manager;

namespace Majales.Classification
{
    public class ClassificationAppService:ApplicationService, IClassificationAppService
    {
        private readonly IClassificationManager _classificationManager;
        public ClassificationAppService(IClassificationManager classificationManager)
        {
            _classificationManager = classificationManager;
        }

        public async Task Create(CreateClassificationInput input)
        {
            Models.Classification output = Mapper.Map<CreateClassificationInput, Models.Classification>(input);
            await _classificationManager.Create(output);
        }
        public void Update(UpdateClassificationInput input)
        {
            Models.Classification output = Mapper.Map<UpdateClassificationInput, Models.Classification>(input);
            _classificationManager.Update(output);
        }
        public void Delete(DeleteClassificationInput input)
        {
            _classificationManager.Delete(input.Id);
        }

        public GetClassificationOutput GetClassificationById(GetClassificationInput input)
        {
            var getClassification = _classificationManager.GetClassificationByID(input.Id);
            GetClassificationOutput output = Mapper.Map<Models.Classification, GetClassificationOutput>(getClassification);
            return output;
        }

        public IEnumerable<GetClassificationOutput> ListAll()
        {
            var getAll = _classificationManager.GetAllList().ToList();
            List<GetClassificationOutput> output = Mapper.Map<List<Models.Classification>, List<GetClassificationOutput>>(getAll);
            return output;
        }

    }
}
