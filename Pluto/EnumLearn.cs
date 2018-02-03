using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
 
namespace Pluto
{
   public class EnumLearn
    {
        

        //^ Start Regex $ close regex [character range like a-z]{1,3} character lenght to apply regex
        //a-g only for one chaacter  [] range of characters 
        //a-g with length of 3 {1,5} minlength,max lenght length of words to check lenght of characters 


        public void regexMatch()
            {
            String Pattern2 = "^[a-z]{7}$";

            Regex firstname = new Regex("^[a-z]{7}$");
           bool Ismatch = firstname.IsMatch("devarsh");

            

            Console.WriteLine(Ismatch.ToString());
          

            


        }
        
       
       


}

}



