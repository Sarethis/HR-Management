using System;

namespace HR_Management
{
    public class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public double Salary { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public DateTime EmploymentEndDate  { get; set; }
        public bool Dissmised { get; set; }
        public int IdPosition { get; set; }
        public string Comments { get; set; }
    }
}
