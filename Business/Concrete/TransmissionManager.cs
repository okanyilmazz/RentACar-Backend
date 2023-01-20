using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TransmissionManager : ITransmissionService
    {
        ITransmissionDal _transmissionDal;

        public TransmissionManager(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }
        public IResult Add(Transmission transmission)
        {
            _transmissionDal.Add(transmission);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Transmission transmission)
        {
            _transmissionDal.Delete(transmission);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<Transmission> Get(int id)
        {
            return new SuccessDataResult<Transmission>(_transmissionDal.Get(t => t.Id == id));
        }

        public IDataResult<List<Transmission>> GetAll()
        {
            return new SuccessDataResult<List<Transmission>>(_transmissionDal.GetAll());
        }

        public IResult Update(Transmission transmission)
        {
            _transmissionDal.Update(transmission);
            return new Result(true, Messages.Updated);
        }
    }
}
