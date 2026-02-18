using ISYS366Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISYS366Assignment2.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet=true)]
        public PersonModel? Person { get; set; } = null;
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("Index OnGet");
            if (Person != null)
            {
                _logger.LogInformation("Person Name: {Name}", Person.Name);
                _logger.LogInformation("Person Age: {Age}", Person.Age);
            }
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Index OnPost - redirecting to Privacy");
            if (Person != null)
            {
                _logger.LogInformation("Person Name: {Name}", Person.Name);
                _logger.LogInformation("Person Age: {Age}", Person.Age);
            }
            return RedirectToPagePreserveMethod("/Privacy");
        }
    }
}
