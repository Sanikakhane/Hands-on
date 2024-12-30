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
            var groupJoin = persons.GroupJoin(
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
            }
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public int PersonId { get; set; }
        public string Product { get; set; }
    }

}
