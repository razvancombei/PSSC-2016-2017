using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Subject;

namespace Repository
{
    class SubjectRepository : ISubjectRepository
     {
         private static List<Models.Subject.Subject> _subject = new List<Models.Subject.Subject>();
 
         public SubjectRepository()
         {
         }
 
         public Models.Subject.Subject GetById(Guid Id)
         {
             var rezulta = _subject.Find(p => p.GetID == Id);
             return rezulta;
         }

         public void Add(Models.Subject.Subject subject)
         {
         }

         public void Delete(Models.Subject.Subject subject)
         {
         }

         public void Update(Models.Subject.Subject subject)
         {
         }
         public void Save(Models.Subject.Subject subject)
         {  
         }
    }
}
