using EntityFramework_ClassLibrary.Business.Interface;
using EntityFramework_ClassLibrary.Integration;
using System;

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
    }
}


