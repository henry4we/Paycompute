﻿using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services.Implement
{
    class EmployeeService : IEmployeeService
    {
        public Task CreateAsync(Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public decimal StudentLoanRepaymentAmount(int id, decimal totalAmount)
        {
            throw new NotImplementedException();
        }

        public decimal UnionFees(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
