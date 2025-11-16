using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensaoDeString;

public static class StringExtension
{
    public static string ReverseString(this string str)
    {
        char[] item = str.ToCharArray();
        Array.Reverse(item);
        return new string(item);
    }
}