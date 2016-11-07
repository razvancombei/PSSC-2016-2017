using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Student;

namespace Factories
{
    public class GradeFactory
    {
        public static readonly GradeFactory Instance = new GradeFactory();

        private GradeFactory()
        { }

        public Grade CreateGrade()
        {
            var GradeReport = new Grade();
            return GradeReport;
        }
    }
}
