using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange din inkomst: ");
            int inkomst = 0;
            int timmar = 0;
            try
            {
                inkomst = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.Write("Ange antal timmar: ");
            try
            {
                timmar = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }    
                
            Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");// kommer kracha om timmar == 0 || timmar e samt om inkomst == e

            Console.ReadKey();
        }
    }
}
