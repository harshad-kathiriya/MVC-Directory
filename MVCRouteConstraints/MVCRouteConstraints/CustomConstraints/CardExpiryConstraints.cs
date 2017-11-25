using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVCRouteConstraints.CustomConstraints
{
    public class CardExpiryConstraints : IRouteConstraint
    {
        string expiryDateFormat { get; set; }
        public CardExpiryConstraints(string ExpiryDateFormat)
        {
            this.expiryDateFormat = ExpiryDateFormat;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            DateTime dateTime;

            return DateTime.TryParseExact(
                Convert.ToString(values[parameterName]), 
                expiryDateFormat, 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, 
                out dateTime);
        }
    }
}