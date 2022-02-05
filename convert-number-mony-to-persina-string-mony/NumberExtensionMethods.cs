using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeNameSpace
{
    public static class NumberExtensionMethods
    {


        public static string ToStringMony(this decimal number)
        {
            var str = "";
            number /= 10;
            ConvertToThousand(number, ref str);

            return str;
        }

        private static void ConvertToThousand(decimal number, ref string str)
        {

            if (number >= 1000000000)
            {
                if (number % 1000000000 > 0)
                {
                    str += $" {(int)(number / 1000000000)} میلیارد و";
                    ConvertToThousand(number % 1000000000, ref str);
                }
                else
                {
                    str += $" {(int)(number / 1000000000)} میلیارد تومان ";
                }

            }

            else if (number >= 1000000)
            {
                if (number % 1000000 > 0)
                {
                    str += $" { (int)(number / 1000000)} میلیون و";
                    ConvertToThousand(number % 1000000, ref str);

                }
                else
                {
                    str += $" { (int)(number / 1000000)}میلیون تومان ";
                }

            }

            else if (number >= 1000)
            {
                if (number % 1000 > 0)
                {
                    str += $"{(int)(number / 1000)}   هزار و ";
                    ConvertToThousand(number % 1000, ref str);


                }
                else
                {
                    str += $"{(int)(number / 1000)} هزار تومان";
                }
            }
            else
            {
                str += $"{number:0} تومان";
            }

        }

    }
}
