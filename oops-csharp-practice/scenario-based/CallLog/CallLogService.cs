using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CallLog
{
    internal class CallLogService:ICallLogService
    {
        public static  ICallLog[] logs=new ICallLog[50];
        public static int count = 0;
        public void AddLog() {
            Console.WriteLine("Enter Phone Number:");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Message:");
            string message = Console.ReadLine();
            DateTime time = DateTime.Now;
            logs[count++] = new CallLog(phone, message, time);
        }
    }
}
