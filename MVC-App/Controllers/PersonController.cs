using EntityFramework_ClassLibrary;
using EntityFramework_ClassLibrary.Business.Implementation;
using EntityFramework_ClassLibrary.Business.Interface;
using EntityFramework_ClassLibrary.Domain.Model;
using MVC_App.Models;
using System;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EnterPersonDetails()
        {
            return View();
        }
        public ActionResult SavePersonDetails(PersonModel model)
        {
            IPersonService personService = new PersonService();

            /* Transfer values from PersonModel to PersonEntity Start*/
            PersonEntity personEntity = new PersonEntity();
            personEntity.Id = new Random().Next(1, 1000);
            personEntity.FirstName = model.FirstName;
            personEntity.LastName = model.LastName;
            personEntity.DOB = model.DOB;
            personEntity.State = model.State;
            /* Transfer values from PersonModel to PersonEntity End*/

            personService.SavePersonDetails(personEntity);
          

            //Call create person pass UserId
            PersonEntity person = new PersonEntity()
            {
                FirstName = "TempValue",
                LastName = "TempValue",
                Id = new Random().Next(1, 1000),
                DOB = model.DOB,
                State = "ME"
            };
            personService.SavePersonDetails(person);

            return View("SavedSuccess");
        }
        public ActionResult SavedSuccess()
        {
            return View();
        }
    }
}