using AutoMapper;
using EntityFramework_ClassLibrary.Business.Implementation;
using EntityFramework_ClassLibrary.Business.Interface;
using EntityFramework_ClassLibrary.Domain.Model;
using MVVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVVC_App.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult AddPerson()
        {
            AddPersonViewModel model = new AddPersonViewModel();
            model.StateList = new List<SelectListItem>();
            model.StateList.Add(new SelectListItem() { Text = "ME", Value = "ME" });
            model.StateList.Add(new SelectListItem() { Text = "AZ", Value = "AZ" });

            return View(model);
        }

        [HttpPost]
        public ActionResult AddPerson(AddPersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Transfering values from ViewModel to Entity - Start
                PersonEntity personEntity = Mapper.Map<PersonEntity>(model);
                // Transfering values from ViewModel to Entity - End

                // Call PersonService to save the PersonEntity
                IPersonService personService = new PersonService();
                personService.SavePersonDetails(personEntity);

                return RedirectToAction("SeePerson");
            }
            else
            { 
                model.StateList = new List<SelectListItem>();
                model.StateList.Add(new SelectListItem() { Text = "ME", Value = "ME" });
                model.StateList.Add(new SelectListItem() { Text = "AZ", Value = "AZ" });
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult SeePerson()
        {
            IPersonService personService = new PersonService();
            List<PersonEntity> personList = personService.GetAllPersonDetails();

            // Transfering data from Entity to ViewModle - Start
            /*
            IList<SeePersonViewModel> seePersonViewModelList = new List<SeePersonViewModel>();
            foreach (var person in personList)
            {
                SeePersonViewModel newModel = new SeePersonViewModel();
                newModel.FirstName = person.FirstName;
                newModel.LastName = person.LastName;
                newModel.DOB = person.DOB;
                newModel.PersonState = person.State;

                seePersonViewModelList.Add(newModel);
            }
            */
            // Transfering data from Entity to ViewModle - End

            IList<SeePersonViewModel> seePersonViewModelList = Mapper.Map<List<SeePersonViewModel>>(personList);

            return View(seePersonViewModelList);
        }
    }
}