using AutoMapper;
using AutoMapper.QueryableExtensions;
using SchoolBusRegistration.Core.ViewModels;
using SchoolBusRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Core.Services
{
    public class GradeService : IGradeService
    {
        private readonly IMapper mapper;
        private readonly SchoolBusRegistrationContext context;

        public GradeService(IMapper mapper, SchoolBusRegistrationContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public List<GradeViewModel> GetGrades()
        {
            return context.Grades
                .ProjectTo<GradeViewModel>(mapper.ConfigurationProvider)
                .ToList();
        }
    }
}
