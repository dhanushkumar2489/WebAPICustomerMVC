using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCoreMVCCustomerEx.Models;

namespace WebAppCoreMVCCustomerEx.Data
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext (DbContextOptions<CustomerDBContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCoreMVCCustomerEx.Models.Customer> Customer { get; set; }
    }
}
