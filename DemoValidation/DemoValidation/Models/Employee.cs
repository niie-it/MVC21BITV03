using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DemoValidation.Models
{
    public class Employee
    {
        public int? Id { get; set; }

        [Display(Name = "Mã nhân viên")]
        //[RegularExpression(@"[a-z]{6}", ErrorMessage ="Đúng 6 kí tự")]
        [Remote(action:"CheckExistedEmployee", controller:"Employee")]
        public string EmployeeNo { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Từ 3 đến 100 kí tự")]
        public string FullName { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }


        [DataType(DataType.Date)]
        [EnoughAgeForWork]
        public DateTime BirthDate { get; set; }

        public string? Email { get; set; }

        [RegularExpression(@"0[98753]\d{8}", ErrorMessage ="Số di động gồm 10 chữ số")]
        public string Phone { get; set; }

        public string? Address { get; set; }
        public bool Gender { get; set; }
        public string? Website { get; set; }

        [Range(0, double.MaxValue, ErrorMessage ="Lương phải không âm")]
        public double Salary { get; set; }
        public bool IsPartTime { get; set; }
        public string? CreditCard { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }
}
