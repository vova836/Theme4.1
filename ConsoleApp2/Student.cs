using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student : Person
    {
        public string Falculty { get; set; }
        public int Course { get; set; }

        public Student()
        {

        }
        public Student(string Name, string Surname, DateTime Date, string Falculty, int Course) : base(Name, Surname, Date, Falculty)
        {
            
            this.Falculty = Falculty;
            this.Course = Course;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Имя = {Name}\tФамилия = {Surname}\tВозраст = {Date}\tФакультет = {Falculty}\tФамилия = {Course}");
        }
    }
}
