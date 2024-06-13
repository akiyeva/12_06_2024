using _12_06_2024.Helpers;

namespace _12_06_2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = CreateUser();
            Group group = CreateGroup();

            while (true)
            {
                Console.WriteLine("1. Show info");
                Console.WriteLine("2. Create new group");

                string command = Console.ReadLine();

                if (command == "1")
                {
                    user.ShowInfo();
                }
                else if (command == "2")
                {
                    group.ShowInfo();
                }
                else if (command == "3")
                {
                    Console.WriteLine("1. Show all students");
                    Console.WriteLine("2. Get student by id");
                    Console.WriteLine("3. Add student");
                    Console.WriteLine("0. Quit");
                }
            }

        }

        public static User CreateUser()
        {
            Console.Write("Enter user name: ");
            string email = Console.ReadLine();

            Console.Write("Enter user age: ");
            string password = Console.ReadLine();

            return new User(email, password);
        }

        public static Group CreateGroup()
        {
            Console.Write("Enter group no: ");
            string groupNo = Console.ReadLine();

            if (CheckGroupNo(groupNo))
            {


                Console.Write("Enter user age: ");
                int studentLimit = int.Parse(Console.ReadLine());

                return new Group(groupNo, studentLimit);
            }
            else
            {
                Console.WriteLine("Invalid group number format.");
                return null;
            }
        }
    }
}

