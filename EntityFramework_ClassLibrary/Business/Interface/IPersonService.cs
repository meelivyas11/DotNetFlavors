using EntityFramework_ClassLibrary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ClassLibrary.Business.Interface
{
    public interface IPersonService
    {
        void SavePersonDetails(PersonEntity personEntity);
    }
}
