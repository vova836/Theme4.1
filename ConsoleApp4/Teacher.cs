using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Teacher : Person
    {
        public string Position;
        public int Experience;
        public string Falculty;

        public Teacher(string Name, string Surname, DateTime Date, string Falculty, string Position , int Experience) : base(Name, Surname, Date)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Date = Date;
            this.Falculty = Falculty;
            this.Position = Position;
            this.Experience = Experience;
        }
        public override string ToString()
        {
            return $"Имя = {Name}\tФамилия = {Surname}\tВозраст = {Date}\tФакультет = {Falculty}\tДолжность{Position}\tСтаж{Experience}";
        }
    }
}
