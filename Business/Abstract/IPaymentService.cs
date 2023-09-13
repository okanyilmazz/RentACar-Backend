using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IDataResult<List<Payment>> GetAll();
        IDataResult<Payment> GetById(int id);
        IDataResult<List<Payment>> GetByUserId(int userId);
        IResult Add(Payment payment);
        IDataResult<Payment> Pay(PaymentPayDto paymentPayDto);
        IResult Update(Payment payment);
        IResult Delete(Payment payment);
    }
}
