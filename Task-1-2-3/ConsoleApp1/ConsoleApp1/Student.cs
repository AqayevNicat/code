using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public string FullName;
        public int Course;
        public string Subject;
        public string University;
        public string Email;
        public string PhoneNum;

        public Student(string fullname,int course,string subject,string university,string email,string number)
        {
            FullName = fullname;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNum=number;
        }

        public void Method()
        {
            Console.WriteLine($"\n{FullName}\n{Course}\n{Subject}\n{University}\n{Email}\n{PhoneNum}");
        }
    }
}
