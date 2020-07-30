using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiEFCore.Model;

namespace WebApiEFCore.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer { 
                    CustomerId=1,
                    Name = "Manoj Bandara",
                    Age = 30
                },
                new Customer { 
                    CustomerId=2,
                    Name = "Malin bandara",
                    Age = 28
                }
                );
        }
    }
}
