using System;

namespace personClass
{
    //Creating a new class named Person
    class Person 
    {
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public int YearOfBirth {get; set; }
        public static DateTime Today { get; }
        public string getage;
        public string getfullname;

        //Constructor
        public Person(string firstname, string lastname, int yearofbirth)
        {
            FirstName = firstname;
            LastName = lastname;
            YearOfBirth = yearofbirth;
        }

        public string getFullName(){
            var getfullname = "Creating new person record";
            getfullname += $"{FirstName + LastName}"; 
            return getfullname;
            }
        public int getAge(DateTime YearOfBirth, DateTime Today)
        {
            
            int getage = Today.Year - YearOfBirth.Year - (YearOfBirth.DayOfYear < Today.DayOfYear ? 0 : 1);
            return getage;

        }
        public string PersonInfo(){
            var personInfo = "Enter name of new person bellow\n";            
            personInfo += $"First Name: {FirstName}\n";
            personInfo += $"Last Name: {LastName}\n";
            return personInfo;
        }

        //Overriding the method in the Person class
        public override string ToString(){
            return $"Person: {getfullname} is {getage} years old. ";
        }            
    }
    class Program
    {
        public static string FirstName;
        
        static void Main(string[] args)
        {
            //Star the program with Clear()
            Console.Clear();

            Person person1 = new Person ("Jane", "Doe", 1995);
            Console.WriteLine(person1.PersonInfo());
            Console.WriteLine("Creating new person record...");
            Console.WriteLine("Enter year of birth: 1995");            
            Console.WriteLine(person1.ToString());
            Console.WriteLine("Press any key to exit");
            
            
            Console.ReadKey();

        }
    }
}



