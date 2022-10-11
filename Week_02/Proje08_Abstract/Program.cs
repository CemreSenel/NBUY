namespace Proje08_Abstract
{
    abstract class Person// Eger bir class abstract ise o classtan yenı bır nesne yaratılamaz.
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Greeting()
        {
            Console.WriteLine("I am a person.");
        }
        public abstract void Intro();////Soyut Method
        // Eger bır classın ıcınde abstract bir method var ıse o class da abstract olmalı
        

    }
    class Student : Person
    {
        public Student(string firstName, string lastName, int studentNumber) : base(firstName, lastName)
        {
            StudentNumber = studentNumber;

        }
        public int StudentNumber { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name:{FirstName} last name:{LastName} ");
        }
    }
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string branch) : base(firstName, lastName, branch);
        public override void Intro()
        {
            throw new NotImplementedException();
        }
    }
    class Writer : Person
    {
        public Writer(string firstName, string lastName, string bookName) : base(firstName, lastName, bookName);
        public override void Intro()
        {
            throw new NotImplementedException();
        }
    }
    public static BookName()
    {

    }
   internal class Program
    {
    static void Main(string[] args)
    {
        Student student1 = new Student("aysem umay", "ergul", 15);
        student1.Greeting();
        student1.Intro();  //ıstemedıgımız halde Person dakı ıntro calısıyor 

        Teacher teacher = new Teacher("maria", "canan ", "fizik");
        Console.ReadLine();

    } 
    }
}