using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        IInvoiceDal _invoiceDal;

        public InvoiceManager(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        }
        public IResult Add(Invoice invoice)
        {
            _invoiceDal.Add(invoice);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Invoice invoice)
        {
            _invoiceDal.Delete(invoice);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Invoice>> GetAll()
        {
            return new SuccessDataResult<List<Invoice>>(_invoiceDal.GetAll());
        }

        public IDataResult<Invoice> GetById(int id)
        {
            return new SuccessDataResult<Invoice>(_invoiceDal.Get(d => d.Id == id));
        }
        public IDataResult<List<Invoice>> GetByUserId(int id)
        {
            return new SuccessDataResult<List<Invoice>>(_invoiceDal.GetAll(d => d.UserId == id));
        }

        public IDataResult<List<InvoiceDetailDto>> GetDetailByUserId(int id)
        {
            return new SuccessDataResult<List<InvoiceDetailDto>>(_invoiceDal.GetDetailByUserId(id));
        }

        public IResult Update(Invoice invoice)
        {
            _invoiceDal.Update(invoice);
            return new Result(true, Messages.Updated);
        }
    }
}
