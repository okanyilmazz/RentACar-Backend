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
    public class NewsManager : INewsService
    {
        INewsDal _newsDal;

        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public IResult Add(News news)
        {
            _newsDal.Add(news);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(News news)
        {
            _newsDal.Delete(news);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<News> Get(int id)
        {
            return new SuccessDataResult<News>(_newsDal.Get(c => c.Id == id));
        }

        public IDataResult<List<News>> GetAll()
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetAll(), Messages.Listed);
        }

        public IResult Update(News news)
        {
            _newsDal.Update(news);
            return new SuccessResult(Messages.Updated);
        }
    }
}
