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
            `c#
using System;
using System.Collections.Generic;

// Абстрактный класс Person
abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public abstract void ShowInfo(); // Абстрактный метод вывода информации
    public virtual int CalculateAge()  // Виртуальный метод определения возраста
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - DateOfBirth.Year;
        if (currentDate < Da
        foreach (Person person in people)
        {
            person.ShowInfo();
            Console.WriteLine($"Age:{person.CalculateAge()}");
        }

       
        Console.WriteLine("People in the age range of 20-25:");
        foreach (Person person in people)
        {
            int age = person.CalculateAge();
            if (age >= 20 && age <= 25)
            {
                person.ShowInfo();
            }`c#
using System;
using System.Collections.Generic;

// Абстрактный класс Person
abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public abstract void ShowInfo(); // Абстрактный метод вывода информации
    public virtual int CalculateAge()  // Виртуальный метод определения возраста
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - DateOfBirth.Year;
        if (currentDate < Da
        foreach (Person person in people)
        {
            person.ShowInfo();
            Console.WriteLine($"Age:{person.CalculateAge()}");
        }

       
        Console.WriteLine("People in the age range of 20-25:");
        foreach (Person person in people)
        {
            int age = person.CalculateAge();
            if (age >= 20 && age <= 25)
            {
                person.ShowInfo();
            }`c#
using System;
using System.Collections.Generic;

// Абстрактный класс Person
abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public abstract void ShowInfo(); // Абстрактный метод вывода информации
    public virtual int CalculateAge()  // Виртуальный метод определения возраста
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - DateOfBirth.Year;
        if (currentDate < Da
        foreach (Person person in people)
        {
            person.ShowInfo();
            Console.WriteLine($"Age:{person.CalculateAge()}");
        }

       
        Console.WriteLine("People in the age range of 20-25:");
        foreach (Person person in people)
        {
            int age = person.CalculateAge();
            if (age >= 20 && age <= 25)
            {
                person.ShowInfo();
            }`c#
using System;
using System.Collections.Generic;

// Абстрактный класс Person
abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public abstract void ShowInfo(); // Абстрактный метод вывода информации
    public virtual int CalculateAge()  // Виртуальный метод определения возраста
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - DateOfBirth.Year;
        if (currentDate < Da
        foreach (Person person in people)
        {
            person.ShowInfo();
            Console.WriteLine($"Age:{person.CalculateAge()}");
        }

       
        Console.WriteLine("People in the age range of 20-25:");
        foreach (Person person in people)
        {
            int age = person.CalculateAge();
            if (age >= 20 && age <= 25)
            {
                person.ShowInfo();
            }`c#
using System;
using System.Collections.Generic;

// Абстрактный класс Person
abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public abstract void ShowInfo(); // Абстрактный метод вывода информации
    public virtual int CalculateAge()  // Виртуальный метод определения возраста
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - DateOfBirth.Year;
        if (currentDate < Da
        foreach (Person person in people)
        {
            person.ShowInfo();
            Console.WriteLine($"Age:{person.CalculateAge()}");
        }

       
        Console.WriteLine("People in the age range of 20-25:");
        foreach (Person person in people)
        {
            int age = person.CalculateAge();
            if (age >= 20 && age <= 25)
            {
                person.ShowInfo();
            }List<Person> people = new List<Person>();
            people.Add(new Enrollee("Сергей", "Герасимов",1985, 5, 26,"Программист"));
            people.Add(new Student("Даниил", "Полозюк", 2006, 3, 20, "Программист"));
            people.Add(new Teacher("Павел", "Павлович", 1981, 6, 15, "Копьютерные сети", "Учитель", 17));
            foreach(Person person in people)
            {
                person.ShowInfo();
                Console.WriteLine($"Age:{person.DateTimeAge()}");
            }List<Person> people = new List<Person>();
            people.Add(new Enrollee("Сергей", "Герасимов",1985, 5, 26,"Программист"));
            people.Add(new Student("Даниил", "Полозюк", 2006, 3, 20, "Программист"));
            people.Add(new Teacher("Павел", "Павлович", 1981, 6, 15, "Копьютерные сети", "Учитель", 17));
            foreach(Person person in people)
            {
                person.ShowInfo();
                Console.WriteLine($"Age:{person.DateTimeAge()}");
            }
`c#
using System;
using System.Collections.Generic;

// Абстрактный класс Person
abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public abstract void ShowInfo(); // Абстрактный метод вывода информации
    public virtual int CalculateAge()  // Виртуальный метод определения возраста
    {
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - DateOfBirth.Year;
        if (currentDate < Da
        foreach (Person person in people)
        {
            person.ShowInfo();
            Console.WriteLine($"Age:{person.CalculateAge()}");
        }
            
        Console.WriteLine("People in the age range of 20-25:");
        foreach (Person person in people)
        {
            int age = person.CalculateAge();
            if (age >= 20 && age <= 25)
            {
                person.ShowInfo();
            }   
            Console.Readkey();
        }
    }
}
