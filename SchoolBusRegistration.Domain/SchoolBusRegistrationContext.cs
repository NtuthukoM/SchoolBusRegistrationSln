using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolBusRegistration.Domain.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Domain
{
    public class SchoolBusRegistrationContext : DbContext
    {

        public DbSet<TransportRequest> TransportRequests { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }

        public SchoolBusRegistrationContext(DbContextOptions<SchoolBusRegistrationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
        }
    }
}
