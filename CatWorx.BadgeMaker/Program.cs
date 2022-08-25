using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    
      // MAIN
     async static Task Main(string[] args)
    {
        // employee class 
        List<Employee> employees = await PeopleFetcher.GetFromApi();

        Util.PrintEmployees(employees);
        Util.MakeCSV(employees);
        await Util.MakeBadges(employees);
    }
  }
}