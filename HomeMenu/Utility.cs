using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeMenu
{
    class Utility
    {
        public static string getArrayMemberAsString(double []x)
        {
            string s = "";
            switch(x.Length)
            {
                case 0:
                    return s;
                default:
                    s += x[0];
                    for (int i = 1; i < x.Length; i++)
                        s = s + " " + x[i];
                    return s;
            }
        }
        public static string getArrayMemberAsString(int[] x)
        {
            string s = "";
            switch (x.Length)
            {
                case 0:
                    return s;
                default:
                    s += x[0];
                    for (int i = 1; i < x.Length; i++)
                        s = s + " " + x[i];
                    return s;
            }
        }
    }
}
