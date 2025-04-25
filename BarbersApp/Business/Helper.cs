using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Business
{
    public static class Helper
    {
        public static bool IsNumeric(string input) => input.All(char.IsDigit);

        public static bool IsNotEmpty(params string[] fields) => fields.All(f => !string.IsNullOrWhiteSpace(f));
    }
}
