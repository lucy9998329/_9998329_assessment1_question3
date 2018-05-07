using System;
using personClass;

namespace personClass
{
    //Creating a new class named Person
    class Person 
    {
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public int YearOfBirth {get; set; }

        //Constructor
        public Person(string firstname, string lastname, int yearofbirth)
        {
            FirstName = firstname;
            LastName = lastname;
            YearOfBirth = yearofbirth;
        } 
        public string getFullName(){return FirstName + " " + LastName;}
        public int getAge(int currentYear) => currentYear - YearOfBirth;}

        public string PersonInfo(){
            var personInfo = "Enter name of new person bellow\n";            
            personInfo += $"First Name: {FirstName}\n";
            personInfo += $"Last Name: {LastName}\n";
            return PersonInfo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Star the program with Clear()
            Console.Clear();

            Person person1 = new Person ("Jane", "Doe", 1995);
            Console.WriteLine(person1.getFullName());
            Console.WriteLine(person1.getAge(1995));
            
            
            Console.ReadKey();

        }
    }

