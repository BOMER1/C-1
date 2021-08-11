using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        static void Main(string[] args)
        {
            int studentID = 1;
            string studentName = "David george";
            byte age = 18;
            char gender = 'M';
            float percent = 75.50F;
            bool pass = true;

            Console.WriteLine("Student ID:{O}", studentID);
            Console.WriteLine("Student Name:{O}", studentName);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Gender : ", gender);
            Console.WriteLine("Percentage : (0:F2)", percent);
            Console.WriteLine("Passed : {0}", pass);
        }
    }
}
