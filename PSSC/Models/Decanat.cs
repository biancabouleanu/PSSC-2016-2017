using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat
    {
        List<Discipline> discipline = new List<Discipline>();
        List<Profesor> profesori = new List<Profesor>();
        List<Student> studenti = new List<Student>();

        private List<Discipline> Discipline
        {
            get { return discipline; }
            set { discipline = value; }
        }
        private List<Profesor> Profesori
        {
            get { return profesori; }
            set { profesori = value; }
        }
        private List<Student> Studenti
        {
            get { return studenti; }
            set { studenti = value; }
        }
        public Decanat(List<Discipline> discipline, List<Profesor> profesori, List<Student> studenti)
        {
            this.discipline = discipline;
            this.profesori = profesori;
            this.studenti = studenti;
        }
    }
}
