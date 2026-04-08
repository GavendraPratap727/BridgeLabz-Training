using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Generics.SmarWareHouseManagementSystemApp
{
    public class GenricStorage<T> where T : WareHouseSystem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }
        public IReadOnlyList<T> GetAllItems()
        {
            return items;
        }
        public void DisplayAllItems()
        {
            foreach (T item in items)
            {
                item.Show();
            }
        }
    }
}
