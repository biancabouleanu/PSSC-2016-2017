using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    class ProfessorFactory
    {
        public static readonly ProfessorFactory Instance = new ProfessorFactory();
        private ProfessorFactory()
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
