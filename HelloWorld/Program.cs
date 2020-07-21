using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new List<Student>();
            var adding = true;
            while (adding)
            {
                var newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Student Grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.Write("Add another? y/n");
                if(Console.ReadLine() != "y")
                {
                    //
                }
            }
    }
    class Student
    {
        public string Name;
        public string Birthday;
        public string Address;
        public int Grade;
        public int Phone;
    }
}
