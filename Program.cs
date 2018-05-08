using System;

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

        public string getFullName(){ 
            return FirstName + LastName;
            }
        public int getAge(DateTime YearOfBirth, DateTime Today)
        {
            return Today.Year - YearOfBirth.Year - (YearOfBirth.DayOfYear < Today.DayOfYear ? 0 : 1);
        }
        public string PersonInfo(){
            var personInfo = "Enter name of new person bellow\n";            
            personInfo += $"First Name: {FirstName}\n";
            personInfo += $"Last Name: {LastName}\n\n";
            personInfo += $"Creating new person record...\n\n";
            personInfo += $"Enter year of birth: 1995\n";
            return personInfo;
        }
    }
    class Program
    {
        private static DateTime DayOfYear;
        public static DateTime YearOfBirth;
        static void Main(string[] args)
        {
            //Star the program with Clear()
            Console.Clear();

            Person person1 = new Person ("Jane", "Doe", 1995);
            Console.WriteLine(person1.PersonInfo());        
            Console.WriteLine($"Person: {person1.getFullName()}  is {person1.getAge(YearOfBirth, DayOfYear )} years old.");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}



