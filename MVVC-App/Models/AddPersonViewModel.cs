using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVVC_App.Models
{
    public class AddPersonViewModel
    {
        [Required (ErrorMessage = "First Name Missing")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Missing")]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public List<SelectListItem> StateList {get; set;}
        public string State { get; set; }
    }
}