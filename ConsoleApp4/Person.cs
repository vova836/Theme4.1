using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }

        public Person(string Name, string Surname, DateTime Date)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Date = Date;
        }
        public abstract void ShowInfo();
        
        public static virtual void DateTimeAge()
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - Date.Year;
        }
        
            
    }
}
