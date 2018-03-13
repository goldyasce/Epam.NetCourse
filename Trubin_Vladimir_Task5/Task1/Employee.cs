using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee : User
    {
        private double workStage;
        private string userPosition;
        private string userWorkPlace;

        public Employee(string UserName, string Surname, DateTime DateOfBirth, string Secondname, double workStage, string userPosition,
            string userWorkPlace = null) : base (UserName, Surname, DateOfBirth, Secondname)
        {

        }

        public double WorkStage
        {
            get
            {
                return workStage;
            }
            set
            {
                if (value >= 0)
                {
                    workStage = value;
                }
                else
                {
                    throw new ArgumentException("Unreal stage");
                }
            }
        }
        public string UserPosition
        {
            get
            {
                return userPosition;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("User post can't be empty");
                }
                else
                {
                    userPosition = value;
                }
            }
        }
        public string UserWorkPlace
        {
            get
            {
                return userWorkPlace;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("User work place can't be empty");
                }
                else
                {
                    userWorkPlace = value;
                }
            }
        }
    }
}
