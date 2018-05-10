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
        public string getFullName()
        { 
            return $"{FirstName} {LastName}";
        }
        public int getAge()
        {
            return DateTime.Now.Year - this.YearOfBirth;
        }
        public string PersonInfo()
        {
            var personInfo = "Enter name of new person below \n";            
            personInfo += $"First Name: {FirstName}\n";
            personInfo += $"Last Name: {LastName}\n\n";
            personInfo += $"Creating new person record...\n\n";
            personInfo += $"Enter year of birth: {YearOfBirth} \n";  
            return personInfo;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Star the program with Clear()
            Console.Clear();

            Person person = new Person ("Jane", "Doe", 1995);
            Console.WriteLine(person.PersonInfo());       
            Console.WriteLine($"Person: {person.getFullName()} is {person.getAge()} years old.");
            Console.Write("Do you want to enter another person?<y/n> y\n");
            Person person1 = new Person ("John", "Smith", 2001);
            Console.WriteLine(person1.PersonInfo());
            Console.WriteLine($"Person: {person1.getFullName()} is {person1.getAge()} years old.");
        
            var checkAnswer = true;
            
            do
            {              
            Console.Write("Do you want to enter another person?<y/n> ");
            var answer = Console.ReadLine();
            if(answer == "y")
            {
               checkAnswer = true; 
            }else{
                checkAnswer = false;

            } if(checkAnswer){
            Console.WriteLine("Enter name of new person below");
            Console.Write("First Name: ");
            var firstname = Console.ReadLine();
            Console.Write("Last Name: ");
            var lastname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Creating new person record...\n");
            Console.Write("Enter year of birth: ");
            int userInput = int.Parse(Console.ReadLine());
            Person person2 = new Person (firstname, lastname, userInput);
            Console.WriteLine($"Person: {person2.getFullName()}  is {person2.getAge()} years old. \n");
            Console.ReadKey();             
            }
            } while (checkAnswer == true);
            
                      
        }
    }                   
}



