using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVVC_App.Models
{
    public class AddPersonViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public List<SelectListItem> StateList {get; set;}
        public string State { get; set; }
    }
}