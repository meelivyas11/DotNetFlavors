using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVC_App.Models
{
    public class SeePersonViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string State { get; set; }
    }
}