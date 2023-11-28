using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Turbokart.Presentation.Websites.TurbokartDK.Pages
{
    public class BookingModel : PageModel
    {
        [BindProperty, EmailAddress, Required, Display(Name = "Your Email Address")]
        public string CustomerEmail { get; set; }
        [BindProperty, Phone, Required(ErrorMessage = "Please supply your phone number"), Display(Name = "Your Phone Number")]
        public string PhoneNumber { get; set; }
        [BindProperty, Required, Display(Name = "Start Date")]
        public DateTime StartDate { get; set; } = DateTime.Today;
        [BindProperty, Required, Display(Name = "Start Time")]
        public string StartTime { get; set; } = "10:30";
        [BindProperty, Required, Display(Name = "Number of people")]
        public int People { get; set; } = 1;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            return RedirectToPage("BookingSuccess");
        }
    }
}
