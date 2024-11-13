using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        public class Employee
        {
            
            private string employeeId;
            private double salary;

            
            public Employee(string id, double sal)
            {
                employeeId = id;
                salary = sal;
            }

           
            public void SetEmployeeId(string id)
            {
                employeeId = id;
            }

            
            public void SetSalary(double s)
            {
                salary = s;
            }

            
            public string GetEmployeeId()
            {
                return employeeId;
            }

            
            public double GetSalary()
            {
                return salary;
            }

            
            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"Employee ID: {employeeId}, Salary: {salary}");
            }
        }
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("123", 50000);

            
            employee1.DisplayEmployeeInfo();

            
            employee1.SetEmployeeId("456");
            employee1.SetSalary(60000);

            
            employee1.DisplayEmployeeInfo();

            Console.ReadLine();
        }
    }
}
