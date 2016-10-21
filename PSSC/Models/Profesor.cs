using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor
    {
        string nume;
        string prenume;
        string telefon;
        List<Discipline> discipline = new List<Discipline>();
        List<Nota> note = new List<Nota>();

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
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        private List<Discipline> Disciplina
        {
            get { return discipline; }
            set { discipline = value; }
        }
        private List<Nota> Nota
        {
            get { return note; }
            set { note = value; }
        }
        public Profesor(string nume, string prenume, string telefon)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.telefon = telefon;
        }
    }
}
