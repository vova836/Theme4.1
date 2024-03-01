using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Enrollee : Person
    {
        public string Falculty { get; set; }

        public Enrollee(string Name, string Surname, DateTime Date, string Falculty): base(Name, Surname, Date)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Date = Date;
            this.Falculty = Falculty;
        }
        public override string ToString()
        {
            return $"Имя = {Name}\tФамилия = {Surname}\tВозраст = {Date}\tФакультет = {Falculty}";
        }

    }
}
