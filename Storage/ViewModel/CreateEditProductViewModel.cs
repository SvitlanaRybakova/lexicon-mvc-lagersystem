namespace Storage.ViewModel
{
    public class CreateEditProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public DateTime Orderdate { get; set; }
        public string? Category { get; set; }
        public string? Shelf { get; set; }
        public int Count { get; set; }
        public string? Description { get; set; }
    }
}
