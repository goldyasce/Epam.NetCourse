using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        private char[] nchar;

        public char[] Nchars
        {
            get
            {
                return nchar;
            }
            set
            {
                nchar = value;
            }
        }

        public MyString(string newString)
        {
            Nchars = newString.ToCharArray(0, newString.Length);
        }

        public override string ToString()
        {
            string demo = string.Empty;
            for (int i = 0; i < Nchars.Length; i++)
            {
                demo += Nchars[i].ToString();
            }

            return (System.String.Format(demo));
        }

        public static MyString operator + (MyString myString, string newString)
        {
            string demo = myString.ToString();
            int length = newString.Length + myString.Nchars.Length;
            demo += newString;
            myString.Nchars = demo.ToCharArray(0, length);
            return myString;
        }

        public static MyString operator - (MyString myString, string newString)
        {
            string demo = myString.ToString();
            demo = demo.Replace(newString, string.Empty);
            myString.Nchars = demo.ToCharArray(0, demo.Length);
            return myString;
        }

        public static bool operator == (MyString myStringA, MyString myStringB)
        {
            string demoA = myStringA.ToString();
            string demoB = myStringB.ToString();

            if (String.Compare(demoA, demoB) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (MyString myStringA, MyString myStringB)
        {
            string demoA = myStringA.ToString();
            string demoB = myStringB.ToString();

            if (String.Compare(demoA, demoB) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
