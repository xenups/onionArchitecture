namespace Book.Core.Contracts.Book
{
    public class AddBookOutput
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}