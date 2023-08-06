﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> Get(int id);
        IDataResult<List<Rental>> GetByUserId(int id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByUserId(int id);
    }
}
