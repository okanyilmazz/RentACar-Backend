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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<Contact> Get(int id)
        {
            return new SuccessDataResult<Contact>(_contactDal.Get(b => b.Id == id));
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll());
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new Result(true, Messages.Updated);
        }
    }
}
