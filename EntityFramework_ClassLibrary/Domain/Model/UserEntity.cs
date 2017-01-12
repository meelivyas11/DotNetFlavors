using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ClassLibrary.Domain.Model
{
    public class UserEntity
    {
        // UserEntityId is the Primary Key of this table
        public int Id { get; set; }

        // Create Index on UserName
        [Index("UserNameIndex", IsUnique = true)]
        [MaxLength(20)]
        public string UserName { get; set; }
        public string Password { get; set; }

        // Foreign Key from PersonEntity Table
        public int PersonEntityId { get; set; } 
        public virtual PersonEntity PersonEntity { get; set; }

    }
}
