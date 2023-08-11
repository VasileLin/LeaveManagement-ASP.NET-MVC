using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name ="Default numbers of days")]
        [Required]
        [Range(1,50,ErrorMessage = "Pleas enter a valid number")]
        public int DefaultDays { get; set; }
    }
}
