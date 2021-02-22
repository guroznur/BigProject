using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _ColorDal;
        public ColorManager(IColorDal colorDal)
        {
            _ColorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _ColorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);

        }

        public IResult Delete(Color color)
        {
            _ColorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            throw new NotImplementedException();
        }

        //public IDataResult<List<Color>> GetAll()
        //{
        //   return new SuccessDataResult<Color>(_ColorDal.GetAll(),Messages.ColorsListed);
        //}

        public IDataResult<Color> GetByColorId(int id)
        {
            return new SuccessDataResult<Color>(_ColorDal.Get(p=>p.ColorId==id));
        }

        public IResult Update(Color color)
        {
            _ColorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
