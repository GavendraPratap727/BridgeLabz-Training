using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Senario.HospitalSystemApp
{
    

    public class AmbulanceRouteUtility : IHospitalNavigation
    {
        private HospitalUnit head;
        private HospitalUnit tail;

        public void AddUnit(string name)
        {
            HospitalUnit unit = new HospitalUnit(name);

            if (head == null)
            {
                head = tail = unit;
                unit.Next = unit;
            }
            else
            {
                tail.Next = unit;
                tail = unit;
                tail.Next = head;
            }
        }

        public void RemoveUnit(string name)
        {
            if (head == null) return;

            HospitalUnit current = head;
            HospitalUnit previous = tail;

            do
            {
                if (current.Name == name)
                {
                    if (head == tail)
                    {
                        head = tail = null;
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (current == head) head = current.Next;
                        if (current == tail) tail = previous;
                    }
                    return;
                }

                previous = current;
                current = current.Next;

            } while (current != head);
        }

        public void SetAvailability(string name, bool isAvailable)
        {
            HospitalUnit unit = FindUnit(name);
            if (unit != null)
                unit.IsAvailable = isAvailable;
        }

        public string FindNextAvailable(string startName)
        {
            HospitalUnit start = FindUnit(startName);
            if (start == null)
                return "Invalid starting unit";

            HospitalUnit temp = start;

            do
            {
                if (temp.IsAvailable)
                    return "Redirected to " + temp.Name;

                temp = temp.Next;
            }
            while (temp != start);

            return "No units available";
        }

        public void DisplayRoute()
        {
            if (head == null)
            {
                Console.WriteLine("Route empty");
                return;
            }

            HospitalUnit temp = head;
            do
            {
                Console.Write(temp.Name + " -> ");
                temp = temp.Next;
            }
            while (temp != head);

            Console.WriteLine("(back to start)");
        }

        private HospitalUnit FindUnit(string name)
        {
            if (head == null) return null;

            HospitalUnit temp = head;
            do
            {
                if (temp.Name == name)
                    return temp;

                temp = temp.Next;
            }
            while (temp != head);

            return null;
        }
    }

}
