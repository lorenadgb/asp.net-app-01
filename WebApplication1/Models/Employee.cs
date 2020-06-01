using System;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HoursPerWeek { get; set; }
        public decimal RatePerHour { get; set; }
        
        public decimal CalculateWage(decimal hoursPerWeek, decimal ratePerHour)
        {
            decimal result = hoursPerWeek * ratePerHour;
            
            Console.WriteLine(result);
            
            return result;
        }
    }
}
