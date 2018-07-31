using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pluto
{



    public interface Itaxcalculator
    {
         int Sentname();
    }



    class Program
    {
        

        static void Main(string[] args)
        {

            NORTHWNDEntities entities = new NORTHWNDEntities();


            Employee employee = new Employee();

            employee.FirstName = "Devarsh";
            employee.LastName = "Shuklaaaa";
            employee.Notes = "This are my notes";

            entities.Employees.Add(employee);
            entities.SaveChanges();




        }
         
       
        

    }
}

