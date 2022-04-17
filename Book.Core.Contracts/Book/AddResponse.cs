namespace Book.Core.Contracts.Book
{
    public class AddResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}