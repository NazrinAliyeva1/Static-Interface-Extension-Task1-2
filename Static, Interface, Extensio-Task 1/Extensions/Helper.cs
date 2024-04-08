using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Interface__Extensio_Task_1.Extensions
{
    internal static class Helper
    {

        private static string _password;
        private static bool _isOdd;
        private static bool _isEven;
        private static bool _CheckHasDigit;
        


        public static string HasDigit
        {
            set
            {
                bool v = CheckHasDigit(value);
                if (v)
                {
                    _isOdd = true;
                }
                else
                {
                    _isEven = false;
                }

            }
        }

        public static bool IsOdd
        {
            set
            {
                _isOdd = value;
            }
        }
        public static bool IsEven {
            set
            {
                _isEven = value;

            }
        }


        public static string Capitalize(this string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }
            name = name.Trim();
            return String.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1).ToLower());
        }


        public static bool CheckPassword(string value)
        {               
                if (value.Length >= 8 && CheckLower(value) && CheckUpper(value) && CheckHasDigit(value))
                {
                    return true;
                    _password = value;
                    Console.WriteLine(_password);
                }
                else
                {
                    return false;
                    Console.WriteLine("Sifre minimum 1 kicik herf, 1 boyuk herf, 1 reqem ve uzunlugu 8-den kicik olmammalidir.");
                }     
        }

        public static bool CheckIsOdd(int num)
        {
            return num % 2 != 0;


        }
        public static bool CheckIsEven(int num)
        {
            return num % 2 == 0;


        }

        public static bool CheckHasDigit(string input)
        {
            foreach(char c in input)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        public static bool CheckLower(string input)
        {
            for(int i =0; i<input.Length; i++)
            {
                if (Char.IsLower(input[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    return true;
                }
            }
            return false;

        }


    }
}
