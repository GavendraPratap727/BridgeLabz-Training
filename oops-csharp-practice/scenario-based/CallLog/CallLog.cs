using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CallLog
{
     class CallLog:ICallLog
    {
        private string phone;
        private string message;
        private DateTime time;
        public CallLog(string phone, string message, DateTime time) {
            this.phone = phone;
            this.message = message;
            this.time = time;
        }
        public void Display() {
            Console.WriteLine($"Phone number  {phone} -- Message {message} -: Time: {time}");
        }
        public string GetMessage() {
            return message;
        }
        public DateTime GetTime() {
            return time;
        }



    }
}
