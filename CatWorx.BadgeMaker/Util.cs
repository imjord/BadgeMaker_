// imports
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util 
    {
           // PRINT EMPLOYEES NO RETRUN 
    public static void PrintEmployees(List<Employee> employees){
        
        for(int i = 0; i < employees.Count; i++){
            string template = "{0,-10}\t{1,-20}\t{2}";
            Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
        }
    }

    public static void MakeCSV(List<Employee> employees)
    {
        // see if folder exists 
        if(!Directory.Exists("data"))
        {
            // if not create it
            Directory.CreateDirectory("data");
        }
        using (StreamWriter file = new StreamWriter("data/employees.csv"))
        {
            file.WriteLine("ID, Name, PhotoURL");
            // loop over employees 
            for(int i = 0; i < employees.Count; i++){
            string template = "{0},{1},{2}";
            file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
        }
        }
    }
    }
}