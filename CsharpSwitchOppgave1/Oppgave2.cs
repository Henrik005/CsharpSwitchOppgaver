using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSwitchOppgave1
{
    internal class Oppgave2
    {

        public void Run()
        {
            var input = CreateInput();
            switch (input)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Run();
                    break;
            }
        }
        private int CreateInput()
        {
            bool isInt = false;
            int answer = 0;
            while (!isInt)
            {
                int check;
                var input = Console.ReadLine();
                if (int.TryParse(input, out check))
                {
                    answer = Convert.ToInt32(input);
                    isInt = true;

                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
            return answer;
        }
    }
}
