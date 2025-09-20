using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace B3.Models
{
    public class Informaton1
    {
        [Required(ErrorMessage = "Nhap sai nhap lai")]
        [StringLength(50, ErrorMessage = "ko qua 50 ki tu")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Nhap sai nhap lai")]
        [StringLength(10, ErrorMessage = "ko qua 10 ki tu")]
        public string IdStudent { get; set; }
        [Required(ErrorMessage = "Nhap sai nhap lai")]
        [EmailAddress(ErrorMessage = "nhap sai dinh dang email")]
        public string Email { get; set; }
        public string FileImage { get; set; }
        public string Note { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
        [Required()]
        public string ChooseWorkTime { get; set; }
        [Required()]
        public int SelectCourse { get; set; }
    }
}