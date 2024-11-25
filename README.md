
# TechnicalDogsbody's Optimizely CloudflareGeoLocationCriteria

**A simple integration to use Cloudflare's geolocation headers with Optimizely CMS visitor groups.**

---

## **Overview**

This library extends Optimizely CMS by adding a visitor group criterion based on Cloudflare's geolocation headers. By leveraging Cloudflare's `CF-IPCountry` header, you can create location-based personalisation without requiring additional IP lookup services.

---

## **Features**

- **Easy Integration**: Adds a plug-and-play visitor group criterion.  
- **Cloudflare Native**: Utilises Cloudflare's `CF-IPCountry` header.  
- **Performance**: No external API calls—geolocation data is sent directly by Cloudflare.  

---

## **Installation**

Install via NuGet:

```
Install-Package TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria
```

---

## **Usage**

1. **Enable Geolocation in Cloudflare**  
   Make sure Cloudflare's geolocation service is enabled for your account.

2. **Add to Visitor Groups**  
   - Go to the Optimizely Admin interface.  
   - Create or edit a visitor group.  
   - Add the **Cloudflare GeoLocation** criterion.  
   - Select the countries where the criterion should apply.  

---

## **Requirements**

- **Optimizely CMS**: Version 12 or later.  
- **.NET Version**: .NET 6 or later.  
- **Cloudflare Account**: Your site must be proxied via Cloudflare with the `CF-IPCountry` header enabled.  

---

## **License**

This project is licensed under the **GNU General Public License v3.0 (GPL-3.0)**.  
You may redistribute and/or modify this software under the terms of the GPL-3.0 license.  
For more details, see the [LICENSE](LICENSE) file in the repository.

---

## **Contributing**

Contributions are welcome!  

1. Fork the repository.  
2. Create a new branch (`feature/your-feature-name`).  
3. Commit your changes.  
4. Open a pull request.  

---

## **Support**

If you encounter any issues, please open an issue in the [GitHub repository](https://github.com/technicaldogsbody/TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria/issues).
