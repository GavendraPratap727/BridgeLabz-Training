using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Generics.SmarWareHouseManagementSystemApp
{
    internal class ShowItem
    {
        public static void DisplayWarehouseItems(IReadOnlyList<WareHouseSystem> items)
        {
            foreach (var item in items)
            {
                item.Show();
            }
        }
    }
}
