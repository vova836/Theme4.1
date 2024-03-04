using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public string Faculty { get; set; }

        public Person()
        {

        }
        public Person(string Name, string Surname, DateTime Date, string Faculty)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Date = Date;
            this.Faculty = Faculty;
        }
        public abstract void ShowInfo();
    public int GetAge()
        {
            return DateTime.Now.Year - Date.Year;
        }
       
    }
}
