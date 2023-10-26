using SchoolBusRegistration.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Core.ViewModels
{
    public class TransportRequestViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Transport Type")]
        public TransportType TransportType { get; set; }
        [Display(Name= "Transport Type")]
        public string TransportTypeDescription { get { return TransportType.ToString(); } }
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        public int ParentId { get; set; }
        //Parent details:
        [Display(Name = "Parent Name")]
        public string ParentName { get; set; }
        [Display(Name = "Identity Number")]
        public string IdentityNumber { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public int ChildId { get; set; }
        //Child details:
        [Display(Name = "Child Name")]
        public string ChildName { get; set; }
        public int Age { get; set; }
        public int? GradeId { get; set; }
        [Display(Name = "Grade")]
        public string GradeName { get; set; }
    }
}
