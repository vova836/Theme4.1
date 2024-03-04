using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Enrollee : Person
    {
        public string Falculty { get; set; }

        public Enrollee()
        {

        }
        public Enrollee(string Name, string Surname, DateTime Date, string Falculty)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Date = Date;
            this.Falculty = Falculty;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Имя = {Name}\tФамилия = {Surname}\tВозраст = {Date}\tФакультет = {Falculty}");
        }
    }
}