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
            /*
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
            */
            //Övning 5
            /*
            try
            {
                int fem = 5;
                int inmatat = int.Parse(Console.ReadLine());
                Console.WriteLine(fem/inmatat);
            }
            catch (Exception e)
            {
             
                Console.Write("Application has encountered error....");
            }
            Console.ReadKey();
            */
            //Övning 6
            /*
            Console.WriteLine("Skriv in ett heltal: ");
            int inmatat = 0;
            bool spärr = false;
            Console.WriteLine(FelHanterare(inmatat, spärr));
            Console.ReadKey();

        }

        static string FelHanterare(int inmatat, bool spärr)
        {
            do
            {
                spärr = int.TryParse(Console.ReadLine(), out inmatat);
                if (!spärr)
                {
                    return "Försök igen";
                }
            } while (!spärr);
            return inmatat.ToString();
        }
        */
            //Övning 7
            /*
            int värdeStart = 0;
            bool startBool = false;
            try
            {
                Console.Write("Mata in start: ");
                int startVar = Start(värdeStart, startBool);
                Console.Write("Mata in stop: ");
                int stopVar = Stop(värdeStart, startBool);
                Console.Write("Mata in steg: ");
                int stegVar = Steg(värdeStart, startBool);
                for (int i = startVar; i <= stopVar; i += stegVar)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();               
        }

        static int Start(int värdeStart, bool startBool)
        {

            while (!startBool)
            {
                startBool = int.TryParse(Console.ReadLine(), out värdeStart);
                if (!startBool)
                {
                    return -1;
                }
            }
            return värdeStart;
        }

        static int Stop(int värdeStop, bool stopBool)
        {

            while (!stopBool)
            {
                stopBool = int.TryParse(Console.ReadLine(), out värdeStop);
                if (!stopBool)
                {
                    return -1;
                }
            }
            return värdeStop;
        }

        static int Steg(int värdeSteg, bool stegBool)
        {

            while (!stegBool)
            {
                stegBool = int.TryParse(Console.ReadLine(), out värdeSteg);
                if (!stegBool)
                {
                    return -1;
                }
            }
            return värdeSteg;
        }
        */
    }
}
