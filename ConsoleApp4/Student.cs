using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student : Person
    {
        public string Falculty;
        public int Course;

        public Student(string Name, string Surname, DateTime Date, string Falculty, int Course) : base(Name, Surname, Date)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Date = Date;
            this.Falculty = Falculty;
            this.Course = Course;
        }
        public override string ToString()
        {
            return $"Имя = {Name}\tФамилия = {Surname}\tВозраст = {Date}\tФакультет = {Falculty}\tКурс ={Course}";
        }
    }
}
