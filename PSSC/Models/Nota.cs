using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum TipNota
    {
        notaExamen,
        notaDistribuita
    }
    class Nota
    {
      
        Discipline disciplina;
        Student student;
        TipNota tNota;

        public Discipline Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }
        public TipNota tnota
        {
            get { return tNota; }
            set { tNota = value; }
        }
        public Student Student
        {
            get { return student; }
            set { student = value; }
        }
        public Nota(Discipline disciplina, Student student, TipNota tNota)
        {
            this.disciplina = disciplina;
            this.Student = student;
            this.tNota = tNota;
        }
    }
}
