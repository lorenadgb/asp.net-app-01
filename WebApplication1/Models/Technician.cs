using System;

namespace WebApplication1.Models
{
    public class Technician : Employee
    {
        public string CPA { get; set; }
        
        public void Info()
        {
            Console.WriteLine("ID: {0} - Name: {1} - Rate per hour: {2} - Registration No: {3}", 
                this.Name, this.Name, this.RatePerHour, this.CPA);
        }
    }
}
