# BlueRain.ID4i.Api.OrganizationsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserRoles**](OrganizationsApi.md#adduserroles) | **POST** /api/v1/organizations/{organizationId}/users/{username}/roles | Add role(s) to user
[**CreateOrganization**](OrganizationsApi.md#createorganization) | **POST** /api/v1/organizations | Create organization
[**DeleteOrganization**](OrganizationsApi.md#deleteorganization) | **DELETE** /api/v1/organizations/{organizationId} | Delete organization
[**DeleteOrganizationBillingAddress**](OrganizationsApi.md#deleteorganizationbillingaddress) | **DELETE** /api/v1/organizations/{organizationId}/addresses/billing | Remove billing address
[**DeleteOrganizationLogo**](OrganizationsApi.md#deleteorganizationlogo) | **DELETE** /api/v1/organizations/{organizationId}/logo | Delete organization logo
[**FindOrganization**](OrganizationsApi.md#findorganization) | **GET** /api/v1/organizations/{organizationId} | Find organization by id
[**FindOrganizationAddress**](OrganizationsApi.md#findorganizationaddress) | **GET** /api/v1/organizations/{organizationId}/addresses/default | Retrieve address
[**FindOrganizationBillingAddress**](OrganizationsApi.md#findorganizationbillingaddress) | **GET** /api/v1/organizations/{organizationId}/addresses/billing | Retrieve billing address
[**GetAllCollectionsOfOrganization**](OrganizationsApi.md#getallcollectionsoforganization) | **GET** /api/v1/organizations/{organizationId}/collections | Get collections of organization
[**GetAllOrganizationRoles**](OrganizationsApi.md#getallorganizationroles) | **GET** /api/v1/organizations/{organizationId}/roles | List users and their roles
[**GetOrganizationsOfUser**](OrganizationsApi.md#getorganizationsofuser) | **GET** /api/v1/user/organizations | Retrieve organizations of user
[**GetUserRoles**](OrganizationsApi.md#getuserroles) | **GET** /api/v1/organizations/{organizationId}/users/{username}/roles | Get user roles by username
[**GetUsersOfOrganization**](OrganizationsApi.md#getusersoforganization) | **GET** /api/v1/organizations/{organizationId}/users | Find users in organization
[**InviteUsers**](OrganizationsApi.md#inviteusers) | **POST** /api/v1/organizations/{organizationId}/users/invite | Invite Users
[**ListCountries**](OrganizationsApi.md#listcountries) | **GET** /api/v1/countries | List countries
[**RemoveUserRoles**](OrganizationsApi.md#removeuserroles) | **DELETE** /api/v1/organizations/{organizationId}/users/{username}/roles | Remove role(s) from user
[**SetOrganizationLogo**](OrganizationsApi.md#setorganizationlogo) | **POST** /api/v1/organizations/{organizationId}/logo | Update organization logo
[**UpdateOrganization**](OrganizationsApi.md#updateorganization) | **PUT** /api/v1/organizations/{organizationId} | Update organization
[**UpdateOrganizationAddress**](OrganizationsApi.md#updateorganizationaddress) | **PUT** /api/v1/organizations/{organizationId}/addresses/default | Store address
[**UpdateOrganizationBillingAddress**](OrganizationsApi.md#updateorganizationbillingaddress) | **PUT** /api/v1/organizations/{organizationId}/addresses/billing | Store billing address


<a name="adduserroles"></a>
# **AddUserRoles**
> void AddUserRoles (long? organizationId, string username, ChangeRoleRequest changeRoleRequest)

Add role(s) to user

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddUserRolesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var username = username_example;  // string | username
            var changeRoleRequest = new ChangeRoleRequest(); // ChangeRoleRequest | changeRoleRequest

            try
            {
                // Add role(s) to user
                apiInstance.AddUserRoles(organizationId, username, changeRoleRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.AddUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **username** | **string**| username | 
 **changeRoleRequest** | [**ChangeRoleRequest**](ChangeRoleRequest.md)| changeRoleRequest | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorganization"></a>
# **CreateOrganization**
> Organization CreateOrganization (Organization organization)

Create organization

Creating a new organization.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organization = new Organization(); // Organization | Organization to be created

            try
            {
                // Create organization
                Organization result = apiInstance.CreateOrganization(organization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.CreateOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organization** | [**Organization**](Organization.md)| Organization to be created | 

### Return type

[**Organization**](Organization.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorganization"></a>
# **DeleteOrganization**
> void DeleteOrganization (long? organizationId)

Delete organization

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization to be deleted.

            try
            {
                // Delete organization
                apiInstance.DeleteOrganization(organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization to be deleted. | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorganizationbillingaddress"></a>
# **DeleteOrganizationBillingAddress**
> void DeleteOrganizationBillingAddress (long? organizationId)

Remove billing address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteOrganizationBillingAddressExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId

            try
            {
                // Remove billing address
                apiInstance.DeleteOrganizationBillingAddress(organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationBillingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorganizationlogo"></a>
# **DeleteOrganizationLogo**
> void DeleteOrganizationLogo (long? organizationId)

Delete organization logo

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteOrganizationLogoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization where the logo should be deleted.

            try
            {
                // Delete organization logo
                apiInstance.DeleteOrganizationLogo(organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization where the logo should be deleted. | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findorganization"></a>
# **FindOrganization**
> Organization FindOrganization (long? organizationId)

Find organization by id

Returns a single organization.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization to be retrieved.

            try
            {
                // Find organization by id
                Organization result = apiInstance.FindOrganization(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FindOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization to be retrieved. | 

### Return type

[**Organization**](Organization.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findorganizationaddress"></a>
# **FindOrganizationAddress**
> OrganizationAddress FindOrganizationAddress (long? organizationId)

Retrieve address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindOrganizationAddressExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId

            try
            {
                // Retrieve address
                OrganizationAddress result = apiInstance.FindOrganizationAddress(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FindOrganizationAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 

### Return type

[**OrganizationAddress**](OrganizationAddress.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findorganizationbillingaddress"></a>
# **FindOrganizationBillingAddress**
> OrganizationAddress FindOrganizationBillingAddress (long? organizationId)

Retrieve billing address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindOrganizationBillingAddressExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId

            try
            {
                // Retrieve billing address
                OrganizationAddress result = apiInstance.FindOrganizationBillingAddress(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FindOrganizationBillingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 

### Return type

[**OrganizationAddress**](OrganizationAddress.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcollectionsoforganization"></a>
# **GetAllCollectionsOfOrganization**
> PaginatedGuidCollection GetAllCollectionsOfOrganization (long? organizationId, int? offset = null, int? limit = null, string type = null, string label = null, string labelPrefix = null)

Get collections of organization

Retrieving all collections of an organization in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetAllCollectionsOfOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 
            var type = type_example;  // string | Filter by this type (optional) 
            var label = label_example;  // string | Filter by this label (optional) 
            var labelPrefix = labelPrefix_example;  // string | Filter by this label prefix (optional) 

            try
            {
                // Get collections of organization
                PaginatedGuidCollection result = apiInstance.GetAllCollectionsOfOrganization(organizationId, offset, limit, type, label, labelPrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetAllCollectionsOfOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 
 **type** | **string**| Filter by this type | [optional] 
 **label** | **string**| Filter by this label | [optional] 
 **labelPrefix** | **string**| Filter by this label prefix | [optional] 

### Return type

[**PaginatedGuidCollection**](PaginatedGuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallorganizationroles"></a>
# **GetAllOrganizationRoles**
> PaginatedUserRolesResponse GetAllOrganizationRoles (long? organizationId, int? offset = null, int? limit = null)

List users and their roles

Listing users and their roles in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetAllOrganizationRolesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List users and their roles
                PaginatedUserRolesResponse result = apiInstance.GetAllOrganizationRoles(organizationId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetAllOrganizationRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedUserRolesResponse**](PaginatedUserRolesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationsofuser"></a>
# **GetOrganizationsOfUser**
> PaginatedOrganizationResponse GetOrganizationsOfUser (string role = null, int? offset = null, int? limit = null)

Retrieve organizations of user

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetOrganizationsOfUserExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var role = role_example;  // string | role (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Retrieve organizations of user
                PaginatedOrganizationResponse result = apiInstance.GetOrganizationsOfUser(role, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationsOfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **role** | **string**| role | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOrganizationResponse**](PaginatedOrganizationResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserroles"></a>
# **GetUserRoles**
> PaginatedStringResponse GetUserRoles (long? organizationId, string username, int? offset = null, int? limit = null)

Get user roles by username

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetUserRolesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var username = username_example;  // string | username
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Get user roles by username
                PaginatedStringResponse result = apiInstance.GetUserRoles(organizationId, username, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **username** | **string**| username | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedStringResponse**](PaginatedStringResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersoforganization"></a>
# **GetUsersOfOrganization**
> PaginatedUserPresentationResponse GetUsersOfOrganization (long? organizationId, int? offset = null, int? limit = null)

Find users in organization

Finding users in the specified organization in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetUsersOfOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Find users in organization
                PaginatedUserPresentationResponse result = apiInstance.GetUsersOfOrganization(organizationId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetUsersOfOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedUserPresentationResponse**](PaginatedUserPresentationResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteusers"></a>
# **InviteUsers**
> void InviteUsers (long? organizationId, OrganizationUserInvitationListRequest invitationList)

Invite Users

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class InviteUsersExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var invitationList = new OrganizationUserInvitationListRequest(); // OrganizationUserInvitationListRequest | invitationList

            try
            {
                // Invite Users
                apiInstance.InviteUsers(organizationId, invitationList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.InviteUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **invitationList** | [**OrganizationUserInvitationListRequest**](OrganizationUserInvitationListRequest.md)| invitationList | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcountries"></a>
# **ListCountries**
> PaginatedCountryResponse ListCountries (int? offset = null, int? limit = null)

List countries

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListCountriesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List countries
                PaginatedCountryResponse result = apiInstance.ListCountries(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ListCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedCountryResponse**](PaginatedCountryResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserroles"></a>
# **RemoveUserRoles**
> void RemoveUserRoles (long? organizationId, string username, ChangeRoleRequest changeRoleRequest)

Remove role(s) from user

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveUserRolesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var username = username_example;  // string | username
            var changeRoleRequest = new ChangeRoleRequest(); // ChangeRoleRequest | changeRoleRequest

            try
            {
                // Remove role(s) from user
                apiInstance.RemoveUserRoles(organizationId, username, changeRoleRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.RemoveUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **username** | **string**| username | 
 **changeRoleRequest** | [**ChangeRoleRequest**](ChangeRoleRequest.md)| changeRoleRequest | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setorganizationlogo"></a>
# **SetOrganizationLogo**
> PublicImagePresentation SetOrganizationLogo (long? organizationId, System.IO.Stream file)

Update organization logo

Updating an organization logo using a multipart file upload.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class SetOrganizationLogoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization where the logo should be updated.
            var file = new System.IO.Stream(); // System.IO.Stream | An image containing the new logo.

            try
            {
                // Update organization logo
                PublicImagePresentation result = apiInstance.SetOrganizationLogo(organizationId, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.SetOrganizationLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization where the logo should be updated. | 
 **file** | **System.IO.Stream**| An image containing the new logo. | 

### Return type

[**PublicImagePresentation**](PublicImagePresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorganization"></a>
# **UpdateOrganization**
> Organization UpdateOrganization (long? organizationId, Organization organization)

Update organization

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization to be updated.
            var organization = new Organization(); // Organization | Updated organization object

            try
            {
                // Update organization
                Organization result = apiInstance.UpdateOrganization(organizationId, organization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization to be updated. | 
 **organization** | [**Organization**](Organization.md)| Updated organization object | 

### Return type

[**Organization**](Organization.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorganizationaddress"></a>
# **UpdateOrganizationAddress**
> OrganizationAddress UpdateOrganizationAddress (long? organizationId, OrganizationAddress addressResource)

Store address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateOrganizationAddressExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var addressResource = new OrganizationAddress(); // OrganizationAddress | addressResource

            try
            {
                // Store address
                OrganizationAddress result = apiInstance.UpdateOrganizationAddress(organizationId, addressResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganizationAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **addressResource** | [**OrganizationAddress**](OrganizationAddress.md)| addressResource | 

### Return type

[**OrganizationAddress**](OrganizationAddress.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorganizationbillingaddress"></a>
# **UpdateOrganizationBillingAddress**
> OrganizationAddress UpdateOrganizationBillingAddress (long? organizationId, OrganizationAddress addressResource)

Store billing address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateOrganizationBillingAddressExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var addressResource = new OrganizationAddress(); // OrganizationAddress | addressResource

            try
            {
                // Store billing address
                OrganizationAddress result = apiInstance.UpdateOrganizationBillingAddress(organizationId, addressResource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganizationBillingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **addressResource** | [**OrganizationAddress**](OrganizationAddress.md)| addressResource | 

### Return type

[**OrganizationAddress**](OrganizationAddress.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

