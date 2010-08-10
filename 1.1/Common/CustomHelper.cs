using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class CustomHelper
    {
        public static string GetGuidString(Guid ID)
        {
            return ID.ToString().Replace("-", "");
        }
    }
}
