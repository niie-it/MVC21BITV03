using System.ComponentModel.DataAnnotations;

namespace DemoValidation.Models
{
    public class Employee
    {
        public int? Id { get; set; }
        public string EmployeeNo { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public bool Gender { get; set; }
        public string? Website { get; set; }
        public double Salary { get; set; }
        public bool IsPartTime { get; set; }
        public string? CreditCard{ get; set; }

        [DataType(DataType.MultilineText)]
        public string? Description{ get; set; }
    }
}
