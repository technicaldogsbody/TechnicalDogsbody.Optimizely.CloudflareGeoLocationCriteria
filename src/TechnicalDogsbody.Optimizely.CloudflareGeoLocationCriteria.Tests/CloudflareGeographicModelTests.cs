namespace TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria.Tests;

using Xunit;

public class CloudflareGeographicModelTests
{
    [Fact]
    public void Copy_ReturnsShallowCopy_WithIdenticalProperties()
    {
        var model = new CloudflareGeographicModel { CountryCode = "US" };

        var copy = model.Copy();

        Assert.NotSame(model, copy);
        Assert.Equal(model.CountryCode, (copy as CloudflareGeographicModel)?.CountryCode);
    }

    [Fact]
    public void Copy_DoesNotMutateOriginal_WhenCopyIsModified()
    {
        var model = new CloudflareGeographicModel { CountryCode = "US" };

        var copy = model.Copy();
        ((copy as CloudflareGeographicModel)!).CountryCode = "GB";

        Assert.Equal("US", model.CountryCode);
    }
}
