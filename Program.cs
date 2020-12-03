using System;

namespace assignment4
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the number of days:");
            int numOfDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you want any add on services? y/n");
            string opt = Console.ReadLine();

            if (opt == "y"){
                Console.WriteLine("\nA = Bathing & Grooming");
                Console.WriteLine("c = Bathing");

                Console.WriteLine("\nSelect an option from the list of services above");
                string addonCode = Console.ReadLine();

                computeRate(numOfDays, addonCode);
            }else{
                computeRate(numOfDays);
            }
            
        }

        public static void computeRate(int numOfDays){
            int rate = numOfDays * 75;
            Console.WriteLine($"The number of days the dog will stay is {numOfDays}");
            Console.WriteLine($"The total cost is {rate}");         
        }

        public static void computeRate(int numOfDays, string addonCode){
            string code = addonCode.ToUpper();
            while(code != "A" && code != "C"){
                Console.WriteLine("You have entered an invalid code");
                Console.WriteLine("\nA = Bathing & Grooming");
                Console.WriteLine("C = Bathing");

                Console.WriteLine("\nSelect an option from the list of services above");
                addonCode = Console.ReadLine();
                code = addonCode.ToUpper();
                
            }

            string[] addonServices = {"Bathing & grooming", "Bathing"};
            string addonService = "";
            double rate = 0;
            if (code == "A"){
                rate += numOfDays * 169;
                addonService += addonServices[0];
            }else if(code == "C"){
                rate += numOfDays * 169;
                addonService += addonServices[1];

            }

            Console.WriteLine($"You selected option {code} ({addonService}) as your preferred service");
            Console.WriteLine($"The number of days the dog will stay is {numOfDays}");
            Console.WriteLine($"The total cost is ${rate}");

        }

    }
}
