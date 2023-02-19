using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class SalaryEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }

        #endregion

        #region Method
        public override decimal GetValueToPay()
        {
            return Salary;  
            
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t" +
                $" Value To Pay:{GetValueToPay()}";
        }
        #endregion


    }
}
