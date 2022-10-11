namespace Proje07_Constructor_Methods
{
    class Person
    {
        public Person()// method-constructor method-tipi olmaz
        {
            // Her classın default olarak bos bir constructor methodu vardır ama ımplicittir,yani ortulu gizlidir.su anda biz kendi constructorımızı yazdık
            Console.WriteLine("Merhaba ben Person.Şu an yaratıldım!");
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Student : Person
    {
        public Student(string firtsname, string lastname, int studentnumber):base(firtsname,lastname)
        {
           
            StudentNumber = studentnumber;  
        }
        public int StudentNumber { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //Person person2 = new Person("Cemre", "Şenel");
            //Console.WriteLine($"{person2.FirstName} {person2.LastName}");
            

            Student student1 = new Student("ahmet", "can",345);
            Console.WriteLine($"{student1.FirstName} {student1.LastName} {student1.StudentNumber}");
            Console.ReadLine();

        }
    }
}