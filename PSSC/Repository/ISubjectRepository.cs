using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface ISubjectRepository
    {
          Models.Subject.Subject GetById(Guid id);
          void Add(Models.Subject.Subject subject);
          void Delete(Models.Subject.Subject subject);
          void Update(Models.Subject.Subject subject);
          void Save();
    }
}
