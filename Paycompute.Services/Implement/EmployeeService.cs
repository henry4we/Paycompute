﻿using Paycompute.Entity;
using Paycompute.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services.Implement
{
    class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService( ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task CreateAsync(Employee newEmployee)
        {
            await _context.Employees.AddAsync(newEmployee);
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int employeeId)
        {
            var employee = GetById(employeeId);
            _context.Remove(employee);
            await _context.SaveChangesAsync();

         
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
