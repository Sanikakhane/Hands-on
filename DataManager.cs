using System;

namespace Hands_on
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } = 0;
        public string Department { get; set; }
        public int Salary { get; set; }
        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Age = 0;
            Department = string.Empty;
            Salary = 0;
        }
        public Employee(int id,string firstName,string lastName,int age,string department,int salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Department = department;
            Salary = salary;
        }
    }
    public static class Datamanager
    {
        public static List<Employee> GetData()
        {
            List<Employee> employees = new List<Employee>
                {
                   new Employee(1, "Sanika", "Khane", 21, "Intern", 12000),
                   new Employee(2, "Amit", "Sharma", 29, "HR", 40000),
                   new Employee(3, "Rohit", "Verma", 35, "IT", 60000),
                   new Employee(4, "Pooja", "Singh", 25, "Finance", 35000),
                   new Employee(5, "Neha", "Patil", 30, "Marketing", 45000),
                   new Employee(6, "Suresh", "Mishra", 40, "Admin", 50000),
                   new Employee(7, "Ankita", "Roy", 26, "IT", 55000),
                   new Employee(8, "Dev", "Desai", 38, "Sales", 47000),
                   new Employee(9, "Sanika", "Kulkarni", 24, "Intern", 15000),
                   new Employee(10, "Arjun", "Kumar", 32, "Operations", 52000),
                   new Employee(11, "Meera", "Gupta", 27, "Finance", 37000),
                   new Employee(12, "Raj", "Kapoor", 41, "IT", 62000),
                   new Employee(13, "Manisha", "Dutta", 28, "HR", 42000),
                   new Employee(14, "Prakash", "Yadav", 36, "Admin", 51000),
                   new Employee(15, "Sanika", "Bose", 23, "Marketing", 34000),
                   new Employee(16, "Anil", "Pawar", 33, "Sales", 49000),
                   new Employee(17, "Kavita", "Mehta", 22, "Intern", 14000),
                   new Employee(18, "Dev", "Joshi", 37, "Operations", 53000),
                   new Employee(19, "Nikita", "Singh", 25, "Finance", 36000),
                   new Employee(20, "Ravi", "Chopra", 39, "Admin", 52000)
                 };
                return employees;
        }
        
    }
}