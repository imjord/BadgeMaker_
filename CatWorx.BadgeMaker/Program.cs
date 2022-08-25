using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
   
    // LIST EMPLOYEES METHOD
    static List<Employee> GetEmployees(){
        // get list of employees
        List<Employee> employees = new List<Employee>();
        while(true)
        {
            Console.WriteLine("Please enter first name of employee: (leave empty to exit): ");
            string firstName = Console.ReadLine() ?? "";
            if(firstName == ""){
                break;
            }
            Console.Write("Enter a last name: ");
            string lastName = Console.ReadLine() ?? "";
            Console.Write("Enter employee id: ");
            int id = Int32.Parse(Console.ReadLine() ?? "");
            Console.Write("Enter employee photo url: ");
            string photoUrl = Console.ReadLine() ?? "";

            // employee instance
            Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
            employees.Add(currentEmployee);
        }
        return employees;
    }

     

        // MAIN
     async static Task Main(string[] args)
    {
        // employee class 
        List<Employee> employees = GetEmployees();

        Util.PrintEmployees(employees);
        Util.MakeCSV(employees);
        await Util.MakeBadges(employees);
    }
  }
}