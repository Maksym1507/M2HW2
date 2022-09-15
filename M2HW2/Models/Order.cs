namespace M2HW2.Models
{
    public class Order
    {
        private readonly string[] _selectedProducts;

        private static int _id;

        public Order(string[] selectedProducts)
        {
            _selectedProducts = selectedProducts;
            _id++;
            Id = _id;
        }

        public string[] SelectedProducts => _selectedProducts;

        public int Quantity { get; set; }

        public int Id { get; }

        public static Order[] Orders { get; set; }
    }
}
