using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
   
        class User
        {
            public int id;
            public string name;
            public int age;
            public List<int> friends;

            public User(int id, string name, int age)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                friends = new List<int>();
            }
        }

        class Program
        {
            static LinkedList<User> users = new LinkedList<User>();

            static void Main(string[] args)
            {
                AddUser(1, "Aman", 20);
                AddUser(2, "Riya", 21);
                AddUser(3, "Rahul", 22);
                AddUser(4, "Neha", 20);

                AddFriend(1, 2);
                AddFriend(1, 3);
                AddFriend(2, 3);
                AddFriend(3, 4);

                Console.WriteLine("Friends of User 1:");
                ShowFriends(1);

                Console.WriteLine("Mutual Friends of 1 and 2:");
                MutualFriends(1, 2);

                Console.WriteLine("Remove Friend Connection (1 & 3):");
                RemoveFriend(1, 3);
                ShowFriends(1);

                Console.WriteLine("Search by Name:");
                SearchByName("Rahul");

                Console.WriteLine("Search by ID:");
                SearchById(4);

                Console.WriteLine("Friend Count:");
                FriendCount();
            }

            static void AddUser(int id, string name, int age)
            {
                users.AddLast(new User(id, name, age));
            }

            static void AddFriend(int id1, int id2)
            {
                User u1 = FindUser(id1);
                User u2 = FindUser(id2);

                if (u1 == null || u2 == null) { Console.WriteLine("User not found"); return; }

                if (!u1.friends.Contains(id2)) u1.friends.Add(id2);
                if (!u2.friends.Contains(id1)) u2.friends.Add(id1);
            }

            static void RemoveFriend(int id1, int id2)
            {
                User u1 = FindUser(id1);
                User u2 = FindUser(id2);

                if (u1 == null || u2 == null) { Console.WriteLine("User not found"); return; }

                u1.friends.Remove(id2);
                u2.friends.Remove(id1);
                Console.WriteLine("Friend connection removed");
            }

            static void MutualFriends(int id1, int id2)
            {
                User u1 = FindUser(id1);
                User u2 = FindUser(id2);

                if (u1 == null || u2 == null) { Console.WriteLine("User not found"); return; }

                bool found = false;
                foreach (int f in u1.friends)
                {
                    if (u2.friends.Contains(f)) { Console.WriteLine("Mutual Friend ID: " + f); found = true; }
                }
                if (!found) Console.WriteLine("No mutual friends");
            }

            static void ShowFriends(int id)
            {
                User u = FindUser(id);

                if (u == null) { Console.WriteLine("User not found"); return; }
                if (u.friends.Count == 0) { Console.WriteLine("No friends"); return; }

                foreach (int f in u.friends) Console.WriteLine("Friend ID: " + f);
            }

            static void SearchByName(string name)
            {
                foreach (User u in users)
                {
                    if (u.name.ToLower() == name.ToLower())
                    {
                        Console.WriteLine("ID: " + u.id + ", Name: " + u.name + ", Age: " + u.age);
                        return;
                    }
                }
                Console.WriteLine("User not found");
            }

            static void SearchById(int id)
            {
                foreach (User u in users)
                {
                    if (u.id == id)
                    {
                        Console.WriteLine("ID: " + u.id + ", Name: " + u.name + ", Age: " + u.age);
                        return;
                    }
                }
                Console.WriteLine("User not found");
            }

            static void FriendCount()
            {
                foreach (User u in users)
                    Console.WriteLine("User: " + u.name + ", Friends: " + u.friends.Count);
            }

            static User FindUser(int id)
            {
                foreach (User u in users)
                {
                    if (u.id == id) return u;
                }
                return null;
            }
        }
    }


