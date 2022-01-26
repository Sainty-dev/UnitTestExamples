using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UnitTestExamples.ViewModels
{
    public class MainPageViewModel 
    {
        public MainPageViewModel()
        {
           var Title = "Main Page";
        }

        private const string PhoneRegex = "^[0-9+]*$";

        public bool IsValidPhoneNumber(string input)
        {
            var regeItem = new Regex(PhoneRegex);
            bool IsMatchRes = false;
            if (string.IsNullOrWhiteSpace(input))
            {
                IsMatchRes = false;
            }
            else if (input.Length < 3)
            {
                IsMatchRes = false;
            }


            else if (regeItem.IsMatch(input))
            {
                IsMatchRes = true;
            }
            else
            {
                IsMatchRes = false;
            }

            return IsMatchRes;
        }
    }
}
