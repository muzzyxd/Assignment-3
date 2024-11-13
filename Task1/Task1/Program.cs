using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {

        public class Student
        {

            private string name;
            private int age;

            public void SetDetails(string n, int a)
            {
                name = n;
                age = a;
            }


            public void DisplayDetails()
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
        }
            static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.SetDetails("Muzammil", 18);

            Student student2 = new Student();
            student2.SetDetails("Haseeb", 20);

            Student student3 = new Student();
            student3.SetDetails("Zohaib", 19);

 
            student1.DisplayDetails();
            student2.DisplayDetails();
            student3.DisplayDetails();

            Console.ReadLine();
        }
    }
}
