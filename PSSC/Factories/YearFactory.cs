using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Deanship;

namespace Factories
{
   class YearFactory
    {
         public static readonly YearFactory Instance = new YearFactory();

        private YearFactory()
        { }

        public Year CreateYear()
        {
            var Year = new Year();
            return Year;
        }
    }
}
