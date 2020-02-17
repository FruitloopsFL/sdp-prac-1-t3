using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Problem7_10001Prime();
            Console.WriteLine('\n');
            Console.ReadLine(); //enter to see next euler problem
            Problem8_LargestProductInASeries();
            Console.WriteLine('\n');
            Console.ReadLine(); //enter to see next euler problem
            Problem1_Multiplesof3and5();

        }
        public static void Problem7_10001Prime() 
        {
            int count = 1;
            int index = 3;
            while (true)
            {
                int num = 1;
                bool PrimeNum = true;
                for (int i = 2; i <= index; i++)
                {
                    if (index % i == 0)
                    {
                        num++;
                        if (num > 2)
                        {
                            PrimeNum = false;
                            break;
                        }
                    }

                }
                if (PrimeNum)
                {
                    count++;
                    if (count == 10001)
                    {
                        Console.WriteLine("The 10001st Prime Number is " + index);
                        break;

                    }
                }
                index++;

            }
            
            
        }


        public static void Problem1_Multiplesof3and5() //tandza khoza
         {
            
            List<int> numbers = new List<int>();
            for (int i = 3; i < 1000; i += 3)
            {
                numbers.Add(i);

            }
            for (int j = 5; j < 1000; j += 5)
            {
                numbers.Add(j);

            }
            Console.WriteLine("list of natural numbers below 1000");
            int sum = 0;
             foreach(int x in numbers )
             {
                Console.WriteLine(x);
                sum = sum + x;
               
            }
        

            numbers.ForEach(Console.WriteLine);
            Console.WriteLine("sum of all the multiples of 3 or 5 below 1000 = "+sum);
            Console.ReadLine();



        }

        //Finds the largest product of 13 consecutive numbers in a series of 1000 numbers
        static void Problem8_LargestProductInASeries() //Solved by Kabir Sonne
        {
            int stored = 0; //stores the current larges product
            
            string num = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            for (int i = 0; i <= 987; i++) //Sets the starting number to be multiplied with the exception of the last 12 numbers(the last 12 numbers are all part of the last set to be multiplied and cannot be the start of a new set)
            {
                int product = 1;
                for (int j = 0; j < 13; j ++) //Multiplies 13 consecutive numbers and stores them in 'product'
                {
                    product = product * Convert.ToInt32(num[j]);
                }

                if (product > stored) //Compares the newly calculated product with the stored product and the larger value is kept in 'stored'
                {
                    stored = product;
                }
                
            }
            
            Console.WriteLine("The Largest product of 13 consecutive numbers in the series is: " + stored); //Prints the largest product
            
            //Console.ReadLine();
        }
    }
}
