using System;
using System.Collections.Generic;


namespace Hands_on
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees= Datamanager.GetData();

            //It selects only the firtname of the employees
            /*IEnumerable<string> names = employees.Select(emp => emp.FirstName);
            foreach (string name in names) { Console.WriteLine(name); }*/

            //If we want the unqui values distict is used
            /*IEnumerable<string> names = employees.Select(emp => emp.FirstName).Distinct();
            int count= employees.Count();
            Console.WriteLine(count);
            Console.WriteLine(names.Count());
            foreach (string name in names) { Console.WriteLine(name); }*/

            //Order By name only 
            //employees=employees.OrderBy(x => x.FirstName).ToList();

            //If want to add another parameter for ordering then "ThenBy" is used
            //employees = employees.OrderByDescending(e => e.FirstName).ThenBy(e=>e.LastName).ToList();


            //For adding the condition where clause is used
            //employees = employees.Where(e => e.Age > 30).ToList();

            //if we want a single value or record from the collection the 
            //Employee emp = employees.First(e=> e.FirstName=="Sanika");

            //If the element is not present then it will throw error so FirstOrdefault is used it will return null
            //Employee emp = employees.FirstOrDefault(e => e.FirstName == "Saanika");

            //Employee emp = employees.Last(e => e.FirstName == "Sanika");
            //Employee emp1 = employees.LastOrDefault(e => e.FirstName == "Sanika");

            //if there is only one unique recodr then signle is used
            //Employee emp = employees.Single(emp => emp.FirstName == "Meera");



            //It will only consider the records of how much count is given from start
            //employees = employees.Take(3).ToList();

            employees = employees.DistinctBy(x => x.FirstName).ToList();


            //Console.WriteLine($"Id : {emp.Id} FirstName : {emp.FirstName} LastName : {emp.LastName} Age : {emp.Age}" +
            //                     $" Department : {emp.Department} Salary : {emp.Salary}");

            employees.ForEach(emp => 
                       Console.WriteLine($"Id : {emp.Id} FirstName : {emp.FirstName} LastName : {emp.LastName} Age : {emp.Age} Department : {emp.Department} Salary : {emp.Salary}"));




        }
    }
}