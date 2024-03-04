using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Teatcher : Person
    {
        public string Position { get; set; }
        public int Experience { get; set; }
        public string Falculty { get; set; }

        public Teatcher()
        {

        }
        public Teatcher(string Name, string Surname, DateTime Date, string Falculty, string Position, int Experience) : base(Name, Surname, Date, Falculty)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Date = Date;
            this.Falculty = Falculty;
            this.Position = Position;
            this.Experience = Experience;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Имя = {Name}\tФамилия = {Surname}\tВозраст = {Date}\tФакультет = {Falculty}\tДолжность = {Position}\tСтаж{Experience}");
        }
    }
}
