using System;

namespace bridge.DSA_Senario.FlashDealz
{
    class FlashManagerImpl : IFlashManager
    {
        private Product[] products = new Product[50];
        private int count = 0;

        public void AddProduct(string name, double discount)
        {
            if (count >= products.Length)
            {
                Console.WriteLine("Product limit reached");
                return;
            }

            products[count++] = new Product(name, discount);
            Console.WriteLine("Product added successfully");
        }

        public void SortProducts()
        {
            if (count == 0)
            {
                Console.WriteLine("No products to sort");
                return;
            }

            QuickSort(0, count - 1);
            Console.WriteLine("Products sorted by discount (High to Low)");
        }

        private void QuickSort(int low, int high)
        {
            if (low < high)
            {
                int p = Partition(low, high);
                QuickSort(low, p - 1);
                QuickSort(p + 1, high);
            }
        }

        private int Partition(int low, int high)
        {
            double pivot = products[high].GetDiscount();
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (products[j].GetDiscount() > pivot)
                {
                    i++;
                    Swap(i, j);
                }
            }

            Swap(i + 1, high);
            return i + 1;
        }

        private void Swap(int i, int j)
        {
            Product temp = products[i];
            products[i] = products[j];
            products[j] = temp;
        }

        public void DisplayDeals()
        {
            if (count == 0)
            {
                Console.WriteLine("No products available");
                return;
            }

            Console.WriteLine("\nTop Discounted Products:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(products[i].GetName() + " - " + products[i].GetDiscount() + "%");
            }
        }
    }
}
