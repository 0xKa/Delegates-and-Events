using System;
using System.Collections.Generic;

namespace test
{
    internal class Delegates
    {
        public static List<Employee> FillListWithEmployees()
        {
            //40 employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Reda Hilal", 5000, "Engineering", new DateTime(2004, 8, 6)),
                new Employee(2, "Ahmed Ali", 3150, "Finance", new DateTime(1995, 2, 17)),
                new Employee(3, "Sarah Johnson", 6800, "HR", new DateTime(1990, 7, 13)),
                new Employee(4, "Mohammad Youssef", 4600, "Marketing", new DateTime(1985, 11, 23)),
                new Employee(5, "Lisa Brown", 7500, "Engineering", new DateTime(1992, 4, 1)),
                new Employee(6, "Omar Khalid", 8200, "IT", new DateTime(1998, 12, 19)),
                new Employee(7, "John Doe", 5400, "Engineering", new DateTime(2000, 6, 9)),
                new Employee(8, "Emily Davis", 3900, "Design", new DateTime(1997, 10, 30)),
                new Employee(9, "Khaled Ibrahim", 6200, "Sales", new DateTime(1991, 5, 16)),
                new Employee(10, "Fatima Zain", 4700, "HR", new DateTime(1993, 8, 24)),
                new Employee(11, "David Lee", 7700, "Engineering", new DateTime(1988, 9, 3)),
                new Employee(12, "Maria Gomez", 6100, "Finance", new DateTime(1994, 12, 29)),
                new Employee(13, "James Smith", 4200, "Marketing", new DateTime(1999, 1, 18)),
                new Employee(14, "Hassan Omar", 4900, "Engineering", new DateTime(1987, 3, 11)),
                new Employee(15, "Sophia Martinez", 5300, "HR", new DateTime(2001, 7, 25)),
                new Employee(16, "Peter Parker", 8200, "IT", new DateTime(1995, 6, 20)),
                new Employee(17, "Nora Adams", 4400, "Sales", new DateTime(1996, 11, 8)),
                new Employee(18, "Ali Hussain", 5100, "Engineering", new DateTime(1993, 5, 14)),
                new Employee(19, "Zara Khan", 6900, "Finance", new DateTime(1989, 9, 27)),
                new Employee(20, "Jacob Wilson", 4800, "Marketing", new DateTime(2002, 4, 2)),
                new Employee(21, "Olivia Thompson", 6200, "HR", new DateTime(1985, 8, 15)),
                new Employee(22, "Aisha Ahmed", 5500, "Engineering", new DateTime(1998, 10, 7)),
                new Employee(23, "Charles Cooper", 4600, "Sales", new DateTime(1994, 12, 5)),
                new Employee(24, "Mehdi Rami", 7800, "IT", new DateTime(1997, 3, 6)),
                new Employee(25, "Jenna White", 6300, "Marketing", new DateTime(1999, 7, 19)),
                new Employee(26, "Samir Mahmoud", 4700, "Engineering", new DateTime(2001, 2, 26)),
                new Employee(27, "Lara Jones", 6800, "HR", new DateTime(1986, 11, 14)),
                new Employee(28, "Mona Salim", 5200, "Finance", new DateTime(1995, 5, 28)),
                new Employee(29, "Victor Hugo", 7100, "Engineering", new DateTime(2000, 9, 11)),
                new Employee(30, "Ahmed Sameh", 4600, "Marketing", new DateTime(1989, 6, 17)),
                new Employee(31, "Isabella Clark", 7300, "Sales", new DateTime(1996, 12, 22)),
                new Employee(32, "Othman Qureshi", 5000, "IT", new DateTime(1994, 3, 9)),
                new Employee(33, "Amira Hussein", 6500, "HR", new DateTime(1997, 7, 29)),
                new Employee(34, "Bilal Saeed", 4800, "Engineering", new DateTime(1993, 8, 12)),
                new Employee(35, "Eva Wilson", 5700, "Design", new DateTime(1999, 2, 5)),
                new Employee(36, "Nabil Fares", 6900, "Marketing", new DateTime(1987, 10, 30)),
                new Employee(37, "Grace Patel", 7600, "Sales", new DateTime(1991, 1, 3)),
                new Employee(38, "Rami Saad", 6700, "IT", new DateTime(1995, 4, 21)),
                new Employee(39, "Linda Green", 5000, "Finance", new DateTime(1988, 6, 13)),
                new Employee(40, "Zainab Tariq", 5800, "HR", new DateTime(2002, 11, 4))
            };
            return employees;
        }

        public class Employee
        {
            private int ID { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
            public string Department { get; set; }
            public DateTime DateOfBirth { get; set; }

            public Employee(int ID, string Name, double Salary, string Department, DateTime DateOfBirth)
            {
                this.ID = ID;
                this.Name = Name;
                this.Salary = Salary;
                this.Department = Department;
                this.DateOfBirth = DateOfBirth;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"{ID}, {Name}, {Salary}, {Department}, {DateOfBirth:yyyy/MM/dd} ");
            }

        }

        //delegete is pointer to store functions addresses 
        //delegate is same as class you can create objects of.
        public delegate bool MyDelegate(Employee employee); // void and Employee class are the func ssignture

        public static int CountEmployees(List<Employee> employees, MyDelegate Condition)
        {
            int count = 0;
            foreach (Employee employee in employees)
            {
                if (Condition(employee))
                    count++;
            }
            return count;
        }

        //condition funcs for delegate
        public static bool AllEmployees(Employee employee)
        {
            return true;
        }
        public static bool IsSalaryMoreThan5000(Employee employee)
        {
            return employee.Salary >= 5000;
        }
        public static bool IsSalaryLessThan2000(Employee employee)
        {
            return employee.Salary <= 2000;
        }
        public static bool IsNameStartWithR(Employee employee)
        {
            return employee.Name.StartsWith("R");
        }
        public static bool IsBirthDateAfter2000(Employee employee) => employee.DateOfBirth >= new DateTime(2000, 1, 1); //this is same as lambda exerpresion 


    }
}
