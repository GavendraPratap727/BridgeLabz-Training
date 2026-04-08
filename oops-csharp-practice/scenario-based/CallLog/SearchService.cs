using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CallLog
{
    class SearchService:ISearchService
    {
        public void Search(string Keyword) {
            bool found = false;
            for(int i=0;i<CallLogService.count;i++) {
                if(CallLogService.logs[i].GetMessage().Contains(Keyword)) {
                    CallLogService.logs[i].Display();
                    found = true;
                }
            }
            if(!found) {
                Console.WriteLine("Not found ");
            }
        }
    }
}
