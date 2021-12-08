using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full name : ");
            string name = Console.ReadLine();
            Console.Write("Enter course : ");
             int course = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter subject : ");
            string subject = Console.ReadLine();
            Console.Write("Enter university : ");
            string university = Console.ReadLine();
            Console.Write("Enter email : ");
            string email = Console.ReadLine();
            Console.Write("Enter phone number : ");
            string phnum = Console.ReadLine();


            Student student1 = new Student(name,course,subject,university,email,phnum);
            student1.Method();
        }
    }
}
