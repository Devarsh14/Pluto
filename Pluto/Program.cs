using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto
{
    class Program
    {
        static void Main(string[] args)
        {

            var dbcontext = new PlutoDbContext();

            var courses = dbcontext.GetCourses();
            

            foreach(var c in courses)
            {
                Console.WriteLine(c.Title);
            }

            Console.ReadLine();

        }

    }
}

