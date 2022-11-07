using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BorrowBooks.Models
{
    public partial class User
    {
        
        public int Id { get; set; }
        [Display(Name="氏名")]
        public string User_Name { get; set; }
        [Display(Name = "メールアドレス")]
        public string Mail_Address { get; set; }
        [Display(Name = "パスワード")]
        public string Password { get; set; }
        [Display(Name = "電話番号")]
        public string Phone { get; set; }
    }
}
