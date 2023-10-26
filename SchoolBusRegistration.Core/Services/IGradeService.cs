using SchoolBusRegistration.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Core.Services
{
    public interface IGradeService
    {
        List<GradeViewModel> GetGrades();
    }
}
