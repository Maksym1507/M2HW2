using M2HW2.Models;

namespace M2HW2.Services
{
    public class CatalogService
    {
        private static readonly Catalog _products;

        static CatalogService()
        {
            _products = Catalog.Instance;
        }

        public static void ShowProducts()
        {
            NotificationService.ShowMessage("Product range:\n");

            foreach (var item in _products.ListOfProducts)
            {
                NotificationService.ShowMessage($"{item}\n");
            }

            NotificationService.ShowMessage("\n");
        }
    }
}
