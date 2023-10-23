using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Domain
{
    public enum TransportType
    {
        FromHomeToSchool = 1,
        FromSchoolToHome = 2,
        FromHomeToSchoolAndFromSchoolToHome = 3
    }
}
