using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Display(Name = "No")]
        public int EmployeeId { get; set; }

        [StringLength(maximumLength: 30, ErrorMessage = "Name cannot exceed 30 characters")]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Reg")]
        [Required]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Selected Days")]
        [Required]
        public string SelectedDays { get; set; }

        [Display(Name = "Add. request")]
        [StringLength(100)]
        public string Request { get; set; }
    }
}
