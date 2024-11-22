using EPiServer.Personalization.VisitorGroups;
using Microsoft.AspNetCore.Components.Server.Circuits;

namespace TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria.Tests;

using CloudflareGeoLocationCriteria;
using Microsoft.AspNetCore.Http;
using Xunit;

public class CloudflareGeographicLocationTests
{
    [Fact]
    public void IsMatch_ReturnsTrue_WhenCountryCodeMatchesHeader()
    {
        var criterion = new CloudflareGeographicLocation();
        criterion.Initialize(new VisitorGroupCriterion{
            Model = new CloudflareGeographicModel
            {
                CountryCode = "US"
            }
        });

        var context = new DefaultHttpContext();
        context.Request.Headers["CF-IPCountry"] = "US";

        var result = criterion.IsMatch(null, context);

        Assert.True(result);
    }

    [Fact]
    public void IsMatch_ReturnsFalse_WhenCountryCodeDoesNotMatchHeader()
    {
        var criterion = new CloudflareGeographicLocation();
        criterion.Initialize(new VisitorGroupCriterion
        {
            Model = new CloudflareGeographicModel
            {
                CountryCode = "US"
            }
        });

        var context = new DefaultHttpContext();
        context.Request.Headers["CF-IPCountry"] = "GB";

        var result = criterion.IsMatch(null, context);

        Assert.False(result);
    }

    [Fact]
    public void IsMatch_ReturnsFalse_WhenHeaderIsMissing()
    {
        var criterion = new CloudflareGeographicLocation();
        criterion.Initialize(new VisitorGroupCriterion
        {
            Model = new CloudflareGeographicModel
            {
                CountryCode = "US"
            }
        });

        var context = new DefaultHttpContext(); // No headers added
        var result = criterion.IsMatch(null, context);

        Assert.False(result);
    }

    [Fact]
    public void IsMatch_ReturnsFalse_WhenCountryCodeIsNull()
    {
        var criterion = new CloudflareGeographicLocation();
        criterion.Initialize(new VisitorGroupCriterion
        {
            Model = new CloudflareGeographicModel
            {
                CountryCode = null
            }
        });

        var context = new DefaultHttpContext();
        context.Request.Headers["CF-IPCountry"] = "US";

        var result = criterion.IsMatch(null, context);

        Assert.False(result);
    }

    [Fact]
    public void IsMatch_ReturnsFalse_WhenHttpContextIsNull()
    {
        var criterion = new CloudflareGeographicLocation();
        criterion.Initialize(new VisitorGroupCriterion
        {
            Model = new CloudflareGeographicModel
            {
                CountryCode = "US"
            }
        });

        var result = criterion.IsMatch(null, null);

        Assert.False(result);
    }
}
