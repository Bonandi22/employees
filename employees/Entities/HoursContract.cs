using System;

namespace employees.Entities
{
    class HoursContract
    {
        public DateTime Data { get; set; }
        public Double ValuerPerHours { get; set; }
        public int Hours { get; set; }
        public HoursContract() { 
        }
        public HoursContract(DateTime data, double valuerPerHours, int hours)
        {
            Data = data;
            ValuerPerHours = valuerPerHours;
            Hours = hours;
        }
        public double TotalValue()
        {
            return Hours* ValuerPerHours;
        }
    }
}
