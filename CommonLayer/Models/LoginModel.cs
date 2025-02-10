using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = " id required ")]
        public int EmployeeId { get; set; }
        [RegularExpression(@"^[A-Z][a-z]{2,}$", ErrorMessage = "name should starts with capital letter has min 3 characters")]
        public string EmployeeName { get; set; }

    }
}
