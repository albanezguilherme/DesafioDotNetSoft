namespace DesafioSoft.Core.Entities
{
    public class Book : BaseEntity
    {       
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Year { get; set; } = "";

        public Book(string title, string author, string year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }

        public Book()
        {
            
        }
    }
}
