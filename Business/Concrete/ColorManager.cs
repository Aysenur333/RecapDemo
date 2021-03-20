using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IResult GetById(int colorId)
        {
            return new SuccessDataResult<Color> (_colorDal.Get(c => c.ColorId == colorId));
        }
        public IResult Add(Color color)
        {
            if (color.ColorName.Length<1)
            {
                return new ErrorResult(Messages.ColorNameInValid);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }
       
    }
}
