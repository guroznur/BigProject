using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    { 


        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);

        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var getAll = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(getAll);
        }

        public IDataResult<Customer> GetById(int id)
        {
            var getById = _customerDal.Get(p => p.Id == id);
            return new SuccessDataResult<Customer>(getById);
        }

        public IResult Update(Customer customer)
        {
           _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }

    
}
