using System.Security.Principal;
using EPiServer.Personalization.VisitorGroups;
using Microsoft.AspNetCore.Http;

namespace TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria;

[VisitorGroupCriterion(
    Category = "Time and Place Criteria",
    DisplayName = "Cloudflare Geographic Location",
    Description = "Match the country of the visitor with a specified geographic country.")]
public class CloudflareGeographicLocation : CriterionBase<CloudflareGeographicModel>
{
    public override bool IsMatch(IPrincipal principal, HttpContext httpContext)
    {
        var geoLocationHeader = httpContext?.Request?.Headers["CF-IPCountry"];

        return Model.CountryCode?.Equals(geoLocationHeader, StringComparison.InvariantCultureIgnoreCase) == true;

    }
}
