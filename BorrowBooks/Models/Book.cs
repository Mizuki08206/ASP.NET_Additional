using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BorrowBooks.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        [Display(Name = "タイトル")]
        public string Title { get; set; }
        [Display(Name = "著名")]
        public string Author { get; set; }
        [Display(Name = "ジャンル")]
        public string Genre { get; set; }
        [Display(Name = "貸出者ID")]
        public int? Lend_User_Id { get; set; }
        [Display(Name = "貸出日")]
        public DateTime? Lend_Date { get; set; }
    }
}
