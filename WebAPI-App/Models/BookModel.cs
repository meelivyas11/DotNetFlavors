using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_App.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public BookModel () {}

    }
}

