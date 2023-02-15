using System;

namespace MyFirstCodeOPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateObject = new Date(1, 12, 50);
                Console.WriteLine(dateObject);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
             
        }
    }
}
