[![Nuget](https://img.shields.io/badge/nuget-v12.0.2-blue.svg)](https://www.nuget.org/packages/KenticoURLRedirection/)
# Kentico 12 URL Redirection Module
This module adds an interface in the CMS to allow a user to edit and manage URL Redirects in one place. The module supports multi-site instances and multi-culture sites (more details below). The latest version of this module is Version 12.0.2. The source code for this module is included in this repo if you wish to clone and modify it anyway you see fit. 

## Compatibility

 - .NET 4.6.1 or greater
 - Kentico Version 12.0.52 or greater
 - Compatible with all development styles of Kentico (MVC, Portal Engine, ASPX, etc.)

## Installation Instructions

Install the latest version of the Kentico URL Redirection [nuget package](https://www.nuget.org/packages/KenticoURLRedirection/)
`Install-Package KenticoUrlRedirection`

After installation, check the event log of the site and you should see a line like this:
![Module Installed Successfully](https://github.com/silvertech/KenticoURLRedirectionModule/blob/master/Readme%20Assets/moduleintalled-eventlog.png?raw=true)

To update the module to a more recent version, simply update the NuGet package.

## LIMITATIONS/REQUIRED SETUP
**IMPORTANT -** Please note that there are a few limitations with this module that require that your site be configured a certain way to work properly. Look below and take note of the required setup for your configuration.

**Single Site and Single Culture**
If your site is a single domain and single culture, you **must** specify the default visitor culture as the default culture of your site. If this is not set, the redirects will not work. To do this, follow these steps:

 1. Go to Applications>Configuration>Sites
 2. Edit the site
 3. Select the Culture of your site from the "Visitor Culture" drop down (in this example it is English)
 ![Primary Culture Dropdown](https://raw.githubusercontent.com/silvertech/KenticoURLRedirectionModule/master/Readme%20Assets/singlesite-singleculture.png)
 4. Click **Save**

**Multiple Sites and Single Culture**
If your site is a single culture but multiple domains, then the above steps for "Single Site and Single Culture" must be done on **each** of your Kentico sites in your CMS.

**Single Site and Multiple Cultures - Domain Aliases**
If your site is a single site but uses different domain aliases for each culture then you must specify which language each domain:

 1. Follow the steps for "Single Site and Single Culture" and set the main domain's culture to your primary culture
 2. Click on **Domain aliases** in the left hand tabs
 3. For each domain aliases, select the appropriate culture. In this example, **de.** is German and **fr.** is French
![Multiple Cultures Domain Aliases](https://github.com/silvertech/KenticoURLRedirectionModule/blob/master/Readme%20Assets/singlesite-domainaliases.png?raw=true)

**Multiple Sites and Multiple Cultures - Domain Aliases**
If you have multiple sites and unique domain aliases for the different culture on each site, then the above for "Single Site and Multiple Cultures - Domain Aliases" must be done on **each** of yoru Kentico sites in your CMS.

**Single Site and Multiple Cultures - Language Aliases**
If you have a single site that has multiple cultures but use language aliases as opposed to unique domain aliases, then no additional setup is needed. The main site domain will be used in conjunction with the configured language aliases to determine if a redirect applies to the site/culture.

**Multiple Sites and Multiple Cultures - Language Aliases**
Same as "Single Site and Multiple Cultures - Language Aliases"

**Multiple Cultures - Language Aliases AND Domain Aliases**
While it is technically possible to combine both language aliases and domain aliases on a site, this is not an officially supported use case of multiple cultures by Kentico and therefore is not supported by this module.

## Module Overview
The Kentico URL Redirection module contains one class, **Redirection Table**, that is not customizable. The class' fields are as follows:

| Field Name  | Data Type | Form Control | Descrpiton |
|--|--|--|--|
| RedirectionTableID | Integer | N/A (Not Editable) | Unique ID of the redirection item |
| RedirectionOriginalURL | Text (2000) | Text Box | URL Alias that will be redirected. Ex: **/original-url** |
| RedirectionTargetURL | Text (2000) | URL Selector | Internal alias or External URL that the Original URL field will be redirected to. Ex: **/target-url** Ex:**https://www.external-domain.com** |
| RedirectionDescription | Long Text | Text Area | A field that allows a content editor to describe a redirect or enter the purpose of a redirect |
| RedirectionSiteID | Integer | Site Selector | Drop down list that allows a user to specify which site the redirect is for. Default is the current site the user is on. |
| RedirectionType | Text (3) | Drop Down List | Allows the user to specify if the redirect is a 301 or 302 redirect. |
| RedirectionCultures | Text (4000) | Multiple Choice | Allows the user to specify which cultures the redirection should be enabled for. The default selected will be the Cultures available for the current site, although all cultures currently assigned to the site will be shown. |

The module can be accessed by going to **Applications>Custom>URL Redirection**.

## License
This project uses a standard MIT license which can be found [here](https://github.com/silvertech/KenticoURLRedirectionModule/blob/master/LICENSE).

## Contribution
Contributions to this module are welcome. All the source files for this module are included and you just need to add the project to a Kentico Web Application solution and you can start editing anything you like. Submit a pull request to the repo with your changes and we will review and provide feedback. We will also update the NuGet package to a new version once we approve your changes.

## Support
Any bugs can be listed as issues here in GitHub or can be sent to our email alerts@silvertech.com. We will respond as soon as we can.
