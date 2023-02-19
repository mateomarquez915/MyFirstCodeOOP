using System;

namespace MyFirstCodeOPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int year, month, day;
                Console.WriteLine("input the year");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the month");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the day");
                day = Convert.ToInt32(Console.ReadLine());
                var dateObject = new Date(year, month, day);
                Console.WriteLine(dateObject);



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
             
        }
    }
}
