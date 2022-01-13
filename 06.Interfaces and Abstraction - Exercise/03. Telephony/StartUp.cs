using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            //List<string> smartphones = new List<string>();
            //List<string> stationaryPhones = new List<string>();

            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            bool isNotOK = false;
            bool isNotBrows = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int y = 0; y < numbers[i].Length; y++)
                {
                    if (!char.IsDigit(numbers[i][y]) || numbers[i].Length != 10 && numbers[i].Length != 7)
                    {
                        Console.WriteLine("Invalid number!");
                        isNotOK = true;
                        break;
                    }
                }

                if (numbers[i].Length == 10 && isNotOK == false)
                {
                    Console.WriteLine(smartphone.Call(numbers[i]));
                }
                else if(numbers[i].Length == 7 && isNotOK == false)
                {
                    Console.WriteLine(stationaryPhone.Call(numbers[i]));
                }
                
                isNotOK = false;
            }

            for (int i = 0; i < sites.Length; i++)
            {
                for (int y = 0; y < sites[i].Length; y++)
                {
                    if (char.IsDigit(sites[i][y]))
                    {
                        Console.WriteLine("Invalid URL!");
                        isNotBrows = true;
                        break;
                    }
                }
                if(isNotBrows == false)
                {
                    Console.WriteLine(smartphone.Browsing(sites[i]));
                }

                isNotBrows = false;
            }
        }
    }
}
