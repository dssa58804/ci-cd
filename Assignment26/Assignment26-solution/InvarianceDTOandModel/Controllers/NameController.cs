using Microsoft.AspNetCore.Mvc;
using ValidateTheNameModelBinding.Models;
using ValidateTheNameModelBinding.Util;

namespace ValidateTheNameWebApplication.Controllers
{
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", new { nameIsValid = false, showNameEvaluation = false });
        }

        [HttpPost]
        public IActionResult ValidateName(PersonDTO personDto)
        {
            try
            {
                var firstName = new FirstName(personDto.Firstname);
                var lastName = new LastName(personDto.Lastname);
                var person = new Person(firstName, lastName);

                // Hvis alt er gyldigt:
                return Ok($"Valid name: {person.GetFirstName()} {person.GetLastName()}");
            }
            catch (Exception ex)
            {
                // Returnér fejlbeskeden
                return BadRequest(ex.Message);
            }
        }       
    }
}
