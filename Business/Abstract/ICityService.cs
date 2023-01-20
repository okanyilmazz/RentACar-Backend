﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();
        IDataResult<City> GetById(int id);
        IDataResult<List<City>> GetByCountryId(int id);
        IResult Add(City city);
        IResult Update(City city);
        IResult Delete(City city);
    }
}
