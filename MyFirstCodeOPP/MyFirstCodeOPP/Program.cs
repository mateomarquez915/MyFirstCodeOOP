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
                    Id=1000,
                    FirstName= "maria",
                    LastName="posada",
                    BirthDate= new Date(1950,2,5),
                    HiringDate= new Date(2022,12,31),
                    IsActive=true,
                    Salary= 20000.34M           
                 
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
