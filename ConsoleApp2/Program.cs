using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Enrollee("Сергей", "Герасимов",1985, 5, 26,"Программист"));
            people.Add(new Student("Даниил", "Полозюк", 2006, 3, 20, "Программист"));
            people.Add(new Teacher("Павел", "Павлович", 1981, 6, 15, "Копьютерные сети", "Учитель", 17));
            foreach(Person person in people)
            {
                person.ShowInfo();
                Console.WriteLine($"Age:{person.DateTimeAge()}")
            }
               Console.WriteLine("People in the age range of 20-25:");
               foreach (Person person in people)
                   {
                int age = person.CalculateAge();
                 if (age >= 20 && age <= 25)
                   }
               {
                person.ShowInfo();
               }   
                Console.Readkey();
        }
    }
}
