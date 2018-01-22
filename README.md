# DE.ID4i - the C# library for the ID4i API

HTTP API Documentation for ID4i

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 0.1.3-SNAPSHOT
- SDK version: 1.0.0
- Build date: 2018-01-22T11:48:41.140Z
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen
    For more information, please visit [http://bluerain.de](http://bluerain.de)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var organizationId = 789;  // long? | organizationId
            var username = username_example;  // string | username
            var changeRoleRequest = new ChangeRoleRequest(); // ChangeRoleRequest | changeRoleRequest
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add role(s) to user
                ApiError result = apiInstance.AddUserRoles(organizationId, username, changeRoleRequest, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AddUserRoles: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://backend.id4i.de*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**AddUserRoles**](docs/AccountsApi.md#adduserroles) | **POST** /api/v1/organizations/{organizationId}/users/{username}/roles | Add role(s) to user
*AccountsApi* | [**CompleteRegistration**](docs/AccountsApi.md#completeregistration) | **PUT** /account/registration | Complete registration
*AccountsApi* | [**FindUserByUsername**](docs/AccountsApi.md#finduserbyusername) | **GET** /api/v1/users/{username} | Find by username
*AccountsApi* | [**FindUsers**](docs/AccountsApi.md#findusers) | **GET** /api/v1/users | Find users
*AccountsApi* | [**GetAllOrganizationRoles**](docs/AccountsApi.md#getallorganizationroles) | **GET** /api/v1/organizations/{organizationId}/roles | List users and their roles
*AccountsApi* | [**GetOrganizationsOfUser**](docs/AccountsApi.md#getorganizationsofuser) | **GET** /api/v1/user/organizations | Retrieve organizations of user
*AccountsApi* | [**GetUserRoles**](docs/AccountsApi.md#getuserroles) | **GET** /api/v1/organizations/{organizationId}/users/{username}/roles | Get user roles by username
*AccountsApi* | [**GetUsersOfOrganization**](docs/AccountsApi.md#getusersoforganization) | **GET** /api/v1/organizations/{organizationId}/users | Find users in organization
*AccountsApi* | [**InviteUsers**](docs/AccountsApi.md#inviteusers) | **POST** /api/v1/organizations/{organizationId}/users/invite | Invite Users
*AccountsApi* | [**ListAllRoles**](docs/AccountsApi.md#listallroles) | **GET** /api/v1/roles | List roles
*AccountsApi* | [**Login**](docs/AccountsApi.md#login) | **POST** /login | 
*AccountsApi* | [**RegisterUser**](docs/AccountsApi.md#registeruser) | **POST** /account/registration | Register user
*AccountsApi* | [**RemoveUserRoles**](docs/AccountsApi.md#removeuserroles) | **DELETE** /api/v1/organizations/{organizationId}/users/{username}/roles | Remove role(s) from user
*AccountsApi* | [**RequestPasswordReset**](docs/AccountsApi.md#requestpasswordreset) | **POST** /account/password | Request password reset
*AccountsApi* | [**VerifyPasswordReset**](docs/AccountsApi.md#verifypasswordreset) | **PUT** /account/password | Verify password reset
*AccountsApi* | [**VerifyUserRegistration**](docs/AccountsApi.md#verifyuserregistration) | **POST** /account/verification | Verify registration
*AliasApi* | [**AddGuidAlias**](docs/AliasApi.md#addguidalias) | **POST** /api/v1/guids/{id4n}/alias/{aliasType} | Add alias for GUIDs
*AliasApi* | [**AddGuidAlias1**](docs/AliasApi.md#addguidalias1) | **DELETE** /api/v1/guids/{id4n}/alias/{aliasType} | Remove aliases from GUIDs
*AliasApi* | [**GetGuidAliasTypes**](docs/AliasApi.md#getguidaliastypes) | **GET** /api/v1/search/guids/aliases/types | List all supported alias types
*AliasApi* | [**GetGuidAliases**](docs/AliasApi.md#getguidaliases) | **GET** /api/v1/guids/{id4n}/alias | Get all aliases for the given GUID
*AliasApi* | [**SearchByAlias**](docs/AliasApi.md#searchbyalias) | **GET** /api/v1/search/guids | Search for GUIDs by alias
*ApiKeysApi* | [**AddApiKeyPrivilege**](docs/ApiKeysApi.md#addapikeyprivilege) | **POST** /api/v1/apikeys/{key}/privileges | Add privilege
*ApiKeysApi* | [**AddApiKeyPrivilegeForId4ns**](docs/ApiKeysApi.md#addapikeyprivilegeforid4ns) | **POST** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | Add ID4ns of a privilege
*ApiKeysApi* | [**CreateNewApiKey**](docs/ApiKeysApi.md#createnewapikey) | **POST** /api/v1/apikeys | Create API key
*ApiKeysApi* | [**DeleteApiKey**](docs/ApiKeysApi.md#deleteapikey) | **DELETE** /api/v1/apikeys/{key} | Delete API key
*ApiKeysApi* | [**GetApiKey**](docs/ApiKeysApi.md#getapikey) | **GET** /api/v1/apikeys/{key} | Show API key
*ApiKeysApi* | [**ListAllApiKeyPrivileges**](docs/ApiKeysApi.md#listallapikeyprivileges) | **GET** /api/v1/apikeys/privileges | List all privileges
*ApiKeysApi* | [**ListAllApiKeysOfOrganization**](docs/ApiKeysApi.md#listallapikeysoforganization) | **GET** /api/v1/apikeys | Find API key by organization
*ApiKeysApi* | [**ListApiKeyPrivileges**](docs/ApiKeysApi.md#listapikeyprivileges) | **GET** /api/v1/apikeys/{key}/privileges | List privileges
*ApiKeysApi* | [**ListId4ns**](docs/ApiKeysApi.md#listid4ns) | **GET** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | ID4ns of a privilege
*ApiKeysApi* | [**RemoveApiKeyPrivilege**](docs/ApiKeysApi.md#removeapikeyprivilege) | **DELETE** /api/v1/apikeys/{key}/privileges | Remove privilege
*ApiKeysApi* | [**RemoveApiKeyPrivilegeForId4ns**](docs/ApiKeysApi.md#removeapikeyprivilegeforid4ns) | **DELETE** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | Remove id4ns of a privilege
*ApiKeysApi* | [**UpdateApiKey**](docs/ApiKeysApi.md#updateapikey) | **PUT** /api/v1/apikeys/{key} | Update API keys
*CollectionsApi* | [**AddElementToCollection**](docs/CollectionsApi.md#addelementtocollection) | **PUT** /api/v1/collections/{id4n}/elements/{elementGuid} | Add element to collection
*CollectionsApi* | [**AddElementToLabelledCollection**](docs/CollectionsApi.md#addelementtolabelledcollection) | **PUT** /api/v1/collections/labelled/{collectionId4n}/elements/{elementGuid} | Add element to labelled collection
*CollectionsApi* | [**AddElementToLogisticCollection**](docs/CollectionsApi.md#addelementtologisticcollection) | **PUT** /api/v1/collections/logistic/{collectionId4n}/elements/{guid} | Add element to logistic collection
*CollectionsApi* | [**AddElementToRoutingCollection**](docs/CollectionsApi.md#addelementtoroutingcollection) | **PUT** /api/v1/collections/routing/{collectionId4n}/elements/{guid} | Add element to routing collection
*CollectionsApi* | [**AddElementsToCollection**](docs/CollectionsApi.md#addelementstocollection) | **PUT** /api/v1/collections/{id4n}/elements | Add elements to collection
*CollectionsApi* | [**AddElementsToLabelledCollection**](docs/CollectionsApi.md#addelementstolabelledcollection) | **PUT** /api/v1/collections/labelled/{collectionId4n}/elements | Add elements to labelled collection
*CollectionsApi* | [**AddElementsToLogisticCollection**](docs/CollectionsApi.md#addelementstologisticcollection) | **PUT** /api/v1/collections/logistic/{collectionId4n}/elements | Add elements to logistic collection
*CollectionsApi* | [**AddElementsToRoutingCollection**](docs/CollectionsApi.md#addelementstoroutingcollection) | **PUT** /api/v1/collections/routing/{collectionId4n}/elements | Add element to routing collection
*CollectionsApi* | [**CreateLabelledCollection**](docs/CollectionsApi.md#createlabelledcollection) | **POST** /api/v1/collections/labelled | Create labelled collection
*CollectionsApi* | [**CreateLogisticCollection**](docs/CollectionsApi.md#createlogisticcollection) | **POST** /api/v1/collections/logistic | Create logistic collection
*CollectionsApi* | [**CreateRoutingCollection**](docs/CollectionsApi.md#createroutingcollection) | **POST** /api/v1/collections/routing | Create routing collecton
*CollectionsApi* | [**DeleteCollection**](docs/CollectionsApi.md#deletecollection) | **DELETE** /api/v1/collections/{id4n} | Delete collection
*CollectionsApi* | [**DeleteLabelledCollection**](docs/CollectionsApi.md#deletelabelledcollection) | **DELETE** /api/v1/collections/labelled/{id4n} | Delete labelled collection
*CollectionsApi* | [**DeleteLogisticCollection**](docs/CollectionsApi.md#deletelogisticcollection) | **DELETE** /api/v1/collections/logistic/{id4n} | Delete logistic collection
*CollectionsApi* | [**DeleteRoutingCollection**](docs/CollectionsApi.md#deleteroutingcollection) | **DELETE** /api/v1/collections/routing/{id4n} | Delete routing collection
*CollectionsApi* | [**FindCollection**](docs/CollectionsApi.md#findcollection) | **GET** /api/v1/collections/{id4n} | Find collection
*CollectionsApi* | [**FindLabelledCollection**](docs/CollectionsApi.md#findlabelledcollection) | **GET** /api/v1/collections/labelled/{id4n} | Find labelled collection
*CollectionsApi* | [**FindLogisticCollection**](docs/CollectionsApi.md#findlogisticcollection) | **GET** /api/v1/collections/logistic/{id4n} | Find logistic collection
*CollectionsApi* | [**FindRoutingCollection**](docs/CollectionsApi.md#findroutingcollection) | **GET** /api/v1/collections/routing/{id4n} | Find routing collection
*CollectionsApi* | [**GetAllCollectionsOfOrganization**](docs/CollectionsApi.md#getallcollectionsoforganization) | **GET** /api/v1/organizations/{organizationId}/collections | Get collections of organization
*CollectionsApi* | [**ListElementsOfCollection**](docs/CollectionsApi.md#listelementsofcollection) | **GET** /api/v1/collections/{id4n}/elements | List contents of the collection
*CollectionsApi* | [**ListElementsOfLabelledCollection**](docs/CollectionsApi.md#listelementsoflabelledcollection) | **GET** /api/v1/collections/labelled/{id4n}/elements | List contents of the collection
*CollectionsApi* | [**ListElementsOfLogisticCollection**](docs/CollectionsApi.md#listelementsoflogisticcollection) | **GET** /api/v1/collections/logistic/{id4n}/elements | List contents of the collection
*CollectionsApi* | [**ListElementsOfRoutingCollection**](docs/CollectionsApi.md#listelementsofroutingcollection) | **GET** /api/v1/collections/routing/{id4n}/elements | List contents of the collection
*CollectionsApi* | [**RemoveElementFromCollection**](docs/CollectionsApi.md#removeelementfromcollection) | **DELETE** /api/v1/collections/{id4n}/elements/{elementGuid} | Remove element from collection
*CollectionsApi* | [**RemoveElementFromLabelledCollection**](docs/CollectionsApi.md#removeelementfromlabelledcollection) | **DELETE** /api/v1/collections/labelled/{collectionId4n}/elements/{elementGuid} | Remove element from labelled collection
*CollectionsApi* | [**RemoveElementFromLogisticCollection**](docs/CollectionsApi.md#removeelementfromlogisticcollection) | **DELETE** /api/v1/collections/logistic/{collectionId4n}/elements/{elementId4n} | Remove element from logistic collection
*CollectionsApi* | [**RemoveElementFromRoutingCollection**](docs/CollectionsApi.md#removeelementfromroutingcollection) | **DELETE** /api/v1/collections/routing/{collectionId4n}/elements/{guid} | Remove element from routing collection
*CollectionsApi* | [**RemoveElementsFromCollection**](docs/CollectionsApi.md#removeelementsfromcollection) | **DELETE** /api/v1/collections/{id4n}/elements | Remove elements from collection
*CollectionsApi* | [**RemoveElementsFromLabelledCollection**](docs/CollectionsApi.md#removeelementsfromlabelledcollection) | **DELETE** /api/v1/collections/labelled/{collectionId4n}/elements | Remove elements from labelled collection
*CollectionsApi* | [**RemoveElementsFromLogisticCollection**](docs/CollectionsApi.md#removeelementsfromlogisticcollection) | **DELETE** /api/v1/collections/logistic/{collectionId4n}/elements | Remove elements from logistic collection
*CollectionsApi* | [**RemoveElementsFromRoutingCollection**](docs/CollectionsApi.md#removeelementsfromroutingcollection) | **DELETE** /api/v1/collections/routing/{collectionId4n}/elements | Remove elements from routing collection
*CollectionsApi* | [**UpdateCollection**](docs/CollectionsApi.md#updatecollection) | **PUT** /api/v1/collections/{id4n} | Alter collection
*CollectionsApi* | [**UpdateLabelledCollection**](docs/CollectionsApi.md#updatelabelledcollection) | **PUT** /api/v1/collections/labelled/{id4n} | Rename labelled collection
*CollectionsApi* | [**UpdateLogisticCollection**](docs/CollectionsApi.md#updatelogisticcollection) | **PUT** /api/v1/collections/logistic/{id4n} | Update logistic collection
*CollectionsApi* | [**UpdateRoutingCollection**](docs/CollectionsApi.md#updateroutingcollection) | **PUT** /api/v1/collections/routing/{id4n} | Update routing collection
*GUIDsApi* | [**AddGuidAlias**](docs/GUIDsApi.md#addguidalias) | **POST** /api/v1/guids/{id4n}/alias/{aliasType} | Add alias for GUIDs
*GUIDsApi* | [**AddGuidAlias1**](docs/GUIDsApi.md#addguidalias1) | **DELETE** /api/v1/guids/{id4n}/alias/{aliasType} | Remove aliases from GUIDs
*GUIDsApi* | [**CreateGuid**](docs/GUIDsApi.md#createguid) | **POST** /api/v1/guids | Create GUID(s)
*GUIDsApi* | [**GetGuid**](docs/GUIDsApi.md#getguid) | **GET** /api/v1/guids/{id4n} | Retrieve GUID information
*GUIDsApi* | [**GetGuidAliases**](docs/GUIDsApi.md#getguidaliases) | **GET** /api/v1/guids/{id4n}/alias | Get all aliases for the given GUID
*GUIDsApi* | [**GetGuidsWithoutCollection**](docs/GUIDsApi.md#getguidswithoutcollection) | **GET** /api/v1/guids/withoutCollection | Retrieve GUIDs not in any collection
*GUIDsApi* | [**UpdateGuid**](docs/GUIDsApi.md#updateguid) | **PUT** /api/v1/guids/{id4n} | Change GUID information.
*ImagesApi* | [**ResolveImageUsingGET**](docs/ImagesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image
*MetaInformationApi* | [**ApplicationInfo**](docs/MetaInformationApi.md#applicationinfo) | **GET** /api/v1/info | Retrieve version information about ID4i
*MicrostorageApi* | [**Read**](docs/MicrostorageApi.md#read) | **GET** /api/v1/microstorage/{id4n}/{organization} | Read data from microstorage
*MicrostorageApi* | [**Write**](docs/MicrostorageApi.md#write) | **PUT** /api/v1/microstorage/{id4n}/{organization} | Write data to microstorage
*OrganizationsApi* | [**AddUserRoles**](docs/OrganizationsApi.md#adduserroles) | **POST** /api/v1/organizations/{organizationId}/users/{username}/roles | Add role(s) to user
*OrganizationsApi* | [**CreateOrganization**](docs/OrganizationsApi.md#createorganization) | **POST** /api/v1/organizations | Create organization
*OrganizationsApi* | [**DeleteOrganization**](docs/OrganizationsApi.md#deleteorganization) | **DELETE** /api/v1/organizations/{organizationId} | Delete organization
*OrganizationsApi* | [**DeleteOrganizationBillingAddress**](docs/OrganizationsApi.md#deleteorganizationbillingaddress) | **DELETE** /api/v1/organizations/{organizationId}/addresses/billing | Remove billing address
*OrganizationsApi* | [**DeleteOrganizationLogo**](docs/OrganizationsApi.md#deleteorganizationlogo) | **DELETE** /api/v1/organizations/{organizationId}/logo | Delete organization logo
*OrganizationsApi* | [**FindOrganization**](docs/OrganizationsApi.md#findorganization) | **GET** /api/v1/organizations/{organizationId} | Find organization by id
*OrganizationsApi* | [**FindOrganizationAddress**](docs/OrganizationsApi.md#findorganizationaddress) | **GET** /api/v1/organizations/{organizationId}/addresses/default | Retrieve address
*OrganizationsApi* | [**FindOrganizationBillingAddress**](docs/OrganizationsApi.md#findorganizationbillingaddress) | **GET** /api/v1/organizations/{organizationId}/addresses/billing | Retrieve billing address
*OrganizationsApi* | [**GetAllCollectionsOfOrganization**](docs/OrganizationsApi.md#getallcollectionsoforganization) | **GET** /api/v1/organizations/{organizationId}/collections | Get collections of organization
*OrganizationsApi* | [**GetAllOrganizationRoles**](docs/OrganizationsApi.md#getallorganizationroles) | **GET** /api/v1/organizations/{organizationId}/roles | List users and their roles
*OrganizationsApi* | [**GetOrganizationsOfUser**](docs/OrganizationsApi.md#getorganizationsofuser) | **GET** /api/v1/user/organizations | Retrieve organizations of user
*OrganizationsApi* | [**GetUserRoles**](docs/OrganizationsApi.md#getuserroles) | **GET** /api/v1/organizations/{organizationId}/users/{username}/roles | Get user roles by username
*OrganizationsApi* | [**GetUsersOfOrganization**](docs/OrganizationsApi.md#getusersoforganization) | **GET** /api/v1/organizations/{organizationId}/users | Find users in organization
*OrganizationsApi* | [**InviteUsers**](docs/OrganizationsApi.md#inviteusers) | **POST** /api/v1/organizations/{organizationId}/users/invite | Invite Users
*OrganizationsApi* | [**ListCountries**](docs/OrganizationsApi.md#listcountries) | **GET** /api/v1/countries | List countries
*OrganizationsApi* | [**RemoveUserRoles**](docs/OrganizationsApi.md#removeuserroles) | **DELETE** /api/v1/organizations/{organizationId}/users/{username}/roles | Remove role(s) from user
*OrganizationsApi* | [**UpdateOrganization**](docs/OrganizationsApi.md#updateorganization) | **PUT** /api/v1/organizations/{organizationId} | Update organization
*OrganizationsApi* | [**UpdateOrganizationAddress**](docs/OrganizationsApi.md#updateorganizationaddress) | **PUT** /api/v1/organizations/{organizationId}/addresses/default | Store address
*OrganizationsApi* | [**UpdateOrganizationBillingAddress**](docs/OrganizationsApi.md#updateorganizationbillingaddress) | **PUT** /api/v1/organizations/{organizationId}/addresses/billing | Store billing address
*OrganizationsApi* | [**UpdateOrganizationLogo**](docs/OrganizationsApi.md#updateorganizationlogo) | **POST** /api/v1/organizations/{organizationId}/logo | Update organization logo
*PublicServicesApi* | [**Go**](docs/PublicServicesApi.md#go) | **GET** /go/{guid} | Forward
*PublicServicesApi* | [**ResolveImageUsingGET**](docs/PublicServicesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image
*PublicServicesApi* | [**ResolveWhoIsEntry**](docs/PublicServicesApi.md#resolvewhoisentry) | **GET** /whois/{id4n} | Resolve owner of id4n
*RoutingApi* | [**GetRoute**](docs/RoutingApi.md#getroute) | **GET** /api/v1/routingfiles/{id4n}/route/{type} | Retrieve current route of a GUID (or ID4N)
*RoutingApi* | [**GetRoutingFile**](docs/RoutingApi.md#getroutingfile) | **GET** /api/v1/routingfiles/{id4n} | Retrieve routing file
*RoutingApi* | [**UpdateRoutingFile**](docs/RoutingApi.md#updateroutingfile) | **PUT** /api/v1/routingfiles/{id4n} | Store routing file
*WhoIsApi* | [**ResolveWhoIsEntry**](docs/WhoIsApi.md#resolvewhoisentry) | **GET** /whois/{id4n} | Resolve owner of id4n


<a name="documentation-for-models"></a>
## Documentation for Models

 - [DE.ID4i.Model.AccountCredentials](docs/AccountCredentials.md)
 - [DE.ID4i.Model.AddApiKeyPrivilegeRequest](docs/AddApiKeyPrivilegeRequest.md)
 - [DE.ID4i.Model.ApiError](docs/ApiError.md)
 - [DE.ID4i.Model.ApiKeyChangeRequest](docs/ApiKeyChangeRequest.md)
 - [DE.ID4i.Model.ApiKeyCreationRequest](docs/ApiKeyCreationRequest.md)
 - [DE.ID4i.Model.ApiKeyPresentation](docs/ApiKeyPresentation.md)
 - [DE.ID4i.Model.ApiKeyPrivilege](docs/ApiKeyPrivilege.md)
 - [DE.ID4i.Model.ApiKeyPrivilegeInfo](docs/ApiKeyPrivilegeInfo.md)
 - [DE.ID4i.Model.ApiKeyPrivilegeInfoResponse](docs/ApiKeyPrivilegeInfoResponse.md)
 - [DE.ID4i.Model.ApiKeyPrivilegePaginatedResponse](docs/ApiKeyPrivilegePaginatedResponse.md)
 - [DE.ID4i.Model.AppInfoPresentation](docs/AppInfoPresentation.md)
 - [DE.ID4i.Model.ChangeRoleRequest](docs/ChangeRoleRequest.md)
 - [DE.ID4i.Model.CompleteUserRegistrationRequest](docs/CompleteUserRegistrationRequest.md)
 - [DE.ID4i.Model.Country](docs/Country.md)
 - [DE.ID4i.Model.CreateGuidRequest](docs/CreateGuidRequest.md)
 - [DE.ID4i.Model.CreateLabelledCollectionRequest](docs/CreateLabelledCollectionRequest.md)
 - [DE.ID4i.Model.CreateLogisticCollectionRequest](docs/CreateLogisticCollectionRequest.md)
 - [DE.ID4i.Model.CreateRoutingCollectionRequest](docs/CreateRoutingCollectionRequest.md)
 - [DE.ID4i.Model.File](docs/File.md)
 - [DE.ID4i.Model.Guid](docs/Guid.md)
 - [DE.ID4i.Model.GuidAlias](docs/GuidAlias.md)
 - [DE.ID4i.Model.GuidCollection](docs/GuidCollection.md)
 - [DE.ID4i.Model.Id4n](docs/Id4n.md)
 - [DE.ID4i.Model.Id4nPresentation](docs/Id4nPresentation.md)
 - [DE.ID4i.Model.Id4nPresentationPaginatedResponse](docs/Id4nPresentationPaginatedResponse.md)
 - [DE.ID4i.Model.InputStream](docs/InputStream.md)
 - [DE.ID4i.Model.InputStreamResource](docs/InputStreamResource.md)
 - [DE.ID4i.Model.ListOfId4ns](docs/ListOfId4ns.md)
 - [DE.ID4i.Model.Organization](docs/Organization.md)
 - [DE.ID4i.Model.OrganizationAddress](docs/OrganizationAddress.md)
 - [DE.ID4i.Model.OrganizationUserInvitation](docs/OrganizationUserInvitation.md)
 - [DE.ID4i.Model.OrganizationUserInvitationListRequest](docs/OrganizationUserInvitationListRequest.md)
 - [DE.ID4i.Model.PaginatedApiKeyResponse](docs/PaginatedApiKeyResponse.md)
 - [DE.ID4i.Model.PaginatedCountryResponse](docs/PaginatedCountryResponse.md)
 - [DE.ID4i.Model.PaginatedGuidCollection](docs/PaginatedGuidCollection.md)
 - [DE.ID4i.Model.PaginatedGuidResponse](docs/PaginatedGuidResponse.md)
 - [DE.ID4i.Model.PaginatedOrganizationResponse](docs/PaginatedOrganizationResponse.md)
 - [DE.ID4i.Model.PaginatedResponseApiKeyPresentation](docs/PaginatedResponseApiKeyPresentation.md)
 - [DE.ID4i.Model.PaginatedResponseApiKeyPrivilege](docs/PaginatedResponseApiKeyPrivilege.md)
 - [DE.ID4i.Model.PaginatedResponseApiKeyPrivilegeInfo](docs/PaginatedResponseApiKeyPrivilegeInfo.md)
 - [DE.ID4i.Model.PaginatedResponseCountry](docs/PaginatedResponseCountry.md)
 - [DE.ID4i.Model.PaginatedResponseGuid](docs/PaginatedResponseGuid.md)
 - [DE.ID4i.Model.PaginatedResponseGuidCollection](docs/PaginatedResponseGuidCollection.md)
 - [DE.ID4i.Model.PaginatedResponseId4nPresentation](docs/PaginatedResponseId4nPresentation.md)
 - [DE.ID4i.Model.PaginatedResponseOrganization](docs/PaginatedResponseOrganization.md)
 - [DE.ID4i.Model.PaginatedResponseRole](docs/PaginatedResponseRole.md)
 - [DE.ID4i.Model.PaginatedResponseUserPresentation](docs/PaginatedResponseUserPresentation.md)
 - [DE.ID4i.Model.PaginatedResponseUserRoles](docs/PaginatedResponseUserRoles.md)
 - [DE.ID4i.Model.PaginatedResponsestring](docs/PaginatedResponsestring.md)
 - [DE.ID4i.Model.PaginatedStringResponse](docs/PaginatedStringResponse.md)
 - [DE.ID4i.Model.PaginatedUserPresentationResponse](docs/PaginatedUserPresentationResponse.md)
 - [DE.ID4i.Model.PaginatedUserRolesResponse](docs/PaginatedUserRolesResponse.md)
 - [DE.ID4i.Model.PasswordResetRequest](docs/PasswordResetRequest.md)
 - [DE.ID4i.Model.PasswordResetVerificationRequest](docs/PasswordResetVerificationRequest.md)
 - [DE.ID4i.Model.RegistrationVerificationTokenPresentation](docs/RegistrationVerificationTokenPresentation.md)
 - [DE.ID4i.Model.RemoveApiKeyPrivilegeRequest](docs/RemoveApiKeyPrivilegeRequest.md)
 - [DE.ID4i.Model.Role](docs/Role.md)
 - [DE.ID4i.Model.RoleResponse](docs/RoleResponse.md)
 - [DE.ID4i.Model.Route](docs/Route.md)
 - [DE.ID4i.Model.RoutingFile](docs/RoutingFile.md)
 - [DE.ID4i.Model.RoutingFileRequest](docs/RoutingFileRequest.md)
 - [DE.ID4i.Model.RoutingOptions](docs/RoutingOptions.md)
 - [DE.ID4i.Model.SimpleMessageResponse](docs/SimpleMessageResponse.md)
 - [DE.ID4i.Model.Timestamp](docs/Timestamp.md)
 - [DE.ID4i.Model.URI](docs/URI.md)
 - [DE.ID4i.Model.URL](docs/URL.md)
 - [DE.ID4i.Model.UserPresentation](docs/UserPresentation.md)
 - [DE.ID4i.Model.UserRegistrationRequest](docs/UserRegistrationRequest.md)
 - [DE.ID4i.Model.UserRegistrationResponse](docs/UserRegistrationResponse.md)
 - [DE.ID4i.Model.UserRoles](docs/UserRoles.md)
 - [DE.ID4i.Model.WhoIsResponse](docs/WhoIsResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Authorization"></a>
### Authorization

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

