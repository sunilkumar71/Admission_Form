using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Admission_Form.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Required*")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required*")]
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Required*")]
        [DataType(DataType.Date)]
        public string DateOfBirth{ get; set; }
        [Required(ErrorMessage = "Required*")]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        [Required(ErrorMessage = "Required*")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10),MinLength(10)]
        public string PhoneNO{ get; set; }
        [Required(ErrorMessage = "Required*")]
        public string Address{ get; set; }
    }
}