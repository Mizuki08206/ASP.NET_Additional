namespace BorrowBooks.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int? Lend_User_Id { get; set; }
        public DateTime? Lend_Date { get; set; }
    }
}
