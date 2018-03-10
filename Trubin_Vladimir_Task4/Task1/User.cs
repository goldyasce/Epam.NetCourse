using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private string userName;
        private string secondName;
        private string surname;
        private string dateOfBirth;
        private int age;

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(UserName))
                {
                    Console.WriteLine("User name can't be empty!!!");
                }
                else
                {
                    userName = value;
                }
            }
        }

        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(SecondName))
                {
                    Console.WriteLine("Second name can't be empty!!!");
                }
                else
                {
                    secondName = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(Surname))
                {
                    Console.WriteLine("Surname can't be empty!!!");
                }
                else
                {
                    surname = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 100 && value > 17)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("User is child or dead!");
                }
            }
        }
        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (DateTime.TryParse(value, out DateTime dateTime) && (DateTime.Today.Year - Age) == dateTime.Year)
                {
                    dateOfBirth = value;
                }
                else
                {
                    Console.WriteLine("Wrong date of Birth!");
                }
            }
        }
    }
}
