using SchoolBusRegistration.Domain;

namespace SchoolBusRegistration.Core.ViewModels
{
    public class TransportRequestFormViewModel
    {
        public int TransportType { get; set; }
        public DateTime StartDate { get; set; }
        //Parent details:
        public string ParentName { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }

        public string ChildName { get; set; }
        public int Age { get; set; }
        public int? GradeId { get; set; }

        public List<GradeViewModel> Grades { get; set; }
    }
}