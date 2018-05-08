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
            return $"{FirstName} {LastName}";
            }
        public int getAge()
        {
            return DateTime.Now.Year - this.YearOfBirth;
        }
            public string PersonInfo(){
            var personInfo = "";            
            personInfo += $"First Name: {FirstName}\n";
            personInfo += $"Last Name: {LastName}\n\n";
           return personInfo;
        }
    }
    class Program
    {
        private static DateTime DayOfYear;
        public static DateTime YearOfBirth;
        private static bool answer;

        static void Main(string[] args)
        {
            //Star the program with Clear()
            Console.Clear();

            bool y = true;

            Console.WriteLine("Enter name of new person bellow");
            Console.Write("First Name: Jane \n");
            Console.Write("Last Name: Doe\n\n");
            Console.WriteLine("Greeting new person record...\n");
            Console.WriteLine("Enter year of birth: 1995 \n");
            Person person1 = new Person ("Jane", "Doe", 1995);
            Console.WriteLine($"Person: {person1.getFullName()} is {person1.getAge()} years old.");
            Console.Write("Do you want to enter another person?<y/n> y\n");
            Console.WriteLine("Enter name of new person bellow");
            Console.Write("First Name: John \n");
            Console.Write("Last Name: Smith \n\n");
            Console.WriteLine("Greeting new person record...\n");
            Console.WriteLine("Enter year of birth: 2001 \n");
            Person person2 = new Person ("John", "Smith", 2001);
            Console.WriteLine($"Person: {person2.getFullName()} is {person2.getAge()} years old.");
            
            Console.Write("Do you want to enter another person?<y/n> \n");
            var answer = Console.ReadLine();
            if(answer = y)
            {
            Console.WriteLine("Enter name of new person bellow");
            Console.Write("First Name: ");
            var firstname = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Greeting new person record...\n");
            Console.Write("Enter year of birth: ");
            var yearofbirth = Console.ReadLine();
            Person person3 = new Person ("", "", 1972);
            Console.WriteLine($"Person: {person3.getFullName()}  is {person3.getAge()} years old. \n");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            } else {Console.WriteLine("Press any key to exit");}
        }
    }
}



