namespace WebApplication1.Data
{
    public class Currency
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }

       public ICollection<BookPrice> Prices { get; set; }
    }
}
