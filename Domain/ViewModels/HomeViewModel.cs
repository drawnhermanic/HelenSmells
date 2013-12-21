using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModels
{
    public class HomeViewModel
    {
        public string WelcomeImage { get; set; }

        [Display(Name = "What's your name")]
        [Required(ErrorMessage = "You need to enter your name")]
        public string YourName { get; set; }

        [Display(Name = "Date of birth")]
        [Required(ErrorMessage = "You need to enter your date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateOfBirth { get; set; }

        public string Message { get; set; }
    }
}