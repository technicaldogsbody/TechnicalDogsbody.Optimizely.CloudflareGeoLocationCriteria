
### TechnicalDogsbody's Optimizely CloudflareGeoLocationCriteria

A lightweight integration for Optimizely CMS that adds support for Cloudflare's geolocation headers in visitor groups. This package simplifies creating personalised experiences based on visitors' geographical location.

---

### **Features**

- Adds a new visitor group criterion for geolocation using Cloudflare headers.
- Supports Cloudflare's `CF-IPCountry` header.
- Seamless integration with Optimizely CMS.

---

### **Getting Started**

1. **Install the package**:  
   Run the following command in your package manager console:  
   ```
   Install-Package TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria
   ```

2. **Configure Cloudflare**:  
   Ensure that your Cloudflare account is set to send the `CF-IPCountry` header.

3. **Add the Criterion to Visitor Groups**:  
   - Navigate to the Optimizely Admin interface.
   - Add the **Cloudflare GeoLocation** criterion to a visitor group.
   - Configure the allowed countries as per your requirements.

---

### **Prerequisites**

- Optimizely CMS 12
- .NET 8.0+
- A site hosted on Optimizely DXP or behind Cloudflare with geolocation headers enabled.

---

### **Documentation**

Visit the [GitHub repository](https://github.com/technicaldogsbody/TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria) for detailed usage instructions and examples.

---

### **License**

This package is licensed under the **GNU General Public License v3.0 (GPL-3.0)**. For more information, visit the [GitHub repository](https://github.com/technicaldogsbody/TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria).
