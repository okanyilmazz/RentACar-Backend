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
    public class BodyManager : IBodyService
    {
        IBodyDal _bodyDal;
        public BodyManager(IBodyDal bodyDal)
        {
            _bodyDal = bodyDal;
        }
        public IResult Add(Body body)
        {
            _bodyDal.Add(body);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Body body)
        {
            _bodyDal.Delete(body);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<Body> Get(int id)
        {
            return new SuccessDataResult<Body>(_bodyDal.Get(b => b.Id == id));
        }

        public IDataResult<List<Body>> GetAll()
        {
            return new SuccessDataResult<List<Body>>(_bodyDal.GetAll());
        }

        public IResult Update(Body body)
        {
            _bodyDal.Update(body);
            return new Result(true, Messages.Updated);
        }
    }
}
