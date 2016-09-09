using EntityFramework_ClassLibrary.Business.Interface;
using EntityFramework_ClassLibrary.Domain.Model;
using EntityFramework_ClassLibrary.Integration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework_ClassLibrary.Business.Implementation
{
    public class PersonService : IPersonService
    {
        public void SavePersonDetails(PersonEntity personEntity)
        {
            PersonContext ctx = new PersonContext();
            ctx.PersonDetailTable.Add(personEntity);
            ctx.SaveChanges();

        }

        public List<PersonEntity> GetAllPersonDetails()
        {
            PersonContext ctx = new PersonContext();
            List<PersonEntity> personDetailsList = ctx.PersonDetailTable.ToList();
            return personDetailsList;
        }

    }
}


