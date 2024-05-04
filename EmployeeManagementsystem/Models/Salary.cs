namespace EmployeeManagementsystem.Models
{
    public class Salary
    {
        public int SalaryID { get; set; }
        public int EmployeeID { get; set; } // Foreign key to link to the Employee model
        public decimal SalaryAmount { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
