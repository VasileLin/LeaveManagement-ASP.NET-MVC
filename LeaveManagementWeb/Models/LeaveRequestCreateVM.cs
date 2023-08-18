using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace LeaveManagementWeb.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]

        public DateTime? EndDate { get; set; }
        [Required]
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }
        [Display(Name = "Request Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate>EndDate)
            {
                yield return new ValidationResult("Start date must be before end date", new[] {nameof(StartDate),nameof(EndDate)});
            }

            if (RequestComments?.Length > 500)
            {
                yield return new ValidationResult("Comments are too long", new[] { nameof(RequestComments)});

            }
        }
    }
}
