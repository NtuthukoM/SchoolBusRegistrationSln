using SchoolBusRegistration.Domain;
using System.ComponentModel.DataAnnotations;

namespace SchoolBusRegistration.Core.ViewModels
{
    public class TransportRequestFormViewModel
    {
        public int? TransportType { get; set; }
        [Required]
        public DateTime? StartDate { get; set; } = null;
        //Parent details:
        [Required]
        public string? ParentName { get; set; }
        public string? IdentityNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? Address { get; set; }

        public string? ChildName { get; set; }
        [Range(9, 20)]
        [Required]
        public int? Age { get; set; }
        [Required]
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