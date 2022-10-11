namespace Proje06_Intheritance_Kalıtım_Miras
{
    class Person// Bir class ıstenıldıgı kadar baska class a mıras verebılır
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void Intro()// virtual keywordu bu metodun mıras alınan classlarda overrıde edılmesıne ızın verır.
        {
            Console.WriteLine($"First Name: {this.FirstName}, LastName: {this.LastName}");
        }
    }

    class Student : Person// Bir class sadece tek bır class tan mıras alabılır.
    {

        public int StudentNumber { get; set; }
        public override void Intro()// Bu metodun mıras alınan sınıftakı versıyonunu ezıp,yok sayıp yerıne bu metodu kabul eder.
        {
            Console.WriteLine($"First Name: {this.FirstName}, LastName: {this.LastName},Student Number: {this.StudentNumber}");
        }


    }
    class Writer : Person
    {
        public string BookName { get; set; }
    }
    class Teacher : Person
    {
        public string Branch { get; set; }
    }
    class a
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    class b : a
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }

    }
    class c : b
    {
        public int MyProperty5 { get; set; }
        public int MyProperty6 { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();
            Teacher teacher = new Teacher();
            student.FirstName = "kemal";
            student.LastName = "kapucu";
            student.StudentNumber = 125;
            student.Intro();
            teacher.FirstName = "cemre";
            teacher.LastName = "senel";
            teacher.Branch = "software developmant";
            teacher.Intro();
            Person person1 = new Student();
            //Student student1 = new Person();  bu hatalı bir yaklasımdır 

            //bir teacher tanımlayın ıcını doldurun ekrana yazdırın.

            Console.ReadLine();
        }
    }
}