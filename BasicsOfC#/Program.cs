using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a low number: ");
            double low = Convert.ToDouble(Console.ReadLine());
            while (low < 1)
            {
                Console.WriteLine("Invalid, enter a positive number: ");
                low = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Input a high number: ");
            double high = Convert.ToDouble(Console.ReadLine());
            while (high < low)
            {
                Console.WriteLine("Invalid, enter a number higher than the low one: ");
                high = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("The difference between the high and low number is " + (high - low));
            Console.ReadLine();

            List<string> list = new List<string>();
            for (double i = 0; i < high; i++)
            {
                if (i > low)
                {                   
                    string a = Convert.ToString(i);
                    list.Add(a);

                    if (prime(i) == true)
                    {
                        Console.WriteLine(i + " is a prime number");
                    }
                }
            }

            list.Reverse();
            System.IO.File.WriteAllLines("numbers.txt", list);

            var contents = System.IO.File.ReadAllLines("numbers.txt");
            double sum = 0;
            foreach (var line in contents)
                sum += Convert.ToDouble(line);

            Console.WriteLine("The sum of all the numbers in the text file is " + sum);
            Console.ReadLine();
        }
        static bool prime(double i)
        {
            double answer = i % 2;
            if (answer == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
