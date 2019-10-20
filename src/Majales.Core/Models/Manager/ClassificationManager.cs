using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;
using Microsoft.EntityFrameworkCore;

namespace Majales.Core.Models.Manager
{
    public class ClassificationManager: DomainService, IClassificationManager
    {
        private readonly IRepository<Classification> _repositoryClassification;
        public ClassificationManager(IRepository<Classification> repositoryClassification)
        {
            _repositoryClassification = repositoryClassification;
        }
        public async Task<Classification> Create(Classification entity)
        {
            var classification = _repositoryClassification.FirstOrDefault(x => x.Id == entity.Id);
            if(classification != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryClassification.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var classification = _repositoryClassification.FirstOrDefault(x => x.Id == id);
            if( classification == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryClassification.Delete(classification);
            }
            
        }

        public  IEnumerable<Classification> GetAllList()
        {
            return _repositoryClassification.GetAllIncluding(x => x.MajlesType);
              //  .GetAll()
              //  .Include(x => x.MajlesType);
                //.ToList();

        }

        public Classification GetClassificationByID(int id)
        {
   
            var classification = _repositoryClassification.GetAllIncluding(x => x.MajlesType).FirstOrDefault(c => c.Id == id);
            if(classification == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else{
                return classification;

            }



            //return _repositoryClassification.Get(id);
        }

        public Classification GetClassificationByMajlesTypeID(int id)
        {

            var classification = _repositoryClassification.GetAllIncluding(x => x.MajlesType).FirstOrDefault(c => c.MajlesTypeId == id);
            if(classification == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else{
                return classification;//classifications.FirstOrDefault(c => c.MajlesTypeId == id);
            }

        }

        public void Update(Classification entity)
        {
             _repositoryClassification.Update(entity);
        } 
    
    }
}