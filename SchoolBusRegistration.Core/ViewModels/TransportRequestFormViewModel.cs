using SchoolBusRegistration.Domain;
using System.ComponentModel.DataAnnotations;

namespace SchoolBusRegistration.Core.ViewModels
{
    public class TransportRequestFormViewModel
    {
        public bool HasErrors { get; set; }
        [Display(Name = "Transport Type")]
        public int? TransportType { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; } = null;
        //Parent details:
        [Required]
        [Display(Name = "Parent Name")]
        public string? ParentName { get; set; }
        [Required]
        [Display(Name = "Identity Number")]
        public string? IdentityNumber { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }
        [Required]
        public string? Address { get; set; }
        //Child details:
        [Required]
        [Display(Name = "Child Name")]
        public string? ChildName { get; set; }
        [Range(9, 20)]
        [Required]
        public int? Age { get; set; }
        [Required]
        [Display(Name = "Grade")]
        public int? GradeId { get; set; }

        public List<GradeViewModel>? Grades { get; set; } = null;
        public Dictionary<int, string> TransportTypes { get; set; } = new Dictionary<int, string>
        {
            { 1, "From Home To School" },
            { 2, "From School To Home" },
            {3, "Both trips" }
        };
    }
}