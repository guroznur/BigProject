using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _BrandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _BrandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {

                _BrandDal.Add(brand);
                 return new SuccessResult(Messages.BrandAdded);

        }

        public IResult Delete(Brand brand)
        {
            _BrandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>>GetAll()
        {
           return new SuccessDataResult<List<Brand>>(_BrandDal.GetAll());
        }

        public IDataResult<List<BrandDetailDto>> GetBrandDetails()
        {
            return new SuccessDataResult<List<BrandDetailDto>>(_BrandDal.GetBrandDetails());
        }

        public IDataResult<Brand> GetByColorId(int id)
        {
            return new SuccessDataResult<Brand>(_BrandDal.Get(p => p.BrandId == id));

        }

        public IResult Update(Brand brand)
        {
            
                _BrandDal.Update(brand);
                 return new SuccessResult(Messages.BrandUpdated);


        }

        
    }
}
