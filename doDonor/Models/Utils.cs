using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doDonor.Models
{
    internal static class Utils
    {
        public static string NullIfEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Pastikan semua data telah terisi.");
                return null;
            }
            return value;
        }

        public static int PositiveOnly(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Masukkan data numeris dengan benar.");
            }
            return value;
        }
    }
}
