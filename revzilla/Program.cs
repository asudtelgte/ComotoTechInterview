using System.Reflection;

namespace revzilla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cap = 120;
            int counter = 7;

            while (counter <= cap)
            {
                string toPrint = "";

                if (counter % 3 == 0 && counter % 5 == 0 && counter % 7 == 0)
                {
                    toPrint += printPizzaParty();
                }

                if (counter %3 == 0 &&! toPrint.Contains("pizza party"))
                {
                    toPrint += printFizz();
                }

               if(counter % 5 == 0 && !toPrint.Contains("pizza party"))
                {
                    toPrint += printBuzz();
                }

                if (counter % 7 == 0 && !toPrint.Contains("pizza party"))
                {
                    toPrint += printPop();
                }

                if(toPrint == "")
                {
                    toPrint = counter.ToString();
                }

                printCounter(toPrint);
                counter++;
            }
        }

        static string printPizzaParty()
        {
            return "pizza party";
        }

        static string printFizz()
        {
            return "fizz";
        }

        static string printBuzz()
        {
            return "buzz";

        }
        static string printPop()
        {
            return "pop";
        }

        static void printCounter(string toPrint) 
        {
            Console.WriteLine(toPrint);
        }
    }
}