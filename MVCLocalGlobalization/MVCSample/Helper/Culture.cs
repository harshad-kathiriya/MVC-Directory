using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace MVCLocalGlobalization.Helper
{
    // It should be static class
    public static class Culture
    {
        // Implement culture thread here
        public static string CurrentCulture
        {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "hi-IN")
                {
                    return "hi-IN";
                }
                else
                {
                    return "en-US";
                }
            }
            set
            {
                if (value == "hi-IN")
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("hi-IN");
                }

                else
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                }

                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;

            }
        }
    }
}