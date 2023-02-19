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
                Console.WriteLine("Please input the year");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the month");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the day");
                day = Convert.ToInt32(Console.ReadLine());
                var dateObject = new Date(year, month, day);
                Console.WriteLine(dateObject);

                Console.WriteLine("************Testing Lates mplementation********");


                Employee salaryEmployee = new SalaryEmployee()
                {

                    Id= Convert.ToInt32(Console.ReadLine()),
                    FirstName= Console.ReadLine(),
                    LastName=Console.ReadLine(),
                    BirthDate= new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate= new Date(2022,12,31),
                    IsActive=Convert.ToBoolean(Console.ReadLine()),
                    Salary= Convert.ToDecimal(Console.ReadLine()),       
                 
                };

                Console.WriteLine(salaryEmployee);




            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
             
        }
    }
}
