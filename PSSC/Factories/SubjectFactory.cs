using Models.Professor;
using Models.Student;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Models.Generics;

namespace Factories
{
    public class SubjectFactory
    {
        public static readonly SubjectFactory Instance = new SubjectFactory();

        private SubjectFactory()
        { }

        internal Subject CreateSubject()
        {
            var Subject = new Subject();
            return Subject;
        }

        internal Student CreateStudent(string Number, string Name)
        {
            Contract.Requires<ArgumentNullException>(Name != null, "Numele nu poate fi null");
            Contract.Requires<ArgumentNullException>(Number != null, "Numarul matricol nu poate fi null");
            var Student = new Student(
                                        new RegistrationNumber(Number),
                                        new PlainText(Name));

            return Student;
        }

        internal Professor CreateProfesor(string Name)
        {
            Contract.Requires<ArgumentNullException>(Name != null, "Numele profesorului nu poate fi null");
                var Prof = new Professor(
                new PlainText(Name));
                return Prof;
        }
    }
}
