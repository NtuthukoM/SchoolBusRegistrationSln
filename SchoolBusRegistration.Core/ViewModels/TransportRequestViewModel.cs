using SchoolBusRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Core.ViewModels
{
    public class TransportRequestViewModel
    {
        public TransportType TransportType { get; set; }
        public string TransportTypeDescription { get { return TransportType.ToString(); } }
        public DateTime StartDate { get; set; }
        public int ParentId { get; set; }
        //Parent details:
        public string ParentName { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public int ChildId { get; set; }

        public string ChildName { get; set; }
        public int Age { get; set; }
        public int? GradeId { get; set; }
        public string GradeName { get; set; }
    }
}
