using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Domain
{
    public class SchoolBusRegistrationContext:DbContext
    {
        public DbSet<TransportRequest> TransportRequests { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }
    }
}
