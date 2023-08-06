using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;

        }

        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll());
        }

        public IDataResult<Payment> GetById(int id)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Payment>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll(p => p.UserId == userId));
        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new Result(true, Messages.Updated);
        }
    }
}
