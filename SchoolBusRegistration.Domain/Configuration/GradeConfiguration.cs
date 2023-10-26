using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Domain.Configuration
{
    internal class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasData(
                new Grade { Id = 1, Title = "Grade 8" },
                new Grade { Id = 2, Title = "Grade 9" },
                new Grade { Id = 3, Title = "Grade 10" },
                new Grade { Id = 4, Title = "Grade 11" },
                new Grade { Id = 5, Title = "Grade 12" }
                );
        }
    }
}
