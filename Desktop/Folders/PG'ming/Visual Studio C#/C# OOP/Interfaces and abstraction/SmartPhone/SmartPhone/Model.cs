using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SmartPhone
{
    public class Model : SmartPhone
    {
        public string Browse(string URL)
        {
            Match ValidateURL = Regex.Match(URL, @"[0-9]");
            if (ValidateURL.Success)
            {
                return "Invalid URL!";
            }
            return $"Browsing: {URL}!";
        }

        public string Call(string number)
        {
            Match ValidateNumber = Regex.Match(number, @"^[0-9]*$");
            if (!ValidateNumber.Success)
            {
               return "Invalid number!";
            }
            return $"Calling... {number}";
        }
    }
}
