using EntityFramework_ClassLibrary;
using EntityFramework_ClassLibrary.Domain.Model;
using System.Data.Entity;

namespace EntityFramework_ClassLibrary.Integration
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("name = PersonContext")
        {
            this.Database.Log = i => System.Diagnostics.Debug.WriteLine(i);
        }

        public DbSet<PersonEntity> PersonDetailTable { get; set; }
        public DbSet<UserEntity> UserTable { get; set; }
    }
}
