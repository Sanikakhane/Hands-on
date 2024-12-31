using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_on
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person { Id = 1, Name = "John" },
                new Person { Id = 2, Name = "Emily" },
                new Person { Id = 3, Name = "Michael" },
                new Person { Id = 4, Name = "Sophia" }
            };
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 101, PersonId = 1, Product = "Laptop" },
                new Order { OrderId = 102, PersonId = 1, Product = "Mouse" },
                new Order { OrderId = 103, PersonId = 2, Product = "Keyboard" },
                new Order { OrderId = 104, PersonId = 3, Product = "Monitor" }
            };
            //Normal Join
            /*var normalJoin = persons.Join(
                orders,
                person => person.Id,        
                order => order.PersonId,    
                (person, order) => new     
                {
                    PersonName = person.Name,
                    Product = order.Product
                });

            foreach (var item in normalJoin)
            {
                Console.WriteLine($"Person: {item.PersonName}, Product: {item.Product}");
            }*/

            //Group join
            /*var groupJoin = persons.GroupJoin(
                orders,
                person => person.Id,        
                order => order.PersonId,    
                (person, ordersGroup) => new 
                {
                    PersonName = person.Name,
                    Orders = ordersGroup     
                });

            foreach (var item in groupJoin)
            {
                Console.WriteLine($"Person: {item.PersonName}");
                foreach (var order in item.Orders)
                {
                    Console.WriteLine($"  Product: {order.Product}");
                }
            }*/



            // result = orders.OrderBy(order => order.OrderId).GroupBy(order => order.PersonId);
            //var result = orders.GroupBy(order => order.PersonId).Where(size => size.Count()==2);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"PersonId: {group.Key}");
            //    foreach (var order in group)
            //    {
            //        Console.WriteLine($"OrderId: {order.OrderId}");
            //    }
            //    Console.WriteLine();
            //}

            List<Employee> employees = Datamanager.GetData();

            //Aggregating functions
            //1. Count
            Console.WriteLine(employees.Count(emp => emp.FirstName == "Sanika"));

            //2. Min
            /* int minSalary = employees.Min(e => e.Salary);
             var result = employees.Where(e => e.Salary == minSalary);
             Console.WriteLine(minSalary);*/

            //3.Max
            //var result = employees.Where(e => e.Salary == employees.Max(e => e.Salary));

            //4. average
            Console.WriteLine(employees.Average(e => e.Age));

            //5. Custome Aggregate function
            var result = employees.Aggregate("", (acc, e) =>acc + e.FirstName + " " + e.LastName+ "\n");
            Console.WriteLine(result);


            //foreach (var emp in result)
            //{
            //    Console.WriteLine($"Id : {emp.Id} FirstName : {emp.FirstName} LastName : {emp.LastName} Age : {emp.Age} Department : {emp.Department} Salary : {emp.Salary}");

            //}

        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public int PersonId { get; set; }
        public string? Product { get; set; }
    }

}
