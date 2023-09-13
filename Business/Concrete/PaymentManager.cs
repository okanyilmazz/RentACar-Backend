using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IDataResult<Payment> Pay(PaymentPayDto paymentPayDto)
        {
            var getPayment = paymentPayDto.Payment;
            var getTotalPrice = paymentPayDto.TotalPrice;
            double usableBalanceLimit = getPayment.UsableBalanceLimit;
            double newBalance;

            IResult result = BusinessRules.Run(CheckBalance(getTotalPrice, usableBalanceLimit));
            if (result != null)
            {

                return new DataResult<Payment>(getPayment, result.Success, result.Message);
            }
            newBalance = (usableBalanceLimit - getTotalPrice);

            Payment newPayment = new Payment
            {
                Id = getPayment.Id,
                CardMonth = getPayment.CardMonth,
                CardName = getPayment.CardName,
                CardNumber = getPayment.CardNumber,
                CardSecurityCode = getPayment.CardSecurityCode,
                CardYear = getPayment.CardYear,
                UserId = getPayment.UserId,
                UsableBalanceLimit = newBalance
            };

            return new SuccessDataResult<Payment>(newPayment, (Messages.SuccessfulPayment));

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

        private IResult CheckBalance(double totalPrice, double usableBalanceLimit)
        {
            if (totalPrice <= usableBalanceLimit)
            {
                return new SuccessResult();
            }
            else
            {
                return new Result(false,Messages.InsufficientBalance);
            }
        }
    }
}
