namespace Application.Boundaries.RegisterCustomer
{
    using System;
    using System.Collections.Generic;
    using Domain.Customers;
    using Domain.ValueObjects;

    public sealed class Customer
    {
        public Guid CustomerId { get; }
        public SSN SSN { get; }
        public Name Name { get; }
        public Username Username { get; }
        public IReadOnlyList<Account> Accounts { get; }

        public Customer(ICustomer customer, List<Account> accounts)
        {
            var customerEntity = (Domain.Customers.Customer) customer;
            CustomerId = customerEntity.Id;
            SSN = customerEntity.SSN;
            Name = customerEntity.Name;
            Username = customerEntity.Username;
            Accounts = accounts;
        }
    }
}