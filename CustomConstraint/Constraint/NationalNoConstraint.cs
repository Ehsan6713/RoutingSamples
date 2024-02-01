using CustomConstraint.Validations;

namespace CustomConstraint.Constraint
{
    public class NationalNoConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (values[routeKey] == null)
                return false;
            var val = values[routeKey]?.ToString() ?? "";
            if (!val.IsNationalNumberValid())
                return false;
            return true;
        }
    }
}
