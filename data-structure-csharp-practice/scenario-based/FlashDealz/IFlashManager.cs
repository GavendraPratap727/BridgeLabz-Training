namespace bridge.DSA_Senario.FlashDealz
{
    public interface IFlashManager
    {
        void AddProduct(string name, double discount);
        void SortProducts();
        void DisplayDeals();
    }
}
