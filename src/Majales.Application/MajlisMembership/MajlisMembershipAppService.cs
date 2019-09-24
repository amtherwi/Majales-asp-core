using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.MajlisMembership.DTO;

namespace Majales.MajlisMembership
{
    public class MajlisMembershipAppService : ApplicationService, IMajlisMembershipAppService
    {
        private readonly IMajlisMembershipManager _majlisMembershipManager;

        public MajlisMembershipAppService(IMajlisMembershipManager majlisMembershipManager)
        {
            _majlisMembershipManager = majlisMembershipManager;
        }
        public IEnumerable<GetMajlisMembershipOutput> GetAll()
        {
            var getAll = _majlisMembershipManager.GetAllList().ToList();
            List<GetMajlisMembershipOutput> output = Mapper.Map<List<Models.MajlisMembership>, List<GetMajlisMembershipOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateMajlisMembershipInput input)
        {
            Models.MajlisMembership output = Mapper.Map<CreateMajlisMembershipInput, Models.MajlisMembership>(input);
            await _majlisMembershipManager.Create(output);
        }

        public void Update(UpdateMajlisMembershipInput input)
        {
            Models.MajlisMembership output = Mapper.Map<UpdateMajlisMembershipInput, Models.MajlisMembership>(input);
            _majlisMembershipManager.Update(output);
        }

        public void Delete(DeleteMajlisMembershipInput input)
        {
            _majlisMembershipManager.Delete(input.Id);
        }

        public GetMajlisMembershipOutput GetMajlisMembershipById(GetMajlisMembershipInput input)
        {
            var getMajlisMembership = _majlisMembershipManager.GetMajlisMembershipByID(input.Id);
            GetMajlisMembershipOutput output = Mapper.Map<Models.MajlisMembership, GetMajlisMembershipOutput>(getMajlisMembership);
            return output;
        }
    }
}
