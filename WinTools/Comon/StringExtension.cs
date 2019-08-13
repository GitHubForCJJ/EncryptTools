using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTools.Comon
{
    public static  class StringExtension
    {
        public static bool Tobool(this object data)
        {
            bool res = false;
            try
            {
                res = Convert.ToBoolean(data);
            }
            catch
            {

            }
            return res;
        }
        public static int Toint(this object data)
        {
            int res = 0;
            try
            {
                res = Convert.ToInt32(data);
            }
            catch
            {

            }
            return res;
        }

    }
}
