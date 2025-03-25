using System.Security.Claims;

namespace api.Extensions
{
    public static class ClaimsExtensions
    {
        public static string? GetUsername(this ClaimsPrincipal user)
            {
            if (user?.Claims == null) return null; // Ensure user is not null

            return user.FindFirst(ClaimTypes.Name)?.Value;

            // return user.FindFirst(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"))?.Value;
                // .SingleOrDefault(x => x.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"))
                // ?.Value; // Use ?. to avoid NullReferenceException
        }
    }
}