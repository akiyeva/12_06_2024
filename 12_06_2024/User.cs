using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06_2024
{
    public class User : Account
    {
        private static string _id;
        private string _password;
        public string Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }
        public User(string email, string password)
        {
            Id += _id;
            Email = email;
            Password = password;
        }
        public override bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if (char.IsLower(c))
                    hasLower = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
            }
            return hasUpper && hasLower && hasDigit;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Id} {Fullname} {Email}");
        }
    }
}
