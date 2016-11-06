using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    class ProffesorFactory
    {
        public static readonly ProffesorFactory Instance = new ProffesorFactory();
        private ProffesorFactory()
        {

        }
        public Subjects SubjectCreate(string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, " Subject name must not be null");

            var subject = new Subjects();
            return subject;
        }
    }
}
