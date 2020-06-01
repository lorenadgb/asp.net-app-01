using System;

namespace WebApplication1.Models
{
    public class Accountant : Employee
    {
        public string ACS { get; set; }
        public DateTime ACSExpiryDate { get; set; }
        
        public void Info()
        {
            Console.WriteLine("ID: {0} - Name: {1} - Rate per hour: {2} - Registration No: {3} - Expire Date: {4}", 
                this.Name, this.Name, this.RatePerHour, this.ACS, this.ACSExpiryDate);
        }
    }
}