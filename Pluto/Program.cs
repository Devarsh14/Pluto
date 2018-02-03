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

         public static (string dev1,string ripal) dev()
        {
            return ("Dev", ripal:"Ripal");
        }


        static void Main(string[] args)
        {


            EnumLearn learn = new EnumLearn();
            learn.regexMatch();
            
            Console.ReadLine();
        }


    }
}

