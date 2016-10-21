using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum TipEvaluare
    {
        distribuita,
        examen
    }
    class Discipline
    {
        string nume_disciplina;
        int credite;
        int an_studiu;
        TipEvaluare tEvaluare;
        List<Student> studenti = new List<Student>();

        public string Nume_disciplina
        {
            get { return nume_disciplina; }
            set { nume_disciplina = value; }
        }
        public int Credite
        {
            get { return credite; }
            set { credite = value; }

        }
        public int An_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
        public TipEvaluare tevaluare
        {
            get { return tEvaluare; }
            set { tEvaluare = value; }
        }
        public Discipline(string nume_disciplina , int credite, int an_studiu, TipEvaluare tEvaluare, List<Student> studenti)
        {
            this.nume_disciplina = nume_disciplina;
            this.credite = credite;
            this.an_studiu = an_studiu;
            this.tEvaluare = tEvaluare;
            this.studenti = studenti;
        }
    }
}
