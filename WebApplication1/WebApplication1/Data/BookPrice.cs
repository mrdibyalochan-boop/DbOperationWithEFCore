namespace WebApplication1.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CurencyId { get; set; }

        public int Amount { get; set; }
        public Book books { get; set; }
    
        public Currency Currencies { get; set; }

       
       
       
    }
}
