using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;

namespace FindJobApplication.Models
{
    public class Account
    {
        private int id;
        private string email;
        private string password;
        private string name;
        private string role;
        private Image avatar = Image.FromFile(Path.GetFullPath(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources", "default-avatar.png"))
            );
        public Account(string email, string password, string name, string role)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.role = role;
        }

        public Account(int id, string email, string password, string name, string role) : this(email, password, name, role)
        {
            this.id = id;
        }

        protected Account(int id, string email, string name)
        {
            this.id = id;
            this.email = email;
            this.name = name;
        }
        
        public Account(string email, string name)
        {
            this.email = email;
            this.name = name;
        }

        public int ID { get => this.id; }
        public string Email {
            get => this.email;
            set
            {
                ValidateNotEmpty(value, "Email");

                string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                Regex regex = new Regex(emailPattern);
                if (regex.IsMatch(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Invalid email format.");
                }
            }
        }
        public string Password { 
            get => this.password; 
            set
            {
                ValidateNotEmpty(value, "Password");

                string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
                Regex regex = new Regex(passwordPattern);
                if (regex.IsMatch (value))
                {
                    this.password = value;
                }
                else
                {
                    throw new Exception("Password must be a minimum of 8 characters, with at least one letter and one number.");
                }
            }
        }
        public string Name {
            get => this.name; 
            set
            {
                ValidateNotEmpty(value, "Name");
                this.name = value;
            }
        }
        public string Role { 
            get => this.role;
            set => this.role = value;
        }

        private void ValidateNotEmpty(string value, string fieldName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{fieldName} cannot be empty.");
            }
        }

        public Image Avatar {
            get => avatar;
            set
            {
                if (value == null)
                    throw new ArgumentException("Image cannot be empty.");

                try
                {
                    avatar = value;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading image");
                }
            }
        }
    }
}
