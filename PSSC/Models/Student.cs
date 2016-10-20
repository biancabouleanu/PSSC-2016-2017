using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        string nume;
        string prenume;
        int an_studiu;
        int nr_matricol;
        string cnp;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public int AnStudiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
        public int NrMatricol
        {
            get { return nr_matricol; }
            set { nr_matricol = value; }
        }
        public string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public Student(string nume, string prenume, int an_studiu, int nr_matricol, string cnp)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.an_studiu = an_studiu;
            this.nr_matricol = nr_matricol;
            this.cnp = cnp;
        }
    }
}
