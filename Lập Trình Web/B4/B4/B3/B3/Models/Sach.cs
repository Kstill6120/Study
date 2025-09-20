using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace B3.Models
{
    public class Sach
    {
        [Required(ErrorMessage = "Nhap sai nhap lai")]
        [StringLength(50, ErrorMessage = "ko qua 50 ki tu")]
        public string MaSach { get; set; }
        [Required(ErrorMessage = "Nhap sai nhap lai")]
        [StringLength(50, ErrorMessage = "ko qua 50 ki tu")]
        public string TenSach { get; set; }
        [Required(ErrorMessage = "Nhap sai nhap lai")]
        [Range(0,100000000,ErrorMessage = "ko qua 100000000 vnd")]
        public float GiaSach { get; set; }
        public string AnhBia { get; set; }
    }
}