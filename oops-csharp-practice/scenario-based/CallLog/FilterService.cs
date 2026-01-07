using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CallLog
{
    class FilterService:IFilterService
    {
        public void Filter(DateTime start, DateTime end) {
            bool found = false;
            for(int i=0;i<CallLogService.count;i++) {
                DateTime logTime = CallLogService.logs[i].GetTime();
                if(logTime >= start && logTime <= end) {
                    CallLogService.logs[i].Display();
                    found = true;
                }
            }
            if(!found) {
                Console.WriteLine("Not found .");
            }

        }
    }
}
