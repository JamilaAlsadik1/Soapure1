using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soapure.Models;

namespace Soapure.Data
{
    public class SoapureContext : DbContext
    {
        public SoapureContext (DbContextOptions<SoapureContext> options)
            : base(options)
        {
        }

        public DbSet<Soapure.Models.Soap> Soap { get; set; }
    }
}
